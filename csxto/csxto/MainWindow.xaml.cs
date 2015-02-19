using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security.AccessControl;
using System.Windows;
using System.Drawing;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using csxto.Model;
using csxto.ViewModel;
using MahApps.Metro.Controls.Dialogs;
using Newtonsoft.Json;

namespace csxto
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow
    {
        private NotifyIcon notifyIcon = new NotifyIcon();

        public MainWindow()
        {
            InitializeComponent();

            //TODO:Issue #2

            notifyIcon.Icon = System.Drawing.Icon.ExtractAssociatedIcon(System.Windows.Forms.Application.ExecutablePath);
            notifyIcon.Visible = true;
            notifyIcon.MouseDoubleClick += notifyIcon_MouseClick;
            notifyIcon.MouseClick += notifyIcon_MouseClick;

            System.Windows.Forms.MenuItem contextMenuShow = new System.Windows.Forms.MenuItem("Show");

            System.Windows.Forms.MenuItem contextMenuExit = new System.Windows.Forms.MenuItem("Exit");

            System.Windows.Forms.MenuItem[] contextMenu = new System.Windows.Forms.MenuItem[] { contextMenuShow , contextMenuExit };
            notifyIcon.ContextMenu = new System.Windows.Forms.ContextMenu(contextMenu);
            
            
            contextMenuExit.Click += MetroWindow_Closed;
            contextMenuShow.Click += notifyIcon_MouseClick;

            if (!DataLoader.DataFileCheck()) return;
            var companyData = DataLoader.MakeCompanyDict();
            ComboBoxSingleCompany.ItemsSource = companyData;
            ComboBoxSingleCompany.DisplayMemberPath = "Key";
            ComboBoxSingleCompany.SelectedValuePath = "Value";
            ComboBoxSingleCompany.SelectedIndex = 0;
        }

        private async void ButtonSingleTrack_Click(object sender, RoutedEventArgs e)
        {
            //Clean first
            DataGridSingle.Items.Clear();
            LabelSingleStateo.Content = "State:";

            if (TextBoxSingleId.Text == null)
            {
                await this.ShowMessageAsync("ERROR", "Please check your input info.");
            }
            else
            {
                TrackSingle(TextBoxSingleId.Text, ComboBoxSingleCompany.SelectedValue.ToString());
            }
        }




        #region SingleTrackEventHandle
        private void RightWindowCommandsAbout_Click(object sender, RoutedEventArgs e)
        {
            FlyoutAbout.IsOpen = true;
        }

        private void TextBlockAbout_Click(object sender, MouseButtonEventArgs e)
        {
            VmGeneral.JumpToProjectPage();
        }

        #endregion

        #region SingleTrackViewHandle
        private void TrackSingle(string id, string company)
        {
            //Download json
            string rawJson = JsonDownloader.GetJson(id, company);
            //Handle json
            var json = SingleTrack.DeserializeJson(rawJson);
            if (json.status != "200")
            {
                this.ShowMessageAsync("ERROR", "Number may out of date. ");
            }
            else
            {
                ShowSingleTrackInfo(json);
            }
        }

        private void ShowSingleTrackInfo(Json json)
        {
            //Handle overview
            LabelSingleStateo.Content = SingleTrack.SingleOverviewBuilder(json.state);
            //Handle dataGirdViewSingle
            foreach (var data in json.data)
            {
                DataGridSingle.Items.Add(new DataGridRow
                {
                    Item = new {TIME = data.time, PROGRESS = data.context}
                });
            }
        }

        #endregion

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

        private void MetroWindow_Closed(object sender, EventArgs e)
        {
            notifyIcon.Dispose();
            Environment.Exit(0);
        }

        private void MetroWindow_StateChanged(object sender, EventArgs e)
        {
            if (WindowState == WindowState.Minimized)
            {
                ShowInTaskbar = false;
                notifyIcon.BalloonTipTitle = "Express Tracker";
                notifyIcon.BalloonTipText = "I am here, don't forget";
                notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon.ShowBalloonTip(2000);
            }
        }

        private void notifyIcon_MouseClick(object sender, EventArgs eventArgs)
        {
            ShowInTaskbar = true;
            WindowState = WindowState.Normal;
        }
    }
}
