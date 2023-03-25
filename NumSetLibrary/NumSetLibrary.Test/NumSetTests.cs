using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumSetLibrary;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NumSetLibrary.Tests
{
    [TestClass]
    public class NumSetTests
    {
        [TestMethod]
        public void TestNumSetConstructor()
        {
            NumSet set = new NumSet(1, 2, 3);
            CollectionAssert.AreEquivalent(new int[] { 1, 2, 3 }, set.ToArray());
        }

        [TestMethod]
        public void TestNumSetEquals()
        {
            NumSet set1 = new NumSet(1, 2, 3);
            NumSet set2 = new NumSet(2, 1, 3);
            NumSet set3 = new NumSet(1, 2, 4);
            NumSet set4 = new NumSet(1, 2, 3, 4);

            Assert.IsTrue(set1.Equals(set2));
            Assert.IsFalse(set1.Equals(set3));
            Assert.IsFalse(set1.Equals(set4));
        }

        [TestMethod]
        public void TestNumSetToString()
        {
            NumSet set = new NumSet(1, 2, 3);
            Assert.AreEqual("1, 2, 3", set.ToString());
        }

        [TestMethod]
        public void TestNumSetImplicitCast()
        {
            NumSet set = new NumSet(1, 2, 3);
            int[] array = set;
            CollectionAssert.AreEquivalent(new int[] { 1, 2, 3 }, array);
        }

        [TestMethod]
        public void TestSetWriter()
        {
            string fileName = "test.txt";
            NumSet set = new NumSet(1, 2, 3);

            using (SetWriter writer = new SetWriter(fileName))
            {
                writer.Write(set);
            }

            string[] lines = File.ReadAllLines(fileName);
            Assert.AreEqual("1, 2, 3", lines[0]);
        }
    }
}





