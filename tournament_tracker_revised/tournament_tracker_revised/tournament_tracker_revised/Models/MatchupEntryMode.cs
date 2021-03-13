using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one team in the matchup.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Represents one score in the matchup.
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Represents the matchup that this team
        /// came from as the winner.
        /// </summary>
        public int ParentMatchup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="initialScore">
        /// 
        /// </param>
        public MatchupEntryModel(double initialScore)
        {

        }
    }
}
