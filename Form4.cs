using System;
using System.Windows.Forms;

namespace Process_Digger
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }
        private void FormSettings_Load(object sender, EventArgs e)
        {
            this.TopMost = Properties.Settings.Default.topMost;

            comboBox1.SelectedIndex = Properties.Settings.Default.sortBy;
            checkBox1.Checked = Properties.Settings.Default.topMost;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.sortBy = comboBox1.SelectedIndex;
            Properties.Settings.Default.topMost = checkBox1.Checked;
            Properties.Settings.Default.Save();
            this.Close();
        }


    }
}
