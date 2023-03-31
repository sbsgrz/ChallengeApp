namespace ChallengeApp
{
    internal interface IEmploee
    {
        string Name { get;}    
        string Surname { get;}

        char Sex { get;}
        Statistics GetStatistics();

        void AddGrade(float grade);

        void AddGrade(string grade);

        void AddGrade(char grade);

        void AddGrade(double grade); 
    }
}
