﻿using Tyuiu.KrasyukME.Sprint3.Task7.V4.Lib;
namespace Tyuiu.KrasyukME.Sprint3.Task7.V4
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
            int startValue = -5, endValue = 5;
            Console.Write( ds.GetMassFunction(startValue, endValue));
            Console.ReadLine();
        }
    }
}