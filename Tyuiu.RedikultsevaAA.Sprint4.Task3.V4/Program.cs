using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.RedikultsevaAA.Sprint4.Task3.V4.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint4.Task3.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrx = new int[5, 5] { { 6, 5, 4, 1, 5, },
                                           { 8, 2, 3, 4, 2, },
                                           { 3, 7, 7, 1, 3, },
                                           { 3, 4, 8, 1, 3, },
                                           { 4, 3, 5, 5, 2,} };

            int rows = matrx.GetUpperBound(0) + 1;
            int colums = matrx.Length / rows;


            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнила: Редикульцева А.А. | АСОиУб 23-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #4                                                                  *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                                 *");
            Console.WriteLine("* Задание #3                                                                 *");
            Console.WriteLine("* Вариант #4                                                                 *");
            Console.WriteLine("* Выполнила: Редикульцева А.А. | АСОиУб 23-1                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный           *");
            Console.WriteLine("* статическими значениями в диапазоне от 1 до 8. Найдите минимальный элемент *");
            Console.WriteLine("* в последнем столбце массива.                                               *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine("Массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{matrx[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            int res = ds.Calculate(matrx);

            Console.WriteLine("Минимальный элемент в последнем столбце = " + res);

            Console.ReadKey();
        }
    }
}
