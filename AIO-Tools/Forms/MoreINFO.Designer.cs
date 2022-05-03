
namespace AIO_Tools.Forms
{
    partial class MoreINFO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoreINFO));
            this.label2 = new AltUI.Controls.DarkLabel();
            this.label5 = new AltUI.Controls.DarkLabel();
            this.BackToMain = new AltUI.Controls.DarkButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 21);
            this.label2.TabIndex = 65;
            this.label2.Text = "Compression information (read this)\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(501, 153);
            this.label5.TabIndex = 66;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // BackToMain
            // 
            this.BackToMain.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToMain.Location = new System.Drawing.Point(365, 240);
            this.BackToMain.Name = "BackToMain";
            this.BackToMain.Size = new System.Drawing.Size(153, 23);
            this.BackToMain.TabIndex = 67;
            this.BackToMain.Text = "Return to downloader";
            this.BackToMain.Click += new System.EventHandler(this.ReturnButton);
            // 
            // MoreINFO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 281);
            this.ControlBox = false;
            this.Controls.Add(this.BackToMain);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MoreINFO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ShowIcon = false;
            this.Text = "More INFO";
            this.Load += new System.EventHandler(this.CompINFO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AltUI.Controls.DarkLabel label2;
        private AltUI.Controls.DarkLabel label5;
        private AltUI.Controls.DarkButton BackToMain;
    }
}