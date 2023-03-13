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
        private uint age;

        private List<float> grades = new List<float>();

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public uint Age { get { return age; } set { age = value; } }


        public Emploee()
        {
            firstName = string.Empty;
            lastName = string.Empty;
            age = 0;
        }

        public Emploee(string firstName, string lastName, uint age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public bool AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
                Console.WriteLine("FLOAT");
                return true;
                
            }
            else
            {
                return false;
                // Console.WriteLine($"Pracownik {this.firstName} {this.lastName} funkcja AddGrade - podana wartość jest poza skalą");
            }
            

        }

        public bool AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
                return true;
            }
            else
                return false;
        }

        public void AddGrade(char grade)
        {
            var result = char.GetNumericValue(grade);
            this.AddGrade(result);
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
                statistics.Min = float.MaxValue;
                statistics.Max = float.MinValue;
                statistics.Average = 0;
                statistics.Sum = 0;

                foreach (float grade in this.grades)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Sum += grade;
                }

                statistics.Average = statistics.Sum / grades.Count();
            }
            else
            {
                statistics.Min = 0;
                statistics.Max = 0;
                statistics.Average = 0;
                statistics.Sum = 0;
            }
            return statistics;
        }

        public Statistics GetStatisticsWithForEach()
        {
            Statistics statistics = new Statistics();

            if (this.grades.Count > 0)
            {
                statistics.Min = float.MaxValue;
                statistics.Max = float.MinValue;
                statistics.Average = 0;
                statistics.Sum = 0;

                foreach (float grade in this.grades)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Sum += grade;
                }

                statistics.Average = statistics.Sum / grades.Count();
            }
            else
            {
                statistics.Min = 0;
                statistics.Max = 0;
                statistics.Average = 0;
                statistics.Sum = 0;
            }
            return statistics;
        }

        public Statistics GetStatisticsWithFor()
        {
            Statistics statistics = new Statistics();

            if (this.grades.Count > 0)
            {
                statistics.Min = float.MaxValue;
                statistics.Max = float.MinValue;
                statistics.Average = 0;
                statistics.Sum = 0;


                for(int i = 0; i < grades.Count; i++)
                {
                    statistics.Max = Math.Max(statistics.Max, grades[i]);
                    statistics.Min = Math.Min(statistics.Min, grades[i]);
                    statistics.Sum += grades[i];
                }

                statistics.Average = statistics.Sum / grades.Count();
            }
            else
            {
                statistics.Min = 0;
                statistics.Max = 0;
                statistics.Average = 0;
                statistics.Sum = 0;
            }
            return statistics;
        }

        public Statistics GetStatisticsWithDoWhile()
        {
            Statistics statistics = new Statistics();

            if (this.grades.Count > 0)
            {
                statistics.Min = float.MaxValue;
                statistics.Max = float.MinValue;
                statistics.Average = 0;
                statistics.Sum = 0;
                int i = 0;

                do
                {
                    statistics.Max = Math.Max(statistics.Max, grades[i]);
                    statistics.Min = Math.Min(statistics.Min, grades[i]);
                    statistics.Sum += grades[i];
                    i++;
                } while (i < this.grades.Count);

                statistics.Average = statistics.Sum / grades.Count();
            }
            else
            {
                statistics.Min = 0;
                statistics.Max = 0;
                statistics.Average = 0;
                statistics.Sum = 0;
            }
            return statistics;
        }

        public Statistics GetStatisticsWithWhile()
        {
            Statistics statistics = new Statistics();

            if (this.grades.Count > 0)
            {
                statistics.Min = float.MaxValue;
                statistics.Max = float.MinValue;
                statistics.Average = 0;
                statistics.Sum = 0;
                int i = 0;

                while(i < grades.Count)
                {
                    statistics.Max = Math.Max(statistics.Max, grades[i]);
                    statistics.Min = Math.Min(statistics.Min, grades[i]);
                    statistics.Sum += grades[i];
                    i++;
                } 

                statistics.Average = statistics.Sum / grades.Count();
            }
            else
            {
                statistics.Min = 0;
                statistics.Max = 0;
                statistics.Average = 0;
                statistics.Sum = 0;
            }
            return statistics;
        }
    }
}
