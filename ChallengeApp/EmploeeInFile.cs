
using System.Runtime.CompilerServices;

namespace ChallengeApp
{
    public class EmploeeInFile : EmploeeBase
    {

        public const string fileName = "grades.txt";
        
        public EmploeeInFile() : base()
        {
        }


        public EmploeeInFile(string name, string surname, char sex) : base(name, surname, sex)
        {
        }

        public override void AddGrade(float grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(grade);
            }
        }

        public override void AddGrade(string grade)
        {
            if(float.TryParse(grade, out float result))
                this.AddGrade(result);
            else
                throw new Exception("Conversion failed. String parameter incorrect!");
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A' or 'a':
                    this.AddGrade(100);
                    break;
                case 'B' or 'b':
                    this.AddGrade(80);
                    break;
                case 'C' or 'c':
                    this.AddGrade(60);
                    break;
                case 'D' or 'd':
                    this.AddGrade(40);
                    break;
                case 'E' or 'e':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong Letter.");
            }
        }

        public override void AddGrade(double grade)
        {
            AddGrade((float)grade);
        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();
            List<float> grades = new List<float>();

            if (File.Exists(fileName)) 
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while(line != null)
                    {
                        grades.Add(float.Parse(line));
                        line = reader.ReadLine();
                    }
                }
                result.Min = grades.Min();
                result.Max = grades.Max();
                result.Average = grades.Average();
                result.Sum = grades.Sum();

                switch (result.Average)
                {
                    case var average when average >= 80:
                        result.AverageLetter = 'A';
                        break;
                    case var average when average >= 60:
                        result.AverageLetter = 'B';
                        break;
                    case var average when average >= 40:
                        result.AverageLetter = 'C';
                        break;
                    case var average when average >= 20:
                        result.AverageLetter = 'D';
                        break;
                    default:
                        result.AverageLetter = 'E';
                        break;
                }

            }

            return result;
        }

        public override void SayHello()
        {
            Console.WriteLine("HI!!! (from file)");
            base.SayHello();
        }
    }
}
