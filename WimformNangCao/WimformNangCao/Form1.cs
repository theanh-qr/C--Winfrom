using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WimformNangCao
{
    public partial class Form1 : Form
    {
        DataTable tbOrder = new DataTable();
        DataRow r;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbOrder.Columns.Add("FoodName");
            tbOrder.Columns.Add("Quantity");
        }
        private void chonmon(string tenmon)
        {
            int test = 0; //test  = 0 là món này chưa có trong bảng đặt hàng
            foreach(DataRow row in tbOrder.Rows)
            {
                if(row["FoodName"].ToString() == tenmon)
                {
                    test = 1;
                }
            }


            if(test == 1)//thêm số lượng lên 1 
            {
                foreach(DataRow row in tbOrder.Rows)
                {
                    if(row["FoodName"].ToString() == tenmon)
                    {
                        row["Quantity"] = int.Parse(row["Quantity"].ToString()) + 1;
                    }
                }
            }
            else// thêm món mới
            {
                r = tbOrder.NewRow();
                r["FoodName"] = tenmon;
                r["Quantity"] = 1;

                tbOrder.Rows.Add(r);
            }
        }

        private void btnBo_Click(object sender, EventArgs e)
        {
            chonmon(btnBo.Text);
            dgrOrder.DataSource = tbOrder;
        }

        private void btnGa_Click(object sender, EventArgs e)
        {
            chonmon(btnGa.Text);
            dgrOrder.DataSource = tbOrder;
        }

        private void btnTom_Click(object sender, EventArgs e)
        {
            chonmon(btnTom.Text);
            dgrOrder.DataSource = tbOrder;
        }

        private void btnCa_Click(object sender, EventArgs e)
        {
            chonmon(btnCa.Text);
            dgrOrder.DataSource = tbOrder;
        }

        private void btnTomCola_Click(object sender, EventArgs e)
        {
            chonmon(btnTomCola.Text);
            dgrOrder.DataSource = tbOrder;
        }

        private void btnGaCola_Click(object sender, EventArgs e)
        {
            chonmon(btnGaCola.Text);
            dgrOrder.DataSource = tbOrder;
        }

        private void btnGaRan_Click(object sender, EventArgs e)
        {
            chonmon(btnGaRan.Text);
            dgrOrder.DataSource = tbOrder;
        }

        private void btnComGa_Click(object sender, EventArgs e)
        {
            chonmon(btnComGa.Text);
            dgrOrder.DataSource = tbOrder;
        }

        private void btnPepsi_Click(object sender, EventArgs e)
        {
            chonmon(btnPepsi.Text);
            dgrOrder.DataSource = tbOrder;
        }

        private void btnLipton_Click(object sender, EventArgs e)
        {
            chonmon(btnLipton.Text);
            dgrOrder.DataSource = tbOrder;
        }

        private void btnCafe_Click(object sender, EventArgs e)
        {
            chonmon(btnCafe.Text);
            dgrOrder.DataSource = tbOrder;
        }

        private void btnCoca_Click(object sender, EventArgs e)
        {
            chonmon(btnCoca.Text);
            dgrOrder.DataSource = tbOrder;
        }

        private void btn7up_Click(object sender, EventArgs e)
        {
            chonmon(btn7up.Text);
            dgrOrder.DataSource = tbOrder;
        }

        private void btnCam_Click(object sender, EventArgs e)
        {
            chonmon(btnCam.Text);
            dgrOrder.DataSource = tbOrder;
        }

        private void btnKhoai_Click(object sender, EventArgs e)
        {
            chonmon(btnKhoai.Text);
            dgrOrder.DataSource = tbOrder;
        }
    }
}
