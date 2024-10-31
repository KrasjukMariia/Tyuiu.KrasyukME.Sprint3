using Tyuiu.KrasyukME.Sprint3.Task5.V1.Lib;
namespace Tyuiu.KrasyukME.Sprint3.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
           
           
            Assert.AreEqual(1633.712, ds.GetSumSumSeries(1,1,1,13,10));
        }
    }
}