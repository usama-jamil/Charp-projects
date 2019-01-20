namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represent a Person
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// The unique identifer for  person.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The firstname of a person
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The lastname of a person
        /// </summary>
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return $"{ FirstName } { LastName }";
            }
        }

        /// <summary>
        /// The primary email Address of a person
        /// </summary>
        public string EmailAddress { get; set; }


        /// <summary>
        /// The primary phone number of a person
        /// </summary>
        public string CellPhoneNumber { get; set; }
    }
}