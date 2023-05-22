namespace Thithu
{
    partial class Frm_DangKy
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
            this.lbl_soThutu = new System.Windows.Forms.Label();
            this.lbl_hoTen = new System.Windows.Forms.Label();
            this.lbl_ngaySinh = new System.Windows.Forms.Label();
            this.txt_soThuTu = new System.Windows.Forms.TextBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_DangKy = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_soThutu
            // 
            this.lbl_soThutu.AutoSize = true;
            this.lbl_soThutu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_soThutu.Location = new System.Drawing.Point(12, 21);
            this.lbl_soThutu.Name = "lbl_soThutu";
            this.lbl_soThutu.Size = new System.Drawing.Size(122, 25);
            this.lbl_soThutu.TabIndex = 4;
            this.lbl_soThutu.Text = "Số Thứ Tự:";
            // 
            // lbl_hoTen
            // 
            this.lbl_hoTen.AutoSize = true;
            this.lbl_hoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hoTen.Location = new System.Drawing.Point(15, 67);
            this.lbl_hoTen.Name = "lbl_hoTen";
            this.lbl_hoTen.Size = new System.Drawing.Size(119, 25);
            this.lbl_hoTen.TabIndex = 5;
            this.lbl_hoTen.Text = "Họ và Tên:";
            // 
            // lbl_ngaySinh
            // 
            this.lbl_ngaySinh.AutoSize = true;
            this.lbl_ngaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngaySinh.Location = new System.Drawing.Point(15, 115);
            this.lbl_ngaySinh.Name = "lbl_ngaySinh";
            this.lbl_ngaySinh.Size = new System.Drawing.Size(119, 25);
            this.lbl_ngaySinh.TabIndex = 6;
            this.lbl_ngaySinh.Text = "Ngày Sinh:";
            // 
            // txt_soThuTu
            // 
            this.txt_soThuTu.Location = new System.Drawing.Point(158, 22);
            this.txt_soThuTu.Name = "txt_soThuTu";
            this.txt_soThuTu.Size = new System.Drawing.Size(513, 26);
            this.txt_soThuTu.TabIndex = 7;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(158, 66);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(513, 26);
            this.txt_HoTen.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(158, 115);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(139, 26);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangKy.Location = new System.Drawing.Point(176, 158);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(138, 51);
            this.btn_DangKy.TabIndex = 13;
            this.btn_DangKy.Text = "Đăng Ký";
            this.btn_DangKy.UseVisualStyleBackColor = true;
            this.btn_DangKy.Click += new System.EventHandler(this.btn_DangKy_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(386, 158);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(127, 51);
            this.btn_Thoat.TabIndex = 14;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // Frm_DangKy
            // 
            this.AcceptButton = this.btn_DangKy;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Thoat;
            this.ClientSize = new System.Drawing.Size(688, 244);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_DangKy);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.txt_soThuTu);
            this.Controls.Add(this.lbl_ngaySinh);
            this.Controls.Add(this.lbl_hoTen);
            this.Controls.Add(this.lbl_soThutu);
            this.Name = "Frm_DangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Đăng Ký";
            this.Load += new System.EventHandler(this.Frm_DangKy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_soThutu;
        private System.Windows.Forms.Label lbl_hoTen;
        private System.Windows.Forms.Label lbl_ngaySinh;
        private System.Windows.Forms.TextBox txt_soThuTu;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_DangKy;
        private System.Windows.Forms.Button btn_Thoat;
    }
}