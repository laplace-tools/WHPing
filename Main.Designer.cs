namespace WHPing
{
    partial class Main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.WebhookTestButton = new System.Windows.Forms.Button();
            this.Ipv4 = new System.Windows.Forms.TextBox();
            this.Ipv4Label = new System.Windows.Forms.Label();
            this.CycleLabel = new System.Windows.Forms.Label();
            this.CycleComboBox = new System.Windows.Forms.ComboBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.PingTestButton = new System.Windows.Forms.Button();
            this.PingTestLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WebhookTestButton
            // 
            this.WebhookTestButton.Location = new System.Drawing.Point(191, 3);
            this.WebhookTestButton.Name = "WebhookTestButton";
            this.WebhookTestButton.Size = new System.Drawing.Size(86, 23);
            this.WebhookTestButton.TabIndex = 0;
            this.WebhookTestButton.Text = "Webhookテスト";
            this.WebhookTestButton.UseVisualStyleBackColor = true;
            this.WebhookTestButton.Click += new System.EventHandler(this.WebhookTestButton_Click);
            // 
            // Ipv4
            // 
            this.Ipv4.Location = new System.Drawing.Point(73, 137);
            this.Ipv4.Name = "Ipv4";
            this.Ipv4.Size = new System.Drawing.Size(100, 19);
            this.Ipv4.TabIndex = 1;
            // 
            // Ipv4Label
            // 
            this.Ipv4Label.AutoSize = true;
            this.Ipv4Label.Location = new System.Drawing.Point(13, 140);
            this.Ipv4Label.Name = "Ipv4Label";
            this.Ipv4Label.Size = new System.Drawing.Size(51, 12);
            this.Ipv4Label.TabIndex = 2;
            this.Ipv4Label.Text = "IPアドレス";
            // 
            // CycleLabel
            // 
            this.CycleLabel.AutoSize = true;
            this.CycleLabel.Location = new System.Drawing.Point(13, 179);
            this.CycleLabel.Name = "CycleLabel";
            this.CycleLabel.Size = new System.Drawing.Size(53, 12);
            this.CycleLabel.TabIndex = 3;
            this.CycleLabel.Text = "監視周期";
            // 
            // CycleComboBox
            // 
            this.CycleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CycleComboBox.FormattingEnabled = true;
            this.CycleComboBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.CycleComboBox.Items.AddRange(new object[] {
            "1分",
            "10分",
            "60分",
            "24時間"});
            this.CycleComboBox.Location = new System.Drawing.Point(73, 176);
            this.CycleComboBox.Name = "CycleComboBox";
            this.CycleComboBox.Size = new System.Drawing.Size(100, 20);
            this.CycleComboBox.TabIndex = 4;
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StartButton.Location = new System.Drawing.Point(15, 33);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(111, 34);
            this.StartButton.TabIndex = 5;
            this.StartButton.Text = "監視開始";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Enabled = false;
            this.StopButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StopButton.Location = new System.Drawing.Point(15, 83);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(111, 34);
            this.StopButton.TabIndex = 6;
            this.StopButton.Text = "監視停止";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.StatusTextBox.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StatusTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.StatusTextBox.Location = new System.Drawing.Point(156, 95);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.ReadOnly = true;
            this.StatusTextBox.Size = new System.Drawing.Size(100, 22);
            this.StatusTextBox.TabIndex = 7;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(154, 80);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(53, 12);
            this.StatusLabel.TabIndex = 8;
            this.StatusLabel.Text = "稼働状態";
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // PingTestButton
            // 
            this.PingTestButton.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PingTestButton.Location = new System.Drawing.Point(181, 137);
            this.PingTestButton.Name = "PingTestButton";
            this.PingTestButton.Size = new System.Drawing.Size(51, 19);
            this.PingTestButton.TabIndex = 9;
            this.PingTestButton.Text = "Ping";
            this.PingTestButton.UseVisualStyleBackColor = true;
            this.PingTestButton.Click += new System.EventHandler(this.PingTestButton_Click);
            // 
            // PingTestLabel
            // 
            this.PingTestLabel.AutoSize = true;
            this.PingTestLabel.Location = new System.Drawing.Point(238, 140);
            this.PingTestLabel.Name = "PingTestLabel";
            this.PingTestLabel.Size = new System.Drawing.Size(0, 12);
            this.PingTestLabel.TabIndex = 10;
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(3, 3);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(0, 12);
            this.VersionLabel.TabIndex = 11;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 221);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.PingTestLabel);
            this.Controls.Add(this.PingTestButton);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.StatusTextBox);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.CycleComboBox);
            this.Controls.Add(this.CycleLabel);
            this.Controls.Add(this.Ipv4Label);
            this.Controls.Add(this.Ipv4);
            this.Controls.Add(this.WebhookTestButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "サーバー監視ツール";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WebhookTestButton;
        private System.Windows.Forms.TextBox Ipv4;
        private System.Windows.Forms.Label Ipv4Label;
        private System.Windows.Forms.Label CycleLabel;
        private System.Windows.Forms.ComboBox CycleComboBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.TextBox StatusTextBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button PingTestButton;
        private System.Windows.Forms.Label PingTestLabel;
        private System.Windows.Forms.Label VersionLabel;
    }
}

