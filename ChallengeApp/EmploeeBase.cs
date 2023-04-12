namespace ChallengeApp
{
    public abstract class EmploeeBase : IEmploee
    {
        public string Name { get; private set; }

        public string Surname { get; private set; }

        public char Sex { get; private set; }

        public delegate void GradeAddedDelegate(object sender, EventArgs args);
        public abstract event GradeAddedDelegate GradeAdded;

        public EmploeeBase()
        {
        }

        public EmploeeBase(string name, string surname, char sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
        }

        public abstract void AddGrade(float grade);

        public abstract void AddGrade(string grade);

        public abstract void AddGrade(char grade);
        
        public abstract void AddGrade(double grade);

        public abstract Statistics GetStatistics();

        public virtual void SayHello()
        {
            Console.WriteLine($"My name is: {Name} {Surname}");
        }
    }
}
