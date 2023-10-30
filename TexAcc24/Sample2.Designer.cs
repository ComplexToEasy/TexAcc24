using System.ComponentModel;

namespace TexAcc24
{
    partial class Sample2
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
            this.BtnPanel = new System.Windows.Forms.Panel();
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.ShowBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.StatusPanel = new System.Windows.Forms.Panel();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.LeftPanel.SuspendLayout();
            this.BtnPanel.SuspendLayout();
            this.SearchGroupBox.SuspendLayout();
            this.StatusPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.StatusPanel);
            this.LeftPanel.Controls.Add(this.BackBtn);
            this.LeftPanel.Size = new System.Drawing.Size(261, 768);
            // 
            // panel1
            // 
            this.TopPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TopPanel.Size = new System.Drawing.Size(976, 100);
            // 
            // BtnPanel
            // 
            this.BtnPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnPanel.Controls.Add(this.SearchGroupBox);
            this.BtnPanel.Controls.Add(this.ShowBtn);
            this.BtnPanel.Controls.Add(this.DeleteBtn);
            this.BtnPanel.Controls.Add(this.SaveBtn);
            this.BtnPanel.Controls.Add(this.EditBtn);
            this.BtnPanel.Controls.Add(this.AddBtn);
            this.BtnPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPanel.Location = new System.Drawing.Point(261, 100);
            this.BtnPanel.Name = "BtnPanel";
            this.BtnPanel.Size = new System.Drawing.Size(976, 58);
            this.BtnPanel.TabIndex = 1;
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Controls.Add(this.SearchTxt);
            this.SearchGroupBox.Location = new System.Drawing.Point(576, 6);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Size = new System.Drawing.Size(198, 52);
            this.SearchGroupBox.TabIndex = 1;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Search";
            // 
            // SearchTxt
            // 
            this.SearchTxt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SearchTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTxt.Location = new System.Drawing.Point(3, 26);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(192, 23);
            this.SearchTxt.TabIndex = 0;
            // 
            // ShowBtn
            // 
            this.ShowBtn.FlatAppearance.BorderSize = 2;
            this.ShowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowBtn.Location = new System.Drawing.Point(460, 5);
            this.ShowBtn.Name = "ShowBtn";
            this.ShowBtn.Size = new System.Drawing.Size(110, 53);
            this.ShowBtn.TabIndex = 0;
            this.ShowBtn.Text = "Show";
            this.ShowBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.FlatAppearance.BorderSize = 2;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(344, 3);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(110, 53);
            this.DeleteBtn.TabIndex = 0;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // SaveBtn
            // 
            this.SaveBtn.FlatAppearance.BorderSize = 2;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(228, 3);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(110, 53);
            this.SaveBtn.TabIndex = 0;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            // 
            // EditBtn
            // 
            this.EditBtn.FlatAppearance.BorderSize = 2;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.Location = new System.Drawing.Point(116, 3);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(110, 53);
            this.EditBtn.TabIndex = 0;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            this.AddBtn.FlatAppearance.BorderSize = 2;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(0, 3);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(110, 53);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // BackBtn
            // 
            this.BackBtn.FlatAppearance.BorderSize = 2;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.BackBtn.Image = global::TexAcc24.Properties.Resources.back;
            this.BackBtn.Location = new System.Drawing.Point(0, 51);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(57, 39);
            this.BackBtn.TabIndex = 0;
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // StatusPanel
            // 
            this.StatusPanel.Controls.Add(this.StatusLbl);
            this.StatusPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.StatusPanel.Location = new System.Drawing.Point(0, 0);
            this.StatusPanel.Name = "StatusPanel";
            this.StatusPanel.Size = new System.Drawing.Size(261, 45);
            this.StatusPanel.TabIndex = 15;
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLbl.ForeColor = System.Drawing.Color.Red;
            this.StatusLbl.Location = new System.Drawing.Point(0, 0);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(0, 20);
            this.StatusLbl.TabIndex = 13;
            // 
            // Sample2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1237, 768);
            this.Controls.Add(this.BtnPanel);
            this.Name = "Sample2";
            this.Text = "Sample2";
            this.Controls.SetChildIndex(this.LeftPanel, 0);
            this.Controls.SetChildIndex(this.TopPanel, 0);
            this.Controls.SetChildIndex(this.BtnPanel, 0);
            this.LeftPanel.ResumeLayout(false);
            this.BtnPanel.ResumeLayout(false);
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            this.StatusPanel.ResumeLayout(false);
            this.StatusPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Panel BtnPanel;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ShowBtn;
        private System.Windows.Forms.GroupBox SearchGroupBox;
        protected System.Windows.Forms.TextBox SearchTxt;

        protected System.Windows.Forms.Button AddBtn;

        private System.Windows.Forms.Panel panel2;

        #endregion

        protected System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Panel StatusPanel;
        private System.Windows.Forms.Label StatusLbl;
    }
}