using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT3las5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lsvNhanvien.SelectedItems.Count > 0)
            {
                lsvNhanvien.SelectedItems[0].SubItems[0].Text = txtHoten.Text;
                lsvNhanvien.SelectedItems[0].SubItems[1].Text = dtpNgaysinh.Value.ToShortDateString();
                lsvNhanvien.SelectedItems[0].SubItems[2].Text = txtDienthoai.Text;
                lsvNhanvien.SelectedItems[0].SubItems[3].Text = txtDiachi.Text;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ListViewItem Liv = lsvNhanvien.Items.Add(txtHoten.Text);
            Liv.SubItems.Add(dtpNgaysinh.Value.ToString());
            Liv.SubItems.Add(txtDienthoai.Text);
            Liv.SubItems.Add(txtDiachi.Text);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvNhanvien.SelectedItems.Count > 0)
            {
                lsvNhanvien.Items.Remove(lsvNhanvien.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Không có dữ liệu hoặc chưa chọn cột");
            }

        }

        private void lsvNhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvNhanvien.SelectedItems.Count > 0)
            {
                txtHoten.Text = lsvNhanvien.SelectedItems[0].SubItems[0].Text;
                dtpNgaysinh.Text = lsvNhanvien.SelectedItems[0].SubItems[1].Text;
                txtDienthoai.Text = lsvNhanvien.SelectedItems[0].SubItems[2].Text;
                txtDiachi.Text = lsvNhanvien.SelectedItems[0].SubItems[3].Text;
            }
        }
    }
}
