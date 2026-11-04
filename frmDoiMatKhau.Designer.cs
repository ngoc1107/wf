namespace btl_wf
{
    partial class frmdoimk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdoimk));
            this.lbltieude = new System.Windows.Forms.Label();
            this.lblten = new System.Windows.Forms.Label();
            this.lblmkhientai = new System.Windows.Forms.Label();
            this.lblmkmoi = new System.Windows.Forms.Label();
            this.lblnhaplai = new System.Windows.Forms.Label();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtmkhientai = new System.Windows.Forms.TextBox();
            this.txtmkmoi = new System.Windows.Forms.TextBox();
            this.txtnhaplai = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltieude
            // 
            this.lbltieude.AutoSize = true;
            this.lbltieude.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltieude.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbltieude.Location = new System.Drawing.Point(125, 9);
            this.lbltieude.Name = "lbltieude";
            this.lbltieude.Size = new System.Drawing.Size(354, 49);
            this.lbltieude.TabIndex = 0;
            this.lbltieude.Text = "ĐỔI MẬT KHẨU";
            // 
            // lblten
            // 
            this.lblten.AutoSize = true;
            this.lblten.Location = new System.Drawing.Point(35, 95);
            this.lblten.Name = "lblten";
            this.lblten.Size = new System.Drawing.Size(163, 25);
            this.lblten.TabIndex = 1;
            this.lblten.Text = "Tên đăng nhập:";
            // 
            // lblmkhientai
            // 
            this.lblmkhientai.AutoSize = true;
            this.lblmkhientai.Location = new System.Drawing.Point(35, 140);
            this.lblmkhientai.Name = "lblmkhientai";
            this.lblmkhientai.Size = new System.Drawing.Size(183, 25);
            this.lblmkhientai.TabIndex = 2;
            this.lblmkhientai.Text = "Mật khẩu hiện tại:";
            // 
            // lblmkmoi
            // 
            this.lblmkmoi.AutoSize = true;
            this.lblmkmoi.Location = new System.Drawing.Point(35, 192);
            this.lblmkmoi.Name = "lblmkmoi";
            this.lblmkmoi.Size = new System.Drawing.Size(147, 25);
            this.lblmkmoi.TabIndex = 3;
            this.lblmkmoi.Text = "Mật khẩu mới:";
            // 
            // lblnhaplai
            // 
            this.lblnhaplai.AutoSize = true;
            this.lblnhaplai.Location = new System.Drawing.Point(35, 246);
            this.lblnhaplai.Name = "lblnhaplai";
            this.lblnhaplai.Size = new System.Drawing.Size(231, 25);
            this.lblnhaplai.TabIndex = 4;
            this.lblnhaplai.Text = "Nhập lại mật khẩu mới:";
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(307, 89);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(259, 31);
            this.txtten.TabIndex = 5;
            // 
            // txtmkhientai
            // 
            this.txtmkhientai.Location = new System.Drawing.Point(307, 134);
            this.txtmkhientai.Name = "txtmkhientai";
            this.txtmkhientai.Size = new System.Drawing.Size(259, 31);
            this.txtmkhientai.TabIndex = 6;
            // 
            // txtmkmoi
            // 
            this.txtmkmoi.Location = new System.Drawing.Point(307, 186);
            this.txtmkmoi.Name = "txtmkmoi";
            this.txtmkmoi.Size = new System.Drawing.Size(259, 31);
            this.txtmkmoi.TabIndex = 7;
            this.txtmkmoi.UseSystemPasswordChar = true;
            // 
            // txtnhaplai
            // 
            this.txtnhaplai.Location = new System.Drawing.Point(307, 239);
            this.txtnhaplai.Name = "txtnhaplai";
            this.txtnhaplai.Size = new System.Drawing.Size(259, 31);
            this.txtnhaplai.TabIndex = 8;
            this.txtnhaplai.UseSystemPasswordChar = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(170, 295);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(211, 29);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Hiển thị mật khẩu";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnluu
            // 
            this.btnluu.AutoSize = true;
            this.btnluu.Location = new System.Drawing.Point(151, 360);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(140, 35);
            this.btnluu.TabIndex = 10;
            this.btnluu.Text = "Lưu thay đổi";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.AutoSize = true;
            this.btnhuy.Location = new System.Drawing.Point(404, 360);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 35);
            this.btnhuy.TabIndex = 11;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // frmdoimk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 449);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtnhaplai);
            this.Controls.Add(this.txtmkmoi);
            this.Controls.Add(this.txtmkhientai);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.lblnhaplai);
            this.Controls.Add(this.lblmkmoi);
            this.Controls.Add(this.lblmkhientai);
            this.Controls.Add(this.lblten);
            this.Controls.Add(this.lbltieude);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmdoimk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.frmdoimk_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltieude;
        private System.Windows.Forms.Label lblten;
        private System.Windows.Forms.Label lblmkhientai;
        private System.Windows.Forms.Label lblmkmoi;
        private System.Windows.Forms.Label lblnhaplai;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtmkhientai;
        private System.Windows.Forms.TextBox txtmkmoi;
        private System.Windows.Forms.TextBox txtnhaplai;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnhuy;
    }
}