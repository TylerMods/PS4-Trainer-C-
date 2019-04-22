using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS4_Trainer_by_TylerMods
{
    public partial class UpdateSuccess : Form
    {
        public UpdateSuccess()
        {
            InitializeComponent();
            this.Hide();
        }

        private async void UpdateSuccess_Load(object sender, EventArgs e)
        {
            okay_button.Visible = false;
            icon.Visible = false;
            LogoAnimator.Show(icon);
            await Task.Delay(700);
            ButtonAnimator.Show(okay_button);
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            LogoAnimator.HideSync(icon);
            this.Close();
        }
    }
}
