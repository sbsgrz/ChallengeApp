
namespace ChallengeApp
{
    public class EmploeeInMemory : EmploeeBase
    {
        private List<float> grades = new List<float>();
        public override event GradeAddedDelegate? GradeAdded;

        public EmploeeInMemory(string name, string surname) 
            : base(name, surname)
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

        protected override List<float> GetGrades()
        {
            return grades;
        }


    }
}
