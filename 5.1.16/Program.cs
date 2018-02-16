using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._1._16
{



    /*
     h = 13
\ \ \ \ \ \ \
 \ \ \ \ \ \
  \ \ \ \ \ \
   \ \ \ \ \ 
    \ \ \ \ \
     \ \ \ \
      \ \ \ \
       \ \ \ 
        \ \ \
         \ \
          \ \
           \
            \

    */



    class Program
    {
        static void WriteFigure(uint h)
        {
            //uint h = 20;
            uint pos = 0;
            for (uint i = 0; i < h; i++)
            {
                for (uint j = 0; j < h; j++)
                {
                    if ((j >= pos) && (j - pos) % 2 == 0)
                    {
                        Console.Write('\\');
                    }
                    else
                        Console.Write(' ');
                }
                pos++;
                Console.WriteLine();
            }
        }

        static uint GetUintInput(string varname)
        {
            uint var;
            Console.WriteLine("Введите значение {0} :", varname);
            while (!uint.TryParse(Console.ReadLine(), out var) || var < 1)
            {
                Console.WriteLine("Введите корректное значение {0} :", varname);
            }
            return var;
        }

        static void Main(string[] args)
        {
            WriteFigure(GetUintInput("h"));
            Console.WriteLine("Выполнить рассчет еще ? (any key or Enter)");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Console.WriteLine(); //выравнивание
                WriteFigure(GetUintInput("h"));
            }
            Console.ReadKey();
        }
    }
}
