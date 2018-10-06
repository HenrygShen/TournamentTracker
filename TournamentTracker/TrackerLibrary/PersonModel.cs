using System;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one person.
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// The first name of a person.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of a person.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The primary email address of a person.
        /// </summary>
        public string EmailAddress { get; set; }
        
        /// <summary>
        /// The primary cellphone number of a person.
        /// </summary>
        public string CellphoneNumber { get; set; }
    }
}
