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
    }
}