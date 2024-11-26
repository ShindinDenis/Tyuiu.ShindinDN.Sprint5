using System.Security.Cryptography.X509Certificates;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ShindinDN.Sprint5.Task7.V22.Lib
{
    public class DataService : ISprint5Task7V22
    {
        public string LoadDataAndSave(string path)
        {
            string pathsave = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V22.txt");
            FileInfo fileInfo = new FileInfo(pathsave);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(pathsave);
            }
            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if ((line[i] == '!') || (line[i] == '.') || (line[i] == '?') || (line[i] == ',') || (line[i] == '-'))
                        {
                            strLine = strLine + '#';
                        }
                        else
                        {
                            strLine += line[i];
                        }
                    }
                    File.AppendAllText(pathsave, strLine);
                    strLine = "";

                }
            }
            return pathsave;
        }
    }
}
