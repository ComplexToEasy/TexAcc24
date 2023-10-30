using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TexAcc24.Data;

namespace TexAcc24
{
    public partial class LoginForm : Sample
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Mcls.Heading(TopPanel,HeadingLable);
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            UsernameErrorLbe.Visible = false;
            PasswordErrorlbl.Visible = false;
            if (string.IsNullOrWhiteSpace(UsernameTxt.Text))
            {
                UsernameErrorLbe.Visible = true;
            }
            if (string.IsNullOrWhiteSpace(PasswordTxt.Text))
            {
                PasswordErrorlbl.Visible = true;

            }

            if (UsernameErrorLbe.Visible || PasswordErrorlbl.Visible)
            {
                Mcls.ShowErrorStatus(StatusPanel, StatusLbl, "All fields with * must be filled");

            }
            else
            {
                Mcls.Success(StatusPanel);
                var home = new HomeScreen();
                if (Mdi.ActiveForm != null) Mcls.ShowWin(home, this, Mdi.ActiveForm);
            }
        }
        int xx = 0, yy = 0;

        private void AddX_Click(object sender, EventArgs e)
        {
            xx =xx+ HeadingLable.Width + 5;
            yy = yy + HeadingLable.Height + 5;
            HeadingLable.Width = xx;
            HeadingLable.Height = yy;
            HeadingLable.Text = $"{HeadingLable.Width} {HeadingLable.Height}";
            HeadingLable.Location = new Point(HeadingLable.Width, HeadingLable.Height);
        }

        private void AddY_Click(object sender, EventArgs e)
        {
    
            xx = xx + HeadingLable.Width - 5;
            yy = yy + HeadingLable.Height - 5;
            HeadingLable.Width = xx;
            HeadingLable.Height = yy;
            HeadingLable.Width += HeadingLable.Width - 5;
            HeadingLable.Height += HeadingLable.Height - 5;
            HeadingLable.Text = $"{HeadingLable.Width} {HeadingLable.Height}";

            HeadingLable.Location = new Point(HeadingLable.Width, HeadingLable.Height);

        }
    }
}
