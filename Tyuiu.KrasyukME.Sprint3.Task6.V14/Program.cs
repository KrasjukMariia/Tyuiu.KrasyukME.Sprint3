using Tyuiu.KrasyukME.Sprint3.Task6.V14.Lib;
namespace Tyuiu.KrasyukME.Sprint3.Task6.V14
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
            Console.WriteLine("* Выполнила: Красюк Мария Евгеньевна | ИБКСб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            int startValue = 7;
            int stopValue = 16;
            int sum = ds.GetSumTheDivisors(startValue, stopValue);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
