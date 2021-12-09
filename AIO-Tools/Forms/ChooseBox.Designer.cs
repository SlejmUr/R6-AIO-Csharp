
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
            this.Choose1_Button = new System.Windows.Forms.Button();
            this.Choose2_Button = new System.Windows.Forms.Button();
            this.Label_Info = new System.Windows.Forms.Label();
            this.Continue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Choose1_Button
            // 
            this.Choose1_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Choose1_Button.AutoSize = true;
            this.Choose1_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Choose1_Button.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choose1_Button.Location = new System.Drawing.Point(80, 100);
            this.Choose1_Button.Name = "Choose1_Button";
            this.Choose1_Button.Size = new System.Drawing.Size(120, 29);
            this.Choose1_Button.TabIndex = 20;
            this.Choose1_Button.Text = "Choose1";
            this.Choose1_Button.UseVisualStyleBackColor = true;
            this.Choose1_Button.Click += new System.EventHandler(this.Choose1_Clicked);
            // 
            // Choose2_Button
            // 
            this.Choose2_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Choose2_Button.AutoSize = true;
            this.Choose2_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Choose2_Button.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choose2_Button.Location = new System.Drawing.Point(319, 100);
            this.Choose2_Button.Name = "Choose2_Button";
            this.Choose2_Button.Size = new System.Drawing.Size(120, 29);
            this.Choose2_Button.TabIndex = 21;
            this.Choose2_Button.Text = "Choose2";
            this.Choose2_Button.UseVisualStyleBackColor = true;
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
            this.Continue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Continue.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Continue.Location = new System.Drawing.Point(429, 135);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(81, 29);
            this.Continue.TabIndex = 24;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = true;
            this.Continue.Click += new System.EventHandler(this.Continue_Clicked);
            // 
            // ChooseBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(524, 181);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.Label_Info);
            this.Controls.Add(this.Choose2_Button);
            this.Controls.Add(this.Choose1_Button);
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
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

        private System.Windows.Forms.Button Choose1_Button;
        private System.Windows.Forms.Button Choose2_Button;
        private System.Windows.Forms.Label Label_Info;
        private System.Windows.Forms.Button Continue;
    }
}