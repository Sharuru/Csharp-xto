using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;

namespace csxto
{
    class ConfigLoader
    {
        internal bool DataFileCheck()
        {
            //Check data file exist or not
            if (File.Exists(Environment.CurrentDirectory + "\\company.dat") == false)
            {
                MessageBox.Show("Can not find data file, please check.", "Info", MessageBoxButton.OK,
                    MessageBoxImage.Information);
                Application.Current.Shutdown();
            }
            return true;

        }

        internal Dictionary<string,string> MakeCompanyDict()
        {
            Dictionary<string, string> companyData = new Dictionary<string, string>();
            var datPath = Environment.CurrentDirectory + "\\company.dat";
            var sr = new StreamReader(datPath);
            while (sr.Peek() >= 0)
            {
                string rawData = sr.ReadLine();
                string[] data = rawData.Split(new char[] {','});
                companyData.Add(data[0],data[1]);
            }
            return companyData;
        }
    }
}
