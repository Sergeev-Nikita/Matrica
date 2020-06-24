using System;

namespace Matr
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum1 = 0;
            Console.WriteLine("Введите a-строк и b-столбцов!");
            Console.Write("a=");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int[,] k = new int[a, b];
            Random r = new Random();        

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    k[i, j] = r.Next(0, 3);    
                    Console.Write("{0} ", k[i, j]);
                }
                Console.WriteLine();
            }

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    sum1 += k[i, j];       
                }
                Console.WriteLine();
                Console.WriteLine("Сумма " + (i + 1) + " строки равна " + sum1);     
                sum1 = 0;    
            }

            Console.ReadKey();
        }
    }
}
