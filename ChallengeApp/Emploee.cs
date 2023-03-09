using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class Emploee
    {
        static int emploeeCount = 0;
        private string firstName;
        private string lastName;
        private uint age;

        private List<float> grades = new List<float>();

        //public int result => this.grades.Sum();

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public uint Age { get { return age; } set { age = value; } }


        public Emploee()
        {
            firstName = string.Empty;
            lastName = string.Empty;
            age = 0;
            Emploee.emploeeCount++;
        }

        public Emploee(string firstName, string lastName, uint age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            Emploee.emploeeCount++;
        }

        public bool AddGrades(float grades)
        {
            if (grades >= 0 && grades <= 100)
            {
                this.grades.Add(grades);
                return true;
            }
            else
            {
                return false;
                // Console.WriteLine($"Pracownik {this.firstName} {this.lastName} funkcja AddGrade - podana wartość jest poza skalą");
            }
        }

        public bool AddGrades(string grades)
        {
            int a = 5;
            //float.TryParse(a, out float resutl);

            float r = a;


            if (float.TryParse(grades, out float result))
            {
                this.AddGrades(result);
                return true;
            }
            else
                return false;
        }
        /*
        public bool RemoveGrades(int grades) 
        {
            if (grades <= 0) 
            { 
                this.grades.Add(grades);
                return true;
            }
            else if(grades > 0)
            {
                grades = -grades;
                this.grades.Add(grades);
                return true;
            }
            else
            {
                return false;
            }
        }
        */

        public Statistics GetStatistics()
        {
            Statistics statistics = new Statistics();

            if (this.grades.Count > 0)
            {
                statistics.Min = float.MaxValue;
                statistics.Max = float.MinValue;
                statistics.Average = 0;


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
    }
}
