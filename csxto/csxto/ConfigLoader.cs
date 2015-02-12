using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace csxto
{
    class ConfigLoader
    {
        public static bool DataFileCheck()
        {
            //Check data file exist or not
            if (File.Exists(Environment.CurrentDirectory + "\\company.dat")) return true;
            MessageBox.Show("Can not find data file, please check.", "Info", MessageBoxButton.OK,
                MessageBoxImage.Information);
            Environment.Exit(0);
            return true;
        }

        public static Dictionary<string,string> MakeCompanyDict()
        {
            var companyData = new Dictionary<string, string>();
            var datPath = Environment.CurrentDirectory + "\\company.dat";
            var sr = new StreamReader(datPath);
            while (sr.Peek() >= 0)
            {
                var rawData = sr.ReadLine();
                if (rawData == null) continue;
                var data = rawData.Split(',');
                companyData.Add(data[0],data[1]);
            }
            return companyData;
        }
    }
}
