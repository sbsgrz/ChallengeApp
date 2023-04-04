namespace ChallengeApp
{
    public class Supervisor : IEmploee
    {
        public string Name { get; }
        
        public string Surname { get; }

        public char Sex { get; }

        private List<float> grades = new List<float>();

        public Supervisor()
        {
            this.Name = string.Empty;
            this.Surname = string.Empty;
            this.Sex = ' ';
        }

        public Supervisor(string name, string surname, char sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);

        }

        public void AddGrade(string grade)
        {
            
            switch(grade)
            {
                case "6":
                    this.AddGrade(100);
                    break;
                case "6-" or "-6":
                    this.AddGrade(95);
                    break;

                case "5+" or "+5":
                    this.AddGrade(85);
                    break;
                case "5":
                    this.AddGrade(80);
                    break;
                case "5-" or "-5":
                    this.AddGrade(75);
                    break;

                case "4+" or "+4":
                    this.AddGrade(65);
                    break;
                case "4":
                    this.AddGrade(60);
                    break;
                case "4-" or "-4":
                    this.AddGrade(55);
                    break;

                case "3+" or "+3":
                    this.AddGrade(45);
                    break;
                case "3":
                    this.AddGrade(40);
                    break;
                case "3-" or "-3":
                    this.AddGrade(35);
                    break;

                case "2+" or "+2":
                    this.AddGrade(25);
                    break;
                case "2":
                    this.AddGrade(20);
                    break;
                case "2-" or "-2":
                    this.AddGrade(15);
                    break;

                case "1+" or "+1":
                    this.AddGrade(5);
                    break;
                case "1":
                    this.AddGrade(0);
                    break;

                default:
                    throw new Exception("Wrong grade.");

            }
        }

        public void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(double grade)
        {
            throw new NotImplementedException();
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
