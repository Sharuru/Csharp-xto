using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

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
            companyDict.Add("YDKD-韵达快递,","yunda");
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
                MessageBox.Show(HttpWResp.StatusDescription+Company+ID);
                Stream abc = HttpWResp.GetResponseStream();
                StreamReader aaa = new StreamReader(abc);
                string html = aaa.ReadToEnd();
                MessageBox.Show(html);
                HttpWResp.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("无法连接服务器。\r\n"+ "补充信息：" + ex.Message,"错误",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

    }
}
