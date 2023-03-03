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
            Console.WriteLine("dupa dupa");
            
            // act
            int result = e.result;

            // assert
            Assert.AreEqual(15, result);


            // Assert.Pass();
        }

        [Test]
        public void WhenUserCollectOneScoreAndLostOne_ShouldCorrectResult()
        {
            //arrange
            var e = new Emploee("Jan", "Kowalski", 30);
            e.AddScore(10);
            e.RemoveScore(2);

            //act
            int result = e.result;

            //assert
            Assert.AreEqual(8,result);
        }

        [Test]
        public void WhenUserTryToAddScoreWithNegativeNumber_ShouldDoNotAdd()
        {
            //arrange
            var e = new Emploee("Jan", "Kowalski", 30);
            e.AddScore(10);
            e.AddScore(-5);

            //act
            int result = e.result;

            //assert
            Assert.AreEqual(10, result);
        }

        [Test]
        public void WhenUserTryToRemoveScoreWithNegativeNumber_ShouldRemove()
        {
            //arrange
            var e = new Emploee("Jan", "Kowalski", 30);
            e.AddScore(20);
            e.RemoveScore(-5);

            //act
            int result = e.result;

            //assert
            Assert.AreEqual(15, result);
        }

        [Test]
        public void WhenUserTryToRemoveScoreWithPositiveNumber_ShouldRemove()
        {
            //arrange
            var e = new Emploee("Jan", "Kowalski", 30);
            e.AddScore(20);
            e.RemoveScore(5);

            //act
            int result = e.result;

            //assert
            Assert.AreEqual(15, result);
        }
    }
}