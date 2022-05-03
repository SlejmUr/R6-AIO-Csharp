﻿
namespace AIO_Tools.Forms
{
    partial class allmanifest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(allmanifest));
            this.comboBox1 = new AltUI.Controls.DarkComboBox();
            this.comboBox2 = new AltUI.Controls.DarkComboBox();
            this.label1 = new AltUI.Controls.DarkLabel();
            this.label2 = new AltUI.Controls.DarkLabel();
            this.label3 = new AltUI.Controls.DarkLabel();
            this.DownloadNow = new AltUI.Controls.DarkButton();
            this.CloseButton = new AltUI.Controls.DarkButton();
            this.versiondate_label = new AltUI.Controls.DarkLabel();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownHeight = 86;
            this.comboBox1.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.comboBox1.AutoExpanding = true;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Location = new System.Drawing.Point(30, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.SelectedName_Changed);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownHeight = 63;
            this.comboBox2.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.comboBox2.AutoExpanding = true;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.IntegralHeight = false;
            this.comboBox2.Location = new System.Drawing.Point(31, 130);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(144, 23);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.SelectedManifest_Changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.label2.Location = new System.Drawing.Point(30, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Manifest";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.label3.Location = new System.Drawing.Point(212, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 150);
            this.label3.TabIndex = 6;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // DownloadNow
            // 
            this.DownloadNow.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadNow.Location = new System.Drawing.Point(31, 212);
            this.DownloadNow.Name = "DownloadNow";
            this.DownloadNow.Size = new System.Drawing.Size(78, 25);
            this.DownloadNow.TabIndex = 64;
            this.DownloadNow.Text = "Download";
            this.DownloadNow.Click += new System.EventHandler(this.Download_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(115, 212);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(60, 25);
            this.CloseButton.TabIndex = 65;
            this.CloseButton.Text = "Close";
            this.CloseButton.Click += new System.EventHandler(this.Close_Click);
            // 
            // versiondate_label
            // 
            this.versiondate_label.AutoSize = true;
            this.versiondate_label.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.versiondate_label.Location = new System.Drawing.Point(212, 212);
            this.versiondate_label.Name = "versiondate_label";
            this.versiondate_label.Size = new System.Drawing.Size(203, 15);
            this.versiondate_label.TabIndex = 66;
            this.versiondate_label.Text = "Placeholder: V168132516 | 2092-03-25";
            // 
            // allmanifest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(529, 251);
            this.Controls.Add(this.versiondate_label);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.DownloadNow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "allmanifest";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Manifest";
            this.Load += new System.EventHandler(this.AllManifest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AltUI.Controls.DarkComboBox comboBox1;
        private AltUI.Controls.DarkComboBox comboBox2;
        private AltUI.Controls.DarkLabel label1;
        private AltUI.Controls.DarkLabel label2;
        private AltUI.Controls.DarkLabel label3;
        private AltUI.Controls.DarkButton DownloadNow;
        private AltUI.Controls.DarkButton CloseButton;
        private AltUI.Controls.DarkLabel versiondate_label;
    }
}