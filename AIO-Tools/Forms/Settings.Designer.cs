
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SetUserName = new System.Windows.Forms.Button();
            this.SteamName_Label = new System.Windows.Forms.Label();
            this.All_Manifest = new System.Windows.Forms.Button();
            this.Compressed_INFO = new System.Windows.Forms.Button();
            this.StreamingInstall_Button = new System.Windows.Forms.Button();
            this.NotesButton = new System.Windows.Forms.Button();
            this.PlazaGet_Button = new System.Windows.Forms.Button();
            this.faqButton = new System.Windows.Forms.Button();
            this.ExtraButton = new System.Windows.Forms.Button();
            this.CheckBox_Fast = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.NameBox.ForeColor = System.Drawing.Color.White;
            this.NameBox.Location = new System.Drawing.Point(30, 32);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(155, 22);
            this.NameBox.TabIndex = 63;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // SetUserName
            // 
            this.SetUserName.BackColor = System.Drawing.Color.Transparent;
            this.SetUserName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SetUserName.ForeColor = System.Drawing.Color.White;
            this.SetUserName.Location = new System.Drawing.Point(191, 32);
            this.SetUserName.Name = "SetUserName";
            this.SetUserName.Size = new System.Drawing.Size(120, 25);
            this.SetUserName.TabIndex = 64;
            this.SetUserName.Text = "Set UserName";
            this.SetUserName.UseVisualStyleBackColor = false;
            this.SetUserName.Click += new System.EventHandler(this.ValidateName);
            // 
            // SteamName_Label
            // 
            this.SteamName_Label.AutoSize = true;
            this.SteamName_Label.BackColor = System.Drawing.Color.Transparent;
            this.SteamName_Label.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SteamName_Label.ForeColor = System.Drawing.Color.White;
            this.SteamName_Label.Location = new System.Drawing.Point(30, 10);
            this.SteamName_Label.Name = "SteamName_Label";
            this.SteamName_Label.Size = new System.Drawing.Size(107, 13);
            this.SteamName_Label.TabIndex = 65;
            this.SteamName_Label.Text = "Steam legacy name:";
            // 
            // All_Manifest
            // 
            this.All_Manifest.BackColor = System.Drawing.Color.Transparent;
            this.All_Manifest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.All_Manifest.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.All_Manifest.ForeColor = System.Drawing.Color.White;
            this.All_Manifest.Location = new System.Drawing.Point(30, 145);
            this.All_Manifest.Name = "All_Manifest";
            this.All_Manifest.Size = new System.Drawing.Size(155, 25);
            this.All_Manifest.TabIndex = 79;
            this.All_Manifest.Text = "All Manifest";
            this.All_Manifest.UseVisualStyleBackColor = false;
            this.All_Manifest.Click += new System.EventHandler(this.All_Manifest_Click);
            // 
            // Compressed_INFO
            // 
            this.Compressed_INFO.BackColor = System.Drawing.Color.Transparent;
            this.Compressed_INFO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Compressed_INFO.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Compressed_INFO.ForeColor = System.Drawing.Color.White;
            this.Compressed_INFO.Location = new System.Drawing.Point(30, 85);
            this.Compressed_INFO.Name = "Compressed_INFO";
            this.Compressed_INFO.Size = new System.Drawing.Size(155, 25);
            this.Compressed_INFO.TabIndex = 76;
            this.Compressed_INFO.Text = "More Info";
            this.Compressed_INFO.UseVisualStyleBackColor = false;
            this.Compressed_INFO.Click += new System.EventHandler(this.MoveCompInfo);
            // 
            // StreamingInstall_Button
            // 
            this.StreamingInstall_Button.BackColor = System.Drawing.Color.Transparent;
            this.StreamingInstall_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StreamingInstall_Button.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreamingInstall_Button.ForeColor = System.Drawing.Color.White;
            this.StreamingInstall_Button.Location = new System.Drawing.Point(190, 85);
            this.StreamingInstall_Button.Name = "StreamingInstall_Button";
            this.StreamingInstall_Button.Size = new System.Drawing.Size(120, 55);
            this.StreamingInstall_Button.TabIndex = 75;
            this.StreamingInstall_Button.Text = "Download\r\nStreaming Install";
            this.StreamingInstall_Button.UseVisualStyleBackColor = false;
            this.StreamingInstall_Button.Click += new System.EventHandler(this.DownStreaming_Click);
            // 
            // NotesButton
            // 
            this.NotesButton.BackColor = System.Drawing.Color.Transparent;
            this.NotesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NotesButton.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesButton.ForeColor = System.Drawing.Color.White;
            this.NotesButton.Location = new System.Drawing.Point(30, 175);
            this.NotesButton.Name = "NotesButton";
            this.NotesButton.Size = new System.Drawing.Size(75, 25);
            this.NotesButton.TabIndex = 74;
            this.NotesButton.Text = "Notes";
            this.NotesButton.UseVisualStyleBackColor = false;
            this.NotesButton.Click += new System.EventHandler(this.MoveNotes);
            // 
            // PlazaGet_Button
            // 
            this.PlazaGet_Button.BackColor = System.Drawing.Color.Transparent;
            this.PlazaGet_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PlazaGet_Button.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlazaGet_Button.ForeColor = System.Drawing.Color.White;
            this.PlazaGet_Button.Location = new System.Drawing.Point(190, 145);
            this.PlazaGet_Button.Name = "PlazaGet_Button";
            this.PlazaGet_Button.Size = new System.Drawing.Size(120, 25);
            this.PlazaGet_Button.TabIndex = 73;
            this.PlazaGet_Button.Text = "Download Plaza";
            this.PlazaGet_Button.UseVisualStyleBackColor = false;
            this.PlazaGet_Button.Click += new System.EventHandler(this.Down_Crack);
            // 
            // faqButton
            // 
            this.faqButton.BackColor = System.Drawing.Color.Transparent;
            this.faqButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.faqButton.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faqButton.ForeColor = System.Drawing.Color.White;
            this.faqButton.Location = new System.Drawing.Point(30, 115);
            this.faqButton.Name = "faqButton";
            this.faqButton.Size = new System.Drawing.Size(155, 25);
            this.faqButton.TabIndex = 72;
            this.faqButton.Text = "FAQ and Information";
            this.faqButton.UseVisualStyleBackColor = false;
            this.faqButton.Click += new System.EventHandler(this.FAQ_Click);
            // 
            // ExtraButton
            // 
            this.ExtraButton.BackColor = System.Drawing.Color.Transparent;
            this.ExtraButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExtraButton.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtraButton.ForeColor = System.Drawing.Color.White;
            this.ExtraButton.Location = new System.Drawing.Point(110, 175);
            this.ExtraButton.Name = "ExtraButton";
            this.ExtraButton.Size = new System.Drawing.Size(75, 25);
            this.ExtraButton.TabIndex = 71;
            this.ExtraButton.Text = "Extras";
            this.ExtraButton.UseVisualStyleBackColor = false;
            this.ExtraButton.Click += new System.EventHandler(this.MoveExtra);
            // 
            // CheckBox_Fast
            // 
            this.CheckBox_Fast.AutoSize = true;
            this.CheckBox_Fast.ForeColor = System.Drawing.Color.White;
            this.CheckBox_Fast.Location = new System.Drawing.Point(12, 252);
            this.CheckBox_Fast.Name = "CheckBox_Fast";
            this.CheckBox_Fast.Size = new System.Drawing.Size(125, 17);
            this.CheckBox_Fast.TabIndex = 80;
            this.CheckBox_Fast.Text = "Fast Download (30)";
            this.CheckBox_Fast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckBox_Fast.UseVisualStyleBackColor = true;
            this.CheckBox_Fast.CheckedChanged += new System.EventHandler(this.CheckedFast);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(384, 281);
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
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button SetUserName;
        private System.Windows.Forms.Label SteamName_Label;
        private System.Windows.Forms.Button All_Manifest;
        private System.Windows.Forms.Button Compressed_INFO;
        private System.Windows.Forms.Button StreamingInstall_Button;
        private System.Windows.Forms.Button NotesButton;
        private System.Windows.Forms.Button PlazaGet_Button;
        private System.Windows.Forms.Button faqButton;
        private System.Windows.Forms.Button ExtraButton;
        private System.Windows.Forms.CheckBox CheckBox_Fast;
    }
}