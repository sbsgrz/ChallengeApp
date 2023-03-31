
namespace ChallengeApp
{
    public class Emploee : IEmploee 
    {
        private List<float> grades = new List<float>();

        public string Name { get;}
        public string Surname { get;}
        public char Sex { get;}

        public Emploee()
        { 
            this.Name = string.Empty;
            this.Surname = string.Empty;
            this.Sex = ' ';
        }

        public Emploee(string name, string surname, char sex)
        { 
            this.Name=name;
            this.Surname=surname;
            this.Sex=sex;
        }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
                this.grades.Add(grade);
            else
                throw new Exception("Value out of range. Enter a value between 0 and 100.");
        }

        public void AddGrade(string grade)
        {
            var list = new List<string> { "A", "a", "B", "b", "C", "c", "D", "d", "E", "e" };

            if (list.Contains(grade))           
                AddGrade(grade[0]);
            else if (float.TryParse(grade, out float result))
                this.AddGrade(result);
            else
                throw new Exception("Conversion failed.");
        }

        public void AddGrade(char grade)
        {
            switch(grade)
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
            this.AddGrade((float)grade);
        }

        public void AddGrade(int grade)
        {
            this.AddGrade((float)grade);
        }

        public Statistics GetStatistics()
        {
            Statistics statistics = new Statistics();
            if (this.grades.Count > 0)
            {
                statistics.Min = grades.Min();
                statistics.Max = grades.Max();
                statistics.Sum = grades.Sum();
                statistics.Average = grades.Average();

                switch (statistics.Average)
                {
                    case var average when average >= 80:
                        statistics.AverageLetter = 'A';
                        break;
                    case var average when average >= 60:
                        statistics.AverageLetter = 'B';
                        break;
                    case var average when average >= 40:
                        statistics.AverageLetter = 'C';
                        break;
                    case var average when average >= 20:
                        statistics.AverageLetter = 'D';
                        break;
                    default:
                        statistics.AverageLetter = 'E';
                        break;
                }
            }            
            return statistics;
        }
    }
}