using Tyuiu.ShindinDN.Sprint5.Task0.V25.Lib;

namespace Tyuiu.ShindinDN.Sprint5.Task0.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.SaveToFileTextData(3);
            string wait = "9,037";
            Assert.AreEqual (wait, File.ReadAllText(res));
        }
    }
}
