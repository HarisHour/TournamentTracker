using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {

        public int Id { get; set; }
        /// <summary>
        /// The unique id for the team competing, taken from the database.
        /// </summary>
        public int TeamCompetingId { get; set; }
        /// <summary>
        /// Represents one team in the matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represents the score of this particular team
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Represents the matchup that this team came from
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
        /// <summary>
        /// The unique id for the parent matchup, taken from the database.
        /// </summary>
        public int ParentMatchupId { get; set; }
    }
}
