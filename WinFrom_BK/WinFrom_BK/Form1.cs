using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFrom_BK
{
    public partial class Form1 : Form
    {
        public Double demlan_choi, demlan_thang;
        public Form1()
        {
            InitializeComponent();
            demlan_choi = demlan_thang = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            demlan_choi++;
            Random r = new Random();
            label1.Text = r.Next(0, 9).ToString();
            label2.Text = r.Next(0, 9).ToString();
            label3.Text = r.Next(0, 9).ToString();
            // an hien hinh anh
            if((label1.Text == "7") || (label2.Text == "7") || (label3.Text == "7"))
            {
                pictureBox1.Visible = true;
                demlan_thang++;
            }
            else
            {
                pictureBox1.Visible = false;
            }
            //code hien thi lable4 va lable5
            label4.Text = demlan_thang.ToString();
            label5.Text = ((demlan_thang / demlan_choi)*100).ToString("0.00%");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
