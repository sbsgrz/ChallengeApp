using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp.Tests
{
    public class StatisticsClass
    {
        [Test]
        public void WhenUserDontCollectAnyGrades_SumShouldRemove0()
        {
            // arrange
            var emploee = new Emploee("Jan","Kowalski",30);

            // act

            // assert
            Assert.AreEqual(0, emploee.GetStatistics().Sum);
        }
        
        [Test]
        public void WhenUserDontCollectAnyGrades_MinShouldRemove0()
        {
            // arrange
            var emploee = new Emploee("Jan", "Kowalski", 30);

            // act

            // assert
            Assert.AreEqual(0, emploee.GetStatistics().Min);
        }
        
        [Test]
        public void WhenUserDontCollectAnyGrades_MaxShouldRemove0()
        {
            // arrange
            var emploee = new Emploee("Jan", "Kowalski", 30);

            // act

            // assert
            Assert.AreEqual(0, emploee.GetStatistics().Max);
        }
        
        [Test]
        public void WhenUserDontCollectAnyGrades_AverageShouldRemove0()
        {
            // arrange
            var emploee = new Emploee("Jan", "Kowalski", 30);

            // act

            // assert
            Assert.AreEqual(0, emploee.GetStatistics().Average);

        }

        [Test]
        public void WhenUserCollectTwogradess_ShouldReturnCorrectResults()
        {
            // arrange
            var e = new Emploee("Jan", "Kowalski", 30);
            e.AddGrades(5);
            e.AddGrades(10);

            // act
            Statistics result = e.GetStatistics();

            // assert
            Assert.AreEqual(15, result.Sum);


            // Assert.Pass();
        }

        [Test]
        public void WhenUserCollectOnegradesAndLostOne_ShouldReturnCorrectResult()
        {
            //arrange
            var e = new Emploee("Jan", "Kowalski", 30);
            e.AddGrades(10);
            e.RemoveGrades(2);

            //act
            Statistics result = e.GetStatistics();

            //assert
            Assert.AreEqual(8, result.Sum);
        }

        [Test]
        public void WhenUserTryToAddGradesWithNegativeNumber_ShouldDoNotAdd()
        {
            //arrange
            var e = new Emploee("Jan", "Kowalski", 30);
            e.AddGrades(10);
            e.AddGrades(-5);

            //act
            Statistics result = e.GetStatistics();

            //assert
            Assert.AreEqual(10, result.Sum);
        }

        [Test]
        public void WhenUserTryToRemoveGradesWithNegativeNumber_ShouldRemove()
        {
            //arrange
            var e = new Emploee("Jan", "Kowalski", 30);
            e.AddGrades(20);
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
            e.AddGrades(20);
            e.RemoveGrades(5);

            //act
            Statistics result = e.GetStatistics();

            //assert
            Assert.AreEqual(15, result.Sum);
        }
    }
}
