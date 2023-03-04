namespace ChallengeApp.Tests
{
    internal class TypeTests
    {
        [Test]
        public void WhenCompareTwoReferenceVariablesPointingObjectsWithTheSameProperties_ShouldNotBeEqual()
        {
            // arrange
            var emploee1 = new Emploee("Jan", "Kowalski", 20);
            var emploee2 = new Emploee("Jan", "Kowalski", 20);

            // act

            // assert
            Assert.AreNotEqual(emploee1,emploee2);
        }

        [Test]
        public void WhenCompareTwoReferenceVariablesPointingTheSameObject_ShouldNotBeEqual() 
        {
            // arrange
            var emploee1 = new Emploee("Jan", "Kowalski", 20);
            var emploee2 = emploee1;

            //act

            // arrange
            Assert.AreEqual(emploee1, emploee2);

        }
    }
}
