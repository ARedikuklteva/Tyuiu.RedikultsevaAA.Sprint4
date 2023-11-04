using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.RedikultsevaAA.Sprint4.Task2.V29.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint4.Task2.V29
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
            Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                       *");
            Console.WriteLine("* Задание #2                                                                 *");
            Console.WriteLine("* Вариант #29                                                                *");
            Console.WriteLine("* Выполнила: Редикульцева А.А. | АСОиУб 23-1                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 11 элементов заполненный случайными *");
            Console.WriteLine("* в диапазоне от 1 до 8 подсчитать  произведение четных элементов массива.   *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");


            Console.WriteLine("Введите количество элементов массива:");
            int len = Convert.ToInt32(Console.ReadLine());

            int[] numsArray = new int[len];

            for (int i = 0; i < len; i++)
            {
                numsArray[i] = rnd.Next(5,20);
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

            Console.WriteLine("Сумма элементов больше 10 = " + res);

            Console.ReadKey();
        }
    }
}
