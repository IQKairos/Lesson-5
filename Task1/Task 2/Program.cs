using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les5Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ввод первого многочлена
            //Степень многочлена должна быть меньше кол. коеф. на 1
            int step = 4;
            int[] koef = new int[] { 1, 2, 3, 4, 5 };

            Mnogochlen A = new Mnogochlen(koef, step);
            //ввод второго многочлена
            int step2 = 3;
            int[] koef2 = new int[] { 1, 2, 3, 4 };
            if (step + 1 != koef.Length)
            {
                throw new Exception("Степень многочлена должна быть меньше кол. коеф. на 1");
            }
            Mnogochlen B = new Mnogochlen(koef2, step2);


            //вывод многочленов
            Console.Write("A= ");
            A.show();
            Console.WriteLine("\n");
            Console.Write("B= ");
            B.show();

            //вывод операций
            A = new Mnogochlen(koef, step);
            B = new Mnogochlen(koef2, step2);
            int cc = A.step;
            Mnogochlen C = A + B;
            Mnogochlen D = A - B;
            Mnogochlen E = A * B;

            Console.Write("A+B= ");
            C.show();

            Console.Write("A-B= ");
            D.show();

            Console.Write("A*B= ");
            E.show();

            Console.ReadLine();
        }
    }
}
