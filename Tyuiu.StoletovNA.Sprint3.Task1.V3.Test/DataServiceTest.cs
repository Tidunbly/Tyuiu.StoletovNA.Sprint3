using Tyuiu.StoletovNA.Sprint3.Task1.V3.Lib;
namespace Tyuiu.StoletovNA.Sprint3.Task1.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 10;

            var res = ds.GetMultiplySeries(startValue, stopValue);
            Assert.AreEqual(24589.408, res);
        }
    }
}