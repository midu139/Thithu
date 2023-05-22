namespace Thithu
{
    partial class Frm_ThongKeKetQua
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
            this.typingTestDataSet = new Thithu.TypingTestDataSet();
            this.btn_rp = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextDisplay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Đạt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorrectNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InCorrectNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTuHienThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SessionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionTableAdapter = new Thithu.TypingTestDataSetTableAdapters.SessionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typingTestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
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
            this.comboBox1.Location = new System.Drawing.Point(92, 6);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(339, 28);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // sessionBindingSource
            // 
            this.sessionBindingSource.DataMember = "Session";
            this.sessionBindingSource.DataSource = this.typingTestDataSet;
            // 
            // typingTestDataSet
            // 
            this.typingTestDataSet.DataSetName = "TypingTestDataSet";
            this.typingTestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_rp
            // 
            this.btn_rp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rp.Location = new System.Drawing.Point(1290, 2);
            this.btn_rp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_rp.Name = "btn_rp";
            this.btn_rp.Size = new System.Drawing.Size(115, 38);
            this.btn_rp.TabIndex = 18;
            this.btn_rp.Text = "Report";
            this.btn_rp.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.FullName,
            this.Birthday,
            this.TextDisplay,
            this.Đạt,
            this.CorrectNo,
            this.InCorrectNo,
            this.SoTuHienThi,
            this.SessionId});
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1393, 553);
            this.dataGridView1.TabIndex = 20;
            // 
            // UserName
            // 
            this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.UserName.DataPropertyName = "UserName";
            this.UserName.FillWeight = 303.719F;
            this.UserName.HeaderText = "Số Thứ Tự";
            this.UserName.MinimumWidth = 8;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 118;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.FillWeight = 20.24793F;
            this.FullName.HeaderText = "Họ và Tên";
            this.FullName.MinimumWidth = 8;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Birthday
            // 
            this.Birthday.DataPropertyName = "Birthday";
            this.Birthday.FillWeight = 20.24793F;
            this.Birthday.HeaderText = "Ngày Sinh";
            this.Birthday.MinimumWidth = 8;
            this.Birthday.Name = "Birthday";
            this.Birthday.ReadOnly = true;
            // 
            // TextDisplay
            // 
            this.TextDisplay.DataPropertyName = "TextDisplay";
            this.TextDisplay.HeaderText = "TextDisplay";
            this.TextDisplay.MinimumWidth = 8;
            this.TextDisplay.Name = "TextDisplay";
            this.TextDisplay.ReadOnly = true;
            this.TextDisplay.Visible = false;
            // 
            // Đạt
            // 
            this.Đạt.DataPropertyName = "Đạt";
            this.Đạt.FillWeight = 20.24793F;
            this.Đạt.HeaderText = "Đạt(%)";
            this.Đạt.MinimumWidth = 8;
            this.Đạt.Name = "Đạt";
            this.Đạt.ReadOnly = true;
            // 
            // CorrectNo
            // 
            this.CorrectNo.DataPropertyName = "CorrectNo";
            this.CorrectNo.FillWeight = 20.24793F;
            this.CorrectNo.HeaderText = "Số Từ Đúng";
            this.CorrectNo.MinimumWidth = 8;
            this.CorrectNo.Name = "CorrectNo";
            this.CorrectNo.ReadOnly = true;
            // 
            // InCorrectNo
            // 
            this.InCorrectNo.DataPropertyName = "InCorrectNo";
            this.InCorrectNo.FillWeight = 20.24793F;
            this.InCorrectNo.HeaderText = "Số Từ Sai";
            this.InCorrectNo.MinimumWidth = 8;
            this.InCorrectNo.Name = "InCorrectNo";
            this.InCorrectNo.ReadOnly = true;
            // 
            // SoTuHienThi
            // 
            this.SoTuHienThi.DataPropertyName = "SoTuHienThi";
            this.SoTuHienThi.FillWeight = 20.24793F;
            this.SoTuHienThi.HeaderText = "Số Từ Hiển Thi";
            this.SoTuHienThi.MinimumWidth = 8;
            this.SoTuHienThi.Name = "SoTuHienThi";
            this.SoTuHienThi.ReadOnly = true;
            // 
            // SessionId
            // 
            this.SessionId.DataPropertyName = "SessionId";
            this.SessionId.FillWeight = 20.24793F;
            this.SessionId.HeaderText = "SessionId";
            this.SessionId.MinimumWidth = 8;
            this.SessionId.Name = "SessionId";
            this.SessionId.ReadOnly = true;
            // 
            // sessionTableAdapter
            // 
            this.sessionTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_ThongKeKetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 621);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_rp);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Frm_ThongKeKetQua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê Kết Quả";
            this.Load += new System.EventHandler(this.Frm_ThongKeKetQua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typingTestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_rp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn TextDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Đạt;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorrectNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn InCorrectNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTuHienThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SessionId;
        private TypingTestDataSet typingTestDataSet;
        private System.Windows.Forms.BindingSource sessionBindingSource;
        private TypingTestDataSetTableAdapters.SessionTableAdapter sessionTableAdapter;
    }
}