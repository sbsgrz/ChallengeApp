using System.Reflection.Metadata;

namespace ChallengeApp.Tests
{
    public class EmploeeTests
    {
        [Test]
        public void WhenUserCollectTwogradess_ShouldCorrectResults()
        {
            // arrange
            var e = new Emploee("Jan", "Kowalski");
            e.AddGrade(5);
            e.AddGrade(10);
            
            // act
            Statistics result = e.GetStatistics();

            // assert
            Assert.AreEqual(15, result.Sum);


            // Assert.Pass();
        }

        [Test]
        public void WhenUserTryToAddGradesWithNegativeNumber_ShouldDoNotAdd()
        {
            //arrange
            var e = new Emploee("Jan", "Kowalski");
            e.AddGrade(10);
            e.AddGrade(-5);

            //act
            Statistics result = e.GetStatistics();

            //assert
            Assert.AreEqual(10, result.Sum);
        }

    }
}