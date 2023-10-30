using System.ComponentModel;

namespace TexAcc24
{
    partial class Sample
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.HeadingLable = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.MediumAquamarine;
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.ForeColor = System.Drawing.Color.Black;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(261, 743);
            this.LeftPanel.TabIndex = 0;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.TopPanel.Controls.Add(this.HeadingLable);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.ForeColor = System.Drawing.Color.White;
            this.TopPanel.Location = new System.Drawing.Point(261, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(691, 100);
            this.TopPanel.TabIndex = 0;
            // 
            // HeadingLable
            // 
            this.HeadingLable.AutoSize = true;
            this.HeadingLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadingLable.Location = new System.Drawing.Point(262, 32);
            this.HeadingLable.Name = "HeadingLable";
            this.HeadingLable.Size = new System.Drawing.Size(0, 31);
            this.HeadingLable.TabIndex = 0;
            // 
            // Sample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 743);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.LeftPanel);
            this.Name = "Sample";
            this.Text = "Sample";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        protected System.Windows.Forms.Panel LeftPanel;
        protected System.Windows.Forms.Panel TopPanel;

        #endregion

        protected System.Windows.Forms.Label HeadingLable;
    }
}