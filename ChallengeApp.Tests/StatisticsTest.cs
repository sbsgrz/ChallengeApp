using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp.Tests
{
    public class StatisticsTest
    {
        [Test]
        public void WhenUserDontCollectAnyGrades_SumShouldRemove0()
        {
            // arrange
            var emploee = new Emploee("Jan","Kowalski");

            // act

            // assert
            Assert.AreEqual(0, emploee.GetStatistics().Sum);
        }
        
        [Test]
        public void WhenUserDontCollectAnyGrades_MinShouldRemove0()
        {
            // arrange
            var emploee = new Emploee("Jan", "Kowalski");

            // act

            // assert
            Assert.AreEqual(0, emploee.GetStatistics().Min);
        }
        
        [Test]
        public void WhenUserDontCollectAnyGrades_MaxShouldRemove0()
        {
            // arrange
            var emploee = new Emploee("Jan", "Kowalski");

            // act

            // assert
            Assert.AreEqual(0, emploee.GetStatistics().Max);
        }
        
        [Test]
        public void WhenUserDontCollectAnyGrades_AverageShouldRemove0()
        {
            // arrange
            var emploee = new Emploee("Jan", "Kowalski");

            // act

            // assert
            Assert.AreEqual(0, emploee.GetStatistics().Average);

        }

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
        }
    }
}
