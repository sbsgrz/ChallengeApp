
namespace ChallengeApp
{
    public class EmploeeInMemory : EmploeeBase
    {
        private List<float> grades = new List<float>();
        public override event GradeAddedDelegate GradeAdded;

        public EmploeeInMemory() : base()
        {
        }

        public EmploeeInMemory(string name, string surname, char sex) 
            : base(name, surname, sex)
        {
        }

        public override void AddGrade(float grade)
        {
            grades.Add(grade);
            
            if (GradeAdded != null)
            {
                GradeAdded(this, new EventArgs());
            }
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
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
            return result;
        }
    }
}
