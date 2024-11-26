using Tyuiu.ShindinDN.Sprint5.Task1.V2.Lib;

namespace Tyuiu.ShindinDN.Sprint5.Task1.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            FileInfo fileInfo = new FileInfo(path);
            DataService ds = new DataService();
            int startValue = -5;
            int endValue = 5;
            var res = ds.SaveToFileTextData(startValue,endValue);
            string wait = "-32,26\r\n-27,5\r\n-22,8\r\n-17,95\r\n-12,97\r\n-9\r\n-0,31\r\n3,77\r\n8,57\r\n13,42\r\n18,28\r\n";
            Assert.AreEqual(wait, File.ReadAllText(res));

        }
    }
}
