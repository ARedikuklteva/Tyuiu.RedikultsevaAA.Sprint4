using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.RedikultsevaAA.Sprint4.Task1.V4.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint4.Task1.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнила: Редикульцева А.А. | АСОиУб 23-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #4                                                                  *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                               *");
            Console.WriteLine("* Задание #1                                                                 *");
            Console.WriteLine("* Вариант #4                                                                 *");
            Console.WriteLine("* Выполнила: Редикульцева А.А. | АСОиУб 23-1                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный значениями *");
            Console.WriteLine("* с клавиатуры в диапазоне от 1 до 9 подсчитать произведение нечетных        *");
            Console.WriteLine("* элементов массива.  С клавиатуры: 1, 2, 5, 3, 4, 7, 8, 8, 3, 9             *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            int len;
            Console.WriteLine("Введите количество элементов массива:");
            len = Convert.ToInt32(Console.ReadLine());

            int[] numsArray = new int[len];

            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Введите значение " + i + " элемента массива: ");
                numsArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Массив:");

            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(numsArray[i] + "\t");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            int res = ds.Calculate(numsArray);

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
