using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// Unique matchup id.
        /// </summary>
        public int Id { get; set; }
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        public int WinnerId { get; set; }
        public TeamModel Winner { get; set; }
        public int MatchupRound { get; set; }

        public string DisplayName
        {
            get
            {
                string name = "";
                foreach (var entry in Entries)
                {

                    if(entry.TeamCompeting != null){
                        if (name.Length == 0)
                        {
                            name = entry.TeamCompeting.TeamName;
                        }
                        else
                        {
                            name += $" vs. {entry.TeamCompeting.TeamName}";
                        }

                    }
                    else
                    {
                        name = "Matchup Not Yet Determined";
                        break;
                    }
                }
                return name;
            }

            
        }
    }
}
