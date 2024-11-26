using tyuiu.cources.programming.interfaces.Sprint5;

using System.IO;
namespace Tyuiu.ShindinDN.Sprint5.Task1.V2.Lib
{
    public class DataService : ISprint5Task1V2
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            double f;
            string strF;
            for (int x = startValue; x <= stopValue; x++)
            {
                f = Math.Round(((2 * x - 3) / (Math.Cos(x) - 2 * x) + 5 * x - 6), 2);
                strF = Convert.ToString(f);
                if (f != stopValue)
                {
                    File.AppendAllText(path, strF+Environment.NewLine);
                }
                if (f == 0)
                {
                    File.AppendAllText(path, 0 + Environment.NewLine);
                }
                if (f == stopValue)
                {
                    File.AppendAllText(path, strF);
                }
            }
            return path;
        }
    }
}
