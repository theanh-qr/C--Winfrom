using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kt5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCapnhap_Click(object sender, EventArgs e)
        {
            lstBandau.Items.Add(txtHoten.Text);
            txtHoten.Text = "";
            txtHoten.Focus();
        }

        private void btTraisangphai_Click(object sender, EventArgs e)
        {
            int n = lstBandau.SelectedItems.Count; //Tong so muc duoc chon
            for (int i = 0; i <= n - 1; i++)
                lstKetqua.Items.Add(lstBandau.SelectedItems[i].ToString());
            for (int j = n - 1; j >= 0; j--)
                lstBandau.Items.RemoveAt(j);
        }

        private void btTatcatraisangphai_Click(object sender, EventArgs e)
        {
            int n = lstBandau.SelectedItems.Count;
            for (int i = 0; i <= n - 1; i++)
                lstKetqua.Items.Add(lstBandau.SelectedItems[i].ToString());
            for (int j = n - 1; j >= 0; j--)
                lstBandau.SelectedItems.RemoveAt(j);
        }

        private void btPhaisangtrai_Click(object sender, EventArgs e)
        {
            int n = lstKetqua.SelectedItems.Count;
            for (int i = 0; i <= n - 1; i++)
                lstBandau.Items.Add(lstKetqua.SelectedItems[i].ToString());
            for (int j = n - 1; j >= 0; j--)
                lstKetqua.Items.RemoveAt(j);
        }

        private void btTatcaphaisangtrai_Click(object sender, EventArgs e)
        {
            int n = lstKetqua.Items.Count;
            for (int i = 0; i <= n - 1; i++)
                lstBandau.Items.Add(lstKetqua.Items[i].ToString());
            for (int j = n - 1; j >= 0; j--) 
                lstKetqua.Items.RemoveAt(j);
        }

        private void lstBandau_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btKetthuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            lstBandau.Items.Remove(lstBandau.SelectedItem);
            lstKetqua.Items.Remove(lstKetqua.SelectedItem);
        }
    }
}
