using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using Newtonsoft.Json;

namespace csxto
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            if (!ConfigLoader.DataFileCheck()) return;
            var companyData = ConfigLoader.MakeCompanyDict();
            ComboBoxSingleCompany.ItemsSource = companyData;
            ComboBoxSingleCompany.DisplayMemberPath = "Key";
            ComboBoxSingleCompany.SelectedValuePath = "Value";
            ComboBoxSingleCompany.SelectedIndex = 0;
        }

        private bool IsSingleInputLeagel()
        {
            //Check user input
            return TextBoxSingleId.Text != "" && ComboBoxSingleCompany.SelectedItem != null;
        }

        private async void ButtonSingleTrack_Click(object sender, RoutedEventArgs e)
        {
            //Clean first
            DataGridSingle.Items.Clear();
            LabelSingleStateo.Content = "State:";

            if (IsSingleInputLeagel() == false)
            {
                await this.ShowMessageAsync("ERROR", "Please check your input info.");
            }
            else
            {
                TrackSingle(TextBoxSingleId.Text, ComboBoxSingleCompany.SelectedValue.ToString());
            }
        }
        private void TrackSingle(string id, string company)
        {
            string rawJson = null;
            try
            {
                var url = "http://www.kuaidi100.com/query?type=" + company + "&postid=" + id;
                var httpWReq = (HttpWebRequest)WebRequest.Create(url);
                var httpWResp = (HttpWebResponse)httpWReq.GetResponse();
                var rawStream = httpWResp.GetResponseStream();
                if (rawStream != null)
                {
                    var reader = new StreamReader(rawStream);
                    rawJson = reader.ReadToEnd();
                }
                httpWResp.Close();
            }
            catch (Exception ex)
            {
                this.ShowMessageAsync("ERROR", ex.Message);
                return;
            }
            DeserializeJson(rawJson);
        }

        private async void DeserializeJson(string rawJson)
        {
            var json = JsonConvert.DeserializeObject<Json>(rawJson);
            if (json.status != "200")
            {
                await this.ShowMessageAsync("ERROR", "Number may out of date.");
            }
            else
            {
                ShowTrackInfo(json);
            }
        }

        private void RightWindowCommandsAbout_Click(object sender, RoutedEventArgs e)
        {
            FlyoutAbout.IsOpen = true;
        }

        private void TextBlockAbout_Click(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Sharuru/Csharp-xto");
        }

        private void ShowTrackInfo(Json json)
        {
            //Handle overview
            string state = null;
            switch (json.state)
            {
                case "0":
                    state = "Shipping";
                    break;
                case "1":
                    state = "Company received";
                    break;
                case "2":
                    state = "Difficult";
                    break;
                case "3":
                    state = "Received";
                    break;
                case "4":
                    state = "Returned";
                    break;
                case "5":
                    state = "Delivering";
                    break;
                case "6":
                    state = "Returning";
                    break;
            }
            LabelSingleStateo.Content = "State: " + state;
            //Handle dataGirdViewSingle
            foreach (var data in json.data)
            {
                DataGridSingle.Items.Add(new DataGridRow
                {
                    Item = new {TIME = data.time, PROGRESS = data.context}
                });
            }
        }

        #region Data structure
        public class Json
        {
            public string message { get; set; }
            public string nu { get; set; }
            public string ischeck { get; set; }
            public string com { get; set; }
            public string updatetime { get; set; }
            public string status { get; set; }
            public string condition { get; set; }
            public List<Data> data { get; set; }
            public string state { get; set; }
        }
        public class Data
        {
            public string time { get; set; }
            public string location { get; set; }
            public string context { get; set; }
            public string ftime { get; set; }
        }
        #endregion
    }
}
