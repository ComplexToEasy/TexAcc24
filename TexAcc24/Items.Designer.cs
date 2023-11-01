namespace TexAcc24
{
    partial class Items
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SatatusCombo = new System.Windows.Forms.ComboBox();
            this.PrateTxt = new System.Windows.Forms.TextBox();
            this.ItemNameTxt = new System.Windows.Forms.TextBox();
            this.SaleRateTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CatNameErrLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lablesale = new System.Windows.Forms.Label();
            this.NameErrLbl = new System.Windows.Forms.Label();
            this.StatusErrorLble = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.IdGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginNameGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsernameGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasswordGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RollGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActiveGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.CatCombo = new System.Windows.Forms.ComboBox();
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
            this.SearchTxt.Location = new System.Drawing.Point(3, 32);
            this.SearchTxt.Size = new System.Drawing.Size(209, 23);
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
            this.BtnPanel.Size = new System.Drawing.Size(905, 58);
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.SearchGroupBox.Location = new System.Drawing.Point(660, 0);
            this.SearchGroupBox.Size = new System.Drawing.Size(215, 58);
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.CatCombo);
            this.LeftPanel.Controls.Add(this.SatatusCombo);
            this.LeftPanel.Controls.Add(this.PrateTxt);
            this.LeftPanel.Controls.Add(this.ItemNameTxt);
            this.LeftPanel.Controls.Add(this.SaleRateTxt);
            this.LeftPanel.Controls.Add(this.label1);
            this.LeftPanel.Controls.Add(this.label6);
            this.LeftPanel.Controls.Add(this.label4);
            this.LeftPanel.Controls.Add(this.CatNameErrLbl);
            this.LeftPanel.Controls.Add(this.label5);
            this.LeftPanel.Controls.Add(this.lablesale);
            this.LeftPanel.Controls.Add(this.NameErrLbl);
            this.LeftPanel.Controls.Add(this.StatusErrorLble);
            this.LeftPanel.Size = new System.Drawing.Size(261, 762);
            this.LeftPanel.Controls.SetChildIndex(this.BackBtn, 0);
            this.LeftPanel.Controls.SetChildIndex(this.StatusPanel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.StatusErrorLble, 0);
            this.LeftPanel.Controls.SetChildIndex(this.NameErrLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.lablesale, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label5, 0);
            this.LeftPanel.Controls.SetChildIndex(this.CatNameErrLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label4, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label6, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label1, 0);
            this.LeftPanel.Controls.SetChildIndex(this.SaleRateTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.ItemNameTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.PrateTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.SatatusCombo, 0);
            this.LeftPanel.Controls.SetChildIndex(this.CatCombo, 0);
            // 
            // TopPanel
            // 
            this.TopPanel.Size = new System.Drawing.Size(905, 100);
            // 
            // SatatusCombo
            // 
            this.SatatusCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SatatusCombo.FormattingEnabled = true;
            this.SatatusCombo.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.SatatusCombo.Location = new System.Drawing.Point(3, 448);
            this.SatatusCombo.Name = "SatatusCombo";
            this.SatatusCombo.Size = new System.Drawing.Size(254, 21);
            this.SatatusCombo.TabIndex = 35;
            // 
            // PrateTxt
            // 
            this.PrateTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrateTxt.Location = new System.Drawing.Point(3, 365);
            this.PrateTxt.Name = "PrateTxt";
            this.PrateTxt.Size = new System.Drawing.Size(255, 23);
            this.PrateTxt.TabIndex = 33;
            this.PrateTxt.UseSystemPasswordChar = true;
            // 
            // ItemNameTxt
            // 
            this.ItemNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemNameTxt.Location = new System.Drawing.Point(3, 322);
            this.ItemNameTxt.Name = "ItemNameTxt";
            this.ItemNameTxt.Size = new System.Drawing.Size(255, 23);
            this.ItemNameTxt.TabIndex = 32;
            // 
            // SaleRateTxt
            // 
            this.SaleRateTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaleRateTxt.Location = new System.Drawing.Point(2, 406);
            this.SaleRateTxt.Name = "SaleRateTxt";
            this.SaleRateTxt.Size = new System.Drawing.Size(255, 23);
            this.SaleRateTxt.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Purchase Rate";
            // 
            // CatNameErrLbl
            // 
            this.CatNameErrLbl.AutoSize = true;
            this.CatNameErrLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatNameErrLbl.ForeColor = System.Drawing.Color.Red;
            this.CatNameErrLbl.Location = new System.Drawing.Point(245, 265);
            this.CatNameErrLbl.Name = "CatNameErrLbl";
            this.CatNameErrLbl.Size = new System.Drawing.Size(12, 15);
            this.CatNameErrLbl.TabIndex = 43;
            this.CatNameErrLbl.Text = "*";
            this.CatNameErrLbl.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Status";
            // 
            // lablesale
            // 
            this.lablesale.AutoSize = true;
            this.lablesale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablesale.Location = new System.Drawing.Point(3, 388);
            this.lablesale.Name = "lablesale";
            this.lablesale.Size = new System.Drawing.Size(70, 17);
            this.lablesale.TabIndex = 41;
            this.lablesale.Text = "Sale Rate";
            // 
            // NameErrLbl
            // 
            this.NameErrLbl.AutoSize = true;
            this.NameErrLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameErrLbl.ForeColor = System.Drawing.Color.Red;
            this.NameErrLbl.Location = new System.Drawing.Point(245, 306);
            this.NameErrLbl.Name = "NameErrLbl";
            this.NameErrLbl.Size = new System.Drawing.Size(12, 15);
            this.NameErrLbl.TabIndex = 44;
            this.NameErrLbl.Text = "*";
            this.NameErrLbl.Visible = false;
            // 
            // StatusErrorLble
            // 
            this.StatusErrorLble.AutoSize = true;
            this.StatusErrorLble.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusErrorLble.ForeColor = System.Drawing.Color.Red;
            this.StatusErrorLble.Location = new System.Drawing.Point(245, 432);
            this.StatusErrorLble.Name = "StatusErrorLble";
            this.StatusErrorLble.Size = new System.Drawing.Size(12, 15);
            this.StatusErrorLble.TabIndex = 46;
            this.StatusErrorLble.Text = "*";
            this.StatusErrorLble.Visible = false;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Chartreuse;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdGv,
            this.LoginNameGv,
            this.UsernameGv,
            this.PasswordGv,
            this.PhoneGv,
            this.RollGv,
            this.IsActiveGv});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(261, 158);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(905, 604);
            this.dataGridView.TabIndex = 3;
            // 
            // IdGv
            // 
            this.IdGv.HeaderText = "Id";
            this.IdGv.Name = "IdGv";
            this.IdGv.ReadOnly = true;
            this.IdGv.Visible = false;
            // 
            // LoginNameGv
            // 
            this.LoginNameGv.HeaderText = "Login Name";
            this.LoginNameGv.Name = "LoginNameGv";
            this.LoginNameGv.ReadOnly = true;
            // 
            // UsernameGv
            // 
            this.UsernameGv.HeaderText = "User Name";
            this.UsernameGv.Name = "UsernameGv";
            this.UsernameGv.ReadOnly = true;
            // 
            // PasswordGv
            // 
            this.PasswordGv.HeaderText = "Password";
            this.PasswordGv.Name = "PasswordGv";
            this.PasswordGv.ReadOnly = true;
            this.PasswordGv.Visible = false;
            // 
            // PhoneGv
            // 
            this.PhoneGv.HeaderText = "Phone";
            this.PhoneGv.Name = "PhoneGv";
            this.PhoneGv.ReadOnly = true;
            // 
            // RollGv
            // 
            this.RollGv.HeaderText = "Role";
            this.RollGv.Name = "RollGv";
            this.RollGv.ReadOnly = true;
            // 
            // IsActiveGv
            // 
            this.IsActiveGv.HeaderText = "Is Active Status";
            this.IsActiveGv.Name = "IsActiveGv";
            this.IsActiveGv.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Item Name";
            // 
            // CatCombo
            // 
            this.CatCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CatCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CatCombo.FormattingEnabled = true;
            this.CatCombo.Location = new System.Drawing.Point(4, 280);
            this.CatCombo.Name = "CatCombo";
            this.CatCombo.Size = new System.Drawing.Size(252, 24);
            this.CatCombo.TabIndex = 47;
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 762);
            this.Controls.Add(this.dataGridView);
            this.Name = "Items";
            this.Text = "Items";
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

        private System.Windows.Forms.ComboBox SatatusCombo;
        private System.Windows.Forms.TextBox PrateTxt;
        private System.Windows.Forms.TextBox ItemNameTxt;
        private System.Windows.Forms.TextBox SaleRateTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CatNameErrLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lablesale;
        private System.Windows.Forms.Label NameErrLbl;
        private System.Windows.Forms.Label StatusErrorLble;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginNameGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsernameGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn PasswordGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn RollGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsActiveGv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CatCombo;
    }
}