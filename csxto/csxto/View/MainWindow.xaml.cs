using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using csxto.Model;
using csxto.ViewModel;
using MahApps.Metro.Controls.Dialogs;

namespace csxto.View
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow
    {
        private readonly NotifyIcon _notifyIcon = new NotifyIcon();

        public MainWindow()
        {
            InitializeComponent();
            InitTray();
            InitComboBoxSingleCompany();
            TextBoxSingleId.Focus();
        }

        #region SingleTrackEventHandle

        private async void ButtonSingleTrack_Click(object sender, RoutedEventArgs e)
        {
            //Clean first
            InitSingleTrack();
            //Start track
            if (TextBoxSingleId.Text == "" || ComboBoxSingleCompany.SelectedItem == null)
            {
                await this.ShowMessageAsync("ERROR", "Please check your input info.");
            }
            else
            {
                TrackSingle(TextBoxSingleId.Text, ComboBoxSingleCompany.SelectedValue.ToString());
            }
        }

        private void RightWindowCommandsAbout_Click(object sender, RoutedEventArgs e)
        {
            FlyoutAbout.IsOpen = true;
        }

        private void TextBlockAbout_Click(object sender, MouseButtonEventArgs e)
        {
            VmGeneral.JumpToProjectPage();
        }

        private void MetroWindow_StateChanged(object sender, EventArgs e)
        {
            if (WindowState == WindowState.Minimized)
            {
                ShowInTaskbar = false;
                _notifyIcon.BalloonTipTitle = @"Express Tracker";
                _notifyIcon.BalloonTipText = @"I am here, don't forget";
                _notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
                _notifyIcon.ShowBalloonTip(1000);
            }
        }

        private void notifyIcon_MouseClick(object sender, EventArgs eventArgs)
        {
            ShowInTaskbar = true;
            WindowState = WindowState.Normal;
        }

        private void MetroWindow_Closed(object sender, EventArgs e)
        {
            _notifyIcon.Dispose();
            Environment.Exit(0);
        }

        #endregion

        #region SingleTrackViewHandle

        private void InitSingleTrack()
        {
            DataGridSingle.Items.Clear();
            LabelSingleStateo.Content = "State:";
        }

        private void InitTray()
        {
            //notifyIcon
            _notifyIcon.Icon = System.Drawing.Icon.ExtractAssociatedIcon(System.Windows.Forms.Application.ExecutablePath);
            _notifyIcon.Visible = true;
            _notifyIcon.MouseDoubleClick += notifyIcon_MouseClick;
            _notifyIcon.MouseClick += notifyIcon_MouseClick;
            //contextMenu
            var contextMenuShow = new System.Windows.Forms.MenuItem("Show");
            var contextMenuExit = new System.Windows.Forms.MenuItem("Exit");
            System.Windows.Forms.MenuItem[] contextMenu = { contextMenuShow, contextMenuExit };
            _notifyIcon.ContextMenu = new System.Windows.Forms.ContextMenu(contextMenu);
            //contextMenuEvent
            contextMenuExit.Click += MetroWindow_Closed;
            contextMenuShow.Click += notifyIcon_MouseClick;
        }

        private void InitComboBoxSingleCompany()
        {
            if (!DataLoader.DataFileCheck()) return;
            var companyData = DataLoader.MakeCompanyDict();
            ComboBoxSingleCompany.ItemsSource = companyData;
            ComboBoxSingleCompany.DisplayMemberPath = "Key";
            ComboBoxSingleCompany.SelectedValuePath = "Value";
            ComboBoxSingleCompany.SelectedIndex = 0;
        }

        private void TrackSingle(string id, string company)
        {
            //Download json
            var rawJson = JsonDownloader.GetJson(id, company);
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

        private void ShowSingleTrackInfo(JsonData.Json json)
        {
            //Handle overview
            LabelSingleStateo.Content = SingleTrack.SingleOverviewBuilder(json.state);
            //Handle dataGirdViewSingle
            foreach (var data in json.data)
            {
                DataGridSingle.Items.Add(new DataGridRow
                {
                    Item = new { TIME = data.time, PROGRESS = data.context }
                });
            }
        }

        #endregion

    }
}
