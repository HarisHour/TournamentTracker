using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";
        private const string PeopleFile = "PersonModels.csv";
        private const string TeamFile = "TeamModels.csv";
        private const string TournamentFile = "TournamentModels.csv";


        public PrizeModel CreatePrize(PrizeModel model)
        {

            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            int currentId = 1;

            if(prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;
            prizes.Add(model);

            prizes.SaveToPrizeFile(PrizesFile);

            return model;
            


        }

        public PersonModel CreatePerson(PersonModel model)
        {
            List<PersonModel> perList = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModel();

            int currentId = 1;

            if(perList.Count > 0)
            {
                currentId = perList.OrderByDescending(x => x.Id).First().Id + 1;
                
            }

            model.Id = currentId;
            perList.Add(model);

            perList.SaveToPersonFile(PeopleFile);

            return model;
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            List<TeamModel> teamList = TeamFile.FullFilePath().LoadFile().ConvertToTeamModel(PeopleFile);

            int currentId = 1;

            if (teamList.Count > 0)
            {
                currentId = teamList.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;
            teamList.Add(model);

            teamList.SaveToTeamFile(TeamFile);

            return model;
        }

        public List<PersonModel> GetPerson_All()
        {

            return PeopleFile.FullFilePath().LoadFile().ConvertToPersonModel();
        }

        public List<TeamModel> GetTeam_All()
        {
            
            return TeamFile.FullFilePath().LoadFile().ConvertToTeamModel(PeopleFile);
        }

        public TournamentModel CreateTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = TournamentFile
                .FullFilePath().
                LoadFile().
                ConvertToTournamentModels(TeamFile, PrizesFile, PeopleFile);

            int currentId = 1;

            if (tournaments.Count > 0)
            {
                currentId = tournaments.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;
            tournaments.Add(model);
            tournaments.SaveToTournamentFile(TournamentFile);
        }
    }
}
