using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.RedikultsevaAA.Sprint4.Task5.V26.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint4.Task5.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнила: Редикульцева А.А. | АСОиУб 23-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #4                                                                  *");
            Console.WriteLine("* Тема: Двумерные массивы. (генератор случайных чисел)                       *");
            Console.WriteLine("* Задание #5                                                                 *");
            Console.WriteLine("* Вариант #26                                                                *");
            Console.WriteLine("* Выполнила: Редикульцева А.А. | АСОиУб 23-1                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный           *");
            Console.WriteLine("* случайными значениями в диапазоне от -4 до 4. Заменить положительные       *");
            Console.WriteLine("* элементы на 1.                                                             *");
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
                    matrx[i, j] = rnd.Next(-4, 4);
                }
            }

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

            int[,] res = ds.Calculate(matrx);

            Console.WriteLine("Получившийся массив : ");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{res[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
