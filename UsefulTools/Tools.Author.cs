namespace UsefulTools
{
    public partial class Tools
    {
        public class Author
        {
            public string firstName;
            public string middleName;
            public string lastName;

            public Author(string firstName, string middleName, string lastName)
            {
                this.firstName = firstName;
                this.middleName = middleName;
                this.lastName = lastName;
            }
        }
    }
}
