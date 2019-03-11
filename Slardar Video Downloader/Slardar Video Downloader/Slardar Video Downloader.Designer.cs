namespace Slardar_Video_Downloader
{
    partial class Slardar_Video_Downloader
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.addressPanel = new System.Windows.Forms.Panel();
            this.SniffComboBox = new System.Windows.Forms.ComboBox();
            this.SniffWebLable = new System.Windows.Forms.Label();
            this.muteCheckBox = new System.Windows.Forms.CheckBox();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.mainLayoutPanel = new System.Windows.Forms.Panel();
            this.addressPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addressPanel
            // 
            this.addressPanel.Controls.Add(this.SniffComboBox);
            this.addressPanel.Controls.Add(this.SniffWebLable);
            this.addressPanel.Controls.Add(this.muteCheckBox);
            this.addressPanel.Controls.Add(this.urlTextBox);
            this.addressPanel.Controls.Add(this.urlLabel);
            this.addressPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addressPanel.Location = new System.Drawing.Point(0, 0);
            this.addressPanel.Name = "addressPanel";
            this.addressPanel.Size = new System.Drawing.Size(1008, 82);
            this.addressPanel.TabIndex = 6;
            // 
            // SniffComboBox
            // 
            this.SniffComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SniffComboBox.FormattingEnabled = true;
            this.SniffComboBox.Items.AddRange(new object[] {
            "Youtube",
            "M3U8",
            "Media",
            "Universal"});
            this.SniffComboBox.Location = new System.Drawing.Point(136, 43);
            this.SniffComboBox.Name = "SniffComboBox";
            this.SniffComboBox.Size = new System.Drawing.Size(146, 29);
            this.SniffComboBox.TabIndex = 4;
            // 
            // SniffWebLable
            // 
            this.SniffWebLable.AutoSize = true;
            this.SniffWebLable.Location = new System.Drawing.Point(5, 46);
            this.SniffWebLable.Name = "SniffWebLable";
            this.SniffWebLable.Size = new System.Drawing.Size(125, 21);
            this.SniffWebLable.TabIndex = 3;
            this.SniffWebLable.Text = "Sniff Template:";
            // 
            // muteCheckBox
            // 
            this.muteCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.muteCheckBox.AutoSize = true;
            this.muteCheckBox.Checked = true;
            this.muteCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.muteCheckBox.Location = new System.Drawing.Point(288, 45);
            this.muteCheckBox.Name = "muteCheckBox";
            this.muteCheckBox.Size = new System.Drawing.Size(70, 25);
            this.muteCheckBox.TabIndex = 2;
            this.muteCheckBox.Text = "&Mute";
            this.muteCheckBox.UseVisualStyleBackColor = true;
            this.muteCheckBox.CheckedChanged += new System.EventHandler(this.MuteCheckBox_CheckedChanged);
            // 
            // urlTextBox
            // 
            this.urlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlTextBox.Location = new System.Drawing.Point(79, 6);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(917, 29);
            this.urlTextBox.TabIndex = 1;
            this.urlTextBox.Text = "https://www.slardar.net";
            this.urlTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.URLTextBox_KeyDown);
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.urlLabel.Location = new System.Drawing.Point(5, 9);
            this.urlLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(66, 21);
            this.urlLabel.TabIndex = 0;
            this.urlLabel.Text = "URL:(&D)";
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Location = new System.Drawing.Point(0, 82);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.Size = new System.Drawing.Size(1008, 647);
            this.mainLayoutPanel.TabIndex = 3;
            // 
            // Slardar_Video_Downloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.mainLayoutPanel);
            this.Controls.Add(this.addressPanel);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Slardar_Video_Downloader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slardar Video Downloader";
            this.Load += new System.EventHandler(this.Slardar_Video_Downloader_Load);
            this.addressPanel.ResumeLayout(false);
            this.addressPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addressPanel;
        private System.Windows.Forms.CheckBox muteCheckBox;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Panel mainLayoutPanel;
        private System.Windows.Forms.ComboBox SniffComboBox;
        private System.Windows.Forms.Label SniffWebLable;
    }
}

