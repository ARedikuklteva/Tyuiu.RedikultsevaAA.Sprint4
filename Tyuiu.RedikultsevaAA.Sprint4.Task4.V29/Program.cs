using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.RedikultsevaAA.Sprint4.Task4.V29.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint4.Task4.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнила: Редикульцева А.А. | АСОиУб 23-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #4                                                                  *");
            Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                               *");
            Console.WriteLine("* Задание #4                                                                 *");
            Console.WriteLine("* Вариант #29                                                                *");
            Console.WriteLine("* Выполнила: Редикульцева А.А. | АСОиУб 23-1                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный           *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 4 до 8. Найдите сумму четных        *");
            Console.WriteLine("* элементов массива.                                                         *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            Console.Write("Введите количество строк в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество столбцов в массиве: ");
            int colums = Convert.ToInt32(Console.ReadLine());

            int[,] matrx = new int[rows, colums];

            Console.WriteLine("******************************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"Введите {i},{j} элемент массива: ");
                    matrx[i,j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nМассив:");
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

            Console.WriteLine("Сумма четных элементов массива = " + res);

            Console.ReadKey();
        }
    }
}
