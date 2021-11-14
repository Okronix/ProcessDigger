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
            comboTheme.SelectedIndex = Properties.Settings.Default.theme;
            comboSort.SelectedIndex = Properties.Settings.Default.sortBy - 1;
            checkBox1.Checked = Properties.Settings.Default.topMost;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.theme = comboTheme.SelectedIndex;
            Properties.Settings.Default.sortBy = comboSort.SelectedIndex + 1;
            Properties.Settings.Default.topMost = checkBox1.Checked;
            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
