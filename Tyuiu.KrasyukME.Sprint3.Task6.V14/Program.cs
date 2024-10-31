using Tyuiu.KrasyukME.Sprint3.Task6.V14.Lib;
namespace Tyuiu.KrasyukME.Sprint3.Task6.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService DataService = new DataService();
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #3                                                                *");
            Console.WriteLine("* Тема:                                                                    *");
            Console.WriteLine("* Задание #3                                                               *");
            Console.WriteLine("* Вариант #5                                                               *");
            Console.WriteLine("* Выполнила: Красюк Мария Евгеньевна | ИБКСб-24-1                         *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* *d > 5, N >= 7 && N <= 16\")                                            *");
            Console.WriteLine("***************************************************************************");
            int sum = DataService.GetSumTheDivisors(7, 16);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
