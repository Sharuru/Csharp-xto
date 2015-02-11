using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace csxto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitComoboxSingleCompany();
        }

        #region event handle
        private void buttonSingle_Click(object sender, EventArgs e)
        {
            //Clear track result first
            dataGridViewSingle.Rows.Clear();
            //Then clear overview
            labelSingleCompanyP.Text = @"快递公司：";
            labelSingleIDP.Text = @"快递单号：";
            labelSingleStatusP.Text = @"快递状态：";
            if (IsSingleInputLeagel() == false)
            {
                MessageBox.Show(@"输入信息有误，请检查。", @"错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                TrackSingle(textBoxSingleID.Text, comboBoxSingleCompany.SelectedValue.ToString());
            }
        }

        private void toolStripStatusLabelProjectAddress_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Sharuru/Csharp-xto/");
        }

        private void toolStripStatusLabelInspiredAddress_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/XadillaX/xto/");
        }
        #endregion

        private bool IsSingleInputLeagel()
        {
            //Check user input
            return textBoxSingleID.Text != "" && comboBoxSingleCompany.SelectedItem != null;
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

        private void TrackSingle(string id, string company)
        {
            string rawJson;
            try
            {
                var url = "http://www.kuaidi100.com/query?type=" + company + "&postid=" + id;
                var httpWReq = (HttpWebRequest) WebRequest.Create(url);
                var httpWResp = (HttpWebResponse) httpWReq.GetResponse();
                var rawStream = httpWResp.GetResponseStream();
                var reader = new StreamReader(rawStream);
                rawJson = reader.ReadToEnd();
                httpWResp.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DeserializeJson(rawJson);
        }

        private void DeserializeJson(string rawJson)
        {
            var json = JsonConvert.DeserializeObject<Json>(rawJson);
            if (json.status != "200")
            {
                MessageBox.Show(@"快递公司参数异常：单号不存在或者已经过期。", @"错误", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                ShowTrackInfo(json);
            }
        }

        private void ShowTrackInfo(Json json)
        {
            //Handle overview
            labelSingleCompanyP.Text = @"快递公司：" + comboBoxSingleCompany.Text;
            labelSingleIDP.Text = @"快递单号：" + json.nu;
            //TODO: Also as a config file future
            string state = null;
            switch (json.state)
            {
                case "0":
                    state = "运输中";
                    break;
                case "1":
                    state = "已揽收";
                    break;
                case "2":
                    state = "疑难件";
                    break;
                case "3":
                    state = "已签收";
                    break;
                case "4":
                    state = "已退回";
                    break;
                case "5":
                    state = "派送中";
                    break;
                case "6":
                    state = "退回中";
                    break;
            }
            labelSingleStatusP.Text = @"快递状态：" + state;
            //Handle dataGirdViewSingle
            foreach (var data in json.data)
            {
                var index = dataGridViewSingle.Rows.Add();
                dataGridViewSingle.Rows[index].Cells[0].Value = data.time;
                dataGridViewSingle.Rows[index].Cells[1].Value = data.context;
            }
        }

        #region Data Structure
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
