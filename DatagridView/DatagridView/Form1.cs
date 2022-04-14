using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatagridView
{
    public partial class Form1 : Form
    {
        private Ho_so_sinh_vienEntities db = new Ho_so_sinh_vienEntities();
        DataGridViewRow dong;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridView1.Rows[0].Cells[0].Value = '1';
            //dataGridView1.Rows[0].Cells[1].Value = 'An';
            //dataGridView1.Rows[0].Cells[2].Value = 'Ha Noi';
            //dataGridView1.Rows[0].Cells[3].Value = '0988347223';

        }

        private void label5_Click(object sender, EventArgs e)
        {
        
        }

        private void button6_Click(object sender, EventArgs e)//Thêm dữ liệu bàng cách nhập
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)// xóa dữ liệu trong danh sách
        {
            dataGridView1.Rows.Remove(dong);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //gán dữ liệu vào biến
        {
            dong = this.dataGridView1.Rows[e.RowIndex];
            textBox1.Text = dong.Cells[0].Value.ToString();
            textBox2.Text = dong.Cells[1].Value.ToString();
            textBox3.Text = dong.Cells[2].Value.ToString();
            textBox4.Text = dong.Cells[3].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e) //Lưu liệu vào danh sách
        {
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
        }

        private void button5_Click(object sender, EventArgs e) //sua du lieu
        {
            dataGridView1.Rows[dong.Index].Cells[0].Value = textBox1.Text;
            dataGridView1.Rows[dong.Index].Cells[1].Value = textBox2.Text;
            dataGridView1.Rows[dong.Index].Cells[2].Value = textBox3.Text;
            dataGridView1.Rows[dong.Index].Cells[3].Value = textBox4.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // dua du lieu tu db vao data grib views
            dataGridView1.DataSource = db.Thong_tinSV.ToList();
        }
    }
}
