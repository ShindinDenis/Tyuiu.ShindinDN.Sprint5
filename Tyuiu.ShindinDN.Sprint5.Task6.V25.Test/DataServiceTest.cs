using Tyuiu.ShindinDN.Sprint5.Task6.V25.Lib;

namespace Tyuiu.ShindinDN.Sprint5.Task6.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask6V25.txt");
            var res = ds.LoadFromDataFile(path);
            int wait = 6;
            Assert.AreEqual(wait, res);
        }
    }
}
