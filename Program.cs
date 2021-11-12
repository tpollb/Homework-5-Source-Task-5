using System;

namespace Homework_5_Source_Task_5
{
    class Program
    {
        /// <summary>
        /// Функция Аккермана. Принимает два неотрицательных целых числа в качестве параметров и возвращает натуральное число.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        static Int64 AkermanFunction(Int64 n, Int64 m)
        {
            if (n == 0)
            {
                return m + 1;
            }
            else if ((n != 0) && (m == 0))
            {
                return AkermanFunction(n - 1, 1);
            }                
            else
            {
                return AkermanFunction(n - 1, AkermanFunction(n, m - 1));
            }
        }
        static void Main(string[] args)
        {
            Int64 n = 0;
            Int64 m = 0;
            bool flag = default;

            while ((n < 1 || n > 3) & flag == false)
            {
                Console.WriteLine("Введите первый параметр функции n от 1 до 3: ");
                Int64.TryParse(Console.ReadLine(), out n);
            }

            flag = default;

            while (m < 1 || n > 10)
            {
                Console.WriteLine("Введите первый параметр функции m от 1 до 10: ");
                Int64.TryParse(Console.ReadLine(), out m);
            }

            Console.WriteLine($"Результат: " + AkermanFunction(n, m));

            Console.ReadKey();
        }
    }
}
