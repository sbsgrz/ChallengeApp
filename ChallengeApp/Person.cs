
namespace ChallengeApp
{
    public abstract class Person
    {

        protected Person(string FirstName, string LastName, bool IsWoman)
        {
            this.Name= FirstName;
            this.Surname= LastName;
            this.isWoman= IsWoman;
        }

        protected string Name { get; set; }
        protected string Surname { get; set; }
        protected bool isWoman { get; set; }
    }
}
