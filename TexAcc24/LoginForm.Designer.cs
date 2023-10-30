namespace TexAcc24
{
  partial class LoginForm
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
            this.StatusPanel = new System.Windows.Forms.Panel();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordErrorlbl = new System.Windows.Forms.Label();
            this.UsernameErrorLbe = new System.Windows.Forms.Label();
            this.AddX = new System.Windows.Forms.Button();
            this.AddY = new System.Windows.Forms.Button();
            this.LeftPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.StatusPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.LoginBtn);
            this.LeftPanel.Controls.Add(this.PasswordTxt);
            this.LeftPanel.Controls.Add(this.UsernameTxt);
            this.LeftPanel.Controls.Add(this.label4);
            this.LeftPanel.Controls.Add(this.label3);
            this.LeftPanel.Controls.Add(this.PasswordErrorlbl);
            this.LeftPanel.Controls.Add(this.UsernameErrorLbe);
            this.LeftPanel.Controls.Add(this.StatusPanel);
            this.LeftPanel.Size = new System.Drawing.Size(261, 740);
            // 
            // TopPanel
            // 
            this.TopPanel.Size = new System.Drawing.Size(695, 100);
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
            // LoginBtn
            // 
            this.LoginBtn.FlatAppearance.BorderSize = 2;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.Location = new System.Drawing.Point(3, 325);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(248, 43);
            this.LoginBtn.TabIndex = 19;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxt.Location = new System.Drawing.Point(3, 286);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(255, 23);
            this.PasswordTxt.TabIndex = 17;
            this.PasswordTxt.UseSystemPasswordChar = true;
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTxt.Location = new System.Drawing.Point(3, 246);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(255, 23);
            this.UsernameTxt.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "User Name";
            // 
            // PasswordErrorlbl
            // 
            this.PasswordErrorlbl.AutoSize = true;
            this.PasswordErrorlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordErrorlbl.ForeColor = System.Drawing.Color.Red;
            this.PasswordErrorlbl.Location = new System.Drawing.Point(79, 272);
            this.PasswordErrorlbl.Name = "PasswordErrorlbl";
            this.PasswordErrorlbl.Size = new System.Drawing.Size(12, 15);
            this.PasswordErrorlbl.TabIndex = 22;
            this.PasswordErrorlbl.Text = "*";
            // 
            // UsernameErrorLbe
            // 
            this.UsernameErrorLbe.AutoSize = true;
            this.UsernameErrorLbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameErrorLbe.ForeColor = System.Drawing.Color.Red;
            this.UsernameErrorLbe.Location = new System.Drawing.Point(94, 228);
            this.UsernameErrorLbe.Name = "UsernameErrorLbe";
            this.UsernameErrorLbe.Size = new System.Drawing.Size(12, 15);
            this.UsernameErrorLbe.TabIndex = 23;
            this.UsernameErrorLbe.Text = "*";
            // 
            // AddX
            // 
            this.AddX.Location = new System.Drawing.Point(479, 171);
            this.AddX.Name = "AddX";
            this.AddX.Size = new System.Drawing.Size(75, 23);
            this.AddX.TabIndex = 1;
            this.AddX.Text = "Add X";
            this.AddX.UseVisualStyleBackColor = true;
            this.AddX.Click += new System.EventHandler(this.AddX_Click);
            // 
            // AddY
            // 
            this.AddY.Location = new System.Drawing.Point(560, 171);
            this.AddY.Name = "AddY";
            this.AddY.Size = new System.Drawing.Size(75, 23);
            this.AddY.TabIndex = 1;
            this.AddY.Text = "Add Y";
            this.AddY.UseVisualStyleBackColor = true;
            this.AddY.Click += new System.EventHandler(this.AddY_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.LoginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 740);
            this.ControlBox = false;
            this.Controls.Add(this.AddY);
            this.Controls.Add(this.AddX);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Controls.SetChildIndex(this.LeftPanel, 0);
            this.Controls.SetChildIndex(this.TopPanel, 0);
            this.Controls.SetChildIndex(this.AddX, 0);
            this.Controls.SetChildIndex(this.AddY, 0);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.StatusPanel.ResumeLayout(false);
            this.StatusPanel.PerformLayout();
            this.ResumeLayout(false);

    }


        #endregion

        private System.Windows.Forms.Panel StatusPanel;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PasswordErrorlbl;
        private System.Windows.Forms.Label UsernameErrorLbe;
        private System.Windows.Forms.Button AddX;
        private System.Windows.Forms.Button AddY;
    }
}

