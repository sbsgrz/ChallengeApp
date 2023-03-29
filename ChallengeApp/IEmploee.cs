namespace ChallengeApp
{
    internal interface IEmploee
    {
        public Statistics GetStatistics();

        public void AddGrade(float grade);

        public void AddGrade(string grade);

        public void AddGrade(char grade);

        public void AddGrade(double grade);
    }
}
