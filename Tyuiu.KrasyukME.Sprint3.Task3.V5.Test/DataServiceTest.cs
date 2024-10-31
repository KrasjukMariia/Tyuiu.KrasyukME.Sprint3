using Tyuiu.KrasyukME.Sprint3.Task3.V5.Lib;
namespace Tyuiu.KrasyukME.Sprint3.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
                        
            Assert.AreEqual("fif* f*", ds.ReplaceCharInString("fifa fa",'a','*'));
        }
    }
}