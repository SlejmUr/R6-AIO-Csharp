
namespace AIO_Tools.Forms
{
    partial class ChooseBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseBox));
            this.Choose1_Button = new AltUI.Controls.DarkButton();
            this.Choose2_Button = new AltUI.Controls.DarkButton();
            this.Label_Info = new AltUI.Controls.DarkLabel();
            this.Continue = new AltUI.Controls.DarkButton();
            this.SuspendLayout();
            // 
            // Choose1_Button
            // 
            this.Choose1_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Choose1_Button.AutoSize = true;
            this.Choose1_Button.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choose1_Button.Location = new System.Drawing.Point(80, 81);
            this.Choose1_Button.Name = "Choose1_Button";
            this.Choose1_Button.Padding = new System.Windows.Forms.Padding(5);
            this.Choose1_Button.Size = new System.Drawing.Size(120, 37);
            this.Choose1_Button.TabIndex = 20;
            this.Choose1_Button.Text = "Choose1";
            this.Choose1_Button.Click += new System.EventHandler(this.Choose1_Clicked);
            // 
            // Choose2_Button
            // 
            this.Choose2_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Choose2_Button.AutoSize = true;
            this.Choose2_Button.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choose2_Button.Location = new System.Drawing.Point(319, 81);
            this.Choose2_Button.Name = "Choose2_Button";
            this.Choose2_Button.Padding = new System.Windows.Forms.Padding(5);
            this.Choose2_Button.Size = new System.Drawing.Size(120, 37);
            this.Choose2_Button.TabIndex = 21;
            this.Choose2_Button.Text = "Choose2";
            this.Choose2_Button.Click += new System.EventHandler(this.Choose2_Clicked);
            // 
            // Label_Info
            // 
            this.Label_Info.AutoSize = true;
            this.Label_Info.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Info.Location = new System.Drawing.Point(80, 25);
            this.Label_Info.Name = "Label_Info";
            this.Label_Info.Size = new System.Drawing.Size(31, 34);
            this.Label_Info.TabIndex = 22;
            this.Label_Info.Text = "Text\r\n\r\n";
            // 
            // Continue
            // 
            this.Continue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Continue.AutoSize = true;
            this.Continue.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Continue.Location = new System.Drawing.Point(429, 130);
            this.Continue.Name = "Continue";
            this.Continue.Padding = new System.Windows.Forms.Padding(5);
            this.Continue.Size = new System.Drawing.Size(81, 37);
            this.Continue.TabIndex = 24;
            this.Continue.Text = "Continue";
            this.Continue.Click += new System.EventHandler(this.Continue_Clicked);
            // 
            // ChooseBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 181);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.Label_Info);
            this.Controls.Add(this.Choose2_Button);
            this.Controls.Add(this.Choose1_Button);
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChooseBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AltUI.Controls.DarkButton Choose1_Button;
        private AltUI.Controls.DarkButton Choose2_Button;
        private AltUI.Controls.DarkLabel Label_Info;
        private AltUI.Controls.DarkButton Continue;
    }
}