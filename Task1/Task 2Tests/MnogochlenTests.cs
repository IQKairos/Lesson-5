using Microsoft.VisualStudio.TestTools.UnitTesting;
using Les5Task2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les5Task2.Tests
{
    [TestClass()]
    public class MnogochlenTests
    {
        [TestMethod()]
        public void MnogochlenTest()
        {
            try
            {
                int step = 5;
                int[] koef = new int[] { 1, 2, 3, 4, 5 };
                Mnogochlen A = new Mnogochlen(koef, step);
                int step2 = 10;
                int[] koef2 = new int[] { 1, 2, 3, 4, 5 };
                Mnogochlen B = new Mnogochlen(koef2, step2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            Assert.Fail("no message was thrown");
        }

        [TestMethod()]
        public void showTest()
        {
            int step = 4;
            int[] koef = new int[] { 1, 2, 3, 4, 5 };
            Mnogochlen A = new Mnogochlen(koef, step);
            int step2 = 4;
            int[] koef2 = new int[] { 1, 2, 3, 4, 5 };
            Mnogochlen B = new Mnogochlen(koef2, step2);
            Mnogochlen C = A + B;
            Assert.IsTrue(C.step == 4);
            int[] koef3 = new int[] { 2, 4, 6, 8, 10 };
            for (int i = 0; i < C.koef.Length; i++)
            {
                Assert.IsTrue(C.koef[i] == koef3[i]);
            }
        }
    }
}