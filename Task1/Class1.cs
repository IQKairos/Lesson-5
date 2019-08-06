using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les5Task1
{
    public class RangeArray
    {
        int[] myarr;
        int lowerBound;
        int upperBound;
        public int LowerBound { get; }
        public int UpperBound { get; }
        public int Length { get; private set; }
        public RangeArray(int low, int high)
        {
            high++;
            if (high <= low)
            {
                high = 1;
                low = 0;
                throw new Exception("Неверные индексы, принимаю длину масива за 1 ");
            }
            myarr = new int[high - low];
            Length = high - low;
            lowerBound = low;
            upperBound = --high;
        }
        public int this[int index]
        {
            get
            {
                if (ok(index))
                {
                    return myarr[index - lowerBound];
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                if (ok(index))
                {
                    myarr[index - lowerBound] = value;
                }
                else
                {
                }
            }
        }
        private bool ok(int index)
        {
            if ((index >= lowerBound) & (index <= upperBound)) return true;
            return false;
        }
    }
}
