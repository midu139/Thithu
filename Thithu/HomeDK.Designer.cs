namespace Thithu
{
    partial class Frm_HomeDK
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thayĐổiThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiểmTraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpUserKhácToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thayĐổiThôngTinToolStripMenuItem,
            this.kiểmTraToolStripMenuItem,
            this.đăngNhậpUserKhácToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1352, 34);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thayĐổiThôngTinToolStripMenuItem
            // 
            this.thayĐổiThôngTinToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thayĐổiThôngTinToolStripMenuItem.Name = "thayĐổiThôngTinToolStripMenuItem";
            this.thayĐổiThôngTinToolStripMenuItem.Size = new System.Drawing.Size(234, 30);
            this.thayĐổiThôngTinToolStripMenuItem.Text = "Thay Đổi Thông Tin";
            this.thayĐổiThôngTinToolStripMenuItem.Click += new System.EventHandler(this.thayĐổiThôngTinToolStripMenuItem_Click);
            // 
            // kiểmTraToolStripMenuItem
            // 
            this.kiểmTraToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kiểmTraToolStripMenuItem.Name = "kiểmTraToolStripMenuItem";
            this.kiểmTraToolStripMenuItem.Size = new System.Drawing.Size(126, 30);
            this.kiểmTraToolStripMenuItem.Text = "Kiểm Tra";
            this.kiểmTraToolStripMenuItem.Click += new System.EventHandler(this.kiểmTraToolStripMenuItem_Click);
            // 
            // đăngNhậpUserKhácToolStripMenuItem
            // 
            this.đăngNhậpUserKhácToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.đăngNhậpUserKhácToolStripMenuItem.Name = "đăngNhậpUserKhácToolStripMenuItem";
            this.đăngNhậpUserKhácToolStripMenuItem.Size = new System.Drawing.Size(258, 30);
            this.đăngNhậpUserKhácToolStripMenuItem.Text = "Đăng Nhập User Khác";
            this.đăngNhậpUserKhácToolStripMenuItem.Click += new System.EventHandler(this.đăngNhậpUserKhácToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(88, 30);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // Frm_HomeDK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 838);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_HomeDK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Đăng Ký";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thayĐổiThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiểmTraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpUserKhácToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}