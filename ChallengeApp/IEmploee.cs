using static ChallengeApp.EmploeeBase;

namespace ChallengeApp
{
    internal interface IEmploee
    {
        string Name { get;}    
        string Surname { get;}

        event GradeAddedDelegate GradeAdded;

        void AddGrade(float grade);

        void AddGrade(string grade);

        void AddGrade(char grade);

        void AddGrade(double grade);

        Statistics GetStatistics();
    }
}
