using Tyuiu.StoletovNA.Sprint3.Task2.V11.Lib;
namespace Tyuiu.StoletovNA.Sprint3.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double value = 0.5;
            int startValue = 1;
            int stopValue = 15;

            var res = ds.GetSumSeries(value, startValue, stopValue);
            Assert.AreEqual(0.43, res);
        }
    }
}