using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les5Task2
{
    public class Mnogochlen
    {
        public int[] koef; //массив коэф-ов
        public int step;
        public Mnogochlen(int[] k, int s)
        {
            if (s + 1 != k.Length)
            {
                throw new Exception("Степень многочлена должна быть меньше кол. коеф. на 1");
            }
            koef = k;
            step = s;
        }
        //сложение полиномов
        public static Mnogochlen operator +(Mnogochlen A, Mnogochlen B)
        {

            int step3 = 0;
            if (A.step >= B.step)
            {
                step3 = A.step;
            }
            else
            {
                step3 = B.step;
            }
            int[] koef3 = new int[step3 + 1];
            int[] nullarr = new int[step3 + 1];
            if (A.step > B.step)
            {
                int j = 0;
                for (int i = (nullarr.Length - B.koef.Length); i < nullarr.Length; i++)
                {
                    nullarr[i] = B.koef[j];
                    j++;
                }
            }
            else if (A.step < B.step)
            {
                int j = 0;
                for (int i = (nullarr.Length - A.koef.Length); i < nullarr.Length; i++)
                {
                    nullarr[i] = A.koef[j];
                    j++;
                }
            }
            else
            {
                for (int i = 0; i < nullarr.Length; i++)
                {
                    nullarr[i] = B.koef[i];
                }
            }
            Mnogochlen C = new Mnogochlen(koef3, step3);
            if (A.step >= B.step)
            {
                for (int i = koef3.Length - 1; i >= 0; i--)
                {
                    C.koef[i] = A.koef[i] + nullarr[i];
                }
                return C;
            }
            else
            {
                for (int i = koef3.Length - 1; i >= 0; i--)
                {
                    C.koef[i] = B.koef[i] + nullarr[i];
                }
                return C;
            }

        }
        //вычитание полиномов
        public static Mnogochlen operator -(Mnogochlen A, Mnogochlen B)
        {
            int step3 = 0;
            if (A.step >= B.step)
            {
                step3 = A.step;
            }
            else
            {
                step3 = B.step;
            }
            int[] koef3 = new int[step3 + 1];
            int[] nullarr = new int[step3 + 1];
            if (A.step > B.step)
            {
                int j = 0;
                for (int i = (nullarr.Length - B.koef.Length); i < nullarr.Length; i++)
                {
                    nullarr[i] = B.koef[j];
                    j++;
                }
            }
            else if (A.step < B.step)
            {
                int j = 0;
                for (int i = (nullarr.Length - A.koef.Length); i < nullarr.Length; i++)
                {
                    nullarr[i] = A.koef[j];
                    j++;
                }
            }
            else
            {
                for (int i = 0; i < nullarr.Length; i++)
                {
                    nullarr[i] = B.koef[i];
                }
            }
            Mnogochlen C = new Mnogochlen(koef3, step3);
            if (A.step >= B.step)
            {
                for (int i = koef3.Length - 1; i >= 0; i--)
                {
                    C.koef[i] = A.koef[i] - nullarr[i];
                }
                return C;
            }
            else
            {
                for (int i = koef3.Length - 1; i >= 0; i--)
                {
                    C.koef[i] = B.koef[i] - nullarr[i];
                }
                return C;
            }
        }
        public static Mnogochlen operator *(Mnogochlen A, Mnogochlen B)
        {
            int step3 = A.step + B.step;
            int[] koef3 = new int[step3 + 1];
            Mnogochlen C = new Mnogochlen(koef3, step3);
            for (int i = 0; i < A.koef.Length; ++i)
            {
                for (int j = 0; j < B.koef.Length; ++j)
                {
                    C.koef[i + j] += A.koef[i] * B.koef[j];
                }
            }
            return C;
        }

        //вывод полинома
        public void show()
        {
            for (int i = 0; i < step; i++)
            {
                if (koef[i] < 0)
                {
                    Console.Write(koef[i] + "x^" + (step - i));
                }
                else if (koef[i] != 0)
                {
                    Console.Write("+" + koef[i] + "x^" + (step - i));
                }
            }
            if (koef[step] > 0)
            {
                Console.Write("+" + koef[step]);
            }
            else
            {
                Console.Write(koef[step]);
            }

            Console.WriteLine("");
            //return 0;
        }
    }
}
