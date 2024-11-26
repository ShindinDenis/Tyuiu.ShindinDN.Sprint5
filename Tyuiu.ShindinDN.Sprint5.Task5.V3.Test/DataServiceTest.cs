using Tyuiu.ShindinDN.Sprint5.Task5.V3.Lib;

namespace Tyuiu.ShindinDN.Sprint5.Task5.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask5V3.txt");
            FileInfo fileInfo = new FileInfo(path);
            double wait = 35;
            double res = ds.LoadFromDataFile(path);
            Assert.AreEqual(wait, res);
        }
    }
}
