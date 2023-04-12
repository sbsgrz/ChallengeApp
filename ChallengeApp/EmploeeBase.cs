namespace ChallengeApp
{
    public abstract class EmploeeBase : IEmploee
    {
        public string Name { get; private set; }

        public string Surname { get; private set; }

        public delegate void GradeAddedDelegate(object sender, EventArgs args);
        public abstract event GradeAddedDelegate GradeAdded;

        public EmploeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public abstract void AddGrade(float grade);
        protected abstract List<float> GetGrades();

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
                this.AddGrade(result);
            else
                throw new Exception("Conversion failed. String parameter incorrect!");
        }

        public void AddGrade(char grade)
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

        public void AddGrade(double grade)
        {
            AddGrade((float)grade);
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            List<float> grades = new List<float>();
            grades = GetGrades();
            if (grades.Count > 0)
            {
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

    }
}
