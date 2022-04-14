using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lad03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void GetPay()
        {
            int Total = 0;
            //Kiểm tra xem đã nhập tên chưa
            if(txtName.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên khác hàng");
            }
            else
            {
                if(chkclean.Checked == true)
                {
                    Total += 100000;
                }
                if(chkWhitening.Checked == true)
                {
                    Total += 1200000;
                }
                if(chkXRay.Checked == true)
                {
                    Total += 200000;
                }
                else
                {
                    Total += int.Parse(numFilling.Value.ToString()) * 80000; //Ép kiẻu dữ liệu sang Int đẻ cộng
                }
                txtTotal.Text = Total.ToString();
                //Lưu thông tin vào textbox
                listBox1.Items.Add("Họ và tên:"+txtName.Text +"   |   Số tiền:"+ txtTotal.Text);
            }
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            GetPay();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = " ";
            chkclean.Checked = false;
            chkWhitening.Checked = false;
            chkXRay.Checked = false;
            numFilling.Value = 0;
            txtTotal.Text = " ";
        }
    }
}
