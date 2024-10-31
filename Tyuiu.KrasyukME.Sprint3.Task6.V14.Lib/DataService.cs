using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KrasyukME.Sprint3.Task6.V14.Lib
{
    public class DataService : ISprint3Task6V14
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int sum = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                for (int d = 5; d < x; d++)
                {
                    if (x % d == 7 && d > 16)
                    {
                        sum += d;
                    }
                }
            }
            return sum;
        }
    }
}
