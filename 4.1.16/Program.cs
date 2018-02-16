using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1._16
{
    class Program
    {
        static uint GetUintInput(string varname)
        {
            uint var;
            Console.WriteLine("Введите значение {0} :", varname);
            while (!uint.TryParse(Console.ReadLine(), out var))
            {
                Console.WriteLine("Введите корректное значение {0} :", varname);
            }
            return var;
        }

        static uint GetNumber(uint n)
        {
            uint cur = 1;
            uint next = 1;
            uint sum = 0;
            uint tmp = 0;
            for (int i = 1; i <= n - 1; i++)
            {
                tmp = next;
                next = next + cur;
                cur = tmp;
                if (next % 2 == 0)
                {
                    sum += next;
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            //1 1 2 3 5 8 13 21 34 55 89 144
            Console.WriteLine(GetNumber(GetUintInput("n")));
            Console.WriteLine("Выполнить рассчет еще ? (any key or Enter)");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Console.WriteLine(); //выравнивание
                Console.WriteLine(GetNumber(GetUintInput("n")));
            }
            //Console.WriteLine(sum);
        }
    }
}
