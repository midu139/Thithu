namespace Thithu
{
    partial class Frm_User
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typingTestDataSet1 = new Thithu.TypingTestDataSet1();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.txt_SessionName = new System.Windows.Forms.TextBox();
            this.txt_SesionId = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_sua = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.txt_maso = new System.Windows.Forms.TextBox();
            this.lbl_ngaySinh = new System.Windows.Forms.Label();
            this.lbl_hoTen = new System.Windows.Forms.Label();
            this.lbl_soThuTu = new System.Windows.Forms.Label();
            this.typingTestDataSet = new Thithu.TypingTestDataSet();
            this.typingTestDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sessionTableAdapter = new Thithu.TypingTestDataSet1TableAdapters.SessionTableAdapter();
            this.txt_UserId = new System.Windows.Forms.TextBox();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SessionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SessionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typingTestDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typingTestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typingTestDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Đợt thi";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.sessionBindingSource;
            this.comboBox1.DisplayMember = "SessionName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(102, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(708, 28);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // sessionBindingSource
            // 
            this.sessionBindingSource.DataMember = "Session";
            this.sessionBindingSource.DataSource = this.typingTestDataSet1;
            // 
            // typingTestDataSet1
            // 
            this.typingTestDataSet1.DataSetName = "TypingTestDataSet1";
            this.typingTestDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.UserName,
            this.FullName,
            this.Birthday,
            this.SessionId,
            this.SessionName});
            this.dataGridView1.Location = new System.Drawing.Point(22, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(788, 820);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.txt_SessionName);
            this.groupBox1.Controls.Add(this.txt_SesionId);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.txt_hoten);
            this.groupBox1.Controls.Add(this.txt_maso);
            this.groupBox1.Controls.Add(this.lbl_ngaySinh);
            this.groupBox1.Controls.Add(this.lbl_hoTen);
            this.groupBox1.Controls.Add(this.lbl_soThuTu);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(826, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 419);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "SessionName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "SessionId:";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(432, 360);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(112, 41);
            this.btn_xoa.TabIndex = 12;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // txt_SessionName
            // 
            this.txt_SessionName.Location = new System.Drawing.Point(189, 262);
            this.txt_SessionName.Name = "txt_SessionName";
            this.txt_SessionName.Size = new System.Drawing.Size(165, 30);
            this.txt_SessionName.TabIndex = 15;
            // 
            // txt_SesionId
            // 
            this.txt_SesionId.Location = new System.Drawing.Point(189, 204);
            this.txt_SesionId.Name = "txt_SesionId";
            this.txt_SesionId.Size = new System.Drawing.Size(165, 30);
            this.txt_SesionId.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(189, 149);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(165, 30);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(259, 360);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(112, 41);
            this.btn_sua.TabIndex = 11;
            this.btn_sua.Text = "Thay đổi";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(189, 307);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 29);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Thêm mới";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(87, 360);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(112, 41);
            this.btn_them.TabIndex = 10;
            this.btn_them.Text = "Thêm mới";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(189, 95);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(403, 30);
            this.txt_hoten.TabIndex = 5;
            // 
            // txt_maso
            // 
            this.txt_maso.Location = new System.Drawing.Point(189, 45);
            this.txt_maso.Name = "txt_maso";
            this.txt_maso.Size = new System.Drawing.Size(403, 30);
            this.txt_maso.TabIndex = 4;
            // 
            // lbl_ngaySinh
            // 
            this.lbl_ngaySinh.AutoSize = true;
            this.lbl_ngaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngaySinh.Location = new System.Drawing.Point(40, 154);
            this.lbl_ngaySinh.Name = "lbl_ngaySinh";
            this.lbl_ngaySinh.Size = new System.Drawing.Size(119, 25);
            this.lbl_ngaySinh.TabIndex = 3;
            this.lbl_ngaySinh.Text = "Ngày Sinh:";
            // 
            // lbl_hoTen
            // 
            this.lbl_hoTen.AutoSize = true;
            this.lbl_hoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hoTen.Location = new System.Drawing.Point(40, 100);
            this.lbl_hoTen.Name = "lbl_hoTen";
            this.lbl_hoTen.Size = new System.Drawing.Size(119, 25);
            this.lbl_hoTen.TabIndex = 2;
            this.lbl_hoTen.Text = "Họ và Tên:";
            // 
            // lbl_soThuTu
            // 
            this.lbl_soThuTu.AutoSize = true;
            this.lbl_soThuTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_soThuTu.Location = new System.Drawing.Point(36, 50);
            this.lbl_soThuTu.Name = "lbl_soThuTu";
            this.lbl_soThuTu.Size = new System.Drawing.Size(122, 25);
            this.lbl_soThuTu.TabIndex = 1;
            this.lbl_soThuTu.Text = "Số Thứ Tự:";
            // 
            // typingTestDataSet
            // 
            this.typingTestDataSet.DataSetName = "TypingTestDataSet";
            this.typingTestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typingTestDataSetBindingSource
            // 
            this.typingTestDataSetBindingSource.DataSource = this.typingTestDataSet;
            this.typingTestDataSetBindingSource.Position = 0;
            // 
            // sessionTableAdapter
            // 
            this.sessionTableAdapter.ClearBeforeFill = true;
            // 
            // txt_UserId
            // 
            this.txt_UserId.Location = new System.Drawing.Point(826, 448);
            this.txt_UserId.Name = "txt_UserId";
            this.txt_UserId.Size = new System.Drawing.Size(100, 26);
            this.txt_UserId.TabIndex = 14;
            this.txt_UserId.Visible = false;
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "UserId";
            this.UserId.MinimumWidth = 8;
            this.UserId.Name = "UserId";
            this.UserId.Visible = false;
            this.UserId.Width = 150;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "Số Thứ Tự";
            this.UserName.MinimumWidth = 8;
            this.UserName.Name = "UserName";
            this.UserName.Width = 150;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Họ và Tên";
            this.FullName.MinimumWidth = 8;
            this.FullName.Name = "FullName";
            this.FullName.Width = 150;
            // 
            // Birthday
            // 
            this.Birthday.DataPropertyName = "Birthday";
            this.Birthday.HeaderText = "Ngày Sinh";
            this.Birthday.MinimumWidth = 8;
            this.Birthday.Name = "Birthday";
            this.Birthday.Width = 150;
            // 
            // SessionId
            // 
            this.SessionId.DataPropertyName = "SessionId";
            this.SessionId.HeaderText = "SessionId";
            this.SessionId.MinimumWidth = 8;
            this.SessionId.Name = "SessionId";
            this.SessionId.Width = 150;
            // 
            // SessionName
            // 
            this.SessionName.DataPropertyName = "SessionName";
            this.SessionName.HeaderText = "SessionName";
            this.SessionName.MinimumWidth = 8;
            this.SessionName.Name = "SessionName";
            this.SessionName.Width = 150;
            // 
            // Frm_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 889);
            this.Controls.Add(this.txt_UserId);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Frm_User";
            this.Text = "Quản Lý User";
            this.Load += new System.EventHandler(this.Frm_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typingTestDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typingTestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typingTestDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.TextBox txt_maso;
        private System.Windows.Forms.Label lbl_ngaySinh;
        private System.Windows.Forms.Label lbl_hoTen;
        private System.Windows.Forms.Label lbl_soThuTu;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource typingTestDataSetBindingSource;
        private TypingTestDataSet typingTestDataSet;
        private TypingTestDataSet1 typingTestDataSet1;
        private System.Windows.Forms.BindingSource sessionBindingSource;
        private TypingTestDataSet1TableAdapters.SessionTableAdapter sessionTableAdapter;
        private System.Windows.Forms.TextBox txt_SesionId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_SessionName;
        private System.Windows.Forms.TextBox txt_UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn SessionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SessionName;
    }
}