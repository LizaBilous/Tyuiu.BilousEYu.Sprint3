using Tyuiu.BilousEYu.Sprint3.Task5.V28.Lib;
namespace Tyuiu.BilousEYu.Sprint3.Task5.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Билоус Е.Ю. | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Билоус Елизавета Юрьевна | ИСТНб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Написать программу , которая вычисляет cумму сумм ряда                   *");
            Console.WriteLine("*  по формуле, при X=2                                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            int x = 2;
            int startValue1 = 1;
            int startValue2 = 3;
            int stopValue1 = 1;
            int stopValue2 = 12;

            Console.WriteLine("Переменная Х = " + x);
            Console.WriteLine("Старт шага первой суммы ряда = " + startValue1);
            Console.WriteLine("Старт шага второй суммы ряда = " + startValue2);
            Console.WriteLine("Конец шага первой суммы ряда = " + stopValue1);
            Console.WriteLine("Конец шага второй суммы ряда = " + stopValue2);


            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("****************************************************************************");
            
            Console.WriteLine("Сумма ряда = " + ds.GetSumSumSeries(x, startValue1, startValue1, stopValue1, stopValue2));
            Console.ReadKey();
        }
    }
}
