namespace Kt
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtSonguyen = new System.Windows.Forms.TextBox();
            this.btCapnhap = new System.Windows.Forms.Button();
            this.lstKetqua = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btXoaphantucuoi = new System.Windows.Forms.Button();
            this.btXoaphantudau = new System.Windows.Forms.Button();
            this.btXoaphantudangchon = new System.Windows.Forms.Button();
            this.btLecuoi = new System.Windows.Forms.Button();
            this.btChonchandau = new System.Windows.Forms.Button();
            this.btTang2 = new System.Windows.Forms.Button();
            this.btKetthuc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số nguyên:";
            // 
            // txtSonguyen
            // 
            this.txtSonguyen.Location = new System.Drawing.Point(283, 50);
            this.txtSonguyen.Name = "txtSonguyen";
            this.txtSonguyen.Size = new System.Drawing.Size(381, 26);
            this.txtSonguyen.TabIndex = 1;
            this.txtSonguyen.TextChanged += new System.EventHandler(this.txtSonguyen_TextChanged_1);
            this.txtSonguyen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSonguyen_KeyPress);
            // 
            // btCapnhap
            // 
            this.btCapnhap.BackColor = System.Drawing.Color.Coral;
            this.btCapnhap.Location = new System.Drawing.Point(700, 46);
            this.btCapnhap.Name = "btCapnhap";
            this.btCapnhap.Size = new System.Drawing.Size(220, 56);
            this.btCapnhap.TabIndex = 2;
            this.btCapnhap.Text = "Cập nhập";
            this.btCapnhap.UseVisualStyleBackColor = false;
            this.btCapnhap.Click += new System.EventHandler(this.btCapnhap_Click);
            // 
            // lstKetqua
            // 
            this.lstKetqua.FormattingEnabled = true;
            this.lstKetqua.ItemHeight = 20;
            this.lstKetqua.Location = new System.Drawing.Point(122, 120);
            this.lstKetqua.Name = "lstKetqua";
            this.lstKetqua.Size = new System.Drawing.Size(428, 484);
            this.lstKetqua.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.btXoaphantucuoi);
            this.groupBox1.Controls.Add(this.btXoaphantudau);
            this.groupBox1.Controls.Add(this.btXoaphantudangchon);
            this.groupBox1.Controls.Add(this.btLecuoi);
            this.groupBox1.Controls.Add(this.btChonchandau);
            this.groupBox1.Controls.Add(this.btTang2);
            this.groupBox1.Location = new System.Drawing.Point(556, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 484);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btXoaphantucuoi
            // 
            this.btXoaphantucuoi.BackColor = System.Drawing.Color.MediumPurple;
            this.btXoaphantucuoi.Location = new System.Drawing.Point(101, 422);
            this.btXoaphantucuoi.Name = "btXoaphantucuoi";
            this.btXoaphantucuoi.Size = new System.Drawing.Size(311, 44);
            this.btXoaphantucuoi.TabIndex = 5;
            this.btXoaphantucuoi.Text = "Xóa phần tử cuối";
            this.btXoaphantucuoi.UseVisualStyleBackColor = false;
            this.btXoaphantucuoi.Click += new System.EventHandler(this.btXoaphantucuoi_Click);
            // 
            // btXoaphantudau
            // 
            this.btXoaphantudau.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btXoaphantudau.Location = new System.Drawing.Point(101, 347);
            this.btXoaphantudau.Name = "btXoaphantudau";
            this.btXoaphantudau.Size = new System.Drawing.Size(311, 44);
            this.btXoaphantudau.TabIndex = 4;
            this.btXoaphantudau.Text = "Xóa phần tử đầu";
            this.btXoaphantudau.UseVisualStyleBackColor = false;
            this.btXoaphantudau.Click += new System.EventHandler(this.btXoaphantudau_Click);
            // 
            // btXoaphantudangchon
            // 
            this.btXoaphantudangchon.BackColor = System.Drawing.Color.Chartreuse;
            this.btXoaphantudangchon.Location = new System.Drawing.Point(101, 265);
            this.btXoaphantudangchon.Name = "btXoaphantudangchon";
            this.btXoaphantudangchon.Size = new System.Drawing.Size(311, 45);
            this.btXoaphantudangchon.TabIndex = 3;
            this.btXoaphantudangchon.Text = "Xóa phần tử  đang chọn";
            this.btXoaphantudangchon.UseVisualStyleBackColor = false;
            this.btXoaphantudangchon.Click += new System.EventHandler(this.btXoaphantudangchon_Click);
            // 
            // btLecuoi
            // 
            this.btLecuoi.BackColor = System.Drawing.SystemColors.Highlight;
            this.btLecuoi.Location = new System.Drawing.Point(101, 186);
            this.btLecuoi.Name = "btLecuoi";
            this.btLecuoi.Size = new System.Drawing.Size(311, 50);
            this.btLecuoi.TabIndex = 2;
            this.btLecuoi.Text = "Chon số lẻ cuối";
            this.btLecuoi.UseVisualStyleBackColor = false;
            this.btLecuoi.Click += new System.EventHandler(this.btLecuoi_Click);
            // 
            // btChonchandau
            // 
            this.btChonchandau.BackColor = System.Drawing.Color.OliveDrab;
            this.btChonchandau.Location = new System.Drawing.Point(101, 106);
            this.btChonchandau.Name = "btChonchandau";
            this.btChonchandau.Size = new System.Drawing.Size(311, 48);
            this.btChonchandau.TabIndex = 1;
            this.btChonchandau.Text = "Chọn số chẵn đầu";
            this.btChonchandau.UseVisualStyleBackColor = false;
            this.btChonchandau.Click += new System.EventHandler(this.btChonchandau_Click);
            // 
            // btTang2
            // 
            this.btTang2.BackColor = System.Drawing.Color.Peru;
            this.btTang2.Location = new System.Drawing.Point(101, 34);
            this.btTang2.Name = "btTang2";
            this.btTang2.Size = new System.Drawing.Size(311, 48);
            this.btTang2.TabIndex = 0;
            this.btTang2.Text = "Tăng mỗi phần tử lên 2";
            this.btTang2.UseVisualStyleBackColor = false;
            this.btTang2.Click += new System.EventHandler(this.btTang2_Click);
            // 
            // btKetthuc
            // 
            this.btKetthuc.BackColor = System.Drawing.SystemColors.Info;
            this.btKetthuc.Location = new System.Drawing.Point(93, 628);
            this.btKetthuc.Name = "btKetthuc";
            this.btKetthuc.Size = new System.Drawing.Size(964, 33);
            this.btKetthuc.TabIndex = 5;
            this.btKetthuc.Text = "Kết thúc";
            this.btKetthuc.UseVisualStyleBackColor = false;
            this.btKetthuc.Click += new System.EventHandler(this.btKetthuc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 732);
            this.Controls.Add(this.btKetthuc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstKetqua);
            this.Controls.Add(this.btCapnhap);
            this.Controls.Add(this.txtSonguyen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSonguyen;
        private System.Windows.Forms.Button btCapnhap;
        private System.Windows.Forms.ListBox lstKetqua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btXoaphantucuoi;
        private System.Windows.Forms.Button btXoaphantudau;
        private System.Windows.Forms.Button btXoaphantudangchon;
        private System.Windows.Forms.Button btLecuoi;
        private System.Windows.Forms.Button btChonchandau;
        private System.Windows.Forms.Button btTang2;
        private System.Windows.Forms.Button btKetthuc;
    }
}

