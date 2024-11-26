using Tyuiu.ShindinDN.Sprint5.Task7.V22.Lib;

namespace Tyuiu.ShindinDN.Sprint5.Task7.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Шиндин Д. Н. | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Шиндин Денис Николаевич | ИСТНб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask7V22.txt в котором           *");
            Console.WriteLine("* есть набор символьных данных.Заменить все знаки препинания на #.        *");
            Console.WriteLine("* Полученный результат сохранить в файл OutPutDataFileTask7V22.txt.       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string pathsave = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V22.txt");
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask7V22.txt");
            var res = ds.LoadDataAndSave(path);
            Console.WriteLine("Данные находятся в файле: " + path);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(File.ReadAllText(res));
            Console.WriteLine("Находится в файле: " + res);
        }
    }
}
