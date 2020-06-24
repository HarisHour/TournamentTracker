using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector 
    {
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments"))) 
            {
                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                return model;

            }
        }

        public PersonModel CreatePerson(PersonModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                var per = new DynamicParameters();
                per.Add("@FirstName", model.FirstName);
                per.Add("@LastName", model.LastName);
                per.Add("@EmailAdress", model.EmailAdress);
                per.Add("CellPhoneNumber", model.CellPhoneNumber);
                per.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPeople_Insert", per, commandType: CommandType.StoredProcedure);

                model.Id = per.Get<int>("@id");

                return model;


            }

                
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                var p = new DynamicParameters();
                p.Add("@TeamName", model.TeamName);
             
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTeams_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                foreach(PersonModel member in model.TeamMembers)
                {
                    var m = new DynamicParameters();
                    m.Add("@TeamId", model.Id);

                    m.Add("@PersonId", member.Id);

                    m.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                    connection.Execute("dbo.spTeamMembers_Insert", m, commandType: CommandType.StoredProcedure);


                }

                return model;

            }


            //return model;
        }

        public TournamentModel CreateTournament(TournamentModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                SaveTournament(connection, model);

                SaveTournamentPrizes(connection, model);

                SaveTournamentEntries(connection, model);

                SaveTournamentRounds(connection, model);

                return model;

            }

        }

        private void SaveTournament(IDbConnection connection, TournamentModel model)
        {
            var p = new DynamicParameters();

            p.Add("@TournamentName", model.TournamentName);
            p.Add("@EntryFee", model.EntreeFee);
            p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.spTournaments_Insert", p, commandType: CommandType.StoredProcedure);
            model.Id = p.Get<int>("@id");
        }

        private void SaveTournamentPrizes(IDbConnection connection, TournamentModel model)
        {
            foreach (PrizeModel prize in model.Prizes)
            {
                var m = new DynamicParameters();
                m.Add("@TournamentId", model.Id);
                m.Add("@PrizeId", prize.Id);
                m.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTournamentPrizes_Insert", m, commandType: CommandType.StoredProcedure);
            }
        }

        private void SaveTournamentEntries(IDbConnection connection, TournamentModel model)
        {
            foreach (TeamModel team in model.EnteredTeams)
            {
                var t = new DynamicParameters();
                t.Add("@TournamentId", model.Id);
                t.Add("@TeamId", team.Id);
                t.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTournamentEntries_Insert", t, commandType: CommandType.StoredProcedure);
               //model.Id = t.Get<int>("@id");
            }
        }

        private void SaveTournamentRounds(IDbConnection connection, TournamentModel model)
        {
            //Loop through the rounds
            //Loop through the matchups
            //Save the matchup
            //Loop through the entries and save them

            foreach(List<MatchupModel> round in model.Rounds)
            {
                foreach(MatchupModel mu in round)
                {
                    var t = new DynamicParameters();
                    t.Add("@TournamentId", model.Id);
                    t.Add("@MatchupRound", mu.MatchupRound);
                    t.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                    connection.Execute("dbo.spMatchups_Insert", t, commandType: CommandType.StoredProcedure);
                    mu.Id = t.Get<int>("@id");

                    foreach(MatchupEntryModel entry in mu.Entries)
                    {              
                        t = new DynamicParameters();
                        t.Add("@MatchupId", mu.Id);
                        
                        if(entry.ParentMatchup == null)
                        {
                            t.Add("@ParentMatchupId", null);
                        }
                        else
                        {
                            t.Add("@ParentMatchupId", entry.ParentMatchup.Id);
                        }

                        if(entry.TeamCompeting == null)
                        {
                            t.Add("@TeamCompetingId", null);
                        }
                        else
                        {
                            t.Add("@TeamCompetingId", entry.TeamCompeting.Id);
                        }
                        
                        t.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                        connection.Execute("dbo.spMatchupEntries_Insert", t, commandType: CommandType.StoredProcedure);
                    }
                }
            }
        }

        public void UpdateMatchup(MatchupModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                var t = new DynamicParameters();
                t.Add("@id", model.Id);
                t.Add("@WinnerId", model.WinnerId);
                

                connection.Execute("dbo.spMatchups_Update", t, commandType: CommandType.StoredProcedure);
                
                foreach(MatchupEntryModel me in model.Entries)
                {
                    var p = new DynamicParameters();
                    p.Add("@id", me.Id);
                    p.Add("@TeamCompetingId", me.TeamCompetingId);
                    p.Add("@Score", me.Score);

                    connection.Execute("dbo.spMatchupEntries_Update", p, commandType: CommandType.StoredProcedure);
                }
            
            }
        }

        public List<PersonModel> GetPerson_All()
        {
            List<PersonModel> personList;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                personList = connection.Query<PersonModel>("dbo.spPeople_GetAll").ToList();
                

            }

            return personList;

        }

        public List<TournamentModel> GetTournaments_All()
        {
            List<TournamentModel> tournList;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                tournList = connection.Query<TournamentModel>("dbo.spTournaments_GetAll").ToList();

                foreach (TournamentModel tm in tournList)
                {
                    var p = new DynamicParameters();
                    p.Add("@TournamentId", tm.Id);
                    //populate prizes
                    tm.Prizes = connection.Query<PrizeModel>("dbo.spPrizes_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();
                    
                    //populate teams
                    tm.EnteredTeams = connection.Query<TeamModel>("dbo.spTeam_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();

                    foreach( TeamModel team in tm.EnteredTeams)
                    {
                        var dp = new DynamicParameters();
                        dp.Add("@TeamId", team.Id);

                        team.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam", dp, commandType: CommandType.StoredProcedure).ToList();

                    }

                    //populate rounds

                    

                    List<MatchupModel> matchups = connection.Query<MatchupModel>("dbo.spMatchups_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();

                    foreach(MatchupModel matchup in matchups)
                    {
                        var mp = new DynamicParameters();
                        mp.Add("@MatchupId", matchup.Id);

                        matchup.Entries = connection.Query<MatchupEntryModel>("dbo.spMatchupEntries_GetByMatchup", mp, commandType: CommandType.StoredProcedure).ToList();

                        List<TeamModel> allTeams = GetTeam_All();

                        if (matchup.WinnerId > 0)
                        {
                            matchup.Winner = allTeams.Where(x => x.Id == matchup.WinnerId).First();
                        }

                        foreach(MatchupEntryModel mue in matchup.Entries)
                        {
                            if(mue.TeamCompetingId > 0)
                            {
                                mue.TeamCompeting = allTeams.Where(x => x.Id == mue.TeamCompetingId).First();
                            }

                            if(mue.ParentMatchupId > 0)
                            {
                                mue.ParentMatchup = matchups.Where(x => x.Id == mue.ParentMatchupId).First();
                            }
                        }
                    }

                    List<MatchupModel> currRow = new List<MatchupModel>();
                    int currRound = 1;

                    foreach (MatchupModel m in matchups)
                    {
                        if(m.MatchupRound > currRound)
                        {
                            tm.Rounds.Add(currRow);
                            currRow = new List<MatchupModel>();
                            currRound += 1;
                        }

                        currRow.Add(m);
                    }

                    tm.Rounds.Add(currRow);

                }
              
            }

            return tournList;

        }

        public List<TeamModel> GetTeam_All()
        {
            List<TeamModel> teamList;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                teamList = connection.Query<TeamModel>("dbo.spTeams_GetAll").ToList();

                foreach(TeamModel team in teamList)
                {

                    var p = new DynamicParameters();
                    p.Add("@TeamId", team.Id);
                    
                    team.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam", p, commandType: CommandType.StoredProcedure).ToList();

                }

            }

            return teamList;

        }

       
    }

    
}
