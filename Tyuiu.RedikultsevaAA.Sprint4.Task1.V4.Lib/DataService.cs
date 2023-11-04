using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Дан одномерный целочисленный массив на 10 элементов заполненный значениями с клавиатуры в диапазоне от 1 до 9
// подсчитать произведение нечетных элементов массива.  С клавиатуры: 1, 2, 5, 3, 4, 7, 8, 8, 3, 9

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.RedikultsevaAA.Sprint4.Task1.V4.Lib
{
    public class DataService : ISprint4Task1V4
    {
        public int Calculate(int[] array)
        {
            int powArray = 1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                    powArray *= array[i];
            }

            return powArray;
        }
    }
}
