using Tyuiu.BritovDS.Sprint3.Task3.V28.Lib;


namespace Tyuiu.BritovDS.Sprint3.Task3.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            char item = 'r';

            string value = "f35hyt t4j 3gkg45";

            Assert.AreEqual("frrhyt trj rgkgrr", ds.ReplaceNumOnChar(value, item));
        }
    }
}