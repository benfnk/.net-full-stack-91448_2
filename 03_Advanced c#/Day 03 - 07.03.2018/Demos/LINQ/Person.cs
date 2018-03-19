namespace LINQ
{
    public enum Hobby
    {
        Skating,
        Reading,
        Baking,
        Running,
        Playing
    }

    public class Person
    {
        public string FirstName{ get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }
        
        public Hobby Hobby { get; set; }

        public double? Height { get; set; }

        public Person(string FirstName, string LastName, int Age, Hobby Hobby, double? Height)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.Hobby = Hobby;
            this.Height = Height;
        }
    }
}
