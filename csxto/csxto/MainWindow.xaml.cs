using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;

namespace csxto
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        Dictionary<string,string> companyData = new Dictionary<string, string>(); 
        public MainWindow()
        {
            InitializeComponent();
            if (ConfigLoader.DataFileCheck())
            {
                companyData = ConfigLoader.MakeCompanyDict();
                ComboBoxSingleCompany.ItemsSource = companyData;
                ComboBoxSingleCompany.DisplayMemberPath = "Key";
                ComboBoxSingleCompany.SelectedValuePath = "Value";
                ComboBoxSingleCompany.SelectedIndex = 0;
            }
        }

        private void ButtonSingleTrack_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void RightWindowCommandsAbout_Click(object sender, RoutedEventArgs e)
        {
            FlyoutAbout.IsOpen = true;
        }

        private void TextBlockAbout_Click(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Sharuru/Csharp-xto/");
        }

    }
}
