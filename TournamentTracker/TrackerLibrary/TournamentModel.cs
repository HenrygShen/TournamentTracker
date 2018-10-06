using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents the tournament to be held.
    /// </summary>
    public class TournamentModel
    {
        /// <summary>
        /// The name of the tournament.
        /// </summary>
        public string TournamentName  { get; set; }
        
        /// <summary>
        /// The fee to pay for entering the tournament.
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// The teams taking part in this tournament.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// The prizes for each place in the tournament.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// The rounds which are made up of each matchup.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
