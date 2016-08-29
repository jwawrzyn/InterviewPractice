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
    public class Question1Tests
    {
        [TestMethod]
        public void UpdateBits_Test1()
        {
            Question1 test = new Question1();
            int result = test.UpdateBits(100, 10, 2, 6);
            Assert.IsTrue(result == 40);
        }
    }
}
