using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void buttonSingle_Click(object sender, EventArgs e)
        {
            if (IsSingleInputLeagel() == false)
            {
                MessageBox.Show("输入信息有误，请检查。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                TrackSingle(textBoxSingleID.Text, comboBoxSingleCompany.SelectedIndex.ToString());
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

        private void TrackSingle(string ID, string Company)
        {
            string url = "http://www.kuaidi100.com/query?type=" + Company + "&postid" + ID; 
            HttpWebRequest HttpWReq = (HttpWebRequest) WebRequest.Create(url);
            try
            {
                HttpWebResponse HttpWResp = (HttpWebResponse) HttpWReq.GetResponse();
                MessageBox.Show(HttpWResp.StatusDescription+Company+ID );
                HttpWResp.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("无法连接服务器。\r\n"+ "补充信息：" + ex.Message,"错误",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }


        }
    }
}
