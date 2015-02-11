using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Windows.Forms.VisualStyles;
using Newtonsoft.Json;

namespace 快递去哪儿
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitComoboxSingleCompany();
        }

        private void buttonSingle_Click(object sender, EventArgs e)
        {
            if (IsSingleInputLeagel() == false)
            {
                MessageBox.Show("输入信息有误，请检查。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                TrackSingle(textBoxSingleID.Text, comboBoxSingleCompany.SelectedValue.ToString());
            }
        }

        private bool IsSingleInputLeagel()
        {
            //Check user input
            if (textBoxSingleID.Text == "" || comboBoxSingleCompany.SelectedItem == null)
            {
                return false;
            }
            return true;
        }

        private void InitComoboxSingleCompany()
        {
            Dictionary<string, string> companyDict = new Dictionary<string, string>();
            companyDict.Add("EMS-EMS", "ems");
            companyDict.Add("SFSY-顺丰速运", "shunfeng");
            companyDict.Add("STKD-申通快递", "shentong");
            companyDict.Add("YDKD-韵达快递","yunda");
            companyDict.Add("YTSD-圆通速递","yuantong");
            companyDict.Add("ZTKD-中通快递","zhongtong");
            comboBoxSingleCompany.DataSource = new BindingSource(companyDict, null);
            comboBoxSingleCompany.DisplayMember = "Key";
            comboBoxSingleCompany.ValueMember = "Value";
        }

        private void TrackSingle(string ID, string Company)
        {
            string url = "http://www.kuaidi100.com/query?type=" + Company + "&postid=" + ID; 
            HttpWebRequest HttpWReq = (HttpWebRequest) WebRequest.Create(url);
            try
            {
                HttpWebResponse HttpWResp = (HttpWebResponse) HttpWReq.GetResponse();
                Stream rawStream = HttpWResp.GetResponseStream();
                StreamReader r = new StreamReader(rawStream);
                string rawJson = r.ReadToEnd();
                HttpWResp.Close();
                DeserializeJson(rawJson);
            }
            catch (Exception ex)
            {
                MessageBox.Show("无法连接服务器。\r\n"+ "补充信息：" + ex.Message,"错误",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        private void DeserializeJson(string rawJson)
        {
            var json = JsonConvert.DeserializeObject<Json>(rawJson);
            MessageBox.Show("Starting...");
            foreach (var data in json.data)
            {
                    MessageBox.Show(data.context.ToString());
            }

        }
        public class Data
        {
            public string time { get; set; }
            public string location { get; set; }
            public string context { get; set; }
            public string ftime { get; set; }
        }


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

    }

}
