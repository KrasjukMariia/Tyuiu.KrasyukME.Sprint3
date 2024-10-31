using Tyuiu.KrasyukME.Sprint3.Task5.V1.Lib;
namespace Tyuiu.KrasyukME.Sprint3.Task5.V1
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
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* -5 <= x <= 5                                                             *");
            Console.WriteLine("***************************************************************************");

           
            Console.Write(ds.GetSumSumSeries(1,1,1,12,13));
            Console.ReadLine();
        }
    }
}
