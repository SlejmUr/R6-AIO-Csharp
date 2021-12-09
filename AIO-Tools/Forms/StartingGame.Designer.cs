
namespace AIO_Tools.Forms
{
    partial class StartingGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartingGame));
            this.Start_Button = new System.Windows.Forms.Button();
            this.InstalledBox = new System.Windows.Forms.ListBox();
            this.InstallLabel = new System.Windows.Forms.Label();
            this.PathLabel = new System.Windows.Forms.Label();
            this.CheckBox_Vulkan = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Kill_Button = new System.Windows.Forms.Button();
            this.RemovePaths = new System.Windows.Forms.Button();
            this.ResponseLabel = new System.Windows.Forms.Label();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Start_Button
            // 
            this.Start_Button.BackColor = System.Drawing.Color.Transparent;
            this.Start_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Start_Button.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_Button.ForeColor = System.Drawing.Color.White;
            this.Start_Button.Location = new System.Drawing.Point(300, 45);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(125, 50);
            this.Start_Button.TabIndex = 77;
            this.Start_Button.Text = "Start";
            this.Start_Button.UseVisualStyleBackColor = false;
            this.Start_Button.Click += new System.EventHandler(this.StartButton_Clicked);
            // 
            // InstalledBox
            // 
            this.InstalledBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InstalledBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstalledBox.ForeColor = System.Drawing.SystemColors.Control;
            this.InstalledBox.FormattingEnabled = true;
            this.InstalledBox.ItemHeight = 17;
            this.InstalledBox.Location = new System.Drawing.Point(40, 45);
            this.InstalledBox.Name = "InstalledBox";
            this.InstalledBox.Size = new System.Drawing.Size(200, 225);
            this.InstalledBox.TabIndex = 78;
            this.InstalledBox.SelectedIndexChanged += new System.EventHandler(this.InstalledBox_IndexChanged);
            // 
            // InstallLabel
            // 
            this.InstallLabel.AutoSize = true;
            this.InstallLabel.BackColor = System.Drawing.Color.Transparent;
            this.InstallLabel.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstallLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.InstallLabel.Location = new System.Drawing.Point(40, 20);
            this.InstallLabel.Name = "InstallLabel";
            this.InstallLabel.Size = new System.Drawing.Size(99, 13);
            this.InstallLabel.TabIndex = 79;
            this.InstallLabel.Text = "Installed Seasons:";
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.BackColor = System.Drawing.Color.Transparent;
            this.PathLabel.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.PathLabel.Location = new System.Drawing.Point(40, 300);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(97, 13);
            this.PathLabel.TabIndex = 80;
            this.PathLabel.Text = "Path to Exe/Game";
            // 
            // CheckBox_Vulkan
            // 
            this.CheckBox_Vulkan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBox_Vulkan.AutoSize = true;
            this.CheckBox_Vulkan.ForeColor = System.Drawing.Color.White;
            this.CheckBox_Vulkan.Location = new System.Drawing.Point(577, 319);
            this.CheckBox_Vulkan.Name = "CheckBox_Vulkan";
            this.CheckBox_Vulkan.Size = new System.Drawing.Size(178, 17);
            this.CheckBox_Vulkan.TabIndex = 82;
            this.CheckBox_Vulkan.Text = "Use Vulkan instead of DirectX";
            this.CheckBox_Vulkan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckBox_Vulkan.UseVisualStyleBackColor = true;
            this.CheckBox_Vulkan.CheckedChanged += new System.EventHandler(this.VulkanCheckBox_Changed);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(448, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 13);
            this.label1.TabIndex = 83;
            this.label1.Text = "LumaPlay_x64.exe is using own method to Disable BattlEye\r\n";
            // 
            // Kill_Button
            // 
            this.Kill_Button.BackColor = System.Drawing.Color.Transparent;
            this.Kill_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Kill_Button.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kill_Button.ForeColor = System.Drawing.Color.White;
            this.Kill_Button.Location = new System.Drawing.Point(300, 130);
            this.Kill_Button.Name = "Kill_Button";
            this.Kill_Button.Size = new System.Drawing.Size(125, 50);
            this.Kill_Button.TabIndex = 84;
            this.Kill_Button.Text = "Kill R6:S";
            this.Kill_Button.UseVisualStyleBackColor = false;
            this.Kill_Button.Click += new System.EventHandler(this.KillButton_Clicked);
            // 
            // RemovePaths
            // 
            this.RemovePaths.BackColor = System.Drawing.Color.Transparent;
            this.RemovePaths.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RemovePaths.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemovePaths.ForeColor = System.Drawing.Color.White;
            this.RemovePaths.Location = new System.Drawing.Point(300, 215);
            this.RemovePaths.Name = "RemovePaths";
            this.RemovePaths.Size = new System.Drawing.Size(125, 50);
            this.RemovePaths.TabIndex = 85;
            this.RemovePaths.Text = "Remove From StartingGame";
            this.RemovePaths.UseVisualStyleBackColor = false;
            this.RemovePaths.Click += new System.EventHandler(this.RemovePaths_Clicked);
            // 
            // ResponseLabel
            // 
            this.ResponseLabel.AutoSize = true;
            this.ResponseLabel.BackColor = System.Drawing.Color.Transparent;
            this.ResponseLabel.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResponseLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ResponseLabel.Location = new System.Drawing.Point(450, 45);
            this.ResponseLabel.Name = "ResponseLabel";
            this.ResponseLabel.Size = new System.Drawing.Size(120, 13);
            this.ResponseLabel.TabIndex = 86;
            this.ResponseLabel.Text = "Response will be here";
            // 
            // Delete_Button
            // 
            this.Delete_Button.BackColor = System.Drawing.Color.Transparent;
            this.Delete_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete_Button.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Button.ForeColor = System.Drawing.Color.Red;
            this.Delete_Button.Location = new System.Drawing.Point(620, 250);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(125, 50);
            this.Delete_Button.TabIndex = 87;
            this.Delete_Button.Text = "Delete all R6:S from Paths!";
            this.Delete_Button.UseVisualStyleBackColor = false;
            this.Delete_Button.Click += new System.EventHandler(this.DeleteAll_Clicked);
            // 
            // StartingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(764, 361);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.ResponseLabel);
            this.Controls.Add(this.RemovePaths);
            this.Controls.Add(this.Kill_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckBox_Vulkan);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.InstallLabel);
            this.Controls.Add(this.InstalledBox);
            this.Controls.Add(this.Start_Button);
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartingGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Start Your Game";
            this.Load += new System.EventHandler(this.StartGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.ListBox InstalledBox;
        private System.Windows.Forms.Label InstallLabel;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.CheckBox CheckBox_Vulkan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Kill_Button;
        private System.Windows.Forms.Button RemovePaths;
        private System.Windows.Forms.Label ResponseLabel;
        private System.Windows.Forms.Button Delete_Button;
    }
}