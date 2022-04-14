namespace Lad03
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.chkclean = new System.Windows.Forms.CheckBox();
            this.chkWhitening = new System.Windows.Forms.CheckBox();
            this.chkXRay = new System.Windows.Forms.CheckBox();
            this.lblCleanCost = new System.Windows.Forms.Label();
            this.lblWhiteningCost = new System.Windows.Forms.Label();
            this.lblXRayCost = new System.Windows.Forms.Label();
            this.numFilling = new System.Windows.Forms.NumericUpDown();
            this.lblFilling = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblFillCost = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numFilling)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Impact", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblTitle.Location = new System.Drawing.Point(57, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(309, 84);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dental Payment Form\r\n\r\n";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Chartreuse;
            this.btnExit.Location = new System.Drawing.Point(18, 418);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 39);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.Gold;
            this.btnCalc.Location = new System.Drawing.Point(148, 355);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(100, 39);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Tính tiền";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 68);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(154, 25);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Tên khách hàng";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.SeaShell;
            this.txtName.Location = new System.Drawing.Point(186, 68);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(317, 30);
            this.txtName.TabIndex = 4;
            // 
            // chkclean
            // 
            this.chkclean.AutoSize = true;
            this.chkclean.Location = new System.Drawing.Point(13, 108);
            this.chkclean.Margin = new System.Windows.Forms.Padding(4);
            this.chkclean.Name = "chkclean";
            this.chkclean.Size = new System.Drawing.Size(105, 29);
            this.chkclean.TabIndex = 5;
            this.chkclean.Text = "Cạo vôi";
            this.chkclean.UseVisualStyleBackColor = true;
            // 
            // chkWhitening
            // 
            this.chkWhitening.AutoSize = true;
            this.chkWhitening.Location = new System.Drawing.Point(13, 155);
            this.chkWhitening.Margin = new System.Windows.Forms.Padding(4);
            this.chkWhitening.Name = "chkWhitening";
            this.chkWhitening.Size = new System.Drawing.Size(116, 29);
            this.chkWhitening.TabIndex = 6;
            this.chkWhitening.Text = "Tẩy răng";
            this.chkWhitening.UseVisualStyleBackColor = true;
            // 
            // chkXRay
            // 
            this.chkXRay.AutoSize = true;
            this.chkXRay.Location = new System.Drawing.Point(13, 202);
            this.chkXRay.Margin = new System.Windows.Forms.Padding(4);
            this.chkXRay.Name = "chkXRay";
            this.chkXRay.Size = new System.Drawing.Size(172, 29);
            this.chkXRay.TabIndex = 7;
            this.chkXRay.Text = "Chụp hình răng";
            this.chkXRay.UseVisualStyleBackColor = true;
            // 
            // lblCleanCost
            // 
            this.lblCleanCost.AutoSize = true;
            this.lblCleanCost.Location = new System.Drawing.Point(181, 112);
            this.lblCleanCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCleanCost.Name = "lblCleanCost";
            this.lblCleanCost.Size = new System.Drawing.Size(94, 25);
            this.lblCleanCost.TabIndex = 8;
            this.lblCleanCost.Text = "$100.000";
            // 
            // lblWhiteningCost
            // 
            this.lblWhiteningCost.AutoSize = true;
            this.lblWhiteningCost.Location = new System.Drawing.Point(181, 155);
            this.lblWhiteningCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWhiteningCost.Name = "lblWhiteningCost";
            this.lblWhiteningCost.Size = new System.Drawing.Size(110, 25);
            this.lblWhiteningCost.TabIndex = 9;
            this.lblWhiteningCost.Text = "$1.200.000";
            // 
            // lblXRayCost
            // 
            this.lblXRayCost.AutoSize = true;
            this.lblXRayCost.Location = new System.Drawing.Point(181, 202);
            this.lblXRayCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblXRayCost.Name = "lblXRayCost";
            this.lblXRayCost.Size = new System.Drawing.Size(94, 25);
            this.lblXRayCost.TabIndex = 10;
            this.lblXRayCost.Text = "$200.000";
            // 
            // numFilling
            // 
            this.numFilling.Location = new System.Drawing.Point(186, 246);
            this.numFilling.Margin = new System.Windows.Forms.Padding(4);
            this.numFilling.Name = "numFilling";
            this.numFilling.Size = new System.Drawing.Size(160, 30);
            this.numFilling.TabIndex = 14;
            // 
            // lblFilling
            // 
            this.lblFilling.AutoSize = true;
            this.lblFilling.Location = new System.Drawing.Point(8, 246);
            this.lblFilling.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilling.Name = "lblFilling";
            this.lblFilling.Size = new System.Drawing.Size(102, 25);
            this.lblFilling.TabIndex = 15;
            this.lblFilling.Text = "Trám răng";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(181, 306);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 25);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.Info;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtTotal.Location = new System.Drawing.Point(251, 297);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(252, 39);
            this.txtTotal.TabIndex = 17;
            // 
            // lblFillCost
            // 
            this.lblFillCost.AutoSize = true;
            this.lblFillCost.Location = new System.Drawing.Point(389, 251);
            this.lblFillCost.Name = "lblFillCost";
            this.lblFillCost.Size = new System.Drawing.Size(114, 25);
            this.lblFillCost.TabIndex = 18;
            this.lblFillCost.Text = "$80.000/cái";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.BlueViolet;
            this.btnReset.Location = new System.Drawing.Point(18, 355);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 39);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(540, 65);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(356, 329);
            this.listBox1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(988, 556);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblFillCost);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblFilling);
            this.Controls.Add(this.numFilling);
            this.Controls.Add(this.lblXRayCost);
            this.Controls.Add(this.lblWhiteningCost);
            this.Controls.Add(this.lblCleanCost);
            this.Controls.Add(this.chkXRay);
            this.Controls.Add(this.chkWhitening);
            this.Controls.Add(this.chkclean);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numFilling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.CheckBox chkclean;
        private System.Windows.Forms.CheckBox chkWhitening;
        private System.Windows.Forms.CheckBox chkXRay;
        private System.Windows.Forms.Label lblCleanCost;
        private System.Windows.Forms.Label lblWhiteningCost;
        private System.Windows.Forms.Label lblXRayCost;
        private System.Windows.Forms.NumericUpDown numFilling;
        private System.Windows.Forms.Label lblFilling;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblFillCost;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ListBox listBox1;
    }
}

