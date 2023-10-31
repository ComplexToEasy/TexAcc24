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
    public partial class Category : Sample2
    {
        public Category()
        {
            InitializeComponent();
        }
        private string status = "";
        Selection s = new Selection();
        int catId;

        private void Category_Load(object sender, EventArgs e)
        {
            Mcls.Heading(TopPanel, HeadingLable);
            Mcls.Disable_Reset(LeftPanel);
            Mcls.DisableBtn(UpdateBtn, SaveBtn, DeleteBtn);
        }

        protected override void AddNewBtn_Click(object sender, System.EventArgs e)
        {
            Mcls.Enable_Reset(LeftPanel);
            Mcls.EnableBtn(SaveBtn);
            Mcls.DisableBtn(AddNewBtn);

        }
        protected override void DeleteBtn_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (catId != 0)
                {
                    DialogResult dr = MessageBox.Show("This record will be deleted. Are you sure?", "Deletion confirmation",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        Deletion d = new Deletion();
                        d.DeleteIt("DeleteCategory", catId);
                        Mcls.Heading(TopPanel, HeadingLable);
                        Mcls.Disable_Reset(LeftPanel);
                        Mcls.DisableBtn(UpdateBtn, SaveBtn, DeleteBtn);
                        Mcls.EnableBtn(AddNewBtn);


                        s.GetCategoryData(dataGridView, IdGv, NameGv);

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
                NameErrLbl.Visible = NameTxt.Text.Trim() == "";
                if (NameErrLbl.Visible)
                {
                    Mcls.ShowErrorStatus(StatusPanel, StatusLbl);
                }
                else
                {

                    Mcls.Success(StatusPanel);
                    SaveRecord.InsertCategory(NameTxt.Text);
                    Mcls.ShowMessage("Successfully Saved", "Information", "success");
                    Mcls.Heading(TopPanel, HeadingLable);
                    Mcls.Disable_Reset(LeftPanel);
                    Mcls.DisableBtn(UpdateBtn, SaveBtn, DeleteBtn);
                    Mcls.EnableBtn(AddNewBtn);

                    s.GetCategoryData(dataGridView, IdGv, NameGv);

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
                NameErrLbl.Visible = NameTxt.Text.Trim() == "";
                if (NameErrLbl.Visible)
                {
                    Mcls.ShowErrorStatus(StatusPanel, StatusLbl);
                }
                else
                {
                    if (catId > 0)
                    {


                        Mcls.Success(StatusPanel);
                        Updation.UpdateCategory(catId, NameTxt.Text);
                        Mcls.ShowMessage("Successfully Saved", "Information", "success");
                        Mcls.Heading(TopPanel, HeadingLable);
                        Mcls.Disable_Reset(LeftPanel);
                        Mcls.DisableBtn(UpdateBtn, SaveBtn, DeleteBtn);
                        Mcls.EnableBtn(AddNewBtn);

                        s.GetCategoryData(dataGridView, IdGv, NameGv);

                    }
                }
            }
            catch (Exception exception)
            {
                Mcls.ShowMessage("Error in Update", "Information", "");

            }

        }

        protected override void ShowBtn_Click(object sender, System.EventArgs e)
        {
            s.GetCategoryData(dataGridView, IdGv, NameGv);
        }
        protected override void ClearScreen_Click(object sender, System.EventArgs e)
        {
            Mcls.Heading(TopPanel, HeadingLable);
            Mcls.EnableBtn(AddNewBtn);

            Mcls.Disable_Reset(LeftPanel);
            Mcls.DisableBtn(UpdateBtn, SaveBtn, DeleteBtn);
            Mcls.Success(StatusPanel);
            s.GetCategoryData(dataGridView, IdGv, NameGv);

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex != -1 && e.RowIndex != -1)
            {

                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                catId = Convert.ToInt32(row.Cells["IdGv"].Value.ToString());
                NameTxt.Text = row.Cells["NameGv"].Value.ToString();
                Mcls.Enable(LeftPanel);
                Mcls.EnableBtn(UpdateBtn, DeleteBtn);
                Mcls.DisableBtn(AddNewBtn, SaveBtn);
            }
        }
    }
}
