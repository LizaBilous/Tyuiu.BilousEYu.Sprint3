using Tyuiu.BilousEYu.Sprint3.Task2.V16.Lib;
namespace Tyuiu.BilousEYu.Sprint3.Task2.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
           
            Console.Title = "Спринт #3 | Выполнилa: Билоус Е.Ю.  | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла do-while                                           *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнилa: Билоус Елизавета Юрьевна  | ИСТНб 24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            int value = 2;
            int startValue = 1;
            int stopValue = 5;
            
            Console.WriteLine("Переменная N " + value);
            Console.WriteLine("Начало шага " + startValue);
            Console.WriteLine("Конец шага " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.GetMultiplySeries(value, startValue, stopValue));
            Console.ReadKey();

        }
    }
}
