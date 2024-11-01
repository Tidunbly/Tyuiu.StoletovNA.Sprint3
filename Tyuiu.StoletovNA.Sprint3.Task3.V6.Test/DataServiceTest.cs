using Tyuiu.StoletovNA.Sprint3.Task3.V6.Lib;
namespace Tyuiu.StoletovNA.Sprint3.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "12able 1o s4gh";
            char item = 't';

            string wait = "ttable to stgh";
            string res = ds.ReplaceNumOnChar(value, item);
            Assert.AreEqual(wait, res);
        }
    }
}