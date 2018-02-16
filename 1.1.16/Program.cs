using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using CSF_Lib;

namespace _1._1._16
{
    class Program
    {

        static bool GetByteInput(string varname, out byte var, byte max, byte min)
        {
            Console.WriteLine("Введите значение {0} :", varname);
            while ((!byte.TryParse(Console.ReadLine(), out var)) || (var < min) || (var > max))
            {
                Console.WriteLine("Введите корректное значение {0} :", varname);

            }
            return true;
        }
        static void Main(string[] args)
        {
            byte h1 = 0, m1 = 0, s1 = 0, h2 = 0, m2 = 0, s2 = 0;
            //первый момент
            GetByteInput("h1", out h1, 23, 0);
            GetByteInput("m1", out m1, 59, 0);
            GetByteInput("s1", out s1, 59, 0);
            //второй момент
            GetByteInput("h2", out h2, 23, 0);
            GetByteInput("m2", out m2, 59, 0);
            GetByteInput("s2", out s2, 59, 0);
            //обработка
            long res = ((((h2 + 24) * 3600) + (m2 * 60) + s2) - ((h1 * 3600) + (m1 * 60) + s1)) % 86400;
            Console.WriteLine("От {0}:{1}:{2} до {3}:{4}:{5} пройдет {6} секунд.", h1, m1, s1, h2, m2, s2, res);
            Console.ReadKey();
        }
    }
}
