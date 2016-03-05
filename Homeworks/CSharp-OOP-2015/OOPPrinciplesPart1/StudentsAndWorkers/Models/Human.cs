namespace StudentsAndWorkers.Models
{
    public abstract class Human
    {
        public Human(string firstName, string lastName) 
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public override string ToString()
        {
            return string.Format("First name = {0}, Last name = {1}", this.FirstName, this.LastName);
        } 
    }
}
