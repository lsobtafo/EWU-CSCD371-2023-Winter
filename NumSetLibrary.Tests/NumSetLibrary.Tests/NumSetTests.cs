using NUnit.Framework;
using NumSetLibrary;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NumSetLibrary.Tests
{
    [TestFixture]
    public class NumSetTests
    {
        [Test]
        public void NumSetToString_ReturnsStringRepresentationOfNumSet()
        {
            // Arrange
            var numSet = new NumSet(1, 2, 3);

            // Act
            var result = numSet.ToString();

            // Assert
            Assert.AreEqual("1, 2, 3", result);
        }

        [Test]
        public void NumSetEquals_ReturnsTrueWhenNumSetsAreEqual()
        {
            // Arrange
            var numSet1 = new NumSet(1, 2, 3);
            var numSet2 = new NumSet(3, 2, 1);

            // Act
            var result = numSet1.Equals(numSet2);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void NumSetOperatorEquals_ReturnsTrueWhenNumSetsAreEqual()
        {
            // Arrange
            var numSet1 = new NumSet(1, 2, 3);
            var numSet2 = new NumSet(3, 2, 1);

            // Act
            var result = numSet1 == numSet2;

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void NumSetOperatorNotEquals_ReturnsTrueWhenNumSetsAreNotEqual()
        {
            // Arrange
            var numSet1 = new NumSet(1, 2, 3);
            var numSet2 = new NumSet(3, 2, 1, 4);

            // Act
            var result = numSet1 != numSet2;

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void NumSetToArray_ReturnsArrayWithNumbersFromSet()
        {
            // Arrange
            var numSet = new NumSet(1, 2, 3);

            // Act
            var result = numSet.ToArray();

            // Assert
            Assert.AreEqual(new int[] { 1, 2, 3 }, result);
        }
    }
}

