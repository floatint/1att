using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2._16
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
        //Находится ли функция ниже параболы
        static bool IsPointBelowParabola(double a, double x0, double y0, double x, double y)
        {
            return y <= a * Math.Pow(x - x0, 2) + y0;
        }
        //находится ли точка справа от параболы
        static bool IsPointRightParabola(double a, double x0, double y0, double x, double y)
        {
            return x >= a * Math.Pow(y - y0, 2) + x0;
        }
        //Находится ли точка слева от параболы
        static bool IsPointLeftParabola(double a, double x0, double y0, double x, double y)
        {
            return x <= a * Math.Pow(y - y0, 2) + x0;
        }
        //Находится ли точка внутри круга
        static bool IsPointInCircle(double x, double y, double x0, double y0, double r)
        {
            return (Math.Pow(x - x0, 2) + Math.Pow(y - y0, 2)) <= Math.Pow(r, 2);
        }
        //Находится ли точка в прямоугольнике
        static bool IsPointInRect(double x0, double y0, double h, double w, double x, double y)
        {
            return ((x >= x0) && (y <= y0)) && ((x <= x0 + w) && (y <= y0 + h));
            //return ((x <= x0) && (y < y0)) && ((x >= x0 + w) && (y >= y0 + h));
        }
        //Находится ли точка выше линии
        static bool IsPointAboveLine(double x, double y, double x0, double y0, double a)
        {
            return y >= a * (x - x0) + y0;
        }

        //Локальные функции
        //Находится ли точка выше линии 1 ? Перегружена.
        static bool IsPointAboveLine1(double x, double y)
        {
            return IsPointAboveLine(x, y, -2, 0, 0.25);
        }
        //Находится ли точка выше линии 2 ?
        static bool IsPointAboveLine2(double x, double y)
        {
            return IsPointAboveLine(x, y, 0, 2, 0);
        }
        //Перегрежена.
        static bool IsPointInRect(double x, double y)
        {
            return IsPointInRect(-6, 4, 7, 4, x, y);
        }

        static bool IsPointLeftParabola1(double x, double y)
        {
            return IsPointLeftParabola(-0.5, 4, 4, x, y);
        }

        static bool IsPointBelowParabola2(double x, double y)
        {
            return IsPointBelowParabola(-0.125, 0, -3, x, y);
        }

        //Определение цвета
        static SimpleColor GetColor(double x, double y)
        {
            if (IsPointLeftParabola1(x, y) && IsPointAboveLine2(x, y) && IsPointInRect(x, y))
                return SimpleColor.Blue;
            if (IsPointLeftParabola1(x, y) && IsPointAboveLine2(x, y) && !IsPointInRect(x, y))
                return SimpleColor.Green;
            if (IsPointLeftParabola1(x, y) && !IsPointAboveLine2(x, y) && IsPointInRect(x, y))
                return SimpleColor.Blue;
            if (IsPointLeftParabola1(x, y) && !IsPointAboveLine2(x, y) && !IsPointInRect(x, y))
                return SimpleColor.Orange;
            if (!IsPointLeftParabola1(x, y) && IsPointAboveLine1(x, y) && IsPointInRect(x, y))
                return SimpleColor.White;
            if (IsPointAboveLine1(x, y) && IsPointAboveLine2(x,y))
                return SimpleColor.Green;
            if (!IsPointAboveLine1(x, y) && IsPointAboveLine2(x,y))
                return SimpleColor.Green;
            if (!IsPointLeftParabola1(x, y) && IsPointAboveLine1(x, y) && !IsPointInRect(x, y))
                return SimpleColor.Blue;
            if (IsPointBelowParabola2(x, y))
                return SimpleColor.Gray;
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
            PrintColorForPoint(1, 10);
            PrintColorForPoint(-4, -1);
            PrintColorForPoint(-1, 1);
            PrintColorForPoint(1, 1);
            PrintColorForPoint(3, -5);
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
            Console.ReadKey();
        }
    }
}
