using System.Reflection.Metadata;

namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectTwoScores_ShouldCorrectResults()
        {
            // arrange
            var e = new Emploee("Jan", "Kowalski", 30);
            e.AddScore(5);
            e.AddScore(10);
            
            
            // act
            int result = e.result;

            // assert
            Assert.AreEqual(15, result);


            // Assert.Pass();
        }
    }
}