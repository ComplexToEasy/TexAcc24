#nullable enable
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TexAcc24.Data
{
    public class Mcls
    {
        public static void Heading(Panel topPanel, Label heading)
        {
            int screenWidth, screenHeight, winX, winY;

            screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            winX = topPanel.Width-20;
            winY = topPanel.Height-50;
            heading.Location = new Point(winX, winY);
            heading.Text = $"{winX} {winY}";
            //heading.Text = "Complex To Easy";
           

        } public static void ShowWin(Form opnForm, Form clsForm, Form mdiForm)
        {
            clsForm.Close();
            opnForm.WindowState = FormWindowState.Maximized;
            opnForm.MdiParent = mdiForm;
            opnForm.Show();

        }
        public static void ShowWin(Form opnForm, Form mdiForm)
        {

            opnForm.WindowState = FormWindowState.Maximized;
            opnForm.MdiParent = mdiForm;
            opnForm.Show();

        }

        public static void ShowMessage(string message, string heading, string type)
        {
            if (type == "success")
            {
                MessageBox.Show(message, heading, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(message, heading, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void ShowErrorStatus(Panel statusPanel, Label statusLabel, string? message = null)
        {
            statusPanel.Visible = true;
            statusLabel.Visible = true;
            statusLabel.Text = message;

            statusLabel.Height = 25;

            statusPanel.BackColor = Color.Yellow;
            statusPanel.ForeColor = Color.Red;

        }
        public static void Success(Panel statusPanel)
        {
            statusPanel.Visible = false;

            

        }

        public static string conn()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string s = File.ReadAllText(path + "\\connectfile");
            return s;

        }

    }
}