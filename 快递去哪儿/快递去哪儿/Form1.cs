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
            //Clean first
            dataGridViewSingle.Rows.Clear();
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
            //TODO: As a config file future
            Dictionary<string, string> companyDict = new Dictionary<string, string>();
            companyDict.Add("BSHT-百世汇通","huitongkuaidi");
            companyDict.Add("EMS-EMS", "ems");
            companyDict.Add("EMSGJKD-EMS国际快递","emsguoji");
            companyDict.Add("QFKD-全峰快递","quanfengkuaidi");
            companyDict.Add("SFSY-顺丰速运", "shunfeng");
            companyDict.Add("STKD-申通快递", "shentong");
            companyDict.Add("TTKD-天天快递","tiantian");
            companyDict.Add("YDKD-韵达快递","yunda");
            companyDict.Add("YZGJBG-邮政国际包裹","YOUZENGGUOJI");
            companyDict.Add("YZGNBG-邮政国内包裹", "youzhengguonei");
            companyDict.Add("YTSD-圆通速递","yuantong");
            companyDict.Add("ZJS-宅急送","zhaijisong");
            companyDict.Add("ZTKD-中通快递","zhongtong");
            comboBoxSingleCompany.DataSource = new BindingSource(companyDict, null);
            comboBoxSingleCompany.DisplayMember = "Key";
            comboBoxSingleCompany.ValueMember = "Value";
        }

        private void TrackSingle(string ID, string Company)
        {
            string rawJson = null;
            string url = "http://www.kuaidi100.com/query?type=" + Company + "&postid=" + ID; 
            HttpWebRequest HttpWReq = (HttpWebRequest) WebRequest.Create(url);
            HttpWebResponse HttpWResp = (HttpWebResponse)HttpWReq.GetResponse();
            Stream rawStream = HttpWResp.GetResponseStream();
            StreamReader r = new StreamReader(rawStream);
            rawJson = r.ReadToEnd();
            HttpWResp.Close();
            DeserializeJson(rawJson);
            
        }

        private void DeserializeJson(string rawJson)
        {
            var json = JsonConvert.DeserializeObject<Json>(rawJson);
            if (json.status != "200")
            {
                MessageBox.Show("快递公司参数异常：单号不存在或者已经过期。", "错误", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                ShowTrackInfo(json);
            }
        }

        private void ShowTrackInfo(Json json)
        {

            foreach (var data in json.data)
            {
                int index = dataGridViewSingle.Rows.Add();
                dataGridViewSingle.Rows[index].Cells[0].Value = data.time;
                dataGridViewSingle.Rows[index].Cells[1].Value = data.context;
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
