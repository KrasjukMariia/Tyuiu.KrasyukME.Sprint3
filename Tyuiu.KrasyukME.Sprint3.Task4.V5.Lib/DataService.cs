﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KrasyukME.Sprint3.Task4.V5.Lib
{
    public class DataService : ISprint3Task4V5
    {
        public double Calculate(int startValue, int stopValue)
        {
            double sum = 0;
            for (int i = startValue; i < stopValue; i++)
            {
                if (i == 0) break;
                sum += (Math.Cos(i) - Math.Sin(i)) / i;
            }
            return Math.Round(sum, 3);
        }
    }
}
