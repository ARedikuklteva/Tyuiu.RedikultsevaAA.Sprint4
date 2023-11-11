using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.RedikultsevaAA.Sprint4.Task6.V11.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint4.Task6.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнила: Редикульцева А.А. | АСОиУб 23-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #4                                                                  *");
            Console.WriteLine("* Тема:  Класс Array                                                         *");
            Console.WriteLine("* Задание #6                                                                 *");
            Console.WriteLine("* Вариант #11                                                                *");
            Console.WriteLine("* Выполнила: Редикульцева А.А. | АСОиУб 23-1                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Дан строковый массив данных ['Кошка', 'Собака', 'Слон', 'Жираф', 'Бегемот' *");
            Console.WriteLine("* 'Игуана', 'Ягуар'] используя класс Array подсчитайте количество элементов, *");
            Console.WriteLine("* длина которых равна 5.                                                     *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            var mas = new string[] { "Кошка", "Собака", "Слон", "Жираф", "Бегемот", "Игуана", "Ягуар" };

            Console.WriteLine("Исходный массив:");
            for(int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i]);
            }


            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine("Количество элементов, длина которых = 5:");

            int num = ds.Calculate(mas);
            Console.WriteLine(num);

            Console.ReadKey();
        }
    }
}
