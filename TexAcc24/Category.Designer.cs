namespace TexAcc24
{
    partial class Category
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NameErrLbl = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.IdGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusPanel.SuspendLayout();
            this.BtnPanel.SuspendLayout();
            this.SearchGroupBox.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchTxt
            // 
            this.SearchTxt.Size = new System.Drawing.Size(84, 23);
            // 
            // AddNewBtn
            // 
            this.AddNewBtn.FlatAppearance.BorderSize = 2;
            // 
            // BackBtn
            // 
            this.BackBtn.FlatAppearance.BorderSize = 2;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.FlatAppearance.BorderSize = 2;
            // 
            // SaveBtn
            // 
            this.SaveBtn.FlatAppearance.BorderSize = 2;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.FlatAppearance.BorderSize = 2;
            // 
            // ShowBtn
            // 
            this.ShowBtn.FlatAppearance.BorderSize = 2;
            // 
            // ClearScreenBtn
            // 
            this.ClearScreenBtn.FlatAppearance.BorderSize = 2;
            // 
            // BtnPanel
            // 
            this.BtnPanel.Size = new System.Drawing.Size(935, 58);
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Size = new System.Drawing.Size(90, 52);
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.NameTxt);
            this.LeftPanel.Controls.Add(this.label6);
            this.LeftPanel.Controls.Add(this.NameErrLbl);
            this.LeftPanel.Size = new System.Drawing.Size(261, 798);
            this.LeftPanel.Controls.SetChildIndex(this.BackBtn, 0);
            this.LeftPanel.Controls.SetChildIndex(this.StatusPanel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.NameErrLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label6, 0);
            this.LeftPanel.Controls.SetChildIndex(this.NameTxt, 0);
            // 
            // TopPanel
            // 
            this.TopPanel.Size = new System.Drawing.Size(935, 100);
            // 
            // NameTxt
            // 
            this.NameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTxt.Location = new System.Drawing.Point(2, 317);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(255, 23);
            this.NameTxt.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "Category";
            // 
            // NameErrLbl
            // 
            this.NameErrLbl.AutoSize = true;
            this.NameErrLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameErrLbl.ForeColor = System.Drawing.Color.Red;
            this.NameErrLbl.Location = new System.Drawing.Point(240, 301);
            this.NameErrLbl.Name = "NameErrLbl";
            this.NameErrLbl.Size = new System.Drawing.Size(12, 15);
            this.NameErrLbl.TabIndex = 46;
            this.NameErrLbl.Text = "*";
            this.NameErrLbl.Visible = false;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Chartreuse;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdGv,
            this.NameGv});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(261, 158);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(935, 640);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // IdGv
            // 
            this.IdGv.HeaderText = "Id";
            this.IdGv.Name = "IdGv";
            this.IdGv.ReadOnly = true;
            this.IdGv.Visible = false;
            // 
            // NameGv
            // 
            this.NameGv.HeaderText = "Category";
            this.NameGv.Name = "NameGv";
            this.NameGv.ReadOnly = true;
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 798);
            this.Controls.Add(this.dataGridView);
            this.Name = "Category";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.Category_Load);
            this.Controls.SetChildIndex(this.LeftPanel, 0);
            this.Controls.SetChildIndex(this.TopPanel, 0);
            this.Controls.SetChildIndex(this.BtnPanel, 0);
            this.Controls.SetChildIndex(this.dataGridView, 0);
            this.StatusPanel.ResumeLayout(false);
            this.StatusPanel.PerformLayout();
            this.BtnPanel.ResumeLayout(false);
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label NameErrLbl;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGv;
    }
}