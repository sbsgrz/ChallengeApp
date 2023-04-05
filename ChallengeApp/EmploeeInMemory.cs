
namespace ChallengeApp
{
    public class EmploeeInMemory : EmploeeBase
    {

        public EmploeeInMemory(string name, string surname, char sex) 
            : base(name, surname, sex)
        {
        }

        public override void AddGrade(float grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(string grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(double grade)
        {
            throw new NotImplementedException();
        }

        public override Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }


        public override void SayHello()
        {
            Console.WriteLine("Hi!!!");
            base.SayHello();
        }
    }
}
