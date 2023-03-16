using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class Emploee
    {
        private string firstName;
        private string lastName;

        private List<float> grades = new List<float>();

        public string FirstName { get { return this.firstName; } set { this.firstName = value; } }
        public string LastName { get { return this.lastName; } set { this.lastName = value; } }

        public Emploee()
        {
            firstName = string.Empty;
            lastName = string.Empty;
        }

        public Emploee(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
                this.grades.Add(grade);
            else
                Console.WriteLine($"Pracownik {this.firstName} {this.lastName} funkcja AddGrade - wartość poza zakresem");
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
                this.AddGrade(result);
            else
                Console.WriteLine($"Pracownik {this.firstName} {this.lastName} funkcja AddGrade(String) - nieudana konwersja");
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
                    Console.WriteLine("Wrong letter");
                    break;
            }
            
            /*
            var result = char.GetNumericValue(grade);
            if(result != -1)
                this.AddGrade(result);
            else
                Console.WriteLine($"Pracownik {this.firstName} {this.lastName} funkcja AddGrade(Char) - konwersja nieudana");
            */
        }

        public void AddGrade(double grade)
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
