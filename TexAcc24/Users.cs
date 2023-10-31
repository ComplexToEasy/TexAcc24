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
    public partial class Users : Sample2
    {
        public Users()
        {
            InitializeComponent();
        }

        private string status ="";
        Selection s = new Selection();
        int userId;

        private void Users_Load(object sender, EventArgs e)
        {
            Mcls.Heading(TopPanel, HeadingLable);
            Mcls.Disable_Reset(LeftPanel);
            Mcls.DisableBtn(UpdateBtn, SaveBtn, DeleteBtn);
            RoleCombo.SelectedIndex = 0;
        }

        protected override void AddNewBtn_Click(object sender, System.EventArgs e)
        {
            Mcls.Enable_Reset(LeftPanel);
            Mcls.EnableBtn(SaveBtn);
            Mcls.DisableBtn(AddNewBtn);
            RoleCombo.SelectedIndex = 0;

        }
        protected override void DeleteBtn_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (userId != 0)
                {
                    DialogResult dr = MessageBox.Show("This record will be deleted. Are you sure?", "Deletion confirmation",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        Deletion d = new Deletion();
                        d.DeleteIt("DeleteUsers", userId);
                        Mcls.Heading(TopPanel, HeadingLable);
                        Mcls.Disable_Reset(LeftPanel);
                        Mcls.DisableBtn(UpdateBtn, SaveBtn, DeleteBtn);
                        Mcls.EnableBtn(AddNewBtn);

                        RoleCombo.SelectedIndex = 0;
                        s.GetUserData(dataGridView, IdGv, LoginNameGv, UsernameGv, PasswordGv, RollGv, IsActiveGv, PhoneGv);

                    }
                }
            }
            catch (Exception exception)
            {
                Mcls.ShowMessage("Error in deletion", "Information", "");

            }

        }

        protected override void SaveBtn_Click(object sender, System.EventArgs e)
        {
            try
            {
                LoginNameErrLbl.Visible = LoginNameTxt.Text.Trim() == "";
                userNameErrLbl.Visible = UserNameTxt.Text.Trim() == "";
                PasswordErrorlbl.Visible = PasswordTxt.Text.Trim() == "";
                roleErrorLble.Visible = RoleCombo.SelectedIndex == -1;
                if (LoginNameErrLbl.Visible || userNameErrLbl.Visible || roleErrorLble.Visible || roleErrorLble.Visible)
                {
                    Mcls.ShowErrorStatus(StatusPanel, StatusLbl);
                }
                else
                {
                    if (IsActiveChk.Checked)
                    {
                        status = "Yes";
                    }
                    else
                    {
                        status = "No";
                    }
                    Mcls.Success(StatusPanel);
                    SaveRecord.InsertUsers(LoginNameTxt.Text, UserNameTxt.Text, PasswordTxt.Text, RoleCombo.Text, status, PhoneTxt.Text);
                    Mcls.ShowMessage("Successfully Saved", "Information", "success");
                    Mcls.Heading(TopPanel, HeadingLable);
                    Mcls.Disable_Reset(LeftPanel);
                    Mcls.DisableBtn(UpdateBtn, SaveBtn, DeleteBtn);
                    RoleCombo.SelectedIndex = 0;
                    s.GetUserData(dataGridView, IdGv, LoginNameGv, UsernameGv, PasswordGv, RollGv, IsActiveGv, PhoneGv);

                }
            }
            catch (Exception exception)
            {
                    Mcls.ShowMessage("Error in Inserting", "Information", "");

            }

        }

        protected override void UpdateBtn_Click(object sender, System.EventArgs e)
        {
            try
            {
                LoginNameErrLbl.Visible = LoginNameTxt.Text.Trim() == "";
                userNameErrLbl.Visible = UserNameTxt.Text.Trim() == "";
                PasswordErrorlbl.Visible = PasswordTxt.Text.Trim() == "";
                roleErrorLble.Visible = RoleCombo.SelectedIndex == -1;
                if (LoginNameErrLbl.Visible || userNameErrLbl.Visible || roleErrorLble.Visible || roleErrorLble.Visible)
                {
                    Mcls.ShowErrorStatus(StatusPanel, StatusLbl);
                }
                else
                {
                    if (IsActiveChk.Checked)
                    {
                        status = "Yes";
                    }
                    else
                    {
                        status = "No";
                    }
                    Mcls.Success(StatusPanel);
                    Updation.UpdateUsers(userId, LoginNameTxt.Text, UserNameTxt.Text, PasswordTxt.Text, RoleCombo.Text, status, PhoneTxt.Text);
                    Mcls.ShowMessage("Successfully Update", "Information", "success");
                    Mcls.Heading(TopPanel, HeadingLable);
                    Mcls.Disable_Reset(LeftPanel);
                    Mcls.DisableBtn(UpdateBtn, SaveBtn, DeleteBtn);
                    Mcls.EnableBtn(AddNewBtn);

                    RoleCombo.SelectedIndex = 0;
                    s.GetUserData(dataGridView, IdGv, LoginNameGv, UsernameGv, PasswordGv, RollGv, IsActiveGv, PhoneGv);

                }
            }
            catch (Exception exception)
            {
                Mcls.ShowMessage("Error in Update", "Information", "");

            }

        }

        protected override void ShowBtn_Click(object sender, System.EventArgs e)
        {
            s.GetUserData(dataGridView, IdGv, LoginNameGv, UsernameGv, PasswordGv,RollGv, IsActiveGv, PhoneGv);
        }
        protected override void ClearScreen_Click(object sender, System.EventArgs e)
        {
            Mcls.Heading(TopPanel, HeadingLable);
            Mcls.EnableBtn(AddNewBtn);

            Mcls.Disable_Reset(LeftPanel);
            Mcls.DisableBtn(UpdateBtn, SaveBtn, DeleteBtn);
            Mcls.Success(StatusPanel);
            s.GetUserData(dataGridView, IdGv, LoginNameGv, UsernameGv, PasswordGv, RollGv, IsActiveGv, PhoneGv);

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                userId = Convert.ToInt32(row.Cells["IdGv"].Value.ToString());
                LoginNameTxt.Text = row.Cells["LoginNameGv"].Value.ToString();
                UserNameTxt.Text = row.Cells["UsernameGv"].Value.ToString();
                PasswordTxt.Text = row.Cells["PasswordGv"].Value.ToString();
                PhoneTxt.Text = row.Cells["PhoneGv"].Value.ToString();
                status = row.Cells["IsActiveGv"].Value.ToString();
                if (status =="Yes")
                {
                    IsActiveChk.CheckState = CheckState.Checked;
                }
                else
                {
                    IsActiveChk.Checked = false;
                }
                RoleCombo.Text = row.Cells["RollGv"].Value.ToString();


                Mcls.Enable(LeftPanel);
                Mcls.EnableBtn(UpdateBtn,DeleteBtn);
                Mcls.DisableBtn(AddNewBtn,SaveBtn);
            }
        }
        protected override void SearchTxt_TextChanged(object sender, System.EventArgs e)
        {
            s.GetUserData(dataGridView, IdGv, LoginNameGv, UsernameGv, PasswordGv, RollGv, IsActiveGv, PhoneGv, SearchTxt.Text);
        }
    }
}
