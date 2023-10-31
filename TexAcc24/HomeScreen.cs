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
    public partial class HomeScreen : Sample
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void UserBtn_Click(object sender, EventArgs e)
        {
            var user = new Users();
            Mcls.ShowWin(user, this, Mdi.ActiveForm);
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            Mcls.Heading(TopPanel, HeadingLable);
        }

        private void Items_Click(object sender, EventArgs e)
        {
            Items i = new Items();
            Mcls.ShowWin(i, this, Mdi.ActiveForm);
        }
    }
}
