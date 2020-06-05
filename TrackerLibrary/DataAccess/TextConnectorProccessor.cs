using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProccessor
    {
        public static string FullFilePath(this string fileName) 
        {
            return $"{ ConfigurationManager.AppSettings["filePath"]}\\{ fileName} ";
           
        }

        public static List<String> LoadFile(this string file) 
        {
            if (!File.Exists(file))
            {
                return new List<String>();

             
            }

            return File.ReadAllLines(file).ToList();
        }



        public static List<PrizeModel> ConvertToPrizeModels(this List<String> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();

            foreach (String line in lines)
            {
                string[] cols = line.Split(',');

                PrizeModel p = new PrizeModel();

                p.Id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);

                output.Add(p);
            }

            return output;
          
        }

        public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
        {
            List<String> lines = new List<string>();
            foreach(PrizeModel p in models)
            {
                String line = $"{p.Id},{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage}";
                lines.Add(line);
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }




        public static List<PersonModel> ConvertToPersonModel(this List<String> lines)
        {
            List<PersonModel> output = new List<PersonModel>();
            foreach (String line in lines)
            {
                String[] cols = line.Split(',');
                PersonModel person = new PersonModel();

                person.Id = int.Parse(cols[0]);
                person.FirstName = cols[1];
                person.LastName = cols[2];
                person.CellPhoneNumber = cols[3];
                person.EmailAdress = cols[4];

                output.Add(person);
            }

            return output;
        }
        public static void SaveToPersonFile(this List<PersonModel> models, string fileName)
        {
            List<String> lines = new List<string>();
            foreach(PersonModel model in models)
            {
                String line = $"{model.Id},{model.FirstName},{model.LastName},{model.CellPhoneNumber},{model.EmailAdress}";
                lines.Add(line);
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }


        public static List<TeamModel> ConvertToTeamModel(this List<String> lines, string peopleFile)
        {
            List<TeamModel> list = new List<TeamModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                

                TeamModel t = new TeamModel();
                t.Id = int.Parse(cols[0]);
                t.TeamName = cols[1];


                List<PersonModel> tmembers = new List<PersonModel>();
                string[] members = cols[2].Split('|');

                List<PersonModel> perList = peopleFile.FullFilePath().LoadFile().ConvertToPersonModel();

                foreach (PersonModel person in perList)
                {

                    for (int i = 0; i < members.Length; i++)
                    {
                        if(person.Id == int.Parse(members[i]))
                        {
                            tmembers.Add(person);
                        }
                        
                    }
                }

                t.TeamMembers = tmembers;
                list.Add(t);





            }

            return list;
        }
        public static void SaveToTeamFile(this List<TeamModel> teams, string fileName)
        {
            List<String> lines = new List<string>();
            foreach( TeamModel team in teams)
            {
                lines.Add($"{team.Id},{team.TeamName},{ConvertPeopleListToString(team.TeamMembers)}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        private static string ConvertPeopleListToString(List<PersonModel> people)
        {
            string output = "";

            if(people.Count == 0)
            {
                return "";
            }

            foreach(PersonModel tmember in people)
            {
                output += $"{tmember.Id}|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }


        public static List<TournamentModel> ConvertToTournamentModels(this List<String> lines, string teamFile, string prizeFile, string peopleFile)
        {

            //id, TournamentName, EntreeFee, (EnteredTeams - id1|id2|id3|), (Prizes - id1|id2|id3), 
            //(Rounds - id^id^id|id^id^id|id^id^id)
            List<TournamentModel> list = new List<TournamentModel>();

            foreach(String line in lines)
            {
                string[] cols = line.Split(',');

                TournamentModel tourn = new TournamentModel();
                tourn.Id = int.Parse(cols[0]);
                tourn.TournamentName = cols[1];
                tourn.EntreeFee = decimal.Parse(cols[2]);

                //team column
                string[] enteredTeams = cols[3].Split('|');
                List<TeamModel> teams = teamFile.FullFilePath().LoadFile().ConvertToTeamModel(peopleFile);

                foreach (TeamModel team in teams)
                {
                    for(int i =0; i < enteredTeams.Length; i++)
                    {
                        if(team.Id == int.Parse(enteredTeams[i]))
                        {
                            tourn.EnteredTeams.Add(team);
                        }
                    }
                }



                //prize column
                string[] pr = cols[4].Split('|');
                List<PrizeModel> prizes = prizeFile.FullFilePath().LoadFile().ConvertToPrizeModels();

                foreach(PrizeModel prize in prizes)
                {
                    for(int i = 0; i < pr.Length; i++)
                    {
                        if(prize.Id == int.Parse(pr[i]))
                        {
                            tourn.Prizes.Add(prize);
                        }
                    }
                }









                list.Add(tourn);


            }

            return list;
        }
        public static void SaveToTournamentFile(this List<TournamentModel> tournaments, string fileName)
        {
            List<String> lines = new List<string>();
            foreach(TournamentModel tournament in tournaments)
            {
                //id, TournamentName, EntreeFee, (EnteredTeams - id1|id2|id3|), (Prizes - id1|id2|id3), 
                lines.Add($"{tournament.Id}," +
                    $"{tournament.TournamentName}," +
                    $"{tournament.EntreeFee}," +
                    $"{ConvertTeamListToString(tournament.EnteredTeams)}," +
                    $"{ConvertPrizeListToString(tournament.Prizes)}," +
                    $"{ConvertRoundListToString(tournament.Rounds)}");

                
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        private static string ConvertTeamListToString(List<TeamModel> teams)
        {
            string output = "";

            if (teams.Count == 0)
            {
                return "";
            }

            foreach (TeamModel team in teams)
            {
                output += $"{team.Id}|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }


        private static string ConvertPrizeListToString(List<PrizeModel> prizes)
        {
            string output = "";

            if (prizes.Count == 0)
            {
                return "";
            }

            foreach (PrizeModel prize in prizes)
            {
                output += $"{prize.Id}|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }

        private static string ConvertRoundListToString(List<List<MatchupModel>> rounds)
        {
            string output = "";

            if (rounds.Count == 0)
            {
                return "";
            }

            foreach (List<MatchupModel> listOfMUs in rounds)
            {
                output += $"{ConvertMatchupListToString(listOfMUs)}|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }

        private static string ConvertMatchupListToString(List<MatchupModel> matchUps)
        {
            string output = "";

            if (matchUps.Count == 0)
            {
                return "";
            }

            foreach (MatchupModel mu in matchUps)
            {
                output += $"{mu.Id}^";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }

        public static List<MatchupModel> ConvertToMUModel(this List<String> lines, string MUEFile, string TeamFile, string PeopleFile)
        {
            List<MatchupModel> output = new List<MatchupModel>();

            foreach(string line in lines)
            {
                MatchupModel mu = new MatchupModel();

                string[] cols = line.Split(',');
                mu.Id = int.Parse(cols[0]);

                List<MatchupEntryModel> muentries = MUEFile.FullFilePath().LoadFile().ConvertToMUEModel();
                string[] entries = cols[1].Split('|');

                foreach (MatchupEntryModel entry in muentries)
                {
                    for(int i=0; i < entries.Length; i++)
                    {
                        if(int.Parse(entries[i]) == entry.Id)
                        {
                            mu.Entries.Add(entry);
                        }
                    }
                }
                mu.Winner = LookupTeamById(int.Parse(cols[2]), TeamFile, PeopleFile);
                mu.MatchupRound =int.Parse(cols[3]);

            }
        }

        private static TeamModel LookupTeamById(int id, string TeamFile, string PeopleFile)
        {
            List<TeamModel> teams = TeamFile.FullFilePath().LoadFile().ConvertToTeamModel(PeopleFile);
            return teams.Where(x => x.Id == id).First(); 
        }

        public static List<MatchupEntryModel> ConvertToMUEModel(this List<String> lines)
        {
            List<MatchupEntryModel> output = new List<MatchupEntryModel>();
            

            foreach(string line in lines)
            {
                MatchupEntryModel mue = new MatchupEntryModel();
                string[] cols = line.Split(',');

                mue.Id = int.Parse(cols[0]);
                mue.TeamCompeting.Id = int.Parse(cols[1]);
                mue.Score = int.Parse(cols[2]);
                mue.ParentMatchup.Id = int.Parse(cols[3]);

                output.Add(mue);
            }

            return output;
        }

         public static void SaveRoundsToFile(this TournamentModel model, string MatchupFile, string MatchupEntryFile)
        {
            foreach(List<MatchupModel> round in model.Rounds)
            {
                foreach(MatchupModel mu in round)
                {
                    mu.SaveMatchupToFile(MatchupFile, MatchupEntryFile);

                    
                }
            }
        }

        public static void SaveMatchupToFile (this MatchupModel matchup, string matchupFile, string MatchupEntryFile)
        {
            foreach (MatchupEntryModel entry in matchup.Entries)
            {
                entry.SaveMUEToFile(MatchupEntryFile);
            }
        }

        public static void SaveMUEToFile(this MatchupEntryModel mue, string MUEFile)
        {

        }

    }
}
