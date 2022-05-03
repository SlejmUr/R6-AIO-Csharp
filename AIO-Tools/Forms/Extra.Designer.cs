namespace AIO_Tools.Forms
{
    partial class Extra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.ExtraLang = new AltUI.Controls.DarkComboBox();
            this.label1 = new AltUI.Controls.DarkLabel();
            this.comboBox3 = new AltUI.Controls.DarkComboBox();
            this.comboBox2 = new AltUI.Controls.DarkComboBox();
            this.label2 = new AltUI.Controls.DarkLabel();
            this.label3 = new AltUI.Controls.DarkLabel();
            this.CloseButton = new AltUI.Controls.DarkButton();
            this.DownloadNow = new AltUI.Controls.DarkButton();
            this.SuspendLayout();
            // 
            // ExtraLang
            // 
            this.ExtraLang.DropDownHeight = 86;
            this.ExtraLang.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.ExtraLang.FormattingEnabled = true;
            this.ExtraLang.IntegralHeight = false;
            this.ExtraLang.Items.AddRange(new object[] {
            "French",
            "Italian",
            "German",
            "Spanish",
            "Brasilian",
            "Polish",
            "Dutch",
            "Czech",
            "Korean",
            "TChinese",
            "SChinese",
            "Japanese",
            "Russian",
            "HighRes Texture"});
            this.ExtraLang.Location = new System.Drawing.Point(10, 35);
            this.ExtraLang.Name = "ExtraLang";
            this.ExtraLang.Size = new System.Drawing.Size(144, 23);
            this.ExtraLang.TabIndex = 0;
            this.ExtraLang.SelectedIndexChanged += new System.EventHandler(this.ExtraLang_Changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Extra";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownHeight = 66;
            this.comboBox3.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.IntegralHeight = false;
            this.comboBox3.Location = new System.Drawing.Point(10, 145);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(144, 23);
            this.comboBox3.TabIndex = 2;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.SeasonSelect_Change);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownHeight = 66;
            this.comboBox2.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.IntegralHeight = false;
            this.comboBox2.Location = new System.Drawing.Point(10, 90);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(144, 23);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.Year_Changed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.label2.Location = new System.Drawing.Point(10, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Season";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.label3.Location = new System.Drawing.Point(10, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select Year";
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(97, 200);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(60, 25);
            this.CloseButton.TabIndex = 62;
            this.CloseButton.Text = "Close";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // DownloadNow
            // 
            this.DownloadNow.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadNow.Location = new System.Drawing.Point(12, 200);
            this.DownloadNow.Name = "DownloadNow";
            this.DownloadNow.Size = new System.Drawing.Size(78, 25);
            this.DownloadNow.TabIndex = 63;
            this.DownloadNow.Text = "Download";
            this.DownloadNow.Click += new System.EventHandler(this.DownloadNow_Click);
            // 
            // Extra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(169, 261);
            this.Controls.Add(this.DownloadNow);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExtraLang);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Extra";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extra";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Extra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AltUI.Controls.DarkComboBox ExtraLang;
        private AltUI.Controls.DarkLabel label1;
        private AltUI.Controls.DarkComboBox comboBox3;
        private AltUI.Controls.DarkComboBox comboBox2;
        private AltUI.Controls.DarkLabel label2;
        private AltUI.Controls.DarkLabel label3;
        private AltUI.Controls.DarkButton CloseButton;
        private AltUI.Controls.DarkButton DownloadNow;
    }
}