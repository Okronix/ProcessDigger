using System.Diagnostics;
using System.Windows.Forms;

namespace Process_Digger
{
    public partial class FormInfo : Form
    {
        public FormInfo()
        {
            InitializeComponent();
        }

        private void FormInfo_Load(object sender, System.EventArgs e)
        {
            this.TopMost = Properties.Settings.Default.topMost;
        }

        private void btnOk_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void pictureTG_Click(object sender, System.EventArgs e)
        {
            Process.Start("https://t.me/FRAMEDEV");
        }

        private void pictureGH_Click(object sender, System.EventArgs e)
        {
            Process.Start("https://github.com/Okronix");
        }

        private void pictureNAB_Click(object sender, System.EventArgs e)
        {
            Process.Start("https://notabug.org/Okronix");
        }
    }
}
