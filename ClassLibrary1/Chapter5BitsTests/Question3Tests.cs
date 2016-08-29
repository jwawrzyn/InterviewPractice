using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chapter5Bits;

namespace Chapter5BitsTests
{
    [TestClass]
    class Question3Tests
    {
        [TestMethod]
        public void Q3_BruteForce_1()
        {
            Question3 test = new Question3();
            int result = test.BruteForce(1775);
            Assert.IsTrue(result == 8);
        }
    }
}
