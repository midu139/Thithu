namespace Thithu
{
    partial class Frm_TrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TrangChu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_DangKy = new System.Windows.Forms.Button();
            this.Btn_DangNhap = new System.Windows.Forms.Button();
            this.Btn_Thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1226, 404);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_DangKy
            // 
            this.Btn_DangKy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_DangKy.BackColor = System.Drawing.Color.Gold;
            this.Btn_DangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DangKy.ForeColor = System.Drawing.Color.White;
            this.Btn_DangKy.Location = new System.Drawing.Point(80, 461);
            this.Btn_DangKy.Name = "Btn_DangKy";
            this.Btn_DangKy.Size = new System.Drawing.Size(244, 91);
            this.Btn_DangKy.TabIndex = 6;
            this.Btn_DangKy.Text = "Đăng Ký";
            this.Btn_DangKy.UseVisualStyleBackColor = false;
            this.Btn_DangKy.Click += new System.EventHandler(this.Btn_DangKy_Click);
            // 
            // Btn_DangNhap
            // 
            this.Btn_DangNhap.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_DangNhap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_DangNhap.BackColor = System.Drawing.Color.Gold;
            this.Btn_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DangNhap.ForeColor = System.Drawing.Color.White;
            this.Btn_DangNhap.Location = new System.Drawing.Point(406, 461);
            this.Btn_DangNhap.Name = "Btn_DangNhap";
            this.Btn_DangNhap.Size = new System.Drawing.Size(244, 91);
            this.Btn_DangNhap.TabIndex = 7;
            this.Btn_DangNhap.Text = "Đăng Nhập";
            this.Btn_DangNhap.UseVisualStyleBackColor = false;
            this.Btn_DangNhap.Click += new System.EventHandler(this.Btn_DangNhap_Click);
            // 
            // Btn_Thoat
            // 
            this.Btn_Thoat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Thoat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Thoat.BackColor = System.Drawing.Color.Gold;
            this.Btn_Thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Thoat.ForeColor = System.Drawing.Color.White;
            this.Btn_Thoat.Location = new System.Drawing.Point(730, 461);
            this.Btn_Thoat.Name = "Btn_Thoat";
            this.Btn_Thoat.Size = new System.Drawing.Size(424, 91);
            this.Btn_Thoat.TabIndex = 9;
            this.Btn_Thoat.Text = "Thoát Khỏi Chương Trình";
            this.Btn_Thoat.UseVisualStyleBackColor = false;
            this.Btn_Thoat.Click += new System.EventHandler(this.Btn_Thoat_Click);
            // 
            // Frm_TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.Btn_Thoat;
            this.ClientSize = new System.Drawing.Size(1234, 603);
            this.Controls.Add(this.Btn_Thoat);
            this.Controls.Add(this.Btn_DangNhap);
            this.Controls.Add(this.Btn_DangKy);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Frm_TrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chủ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_DangKy;
        private System.Windows.Forms.Button Btn_DangNhap;
        private System.Windows.Forms.Button Btn_Thoat;
    }
}

