using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2._16
{
    class Program
    {
        static bool GetUintInput(string varname, out uint var, uint max, uint min)
        {
            Console.WriteLine("Введите значение {0} :", varname);
            while ((!uint.TryParse(Console.ReadLine(), out var)) || (var < min) || (var > max))
            {
                Console.WriteLine("Введите корректное значение {0} :", varname);
            }
            return true;
        }
        static uint GetCentury(uint age)
        {
            //1901 - начало 20 столетия
            return ((age-1) / 100) + 1;
        }
        static void Main(string[] args)
        {
            uint age = 0; //заданный год
            GetUintInput("номера года", out age, uint.MaxValue, 0);
            Console.WriteLine("Номер столетия : {0}.", GetCentury(age));
            Console.ReadKey();
        }
    }
}
