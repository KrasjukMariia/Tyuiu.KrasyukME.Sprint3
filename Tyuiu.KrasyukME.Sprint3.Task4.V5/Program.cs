using Tyuiu.KrasyukME.Sprint3.Task4.V5.Lib;
namespace Tyuiu.KrasyukME.Sprint3.Task4.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #3                                                                *");
            Console.WriteLine("* Тема:                                                                    *");
            Console.WriteLine("* Задание #3                                                               *");
            Console.WriteLine("* Вариант #5                                                               *");
            Console.WriteLine("* Выполнила: Красюк Мария Евгеньевна | АСОиУБ-24-1                         *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* -5 <= x <= 5                                                             *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5, endValue = 5;
            Console.Write("Сумма функций равна " + ds.Calculate(startValue, endValue));
            Console.ReadLine();
        }
    }
}
