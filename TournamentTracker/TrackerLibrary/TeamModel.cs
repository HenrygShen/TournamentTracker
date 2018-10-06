using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents a team which can take part in a tournament.
    /// </summary>
    public class TeamModel
    {
        /// <summary>
        /// Represents the team members.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// The name of the Team.
        /// </summary>
        public string TeamName { get; set; }
    }
}
