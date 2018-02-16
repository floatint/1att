using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3._16
{

    class Program
    {
        enum SimpleColor
        {
            Black,
            White,
            Gray,
            Red,
            Orange,
            Yellow,
            Green,
            Blue
        }

        //Общие функции
        //находится ли точка выше параболы
        static bool IsPointAboveParabola(double a, double x0, double y0, double x, double y)
        {
            return y >= a * Math.Pow(x - x0, 2) + y0;
        }
        //находится ли точка справа от параболы
        static bool IsPointRightParabola(double a, double x0, double y0, double x, double y)
        {
            return x >= a * Math.Pow(y - y0, 2) + x0;
        }
        //Находится ли точка внутри круга
        static bool IsPointInCircle(double x, double y, double x0, double y0, double r)
        {
            return (Math.Pow(x - x0, 2) + Math.Pow(y - y0, 2)) <= Math.Pow(r, 2);
        }
        //Находится ли точка выше линии
        static bool IsPointAboveLine(double x, double y, double x0, double y0, double a)
        {
            return y >= a * (x - x0) + y0;
        }

        //Локальные
        //Находится ли точка выше желтой параболы
        static bool IsPointAboveYellowPara(double x, double y)
        {
            return IsPointAboveParabola(1, -4, 2, x, y);
        }
        //Находится ли точка правее голубой параболы
        static bool IsPointRightBlue(double x, double y)
        {
            return IsPointRightParabola(0.25, 0, 6, x, y);
        }
        //Находится ли точка правее бело-оранжевой параболы
        static bool IsPointRightWhiteOrange(double x, double y)
        {
            return IsPointRightParabola(0.125, 5, 2, x, y);
        }
        //Находится ли точка в трехцветном круге
        static bool IsPointInTripleColorCircle(double x, double y)
        {
            return IsPointInCircle(x, y, 5, 3, 2);
        }
        
        //Определение цвета
        static SimpleColor GetColor(double x, double y)
        {
            if (IsPointAboveYellowPara(x, y))
                return SimpleColor.Yellow;
            if (IsPointRightBlue(x, y) && IsPointRightWhiteOrange(x, y) && IsPointInTripleColorCircle(x, y))
                return SimpleColor.Green;
            if (IsPointRightBlue(x, y) && !IsPointRightWhiteOrange(x, y) && IsPointInTripleColorCircle(x, y))
                return SimpleColor.Orange;
            if (!IsPointRightBlue(x, y) && !IsPointRightWhiteOrange(x, y) && IsPointInTripleColorCircle(x, y))
                return SimpleColor.Orange;
            if (!IsPointRightBlue(x, y) && IsPointRightWhiteOrange(x, y) && IsPointInTripleColorCircle(x, y))
                return SimpleColor.Yellow;
            if (IsPointRightBlue(x, y) && IsPointRightWhiteOrange(x, y))
                return SimpleColor.Orange;
            if (IsPointRightBlue(x, y))
                return SimpleColor.Blue;
            return SimpleColor.White;
        }
        //Печать результата
        static void PrintColorForPoint(double x, double y)
        {
            Console.WriteLine("({0}, {1}) -> {2}", x, y, GetColor(x, y).ToString());
        }

        static bool CheckRange(double var)
        {
            if ((var < -10) || (var > 10))
                return false;
            return true;
        }

        //Ввод данных
        static double GetValue(string varname)
        {
            double var;
            Console.WriteLine("Input {0}:", varname.ToUpper());
            while ((!double.TryParse(Console.ReadLine(), out var)) || !CheckRange(var))
            {
                Console.WriteLine("Input correct {0}:", varname.ToUpper());

            }
            return var;
        }

        static void Main(string[] args)
        {
            PrintColorForPoint(5.3, 1.4);
            PrintColorForPoint(-2, 9);
            PrintColorForPoint(8.5, 9);
            PrintColorForPoint(7.1, 5.4);
            PrintColorForPoint(5.2, 1.4);
            //char flag = 'y';
            double x = GetValue("x");
            double y = GetValue("y");
            PrintColorForPoint(x, y);
            Console.WriteLine("Выполнить рассчет еще ? (any key or Enter)");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Console.WriteLine();
                x = GetValue("x");
                y = GetValue("y");
                PrintColorForPoint(x, y);
                Console.WriteLine("Выполнить рассчет еще ? (any key or Enter)");
            }
            //while (flag == 'y')
            //{
            //    GetValue("x", out x);
            //    GetValue("y", out y);
            //    PrintColorForPoint(x, y);
            //    Console.WriteLine("Выполнить рассчет еще ? (y/n)");
            //    flag = Console.ReadLine()[0];
            //}
            Console.ReadKey();
        }
    }
}
