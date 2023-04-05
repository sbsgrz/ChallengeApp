
namespace ChallengeApp
{
    public class EmploeeInFile : EmploeeBase
    {

        public const string fileName = "grades.txt";

        public EmploeeInFile(string name, string surname, char sex) : base(name, surname, sex)
        {
        }

        public override void AddGrade(float grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.Write(grade);
            }
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
    }
}
