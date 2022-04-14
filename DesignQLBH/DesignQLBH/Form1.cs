using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignQLBH
{
    public partial class Form1 : Form
    {
        int nut = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //khai bao bien csdl
            QLBHEntities db = new QLBHEntities();
            //khai bao bien dang bang tblSanpham
            lbtSanpham bt = new lbtSanpham();
            dataGridView1.DataSource = db.lbtSanphams.ToList();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nut = 1;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //khai bao bien dong
            DataGridViewRow dong = new DataGridViewRow();
            dong = this.dataGridView1.Rows[e.RowIndex];
            //b2 gan du lieu cho text box
            textBox1.Text = dong.Cells[0].Value.ToString();
            textBox2.Text = dong.Cells[1].Value.ToString();
            textBox3.Text = dong.Cells[2].Value.ToString();
            textBox4.Text = dong.Cells[3].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Lưu thêm mới
            if(nut == 1)
            {
                //Kiem tra cac o co rong hay k(Masp)
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Mã sản phẩm không được để trống");
                }
                //Kiem tra ma san pham da co chua
                QLBHEntities db = new QLBHEntities();
                if (db.lbtSanphams.FirstOrDefault(c => c.Masp == textBox1.Text) == null)
                {
                    //cho phep nhap moi
                    //chèn dữ liệu từ form vào database
                    lbtSanpham bt = new lbtSanpham();
                    bt.Masp = textBox1.Text;
                    bt.Tensp = textBox2.Text;
                    bt.Gia = int.Parse(textBox3.Text);
                    bt.Sl = int.Parse(textBox4.Text);
                    //add du lieu vào bảng tạm database
                    db.lbtSanphams.Add(bt);
                    //luu vao database
                    db.SaveChanges();
                    //lenh hien thi du lieu tren datagripviews
                    dataGridView1.DataSource = db.lbtSanphams.ToList();
                }
                else
                {
                    MessageBox.Show("Đã tồn tài mã sản phẩm này vui lòng nhập khác");
                }
            }
            //Lưu Sửa
            if(nut == 4)
            {
                QLBHEntities db = new QLBHEntities();
                lbtSanpham bt = new lbtSanpham();
                bt = db.lbtSanphams.FirstOrDefault(c => c.Masp == textBox1.Text);
                bt.Tensp = textBox2.Text;
                bt.Gia = int.Parse(textBox3.Text);
                bt.Sl = int.Parse(textBox4.Text);
                //Lưu mới
                db.SaveChanges();
                //cập nhập thông tin mới
                dataGridView1.DataSource = db.lbtSanphams.ToList();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            nut = 3;
            //nút xóa
            //khái báo biến cơ sở dữ liệu
            QLBHEntities db = new QLBHEntities();
            //khai báo bảng tạm mà có liên kết vs bảng dữ liệu thật
            lbtSanpham bt = new lbtSanpham();
            //xóa dữ liệu đc chon trong bảng tạm: dựa trên mã sản phẩm đc chọn
            bt = db.lbtSanphams.FirstOrDefault(c => c.Masp == textBox1.Text);
            db.lbtSanphams.Remove(bt);
            db.SaveChanges();
            //Lấy dữ liệu đc lưu làm mới lại trên datagripview
            var lst = db.lbtSanphams.ToList();
            dataGridView1.DataSource = lst;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            nut = 4;
            textBox1.Enabled = false;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
        }
    }
}
