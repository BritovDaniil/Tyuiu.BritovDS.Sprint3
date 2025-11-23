using Tyuiu.BritovDS.Sprint3.Task6.V11.Lib;

namespace Tyuiu.BritovDS.Sprint3.Task6.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Бритов Д. С. | ИСПб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема:  Обработка целочисленной информации                               *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Бритов Д. С. | ИСПб-25-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих       *");
            Console.WriteLine("* числовому отрезку, количество всех делителей больше 10                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Начало отрезка = 10");
            Console.WriteLine("Конец отрезка = 19");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            var res = ds.GetSumTheDivisors(10, 19);
            Console.WriteLine("Количество делителей больше 10 = " + res);
        }
    }
}