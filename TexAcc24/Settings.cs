using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;
using TexAcc24.Data;

namespace TexAcc24
{
    public partial class Settings : Sample
    {
        private string queryString;

        public Settings()
        {
            InitializeComponent();
        }

        private void SaveConfigBtn_Click(object sender, EventArgs e)
        {
            // Clear error labels
            ServerErrorLbl.Visible = false;
            DatabaseErrorLbl.Visible = false;
            UsernameErrorLbe.Visible = false;
            PasswordErrorlbl.Visible = false;

            // Check for empty fields
            if (string.IsNullOrWhiteSpace(ServerTxt.Text))
                ServerErrorLbl.Visible = true;
            if (string.IsNullOrWhiteSpace(DatabaseTxt.Text))
                DatabaseErrorLbl.Visible = true;
            if (IntegratedSecurityCheck.CheckState == CheckState.Unchecked && string.IsNullOrWhiteSpace(UsernameTxt.Text))
                UsernameErrorLbe.Visible = true;
            if (IntegratedSecurityCheck.CheckState == CheckState.Unchecked && string.IsNullOrWhiteSpace(PasswordTxt.Text))
                PasswordErrorlbl.Visible = true;

            if (ServerErrorLbl.Visible || DatabaseErrorLbl.Visible || UsernameErrorLbe.Visible || PasswordErrorlbl.Visible)
            {
                Mcls.ShowErrorStatus( StatusPanel, StatusLbl, "All fields with * must be filled");
            }
            else
            {
                Mcls.Success(StatusPanel);

                var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (IntegratedSecurityCheck.CheckState == CheckState.Checked)
                {
                    queryString = $"Data Source={ServerTxt.Text};Initial Catalog={DatabaseTxt.Text};Integrated Security=true;trusted_connection=true";
                    File.WriteAllText(Path.Combine(path, "connectfile"), queryString);


                }
                else
                {
                    queryString = $"Data Source={ServerTxt.Text};Initial Catalog={DatabaseTxt.Text};User Id={UsernameTxt.Text};Password={PasswordTxt.Text};";
                    File.WriteAllText(Path.Combine(path, "connectfile"), queryString);
                }

                Mcls.ShowMessage("Successfully saved", "Success info", "success");
                LoginForm login = new LoginForm();
                Mcls.ShowWin(login, this, Mdi.ActiveForm);
            }
        }

        private void IntegratedSecurityCheck_CheckedChanged(object sender, EventArgs e)
        {
            UsernameTxt.Enabled = PasswordTxt.Enabled = !IntegratedSecurityCheck.Checked;
            UsernameTxt.Text = PasswordTxt.Text = "";
            UsernameErrorLbe.Visible = PasswordErrorlbl.Visible = IntegratedSecurityCheck.Checked;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            Mcls.Heading(TopPanel, HeadingLable);
        }
    }
}
