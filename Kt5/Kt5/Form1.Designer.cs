namespace Kt5
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.btCapnhap = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstBandau = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstKetqua = new System.Windows.Forms.ListBox();
            this.btTraisangphai = new System.Windows.Forms.Button();
            this.btPhaisangtrai = new System.Windows.Forms.Button();
            this.btTatcatraisangphai = new System.Windows.Forms.Button();
            this.btTatcaphaisangtrai = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btKetthuc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sánh sinh vien";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(374, 132);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(365, 26);
            this.txtHoten.TabIndex = 2;
            // 
            // btCapnhap
            // 
            this.btCapnhap.BackColor = System.Drawing.Color.LightCoral;
            this.btCapnhap.Location = new System.Drawing.Point(763, 124);
            this.btCapnhap.Name = "btCapnhap";
            this.btCapnhap.Size = new System.Drawing.Size(130, 34);
            this.btCapnhap.TabIndex = 3;
            this.btCapnhap.Text = "Cập nhập";
            this.btCapnhap.UseVisualStyleBackColor = false;
            this.btCapnhap.Click += new System.EventHandler(this.btCapnhap_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstBandau);
            this.groupBox1.Location = new System.Drawing.Point(81, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 390);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lớp A";
            // 
            // lstBandau
            // 
            this.lstBandau.FormattingEnabled = true;
            this.lstBandau.ItemHeight = 20;
            this.lstBandau.Location = new System.Drawing.Point(18, 51);
            this.lstBandau.Name = "lstBandau";
            this.lstBandau.Size = new System.Drawing.Size(322, 304);
            this.lstBandau.TabIndex = 0;
            this.lstBandau.SelectedIndexChanged += new System.EventHandler(this.lstBandau_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstKetqua);
            this.groupBox2.Location = new System.Drawing.Point(641, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 390);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lớp B";
            // 
            // lstKetqua
            // 
            this.lstKetqua.FormattingEnabled = true;
            this.lstKetqua.ItemHeight = 20;
            this.lstKetqua.Location = new System.Drawing.Point(21, 51);
            this.lstKetqua.Name = "lstKetqua";
            this.lstKetqua.Size = new System.Drawing.Size(333, 304);
            this.lstKetqua.TabIndex = 0;
            // 
            // btTraisangphai
            // 
            this.btTraisangphai.BackColor = System.Drawing.SystemColors.Highlight;
            this.btTraisangphai.Location = new System.Drawing.Point(449, 263);
            this.btTraisangphai.Name = "btTraisangphai";
            this.btTraisangphai.Size = new System.Drawing.Size(85, 47);
            this.btTraisangphai.TabIndex = 6;
            this.btTraisangphai.Text = ">";
            this.btTraisangphai.UseVisualStyleBackColor = false;
            this.btTraisangphai.Click += new System.EventHandler(this.btTraisangphai_Click);
            // 
            // btPhaisangtrai
            // 
            this.btPhaisangtrai.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btPhaisangtrai.Location = new System.Drawing.Point(550, 263);
            this.btPhaisangtrai.Name = "btPhaisangtrai";
            this.btPhaisangtrai.Size = new System.Drawing.Size(85, 47);
            this.btPhaisangtrai.TabIndex = 7;
            this.btPhaisangtrai.Text = "<";
            this.btPhaisangtrai.UseVisualStyleBackColor = false;
            this.btPhaisangtrai.Click += new System.EventHandler(this.btPhaisangtrai_Click);
            // 
            // btTatcatraisangphai
            // 
            this.btTatcatraisangphai.BackColor = System.Drawing.Color.PeachPuff;
            this.btTatcatraisangphai.Location = new System.Drawing.Point(449, 417);
            this.btTatcatraisangphai.Name = "btTatcatraisangphai";
            this.btTatcatraisangphai.Size = new System.Drawing.Size(85, 47);
            this.btTatcatraisangphai.TabIndex = 8;
            this.btTatcatraisangphai.Text = ">>";
            this.btTatcatraisangphai.UseVisualStyleBackColor = false;
            this.btTatcatraisangphai.Click += new System.EventHandler(this.btTatcatraisangphai_Click);
            // 
            // btTatcaphaisangtrai
            // 
            this.btTatcaphaisangtrai.BackColor = System.Drawing.Color.Orange;
            this.btTatcaphaisangtrai.Location = new System.Drawing.Point(550, 417);
            this.btTatcaphaisangtrai.Name = "btTatcaphaisangtrai";
            this.btTatcaphaisangtrai.Size = new System.Drawing.Size(85, 47);
            this.btTatcaphaisangtrai.TabIndex = 9;
            this.btTatcaphaisangtrai.Text = "<<";
            this.btTatcaphaisangtrai.UseVisualStyleBackColor = false;
            this.btTatcaphaisangtrai.Click += new System.EventHandler(this.btTatcaphaisangtrai_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.Yellow;
            this.btXoa.Location = new System.Drawing.Point(99, 629);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(322, 30);
            this.btXoa.TabIndex = 10;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btKetthuc
            // 
            this.btKetthuc.BackColor = System.Drawing.Color.Lime;
            this.btKetthuc.Location = new System.Drawing.Point(662, 629);
            this.btKetthuc.Name = "btKetthuc";
            this.btKetthuc.Size = new System.Drawing.Size(333, 30);
            this.btKetthuc.TabIndex = 11;
            this.btKetthuc.Text = "Kết thúc";
            this.btKetthuc.UseVisualStyleBackColor = false;
            this.btKetthuc.Click += new System.EventHandler(this.btKetthuc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 680);
            this.Controls.Add(this.btKetthuc);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btTatcaphaisangtrai);
            this.Controls.Add(this.btTatcatraisangphai);
            this.Controls.Add(this.btPhaisangtrai);
            this.Controls.Add(this.btTraisangphai);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btCapnhap);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Button btCapnhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstBandau;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstKetqua;
        private System.Windows.Forms.Button btTraisangphai;
        private System.Windows.Forms.Button btPhaisangtrai;
        private System.Windows.Forms.Button btTatcatraisangphai;
        private System.Windows.Forms.Button btTatcaphaisangtrai;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btKetthuc;
    }
}

