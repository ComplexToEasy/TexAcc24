#nullable enable
using System;
using System.Data.SqlClient;
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

            //screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            //screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            winX = topPanel.Width;
            winY = topPanel.Height;
            //heading.Location = new Point(winX, winY);
            //  heading.Text = $"{winX} {winY}";
            heading.Text = "Complex To Easy";


        }
        public static void ShowWin(Form opnForm, Form clsForm, Form mdiForm)
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
            if (message == null)
            {
                message = "All fields with* must be filled";
            }
            statusLabel.Text = message;

            statusLabel.Height = 25;

            statusPanel.BackColor = Color.Yellow;
            statusPanel.ForeColor = Color.Red;

        }
        public static void Success(Panel statusPanel)
        {
            statusPanel.Visible = false;
        }

        static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        static string connString = File.ReadAllText(path + "\\connectfile");

        public static SqlConnection conn = new SqlConnection(connString);
        public static void Disable_Reset(Panel panel)
        {
            // Get all controls in the panel.

            Control.ControlCollection controls = panel.Controls;
            foreach (Control control in controls)
            {
                if (control is TextBox t)
                {
                    t.Text = "";
                    t.Enabled = false;
                }
                if (control is ComboBox c)
                {
                    c.SelectedIndex = -1;
                    c.Enabled = false;
                }
                if (control is CheckBox cb)
                {
                    cb.Checked = false;
                    cb.Enabled = false;

                }
                if (control is DateTimePicker d)
                {
                    d.Value = DateTime.Now;
                    d.Enabled = false;

                }

            }
        }
        public static void Reset(Panel panel)
        {
            // Get all controls in the panel.

            Control.ControlCollection controls = panel.Controls;
            foreach (Control control in controls)
            {
                if (control is TextBox t)
                {
                    t.Text = "";
                }
                if (control is ComboBox c)
                {
                    c.SelectedIndex = -1;
                }
                if (control is CheckBox cb)
                {
                    cb.Checked = false;

                }
                if (control is DateTimePicker d)
                {
                    d.Value = DateTime.Now;

                }

            }
        }
        public static void Enable_Reset(Panel panel)
        {
            
            // Get all controls in the panel.

            Control.ControlCollection controls = panel.Controls;
            foreach (Control control in controls)
            {
                if (control is TextBox t)
                {
                    t.Text = "";
                    t.Enabled = true;
                }
                if (control is ComboBox c)
                {
                    c.SelectedIndex = -1;
                    c.Enabled = true;
                }
                if (control is CheckBox cb)
                {
                    cb.Checked = false;
                    cb.Enabled = true;

                }
                if (control is DateTimePicker d)
                {
                    d.Value = DateTime.Now;
                    d.Enabled = true;

                }

            }
        }
        public static void Enable(Panel panel)
        {
            
            // Get all controls in the panel.

            Control.ControlCollection controls = panel.Controls;
            foreach (Control control in controls)
            {
                if (control is TextBox t)
                {
                    t.Enabled = true;
                }
                if (control is ComboBox c)
                {
                    c.Enabled = true;
                }
                if (control is CheckBox cb)
                {
                    cb.Enabled = true;

                }
                if (control is DateTimePicker d)
                {
                    d.Enabled = true;

                }

            }
        }
        public static void DisableBtn(Button btn, Button? btn2 = null, Button? btn3 = null, Button? btn4 = null)
        {
            btn.Enabled = false;
            if (btn2 != null)
            {
                btn2.Enabled = false;

            }
            if (btn3 != null)
            {
                btn3.Enabled = false;

            }
            if (btn4 != null)
            {
                btn4.Enabled = false;

            }

        }
        public static void EnableBtn(Button btn, Button? btn2 = null, Button? btn3 = null, Button? btn4 = null)
        {
            btn.Enabled = true;
            if (btn2 != null)
            {
                btn2.Enabled = true;

            }
            if (btn3 != null)
            {
                btn3.Enabled = true;

            }
            if (btn4 != null)
            {
                btn4.Enabled = true;

            }

        }
    }
}