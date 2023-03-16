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

        /*
        [Test]
        public void WhenUserCollectOnegradesAndLostOne_ShouldCorrectResult()
        {
            //arrange
            var e = new Emploee("Jan", "Kowalski", 30);
            e.AddGrade(10);
            e.RemoveGrades(2);

            //act
            Statistics result = e.GetStatistics();

            //assert
            Assert.AreEqual(8,result.Sum);
        }
        */

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

        /*
        [Test]
        public void WhenUserTryToRemoveGradesWithNegativeNumber_ShouldRemove()
        {
            //arrange
            var e = new Emploee("Jan", "Kowalski", 30);
            e.AddGrade(20);
            e.RemoveGrades(-5);

            //act
            Statistics result = e.GetStatistics();

            //assert
            Assert.AreEqual(15, result.Sum);
        }

        [Test]
        public void WhenUserTryToRemoveGradesWithPositiveNumber_ShouldRemove()
        {
            //arrange
            var e = new Emploee("Jan", "Kowalski", 30);
            e.AddGrade(20);
            e.RemoveGrades(5);

            //act
            Statistics result = e.GetStatistics();

            //assert
            Assert.AreEqual(15, result.Sum);
        }
        */
    }
}