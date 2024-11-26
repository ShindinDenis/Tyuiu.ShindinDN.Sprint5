using Tyuiu.ShindinDN.Sprint5.Task4.V1.Lib;
using System.IO;

namespace Tyuiu.ShindinDN.Sprint5.Task4.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = Path.Combine("C:", "DataSprint", "InPutDataFileTask4V1.txt");
            FileInfo fileInfo = new FileInfo(path);
            double wait = -3.680;
            double res = ds.LoadFromDataFile(path);
            Assert.AreEqual(wait, res);
        }
    }
}
