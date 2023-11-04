using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Дан одномерный целочисленный массив на 11 элементов заполненный случайными в диапазоне от 1 до 8
// подсчитать произведение четных элементов массива.

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.RedikultsevaAA.Sprint4.Task2.V29.Lib
{
    public class DataService : ISprint4Task2V29
    {
        public int Calculate(int[] array)
        {
            int powArray = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    powArray *= array[i];
                }
            }

            return powArray;
        }
    }
}
