namespace MayHoc
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPreference = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHuongDan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIntroduce = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.formButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnExportWav = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.chkVietnamese = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.formButtons.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.menuOptions,
            this.mnuInfo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(742, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSave,
            this.mnuOpen,
            this.toolStripSeparator1,
            this.mnuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuSave
            // 
            this.mnuSave.Image = ((System.Drawing.Image)(resources.GetObject("mnuSave.Image")));
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(125, 22);
            this.mnuSave.Text = "Lưu lại";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuOpen
            // 
            this.mnuOpen.Image = ((System.Drawing.Image)(resources.GetObject("mnuOpen.Image")));
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(125, 22);
            this.mnuOpen.Text = "Nhập vào";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(122, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Image = ((System.Drawing.Image)(resources.GetObject("mnuExit.Image")));
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(125, 22);
            this.mnuExit.Text = "Thoát";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // menuOptions
            // 
            this.menuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPreference});
            this.menuOptions.Name = "menuOptions";
            this.menuOptions.Size = new System.Drawing.Size(65, 20);
            this.menuOptions.Text = "Thiết lập";
            // 
            // mnuPreference
            // 
            this.mnuPreference.Image = ((System.Drawing.Image)(resources.GetObject("mnuPreference.Image")));
            this.mnuPreference.Name = "mnuPreference";
            this.mnuPreference.Size = new System.Drawing.Size(157, 22);
            this.mnuPreference.Text = "Thiết lập chung";
            this.mnuPreference.Click += new System.EventHandler(this.mnuPreference_Click);
            // 
            // mnuInfo
            // 
            this.mnuInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHuongDan,
            this.mnuIntroduce});
            this.mnuInfo.Name = "mnuInfo";
            this.mnuInfo.Size = new System.Drawing.Size(71, 20);
            this.mnuInfo.Text = "Thông tin";
            // 
            // mnuHuongDan
            // 
            this.mnuHuongDan.Image = ((System.Drawing.Image)(resources.GetObject("mnuHuongDan.Image")));
            this.mnuHuongDan.Name = "mnuHuongDan";
            this.mnuHuongDan.Size = new System.Drawing.Size(186, 22);
            this.mnuHuongDan.Text = "Hướng dẫn sử dụng";
            this.mnuHuongDan.Click += new System.EventHandler(this.mnuHuongDan_Click);
            // 
            // mnuIntroduce
            // 
            this.mnuIntroduce.Image = ((System.Drawing.Image)(resources.GetObject("mnuIntroduce.Image")));
            this.mnuIntroduce.Name = "mnuIntroduce";
            this.mnuIntroduce.Size = new System.Drawing.Size(186, 22);
            this.mnuIntroduce.Text = "Giới thiệu phần mềm";
            this.mnuIntroduce.Click += new System.EventHandler(this.mnuIntroduce_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtContent);
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 476);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nội dung";
            // 
            // txtContent
            // 
            this.txtContent.AcceptsReturn = true;
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContent.Location = new System.Drawing.Point(3, 16);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtContent.Size = new System.Drawing.Size(711, 457);
            this.txtContent.TabIndex = 0;
            this.txtContent.Text = "Đồ án Máy học:\r\nNhận dạng từ văn bản sang tiếng nói\r\nSinh Viên Thực hiện: Ngô Xuâ" +
    "n Bách, Trần Anh Đức\r\nGiảng viên hướng dẫn: Tiến sĩ Nguyễn Thị Thu Hà\r\n";
            // 
            // formButtons
            // 
            this.formButtons.ColumnCount = 4;
            this.formButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.formButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.formButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.formButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.formButtons.Controls.Add(this.btnExportWav, 3, 0);
            this.formButtons.Controls.Add(this.btnStop, 2, 0);
            this.formButtons.Controls.Add(this.btnPause, 1, 0);
            this.formButtons.Controls.Add(this.btnPlay, 0, 0);
            this.formButtons.Location = new System.Drawing.Point(16, 510);
            this.formButtons.Name = "formButtons";
            this.formButtons.RowCount = 1;
            this.formButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.formButtons.Size = new System.Drawing.Size(503, 58);
            this.formButtons.TabIndex = 2;
            // 
            // btnExportWav
            // 
            this.btnExportWav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExportWav.Image = ((System.Drawing.Image)(resources.GetObject("btnExportWav.Image")));
            this.btnExportWav.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportWav.Location = new System.Drawing.Point(376, 1);
            this.btnExportWav.Margin = new System.Windows.Forms.Padding(1);
            this.btnExportWav.Name = "btnExportWav";
            this.btnExportWav.Size = new System.Drawing.Size(126, 56);
            this.btnExportWav.TabIndex = 3;
            this.btnExportWav.Text = "Xuất ra .WAV";
            this.btnExportWav.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportWav.UseVisualStyleBackColor = true;
            this.btnExportWav.Click += new System.EventHandler(this.btnExportWav_Click);
            // 
            // btnStop
            // 
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStop.Location = new System.Drawing.Point(251, 1);
            this.btnStop.Margin = new System.Windows.Forms.Padding(1);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(123, 56);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Dừng";
            this.btnStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPause.Image")));
            this.btnPause.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPause.Location = new System.Drawing.Point(126, 1);
            this.btnPause.Margin = new System.Windows.Forms.Padding(1);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(123, 56);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = "Dừng/Tiếp tục";
            this.btnPause.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlay.Location = new System.Drawing.Point(1, 1);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(1);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(123, 56);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Phát âm";
            this.btnPlay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 577);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(742, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(35, 17);
            this.statusLabel.Text = "Hello";
            // 
            // chkVietnamese
            // 
            this.chkVietnamese.AutoSize = true;
            this.chkVietnamese.Checked = true;
            this.chkVietnamese.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVietnamese.Location = new System.Drawing.Point(526, 549);
            this.chkVietnamese.Name = "chkVietnamese";
            this.chkVietnamese.Size = new System.Drawing.Size(80, 17);
            this.chkVietnamese.TabIndex = 4;
            this.chkVietnamese.Text = "Tiếng Việt?";
            this.chkVietnamese.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 599);
            this.Controls.Add(this.chkVietnamese);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.formButtons);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Máy Học: Nhận dạng từ văn bản sang tiếng nói :: Ngô Xuân Bách - Trần Anh Đức";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.formButtons.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem menuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuPreference;
        private System.Windows.Forms.ToolStripMenuItem mnuInfo;
        private System.Windows.Forms.ToolStripMenuItem mnuHuongDan;
        private System.Windows.Forms.ToolStripMenuItem mnuIntroduce;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TableLayoutPanel formButtons;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnExportWav;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.CheckBox chkVietnamese;


    }
}

