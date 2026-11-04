namespace btl_wf
{
    partial class frmdangnhap
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
            this.lbldangnhap = new System.Windows.Forms.Label();
            this.lbltendangnhap = new System.Windows.Forms.Label();
            this.lblmk = new System.Windows.Forms.Label();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.chkhienmk = new System.Windows.Forms.CheckBox();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbldangnhap
            // 
            this.lbldangnhap.AutoSize = true;
            this.lbldangnhap.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldangnhap.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbldangnhap.Location = new System.Drawing.Point(140, 9);
            this.lbldangnhap.Name = "lbldangnhap";
            this.lbldangnhap.Size = new System.Drawing.Size(280, 49);
            this.lbldangnhap.TabIndex = 0;
            this.lbldangnhap.Text = "ĐĂNG NHẬP";
            // 
            // lbltendangnhap
            // 
            this.lbltendangnhap.AutoSize = true;
            this.lbltendangnhap.Location = new System.Drawing.Point(50, 85);
            this.lbltendangnhap.Name = "lbltendangnhap";
            this.lbltendangnhap.Size = new System.Drawing.Size(163, 25);
            this.lbltendangnhap.TabIndex = 1;
            this.lbltendangnhap.Text = "Tên đăng nhập:";
            // 
            // lblmk
            // 
            this.lblmk.AutoSize = true;
            this.lblmk.Location = new System.Drawing.Point(55, 159);
            this.lblmk.Name = "lblmk";
            this.lblmk.Size = new System.Drawing.Size(107, 25);
            this.lblmk.TabIndex = 2;
            this.lblmk.Text = "Mật khẩu:";
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(253, 78);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(271, 31);
            this.txtten.TabIndex = 3;
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(253, 152);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(271, 31);
            this.txtmk.TabIndex = 4;
            // 
            // chkhienmk
            // 
            this.chkhienmk.AutoSize = true;
            this.chkhienmk.Location = new System.Drawing.Point(149, 218);
            this.chkhienmk.Name = "chkhienmk";
            this.chkhienmk.Size = new System.Drawing.Size(211, 29);
            this.chkhienmk.TabIndex = 5;
            this.chkhienmk.Text = "Hiển thị mật khẩu";
            this.chkhienmk.UseVisualStyleBackColor = true;
            this.chkhienmk.CheckedChanged += new System.EventHandler(this.chkhienmk_CheckedChanged);
            // 
            // btndangnhap
            // 
            this.btndangnhap.AutoSize = true;
            this.btndangnhap.Location = new System.Drawing.Point(113, 303);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(127, 35);
            this.btndangnhap.TabIndex = 6;
            this.btndangnhap.Text = "Đăng nhập";
            this.btndangnhap.UseVisualStyleBackColor = true;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.AutoSize = true;
            this.btnthoat.Location = new System.Drawing.Point(352, 303);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(77, 35);
            this.btnthoat.TabIndex = 7;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // frmdangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 409);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.chkhienmk);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.lblmk);
            this.Controls.Add(this.lbltendangnhap);
            this.Controls.Add(this.lbldangnhap);
            this.MinimizeBox = false;
            this.Name = "frmdangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frmdangnhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldangnhap;
        private System.Windows.Forms.Label lbltendangnhap;
        private System.Windows.Forms.Label lblmk;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.CheckBox chkhienmk;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.Button btnthoat;
    }
}