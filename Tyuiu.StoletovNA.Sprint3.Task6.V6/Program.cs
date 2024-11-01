using Tyuiu.StoletovNA.Sprint3.Task6.V6.Lib;
namespace Tyuiu.StoletovNA.Sprint3.Task6.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Столетов Никита Андреевич | ИИПБ-24-2";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Обработка целочисленной информации                                      *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #6                                                            *");
            Console.WriteLine("* Выполнил: Столетов Никита Андреевич | ИИПБ-24-2                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Напишите программу, которая ищет среди целых чисел, принадлежащих числово*");
            Console.WriteLine("*ому отрезку [16, 24] количество всех делителей больше 10                 *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = 16;
            int stopValue = 24;

            Console.WriteLine("Начало отрезка = " + startValue);
            Console.WriteLine("Конец отрезка = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = "Сумма делителей = " + ds.GetSumTheDivisors(startValue, stopValue);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}