using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les5Task1
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int left = 10;
            int right = 15;
            RangeArray myarr = new RangeArray(left, right);
            int myArrLength = myarr.Length;

            for (int i = left; i <= right; i++)
            {
                myarr[i] = i;
            }

        }
    }
}
