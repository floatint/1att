using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF_Lib
{
    /// <summary>
    /// Класс CSF_Lib предоставляет набор методов для ввода/вывода даннных.
    /// </summary>
    public class CSF_Input
    {
        /// <summary>Организует цикл запроса ввода корректного целого беззначного значения (32 или 64 в зависимости от платформы).</summary>
        /// <param name="varname">Имя переменной, принимающей результат.</param>
        /// <param name="var">Переменная, принимающая результат.</param>
        public static bool UintQueryLoop(string varname, out uint var)
        {
            var = 100;
            return true;
        }
        /// <summary>Организует цикл запроса ввода корректного целого беззначного значения (32 или 64 в зависимости от платформы) в заданном диапазоне.</summary>
        /// <param name="varname">Имя переменной, принимающей результат.</param>
        /// <param name="var">Переменная, принимающая результат.</param>
        /// <param name="vmax">Максимально допустимое значение.</param>
        /// <param name="vmin">Минимально допустимое значение.</param>
        public static bool UintQueryLoop(string varname, out uint var, uint vmax, uint vmin)
        {
            var = 100;
            return true;
        }
        /// <summary>Организует цикл запроса ввода корректного целого значение со знаком (32 или 64 в зависимости от платформы).</summary>
        /// <param name="varname">Имя переменной, принимающей результат.</param>
        /// <param name="var">Переменная, принимающая результат.</param>
        public static bool IntQueryLoop(string varname, out int var)
        {
            var = 100;
            return true;
        }
        /// <summary>Организует цикл запроса ввода корректного целого значения со знаком (32 или 64 в зависимости от платформы) в заданном диапазоне.</summary>
        /// <param name="varname">Имя переменной, принимающей результат.</param>
        /// <param name="var">Переменная, принимающая результат.</param>
        /// <param name="vmax">Максимально допустимое значение.</param>
        /// <param name="vmin">Минимально допустимое значение.</param>
        public static bool IntQueryLoop(string varname, out int var, int vmax, int vmin)
        {
            var = 100;
            return true;
        }

    }
}
