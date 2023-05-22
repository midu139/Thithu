namespace Thithu
{
    partial class Frm_ThayDoi
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
            this.lbl_maSoDuThi = new System.Windows.Forms.Label();
            this.lbl_hoTen = new System.Windows.Forms.Label();
            this.lbl_ngaySinh = new System.Windows.Forms.Label();
            this.txt_maSoDuThi = new System.Windows.Forms.TextBox();
            this.txt_hoTen = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_thayDoi = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_maSoDuThi
            // 
            this.lbl_maSoDuThi.AutoSize = true;
            this.lbl_maSoDuThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maSoDuThi.Location = new System.Drawing.Point(12, 9);
            this.lbl_maSoDuThi.Name = "lbl_maSoDuThi";
            this.lbl_maSoDuThi.Size = new System.Drawing.Size(122, 25);
            this.lbl_maSoDuThi.TabIndex = 5;
            this.lbl_maSoDuThi.Text = "Số Thứ Tự:";
            // 
            // lbl_hoTen
            // 
            this.lbl_hoTen.AutoSize = true;
            this.lbl_hoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hoTen.Location = new System.Drawing.Point(15, 46);
            this.lbl_hoTen.Name = "lbl_hoTen";
            this.lbl_hoTen.Size = new System.Drawing.Size(119, 25);
            this.lbl_hoTen.TabIndex = 6;
            this.lbl_hoTen.Text = "Họ và Tên:";
            // 
            // lbl_ngaySinh
            // 
            this.lbl_ngaySinh.AutoSize = true;
            this.lbl_ngaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngaySinh.Location = new System.Drawing.Point(15, 89);
            this.lbl_ngaySinh.Name = "lbl_ngaySinh";
            this.lbl_ngaySinh.Size = new System.Drawing.Size(119, 25);
            this.lbl_ngaySinh.TabIndex = 7;
            this.lbl_ngaySinh.Text = "Ngày Sinh:";
            // 
            // txt_maSoDuThi
            // 
            this.txt_maSoDuThi.Location = new System.Drawing.Point(151, 8);
            this.txt_maSoDuThi.Name = "txt_maSoDuThi";
            this.txt_maSoDuThi.Size = new System.Drawing.Size(513, 26);
            this.txt_maSoDuThi.TabIndex = 8;
            // 
            // txt_hoTen
            // 
            this.txt_hoTen.Location = new System.Drawing.Point(151, 45);
            this.txt_hoTen.Name = "txt_hoTen";
            this.txt_hoTen.Size = new System.Drawing.Size(513, 26);
            this.txt_hoTen.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(151, 89);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 26);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // btn_thayDoi
            // 
            this.btn_thayDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thayDoi.Location = new System.Drawing.Point(169, 141);
            this.btn_thayDoi.Name = "btn_thayDoi";
            this.btn_thayDoi.Size = new System.Drawing.Size(146, 58);
            this.btn_thayDoi.TabIndex = 14;
            this.btn_thayDoi.Text = "Thay Đổi";
            this.btn_thayDoi.UseVisualStyleBackColor = true;
            this.btn_thayDoi.Click += new System.EventHandler(this.btn_thayDoi_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(415, 141);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(137, 58);
            this.btn_Thoat.TabIndex = 15;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // Frm_ThayDoi
            // 
            this.AcceptButton = this.btn_thayDoi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Thoat;
            this.ClientSize = new System.Drawing.Size(693, 219);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_thayDoi);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txt_hoTen);
            this.Controls.Add(this.txt_maSoDuThi);
            this.Controls.Add(this.lbl_ngaySinh);
            this.Controls.Add(this.lbl_hoTen);
            this.Controls.Add(this.lbl_maSoDuThi);
            this.Name = "Frm_ThayDoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thay Đổi Thông Tin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_maSoDuThi;
        private System.Windows.Forms.Label lbl_hoTen;
        private System.Windows.Forms.Label lbl_ngaySinh;
        private System.Windows.Forms.TextBox txt_maSoDuThi;
        private System.Windows.Forms.TextBox txt_hoTen;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_thayDoi;
        private System.Windows.Forms.Button btn_Thoat;
    }
}