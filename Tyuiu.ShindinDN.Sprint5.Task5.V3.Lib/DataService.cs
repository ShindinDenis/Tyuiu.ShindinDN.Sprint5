﻿using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ShindinDN.Sprint5.Task5.V3.Lib
{
    public class DataService : ISprint5Task5V3
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                double num;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Replace(".", ",");
                    foreach (string snum in line.Split(' '))
                    {
                        num = Convert.ToDouble(snum);
                        num = Math.Round(num, 3);
                        if (num % 1 == 0)
                        {
                            res = res + num;
                        }
                    }
                }
            }
            return res;
        }
    }
}
