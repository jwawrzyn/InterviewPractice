using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace ClassLibrary1
{
    [TestClass]
    public class Question2Tests
    {
        [TestMethod]
        public void Insert()
        {
            Question2Set test = new Question2Set();
            test.Insert(3);
            test.Insert(4);
            test.Insert(5);

            Assert.IsTrue(test.Count() == 3);
        }

        [TestMethod]
        public void Remove()
        {
            Question2Set test = new Question2Set();
            test.Insert(3);
            test.Insert(4);
            test.Insert(5);
            test.Remove(4);

            Assert.IsTrue(test.Count() == 2);
        }

        [TestMethod]
        public void GetRandom()
        {
            Question2Set test = new Question2Set();
            test.Insert(3);
            test.Insert(4);
            test.Insert(5);

            List<int> numbers = new List<int>();
            numbers.AddRange(new int[] {3,4,5});

            Assert.IsTrue(numbers.Contains(test.GetRandom()));
        }
    }
}
