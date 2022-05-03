
namespace AIO_Tools.Forms
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.NameBox = new AltUI.Controls.DarkTextBox();
            this.SetUserName = new AltUI.Controls.DarkButton();
            this.SteamName_Label = new AltUI.Controls.DarkLabel();
            this.All_Manifest = new AltUI.Controls.DarkButton();
            this.Compressed_INFO = new AltUI.Controls.DarkButton();
            this.StreamingInstall_Button = new AltUI.Controls.DarkButton();
            this.NotesButton = new AltUI.Controls.DarkButton();
            this.PlazaGet_Button = new AltUI.Controls.DarkButton();
            this.faqButton = new AltUI.Controls.DarkButton();
            this.ExtraButton = new AltUI.Controls.DarkButton();
            this.CheckBox_Fast = new AltUI.Controls.DarkCheckBox();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.NameBox.Location = new System.Drawing.Point(30, 34);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(155, 22);
            this.NameBox.TabIndex = 63;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // SetUserName
            // 
            this.SetUserName.DrawBackground = true;
            this.SetUserName.Location = new System.Drawing.Point(191, 32);
            this.SetUserName.Name = "SetUserName";
            this.SetUserName.Padding = new System.Windows.Forms.Padding(5);
            this.SetUserName.Size = new System.Drawing.Size(120, 25);
            this.SetUserName.TabIndex = 64;
            this.SetUserName.Text = "Set UserName";
            this.SetUserName.Click += new System.EventHandler(this.ValidateName);
            // 
            // SteamName_Label
            // 
            this.SteamName_Label.AutoSize = true;
            this.SteamName_Label.BackColor = System.Drawing.Color.Transparent;
            this.SteamName_Label.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SteamName_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.SteamName_Label.Location = new System.Drawing.Point(30, 10);
            this.SteamName_Label.Name = "SteamName_Label";
            this.SteamName_Label.Size = new System.Drawing.Size(107, 13);
            this.SteamName_Label.TabIndex = 65;
            this.SteamName_Label.Text = "Steam legacy name:";
            // 
            // All_Manifest
            // 
            this.All_Manifest.DrawBackground = true;
            this.All_Manifest.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.All_Manifest.Location = new System.Drawing.Point(30, 145);
            this.All_Manifest.Name = "All_Manifest";
            this.All_Manifest.Padding = new System.Windows.Forms.Padding(5);
            this.All_Manifest.Size = new System.Drawing.Size(155, 25);
            this.All_Manifest.TabIndex = 79;
            this.All_Manifest.Text = "All Manifest";
            this.All_Manifest.Click += new System.EventHandler(this.All_Manifest_Click);
            // 
            // Compressed_INFO
            // 
            this.Compressed_INFO.DrawBackground = true;
            this.Compressed_INFO.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Compressed_INFO.Location = new System.Drawing.Point(30, 85);
            this.Compressed_INFO.Name = "Compressed_INFO";
            this.Compressed_INFO.Padding = new System.Windows.Forms.Padding(5);
            this.Compressed_INFO.Size = new System.Drawing.Size(155, 25);
            this.Compressed_INFO.TabIndex = 76;
            this.Compressed_INFO.Text = "More Info";
            this.Compressed_INFO.Click += new System.EventHandler(this.MoveCompInfo);
            // 
            // StreamingInstall_Button
            // 
            this.StreamingInstall_Button.DrawBackground = true;
            this.StreamingInstall_Button.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreamingInstall_Button.Location = new System.Drawing.Point(190, 85);
            this.StreamingInstall_Button.Name = "StreamingInstall_Button";
            this.StreamingInstall_Button.Padding = new System.Windows.Forms.Padding(5);
            this.StreamingInstall_Button.Size = new System.Drawing.Size(120, 55);
            this.StreamingInstall_Button.TabIndex = 75;
            this.StreamingInstall_Button.Text = "Download\r\nStreaming Install";
            this.StreamingInstall_Button.Click += new System.EventHandler(this.DownStreaming_Click);
            // 
            // NotesButton
            // 
            this.NotesButton.DrawBackground = true;
            this.NotesButton.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesButton.Location = new System.Drawing.Point(30, 175);
            this.NotesButton.Name = "NotesButton";
            this.NotesButton.Padding = new System.Windows.Forms.Padding(5);
            this.NotesButton.Size = new System.Drawing.Size(75, 25);
            this.NotesButton.TabIndex = 74;
            this.NotesButton.Text = "Notes";
            this.NotesButton.Click += new System.EventHandler(this.MoveNotes);
            // 
            // PlazaGet_Button
            // 
            this.PlazaGet_Button.DrawBackground = true;
            this.PlazaGet_Button.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlazaGet_Button.Location = new System.Drawing.Point(190, 145);
            this.PlazaGet_Button.Name = "PlazaGet_Button";
            this.PlazaGet_Button.Padding = new System.Windows.Forms.Padding(5);
            this.PlazaGet_Button.Size = new System.Drawing.Size(120, 25);
            this.PlazaGet_Button.TabIndex = 73;
            this.PlazaGet_Button.Text = "Download Plaza";
            this.PlazaGet_Button.Click += new System.EventHandler(this.Down_Crack);
            // 
            // faqButton
            // 
            this.faqButton.DrawBackground = true;
            this.faqButton.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faqButton.Location = new System.Drawing.Point(30, 115);
            this.faqButton.Name = "faqButton";
            this.faqButton.Padding = new System.Windows.Forms.Padding(5);
            this.faqButton.Size = new System.Drawing.Size(155, 25);
            this.faqButton.TabIndex = 72;
            this.faqButton.Text = "FAQ and Information";
            this.faqButton.Click += new System.EventHandler(this.FAQ_Click);
            // 
            // ExtraButton
            // 
            this.ExtraButton.DrawBackground = true;
            this.ExtraButton.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtraButton.Location = new System.Drawing.Point(110, 175);
            this.ExtraButton.Name = "ExtraButton";
            this.ExtraButton.Padding = new System.Windows.Forms.Padding(5);
            this.ExtraButton.Size = new System.Drawing.Size(75, 25);
            this.ExtraButton.TabIndex = 71;
            this.ExtraButton.Text = "Extras";
            this.ExtraButton.Click += new System.EventHandler(this.MoveExtra);
            // 
            // CheckBox_Fast
            // 
            this.CheckBox_Fast.AutoSize = true;
            this.CheckBox_Fast.Location = new System.Drawing.Point(12, 252);
            this.CheckBox_Fast.Name = "CheckBox_Fast";
            this.CheckBox_Fast.Offset = 2;
            this.CheckBox_Fast.Size = new System.Drawing.Size(125, 17);
            this.CheckBox_Fast.TabIndex = 80;
            this.CheckBox_Fast.Text = "Fast Download (30)";
            this.CheckBox_Fast.CheckedChanged += new System.EventHandler(this.CheckedFast);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 281);
            this.Controls.Add(this.CheckBox_Fast);
            this.Controls.Add(this.All_Manifest);
            this.Controls.Add(this.Compressed_INFO);
            this.Controls.Add(this.StreamingInstall_Button);
            this.Controls.Add(this.NotesButton);
            this.Controls.Add(this.PlazaGet_Button);
            this.Controls.Add(this.faqButton);
            this.Controls.Add(this.ExtraButton);
            this.Controls.Add(this.SteamName_Label);
            this.Controls.Add(this.SetUserName);
            this.Controls.Add(this.NameBox);
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AltUI.Controls.DarkTextBox NameBox;
        private AltUI.Controls.DarkButton SetUserName;
        private AltUI.Controls.DarkLabel SteamName_Label;
        private AltUI.Controls.DarkButton All_Manifest;
        private AltUI.Controls.DarkButton Compressed_INFO;
        private AltUI.Controls.DarkButton StreamingInstall_Button;
        private AltUI.Controls.DarkButton NotesButton;
        private AltUI.Controls.DarkButton PlazaGet_Button;
        private AltUI.Controls.DarkButton faqButton;
        private AltUI.Controls.DarkButton ExtraButton;
        private AltUI.Controls.DarkCheckBox CheckBox_Fast;
    }
}