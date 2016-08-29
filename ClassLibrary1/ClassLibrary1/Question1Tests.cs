using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibrary1
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestQ1BruteForce()
        {
            int[] input = { 5, 4, 2, 4 };
            Question1 test = new Question1();

            Assert.IsTrue(test.BruteForce(input, 8));

        }

        [TestMethod]
        public void TestQ1BruteForceFalse()
        {
            int[] input = { 5, 1, 2, 4 };
            Question1 test = new Question1();

            Assert.IsFalse(test.BruteForce(input, 8));
        }

        [TestMethod]
        public void TestQ1Sort()
        {
            int[] input = { 5, 4, 2, 4 };
            Question1 test = new Question1();

            Assert.IsTrue(test.SortMethod(input, 8));

        }

        [TestMethod]
        public void TestQ1SortFalse()
        {
            int[] input = { 5, 1, 2, 4 };
            Question1 test = new Question1();

            Assert.IsFalse(test.SortMethod(input, 8));
        }

        [TestMethod]
        public void TestQ1Hash()
        {
            int[] input = { 5, 4, 2, 4 };
            Question1 test = new Question1();

            Assert.IsTrue(test.HashMethod(input, 8));
            
        }

        [TestMethod]
        public void TestQ1HashFalse()
        {
            int[] input = { 5, 1, 2, 4 };
            Question1 test = new Question1();

            Assert.IsFalse(test.HashMethod(input, 8));
        }
    }
}
