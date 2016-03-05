namespace Animals.Models
{
    class Kitten : Cat
    {
        public Kitten(string name, int age) 
            : base(name, age, Sex.Female)
        {
            this.AnimalKind = AnimalKind.Cat;
        }
    }
}
