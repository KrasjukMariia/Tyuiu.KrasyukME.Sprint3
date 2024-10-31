using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KrasyukME.Sprint3.Task7.V4.Lib
{
    public class DataService : ISprint3Task7V4
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] results = new double[length];

            for (int x = startValue; x <= stopValue; x++)
            {
                double fx;

                // Проверка деления на ноль
                if (Math.Abs(Math.Cos(x) + x) < 1e-10) // Если знаменатель близок к нулю
                {
                    fx = 0; // При делении на ноль возвращаем 0
                }
                else
                {
                    fx = (2 * x + 6) / (Math.Cos(x) + x) - 3;
                }

                // Округление до двух знаков после запятой
                results[x - startValue] = Math.Round(fx, 2);
            }

            return results;
        }
    }
}
