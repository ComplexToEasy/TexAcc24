using System;
using System.IO;
using System.Windows.Forms;
using TexAcc24.Data;

namespace TexAcc24
{
    public partial class Mdi : Form
    {
        public Mdi()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();

            Mcls.ShowWin(settings, this);
        }

        private void Mdi_Load(object sender, EventArgs e)
        {
            this.Text = "Complex to Easy";
            var path =  Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (File.Exists(path + "\\connectfile"))
            {
                var loginForm = new LoginForm();
                Mcls.ShowWin(loginForm, this);
            }
            else if (!File.Exists(path + "\\connectfile"))
            {
                var settings = new Settings();
                Mcls.ShowWin(settings, this);
            }
            else
            {
                Mcls.ShowMessage("Configuration error", "Configuration Error", "");
            }
        }
    }
}