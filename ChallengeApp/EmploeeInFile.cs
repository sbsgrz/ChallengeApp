
using System.Runtime.CompilerServices;

namespace ChallengeApp
{
    public class EmploeeInFile : EmploeeBase
    {

        public const string fileName = "grades.txt";
        public override event GradeAddedDelegate? GradeAdded;

        public EmploeeInFile(string name, string surname) 
            : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(grade);

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }  
            }
        }

        protected override List<float> GetGrades()
        {
            List<float> grades = new List<float>();

            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        grades.Add(float.Parse(line));
                        line = reader.ReadLine();
                    }
                }
            }
            return grades;
        }
          
    }
}
