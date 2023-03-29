
namespace ChallengeApp
{
    public abstract class Person
    {

        protected Person(string FirstName, string LastName, bool IsWoman)
        {
            this.firstName= FirstName;
            this.lastName= LastName;
            this.isWoman= IsWoman;
        }

        protected string firstName { get; set; }
        protected string lastName { get; set; }
        protected bool isWoman { get; set; }
    }
}
