using Tyuiu.KrasyukME.Sprint3.Task2.V23.Lib;
namespace Tyuiu.KrasyukME.Sprint3.Task2.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double value = 1.5;
            int startValue = 1;
            int stopValue = 20;

            double res = ds.GetSumSeries(value, startValue, stopValue);

            double wait = 1632.212;

            Assert.AreEqual(wait, res);
        }
    }
}