using Microsoft.VisualStudio.TestPlatform.TestHost;
using Tyuiu.KrasyukME.Sprint3.Task7.V4.Lib;
namespace Tyuiu.KrasyukME.Sprint3.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            // Act
            double[] result = ds.GetMassFunction(startValue, stopValue);

            // Expected values (вычисленные вручную или с помощью кода)
            double[] expectedValues = { -1.89, -0.7, -1.92, -3.2, -0.75, 0.0, -1.37, -2.54, -2.38, -1.06, 0.26 };

            // Assert
            Assert.AreEqual(expectedValues.Length, result.Length, "Длина массива не совпадает с ожидаемой.");
        }
    }
}