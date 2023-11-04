using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Дан двумерный целочисленный массив 5 на 5 элементов, заполненный статическими значениями в диапазоне от 1 до 8.
// Найдите минимальный элемент в последнем столбце массива.
// 6, 5, 4, 1, 5,
// 8, 2, 3, 4, 2,
// 3, 7, 7, 1, 3,
// 3, 4, 8, 1, 3,
// 4, 3, 5, 5, 2,

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.RedikultsevaAA.Sprint4.Task3.V4.Lib
{
    public class DataService : ISprint4Task3V4
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int colums = array.Length / 5;
            int m = 10000000;

            int count = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (j == colums - 1)
                    {
                        if (array[i, j] < m)
                        {
                            m = array[i, j];
                        }
                    }
                }
            }
            return m;
        }
    }
}
