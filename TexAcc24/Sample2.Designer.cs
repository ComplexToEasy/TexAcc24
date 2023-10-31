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
            this.ClearScreenBtn = new System.Windows.Forms.Button();
            this.ShowBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.AddNewBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.StatusPanel = new System.Windows.Forms.Panel();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.LeftPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
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
            // TopPanel
            // 
            this.TopPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TopPanel.Size = new System.Drawing.Size(976, 100);
            // 
            // HeadingLable
            // 
            this.HeadingLable.Size = new System.Drawing.Size(0, 31);
            // 
            // BtnPanel
            // 
            this.BtnPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnPanel.Controls.Add(this.SearchGroupBox);
            this.BtnPanel.Controls.Add(this.ClearScreenBtn);
            this.BtnPanel.Controls.Add(this.ShowBtn);
            this.BtnPanel.Controls.Add(this.DeleteBtn);
            this.BtnPanel.Controls.Add(this.SaveBtn);
            this.BtnPanel.Controls.Add(this.UpdateBtn);
            this.BtnPanel.Controls.Add(this.AddNewBtn);
            this.BtnPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPanel.Location = new System.Drawing.Point(261, 100);
            this.BtnPanel.Name = "BtnPanel";
            this.BtnPanel.Size = new System.Drawing.Size(976, 58);
            this.BtnPanel.TabIndex = 1;
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SearchGroupBox.Controls.Add(this.SearchTxt);
            this.SearchGroupBox.Location = new System.Drawing.Point(678, 6);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Size = new System.Drawing.Size(295, 52);
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
            this.SearchTxt.Size = new System.Drawing.Size(289, 23);
            this.SearchTxt.TabIndex = 0;
            this.SearchTxt.TextChanged += new System.EventHandler(this.SearchTxt_TextChanged);
            // 
            // ClearScreenBtn
            // 
            this.ClearScreenBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClearScreenBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.ClearScreenBtn.FlatAppearance.BorderSize = 2;
            this.ClearScreenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearScreenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearScreenBtn.Location = new System.Drawing.Point(550, 0);
            this.ClearScreenBtn.Name = "ClearScreenBtn";
            this.ClearScreenBtn.Size = new System.Drawing.Size(110, 58);
            this.ClearScreenBtn.TabIndex = 4;
            this.ClearScreenBtn.Text = "Clear Screen";
            this.ClearScreenBtn.UseVisualStyleBackColor = true;
            this.ClearScreenBtn.Click += new System.EventHandler(this.ClearScreen_Click);
            // 
            // ShowBtn
            // 
            this.ShowBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ShowBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.ShowBtn.FlatAppearance.BorderSize = 2;
            this.ShowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowBtn.Location = new System.Drawing.Point(440, 0);
            this.ShowBtn.Name = "ShowBtn";
            this.ShowBtn.Size = new System.Drawing.Size(110, 58);
            this.ShowBtn.TabIndex = 5;
            this.ShowBtn.Text = "Show";
            this.ShowBtn.UseVisualStyleBackColor = true;
            this.ShowBtn.Click += new System.EventHandler(this.ShowBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.DeleteBtn.FlatAppearance.BorderSize = 2;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(330, 0);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(110, 58);
            this.DeleteBtn.TabIndex = 3;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.SaveBtn.FlatAppearance.BorderSize = 2;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(220, 0);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(110, 58);
            this.SaveBtn.TabIndex = 2;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpdateBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.UpdateBtn.FlatAppearance.BorderSize = 2;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Location = new System.Drawing.Point(110, 0);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(110, 58);
            this.UpdateBtn.TabIndex = 1;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // AddNewBtn
            // 
            this.AddNewBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddNewBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddNewBtn.FlatAppearance.BorderSize = 2;
            this.AddNewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewBtn.Location = new System.Drawing.Point(0, 0);
            this.AddNewBtn.Name = "AddNewBtn";
            this.AddNewBtn.Size = new System.Drawing.Size(110, 58);
            this.AddNewBtn.TabIndex = 0;
            this.AddNewBtn.Text = "Add new";
            this.AddNewBtn.UseVisualStyleBackColor = true;
            this.AddNewBtn.Click += new System.EventHandler(this.AddNewBtn_Click);
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
            this.TopPanel.ResumeLayout(false);
            this.BtnPanel.ResumeLayout(false);
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            this.StatusPanel.ResumeLayout(false);
            this.StatusPanel.PerformLayout();
            this.ResumeLayout(false);

        }
        protected System.Windows.Forms.TextBox SearchTxt;

        protected System.Windows.Forms.Button AddNewBtn;

        private System.Windows.Forms.Panel panel2;

        #endregion

        protected System.Windows.Forms.Button BackBtn;
        protected System.Windows.Forms.Button UpdateBtn;
        protected System.Windows.Forms.Button SaveBtn;
        protected System.Windows.Forms.Button DeleteBtn;
        protected System.Windows.Forms.Button ShowBtn;
        protected System.Windows.Forms.Button ClearScreenBtn;
        protected System.Windows.Forms.Panel StatusPanel;
        protected System.Windows.Forms.Label StatusLbl;
        protected System.Windows.Forms.Panel BtnPanel;
        protected System.Windows.Forms.GroupBox SearchGroupBox;
    }
}