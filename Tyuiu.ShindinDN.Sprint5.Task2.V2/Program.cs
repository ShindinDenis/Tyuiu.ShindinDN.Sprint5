using Tyuiu.ShindinDN.Sprint5.Task2.V2.Lib;

namespace Tyuiu.ShindinDN.Sprint5.Task2.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Шиндин Денис Николаевич | ИСТНб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры. Заменить положительные элементы массива на 1,  *");
            Console.WriteLine("* отрицательные на 0. Результат сохранить в файл OutPutFileTask2.csv      *");
            Console.WriteLine("* и вывести на консоль.                                                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[,] mtrx = new int[3, 3] { {-7,7,5 },
                                          {4,2,-7 },
                                          {2,6,-4 }};
            int rows = mtrx.GetUpperBound(0) + 1;
            int cols = mtrx.Length / rows;
            Console.WriteLine("Массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{mtrx[i, j]}\t");
                }
                Console.WriteLine();
            }
            var res = ds.SaveToFileTextData(mtrx);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Полученный массив:\r\n{0}", File.ReadAllText(ds.SaveToFileTextData(mtrx)));
        }
    }
}
