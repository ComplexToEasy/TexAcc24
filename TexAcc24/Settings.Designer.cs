namespace TexAcc24
{
    partial class Settings
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
            this.SaveConfigBtn = new System.Windows.Forms.Button();
            this.IntegratedSecurityCheck = new System.Windows.Forms.CheckBox();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DatabaseTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ServerTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ServerErrorLbl = new System.Windows.Forms.Label();
            this.DatabaseErrorLbl = new System.Windows.Forms.Label();
            this.UsernameErrorLbe = new System.Windows.Forms.Label();
            this.PasswordErrorlbl = new System.Windows.Forms.Label();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.StatusPanel = new System.Windows.Forms.Panel();
            this.LeftPanel.SuspendLayout();
            this.StatusPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.StatusPanel);
            this.LeftPanel.Controls.Add(this.SaveConfigBtn);
            this.LeftPanel.Controls.Add(this.IntegratedSecurityCheck);
            this.LeftPanel.Controls.Add(this.PasswordTxt);
            this.LeftPanel.Controls.Add(this.UsernameTxt);
            this.LeftPanel.Controls.Add(this.label4);
            this.LeftPanel.Controls.Add(this.DatabaseTxt);
            this.LeftPanel.Controls.Add(this.label3);
            this.LeftPanel.Controls.Add(this.ServerTxt);
            this.LeftPanel.Controls.Add(this.label2);
            this.LeftPanel.Controls.Add(this.PasswordErrorlbl);
            this.LeftPanel.Controls.Add(this.UsernameErrorLbe);
            this.LeftPanel.Controls.Add(this.DatabaseErrorLbl);
            this.LeftPanel.Controls.Add(this.ServerErrorLbl);
            this.LeftPanel.Controls.Add(this.label1);
            this.LeftPanel.Size = new System.Drawing.Size(261, 790);
            // 
            // panel1
            // 
            this.TopPanel.Size = new System.Drawing.Size(539, 100);
            // 
            // SaveConfigBtn
            // 
            this.SaveConfigBtn.FlatAppearance.BorderSize = 2;
            this.SaveConfigBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveConfigBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveConfigBtn.Location = new System.Drawing.Point(8, 449);
            this.SaveConfigBtn.Name = "SaveConfigBtn";
            this.SaveConfigBtn.Size = new System.Drawing.Size(248, 43);
            this.SaveConfigBtn.TabIndex = 5;
            this.SaveConfigBtn.Text = "Save";
            this.SaveConfigBtn.UseVisualStyleBackColor = true;
            this.SaveConfigBtn.Click += new System.EventHandler(this.SaveConfigBtn_Click);
            // 
            // IntegratedSecurityCheck
            // 
            this.IntegratedSecurityCheck.AutoSize = true;
            this.IntegratedSecurityCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntegratedSecurityCheck.Location = new System.Drawing.Point(6, 402);
            this.IntegratedSecurityCheck.Name = "IntegratedSecurityCheck";
            this.IntegratedSecurityCheck.Size = new System.Drawing.Size(146, 21);
            this.IntegratedSecurityCheck.TabIndex = 4;
            this.IntegratedSecurityCheck.Text = "Integrated Security";
            this.IntegratedSecurityCheck.UseVisualStyleBackColor = true;
            this.IntegratedSecurityCheck.CheckedChanged += new System.EventHandler(this.IntegratedSecurityCheck_CheckedChanged);
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxt.Location = new System.Drawing.Point(2, 370);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(255, 23);
            this.PasswordTxt.TabIndex = 3;
            this.PasswordTxt.UseSystemPasswordChar = true;
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTxt.Location = new System.Drawing.Point(2, 330);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(255, 23);
            this.UsernameTxt.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password";
            // 
            // DatabaseTxt
            // 
            this.DatabaseTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabaseTxt.Location = new System.Drawing.Point(2, 288);
            this.DatabaseTxt.Name = "DatabaseTxt";
            this.DatabaseTxt.Size = new System.Drawing.Size(255, 23);
            this.DatabaseTxt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "User Name";
            // 
            // ServerTxt
            // 
            this.ServerTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerTxt.Location = new System.Drawing.Point(2, 244);
            this.ServerTxt.Name = "ServerTxt";
            this.ServerTxt.Size = new System.Drawing.Size(255, 23);
            this.ServerTxt.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Database";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Server Name";
            // 
            // ServerErrorLbl
            // 
            this.ServerErrorLbl.AutoSize = true;
            this.ServerErrorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.ServerErrorLbl.Location = new System.Drawing.Point(93, 228);
            this.ServerErrorLbl.Name = "ServerErrorLbl";
            this.ServerErrorLbl.Size = new System.Drawing.Size(12, 15);
            this.ServerErrorLbl.TabIndex = 13;
            this.ServerErrorLbl.Text = "*";
            // 
            // DatabaseErrorLbl
            // 
            this.DatabaseErrorLbl.AutoSize = true;
            this.DatabaseErrorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabaseErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.DatabaseErrorLbl.Location = new System.Drawing.Point(78, 272);
            this.DatabaseErrorLbl.Name = "DatabaseErrorLbl";
            this.DatabaseErrorLbl.Size = new System.Drawing.Size(12, 15);
            this.DatabaseErrorLbl.TabIndex = 13;
            this.DatabaseErrorLbl.Text = "*";
            // 
            // UsernameErrorLbe
            // 
            this.UsernameErrorLbe.AutoSize = true;
            this.UsernameErrorLbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameErrorLbe.ForeColor = System.Drawing.Color.Red;
            this.UsernameErrorLbe.Location = new System.Drawing.Point(93, 312);
            this.UsernameErrorLbe.Name = "UsernameErrorLbe";
            this.UsernameErrorLbe.Size = new System.Drawing.Size(12, 15);
            this.UsernameErrorLbe.TabIndex = 13;
            this.UsernameErrorLbe.Text = "*";
            // 
            // PasswordErrorlbl
            // 
            this.PasswordErrorlbl.AutoSize = true;
            this.PasswordErrorlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordErrorlbl.ForeColor = System.Drawing.Color.Red;
            this.PasswordErrorlbl.Location = new System.Drawing.Point(78, 356);
            this.PasswordErrorlbl.Name = "PasswordErrorlbl";
            this.PasswordErrorlbl.Size = new System.Drawing.Size(12, 15);
            this.PasswordErrorlbl.TabIndex = 13;
            this.PasswordErrorlbl.Text = "*";
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
            // StatusPanel
            // 
            this.StatusPanel.Controls.Add(this.StatusLbl);
            this.StatusPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.StatusPanel.Location = new System.Drawing.Point(0, 0);
            this.StatusPanel.Name = "StatusPanel";
            this.StatusPanel.Size = new System.Drawing.Size(261, 45);
            this.StatusPanel.TabIndex = 14;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 790);
            this.ControlBox = false;
            this.Name = "Settings";
            this.Text = "Settings2";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.StatusPanel.ResumeLayout(false);
            this.StatusPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveConfigBtn;
        private System.Windows.Forms.CheckBox IntegratedSecurityCheck;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DatabaseTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ServerTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ServerErrorLbl;
        private System.Windows.Forms.Label PasswordErrorlbl;
        private System.Windows.Forms.Label UsernameErrorLbe;
        private System.Windows.Forms.Label DatabaseErrorLbl;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.Panel StatusPanel;
    }
}