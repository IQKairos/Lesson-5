using Microsoft.VisualStudio.TestTools.UnitTesting;
using Les5Task1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les5Task1.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void MainTest()
        {
            try
            {
                RangeArray myarr1 = new RangeArray(10, 5);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            Assert.Fail("no message was thrown");

        }
        [TestMethod()]
        public void RangeArrayTest()
        {
            RangeArray myarr1 = new RangeArray(5, 10);
            int leng = myarr1.Length;
            Assert.IsTrue(leng == 6);
        }
    }
}