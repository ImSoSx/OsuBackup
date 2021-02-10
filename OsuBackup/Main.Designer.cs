
namespace OsuBackup
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.gameLocation_txbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backupGame_btn = new System.Windows.Forms.Button();
            this.backupData_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataLocation_txbx = new System.Windows.Forms.TextBox();
            this.gameLocation_btn = new System.Windows.Forms.Button();
            this.dataLocation_btn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.autoBackup_btn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.restoreGame_btn = new System.Windows.Forms.Button();
            this.restoreData_btn = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // gameLocation_txbx
            // 
            this.gameLocation_txbx.Location = new System.Drawing.Point(147, 35);
            this.gameLocation_txbx.Name = "gameLocation_txbx";
            this.gameLocation_txbx.Size = new System.Drawing.Size(284, 20);
            this.gameLocation_txbx.TabIndex = 1;
            this.gameLocation_txbx.Text = "Write manually or double click to open folder selector";
            this.gameLocation_txbx.TextChanged += new System.EventHandler(this.gameLocation_txbx_TextChanged);
            this.gameLocation_txbx.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gameLocation_txbx_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // backupGame_btn
            // 
            this.backupGame_btn.Location = new System.Drawing.Point(147, 131);
            this.backupGame_btn.Name = "backupGame_btn";
            this.backupGame_btn.Size = new System.Drawing.Size(110, 23);
            this.backupGame_btn.TabIndex = 3;
            this.backupGame_btn.Text = "Backup Game Only";
            this.backupGame_btn.UseVisualStyleBackColor = true;
            this.backupGame_btn.Click += new System.EventHandler(this.backupGame_btn_Click);
            // 
            // backupData_btn
            // 
            this.backupData_btn.Location = new System.Drawing.Point(398, 131);
            this.backupData_btn.Name = "backupData_btn";
            this.backupData_btn.Size = new System.Drawing.Size(114, 23);
            this.backupData_btn.TabIndex = 4;
            this.backupData_btn.Text = "Backup Data Only";
            this.backupData_btn.UseVisualStyleBackColor = true;
            this.backupData_btn.Click += new System.EventHandler(this.backupData_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // dataLocation_txbx
            // 
            this.dataLocation_txbx.Location = new System.Drawing.Point(147, 81);
            this.dataLocation_txbx.Name = "dataLocation_txbx";
            this.dataLocation_txbx.Size = new System.Drawing.Size(284, 20);
            this.dataLocation_txbx.TabIndex = 7;
            this.dataLocation_txbx.Text = "Write manually or double click to open folder selector";
            this.dataLocation_txbx.TextChanged += new System.EventHandler(this.dataLocation_txbx_TextChanged);
            this.dataLocation_txbx.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataLocation_txbx_MouseDoubleClick);
            // 
            // gameLocation_btn
            // 
            this.gameLocation_btn.Location = new System.Drawing.Point(437, 32);
            this.gameLocation_btn.Name = "gameLocation_btn";
            this.gameLocation_btn.Size = new System.Drawing.Size(75, 23);
            this.gameLocation_btn.TabIndex = 8;
            this.gameLocation_btn.Text = "Save";
            this.gameLocation_btn.UseVisualStyleBackColor = true;
            this.gameLocation_btn.Click += new System.EventHandler(this.gameLocation_btn_Click);
            // 
            // dataLocation_btn
            // 
            this.dataLocation_btn.Location = new System.Drawing.Point(437, 79);
            this.dataLocation_btn.Name = "dataLocation_btn";
            this.dataLocation_btn.Size = new System.Drawing.Size(75, 23);
            this.dataLocation_btn.TabIndex = 9;
            this.dataLocation_btn.Text = "Save";
            this.dataLocation_btn.UseVisualStyleBackColor = true;
            this.dataLocation_btn.Click += new System.EventHandler(this.dataLocation_btn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(147, 226);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(365, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // autoBackup_btn
            // 
            this.autoBackup_btn.Location = new System.Drawing.Point(285, 131);
            this.autoBackup_btn.Name = "autoBackup_btn";
            this.autoBackup_btn.Size = new System.Drawing.Size(87, 23);
            this.autoBackup_btn.TabIndex = 12;
            this.autoBackup_btn.Text = "Auto Backup";
            this.autoBackup_btn.UseVisualStyleBackColor = true;
            this.autoBackup_btn.Click += new System.EventHandler(this.autoBackup_btn_Click);
            // 
            // restoreGame_btn
            // 
            this.restoreGame_btn.Location = new System.Drawing.Point(147, 181);
            this.restoreGame_btn.Name = "restoreGame_btn";
            this.restoreGame_btn.Size = new System.Drawing.Size(110, 23);
            this.restoreGame_btn.TabIndex = 13;
            this.restoreGame_btn.Text = "Restore game";
            this.restoreGame_btn.UseVisualStyleBackColor = true;
            this.restoreGame_btn.Click += new System.EventHandler(this.restoreGame_btn_Click);
            // 
            // restoreData_btn
            // 
            this.restoreData_btn.Location = new System.Drawing.Point(398, 181);
            this.restoreData_btn.Name = "restoreData_btn";
            this.restoreData_btn.Size = new System.Drawing.Size(114, 23);
            this.restoreData_btn.TabIndex = 14;
            this.restoreData_btn.Text = "Restore Data";
            this.restoreData_btn.UseVisualStyleBackColor = true;
            this.restoreData_btn.Click += new System.EventHandler(this.restoreData_btn_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(27, 226);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(58, 13);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Tag = "https://github.com/ImSoSx";
            this.linkLabel1.Text = "By ImSoSx";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 261);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.restoreData_btn);
            this.Controls.Add(this.restoreGame_btn);
            this.Controls.Add(this.autoBackup_btn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.dataLocation_btn);
            this.Controls.Add(this.gameLocation_btn);
            this.Controls.Add(this.dataLocation_txbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backupData_btn);
            this.Controls.Add(this.backupGame_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameLocation_txbx);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(650, 300);
            this.MinimumSize = new System.Drawing.Size(650, 300);
            this.Name = "Main";
            this.Text = "osu!Lazer backup and restore - by ImSoSx (v.0.1)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox gameLocation_txbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backupGame_btn;
        private System.Windows.Forms.Button backupData_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dataLocation_txbx;
        private System.Windows.Forms.Button gameLocation_btn;
        private System.Windows.Forms.Button dataLocation_btn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button autoBackup_btn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button restoreGame_btn;
        private System.Windows.Forms.Button restoreData_btn;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}