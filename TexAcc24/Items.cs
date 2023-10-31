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
    public partial class Items : Sample2
    {
        public Items()
        {
            InitializeComponent();
        }

        private DataInList dil = new DataInList();
        protected override void AddNewBtn_Click(object sender, System.EventArgs e)
        {
            Mcls.Enable_Reset(LeftPanel);
            Mcls.EnableBtn(SaveBtn);
            Mcls.DisableBtn(AddNewBtn);
            dil.GetDataInList("GetCategoryData", CatCombo, "ID", "Category");
        }

    }
}
