
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
            this.Start_Button = new AltUI.Controls.DarkButton();
            this.InstalledBox = new AltUI.Controls.DarkListBox();
            this.InstallLabel = new AltUI.Controls.DarkLabel();
            this.PathLabel = new AltUI.Controls.DarkLabel();
            this.CheckBox_Vulkan = new AltUI.Controls.DarkCheckBox();
            this.label1 = new AltUI.Controls.DarkLabel();
            this.Kill_Button = new AltUI.Controls.DarkButton();
            this.RemovePaths = new AltUI.Controls.DarkButton();
            this.ResponseLabel = new AltUI.Controls.DarkLabel();
            this.Delete_Button = new AltUI.Controls.DarkButton();
            this.SuspendLayout();
            // 
            // Start_Button
            // 
            this.Start_Button.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_Button.Location = new System.Drawing.Point(300, 45);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(125, 50);
            this.Start_Button.TabIndex = 77;
            this.Start_Button.Text = "Start";
            this.Start_Button.Click += new System.EventHandler(this.StartButton_Clicked);
            // 
            // InstalledBox
            // 
            this.InstalledBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.InstallLabel.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstallLabel.Location = new System.Drawing.Point(40, 20);
            this.InstallLabel.Name = "InstallLabel";
            this.InstallLabel.Size = new System.Drawing.Size(99, 13);
            this.InstallLabel.TabIndex = 79;
            this.InstallLabel.Text = "Installed Seasons:";
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.CheckBox_Vulkan.Location = new System.Drawing.Point(577, 319);
            this.CheckBox_Vulkan.Name = "CheckBox_Vulkan";
            this.CheckBox_Vulkan.Offset = 2;
            this.CheckBox_Vulkan.Size = new System.Drawing.Size(178, 17);
            this.CheckBox_Vulkan.TabIndex = 82;
            this.CheckBox_Vulkan.Text = "Use Vulkan instead of DirectX";
            this.CheckBox_Vulkan.CheckedChanged += new System.EventHandler(this.VulkanCheckBox_Changed);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(448, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 13);
            this.label1.TabIndex = 83;
            this.label1.Text = "LumaPlay_x64.exe is using own method to Disable BattlEye\r\n";
            // 
            // Kill_Button
            // 
            this.Kill_Button.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kill_Button.Location = new System.Drawing.Point(300, 130);
            this.Kill_Button.Name = "Kill_Button";
            this.Kill_Button.Size = new System.Drawing.Size(125, 50);
            this.Kill_Button.TabIndex = 84;
            this.Kill_Button.Text = "Kill R6:S";
            this.Kill_Button.Click += new System.EventHandler(this.KillButton_Clicked);
            // 
            // RemovePaths
            // 
            this.RemovePaths.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemovePaths.Location = new System.Drawing.Point(300, 215);
            this.RemovePaths.Name = "RemovePaths";
            this.RemovePaths.Size = new System.Drawing.Size(125, 50);
            this.RemovePaths.TabIndex = 85;
            this.RemovePaths.Text = "Remove From StartingGame";
            this.RemovePaths.Click += new System.EventHandler(this.RemovePaths_Clicked);
            // 
            // ResponseLabel
            // 
            this.ResponseLabel.AutoSize = true;
            this.ResponseLabel.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResponseLabel.Location = new System.Drawing.Point(450, 45);
            this.ResponseLabel.Name = "ResponseLabel";
            this.ResponseLabel.Size = new System.Drawing.Size(120, 13);
            this.ResponseLabel.TabIndex = 86;
            this.ResponseLabel.Text = "Response will be here";
            // 
            // Delete_Button
            // 
            this.Delete_Button.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Button.Location = new System.Drawing.Point(620, 250);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(125, 50);
            this.Delete_Button.TabIndex = 87;
            this.Delete_Button.Text = "Delete all R6:S from Paths!";
            this.Delete_Button.Click += new System.EventHandler(this.DeleteAll_Clicked);
            // 
            // StartingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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

        private AltUI.Controls.DarkButton Start_Button;
        private AltUI.Controls.DarkListBox InstalledBox;
        private AltUI.Controls.DarkLabel InstallLabel;
        private AltUI.Controls.DarkLabel PathLabel;
        private AltUI.Controls.DarkCheckBox CheckBox_Vulkan;
        private AltUI.Controls.DarkLabel label1;
        private AltUI.Controls.DarkButton Kill_Button;
        private AltUI.Controls.DarkButton RemovePaths;
        private AltUI.Controls.DarkLabel ResponseLabel;
        private AltUI.Controls.DarkButton Delete_Button;
    }
}