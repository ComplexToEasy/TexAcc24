using System.Windows.Forms;
using TexAcc24.Data;

namespace TexAcc24
{
    public partial class Sample2 : Sample
    {
        protected Sample2()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, System.EventArgs e)
        {
            HomeScreen home = new HomeScreen();
            Mcls.ShowWin(home, Mdi.ActiveForm);
        }

        protected virtual void AddNewBtn_Click(object sender, System.EventArgs e)
        {

        }

        protected virtual void DeleteBtn_Click(object sender, System.EventArgs e)
        {

        }

        protected virtual void SaveBtn_Click(object sender, System.EventArgs e)
        {

        }

        protected virtual void UpdateBtn_Click(object sender, System.EventArgs e)
        {

        }

        protected virtual void ShowBtn_Click(object sender, System.EventArgs e)
        {

        }

        protected virtual void ClearScreen_Click(object sender, System.EventArgs e)
        {

        }

        protected virtual void SearchTxt_TextChanged(object sender, System.EventArgs e)
        {

        }
    }
}