using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace ChallengeApp.Tests
{
    public class EmploeeTests
    {
        [Test]
        public void WhenUserCollectTwogradess_ShouldReturnCorrectResults()
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

        [Test]
        public void WhenUserTryAddGradeA_SumShoudReturnCorrectResult()
        {
            //arrange
            var e = new Emploee();
            e.AddGrade('A');

            //act
            Statistics result = e.GetStatistics();

            //assert
            Assert.AreEqual(100, result.Sum);
        }

        [Test]
        public void WhenUserTryAddGradeB_SumShoudReturnCorrectResult()
        {
            //arrange
            var e = new Emploee();
            e.AddGrade('B');

            //act
            Statistics result = e.GetStatistics();

            //assert
            Assert.AreEqual(80, result.Sum);
        }

        [Test]
        public void WhenUserTryAddGradeC_SumShoudReturnCorrectResult()
        {
            //arrange
            var e = new Emploee();
            e.AddGrade('C');

            //act
            Statistics result = e.GetStatistics();

            //assert
            Assert.AreEqual(60, result.Sum);
        }

        [Test]
        public void WhenUserTryAddGradeD_SumShoudReturnCorrectResult()
        {
            //arrange
            var e = new Emploee();
            e.AddGrade('D');

            //act
            Statistics result = e.GetStatistics();

            //assert
            Assert.AreEqual(40, result.Sum);
        }

        [Test]
        public void WhenUserTryAddGradeE_SumShoudReturnCorrectResult()
        {
            //arrange
            var e = new Emploee();
            e.AddGrade('E');

            //act
            Statistics result = e.GetStatistics();

            //assert
            Assert.AreEqual(20, result.Sum);
        }

        [Test]
        public void WhenUserTryAddGrade100_AvgLetterShouldReturnCorrectResult()
        {
            //arrange
            var e = new Emploee();
            e.AddGrade(100);

            //act
            Statistics result = e.GetStatistics();

            //assert
            Assert.AreEqual('A', result.AverageLetter);
        }

        [Test]
        public void WhenUserTryAddGrade60_AvgLetterShouldReturnCorrectResult()
        {
            //arrange
            var e = new Emploee();
            e.AddGrade(60);

            //act
            Statistics result = e.GetStatistics();

            //assert
            Assert.AreEqual('B', result.AverageLetter);
        }

        [Test]
        public void WhenUserTryAddGrade_AvgLetterShouldReturnCorrectResult()
        {
            //arrange
            var e = new Emploee();
            e.AddGrade(40);

            //act
            Statistics result = e.GetStatistics();

            //assert
            Assert.AreEqual('C', result.AverageLetter);
        }

        [Test]
        public void WhenUserTryAddGrade20_AvgLetterShouldReturnCorrectResult()
        {
            //arrange
            var e = new Emploee();
            e.AddGrade(20);

            //act
            Statistics result = e.GetStatistics();

            //assert
            Assert.AreEqual('D', result.AverageLetter);
        }

        [Test]
        public void WhenUserTryAddGrade0_AvgLetterShouldReturnCorrectResult()
        {
            //arrange
            var e = new Emploee();
            e.AddGrade(0);

            //act
            Statistics result = e.GetStatistics();

            //assert
            Assert.AreEqual('E', result.AverageLetter);
        }
    }
}