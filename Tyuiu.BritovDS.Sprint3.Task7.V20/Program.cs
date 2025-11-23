using Tyuiu.BritovDS.Sprint3.Task7.V20.Lib;

namespace Tyuiu.BritovDS.Sprint3.Task7.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2| Выполнил:  Бритов Д. С. | ИСПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: | Бритов Д. С. | ИСПб-25-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет, и печатает результат на экране                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);
            int len = ds.GetMassFunction(startValue, stopValue).Length;
            double[] valueArray;
            valueArray = new double[len];
            valueArray = ds.GetMassFunction(startValue, stopValue);
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Результат:                                                                   *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine(" +-----------+-----------+");
            Console.WriteLine(" |     X     |    F(x)   |");
            Console.WriteLine(" +-----------+-----------+");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine(" |{0,5:d}       |  {1, 5:f2}   |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine(" +-----------+-----------+");
            Console.ReadKey();
        }
    }

}