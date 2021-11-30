using Microsoft.Win32;
using System;
using System.Drawing;
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
            checkBox1.Checked = Properties.Settings.Default.topMost;
            setTheme();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (comboTheme.SelectedIndex != Properties.Settings.Default.theme)
            { MessageBox.Show($"Для применения темы, необходимо перезагрузить программу", "Process Digger - Смена темы", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            Properties.Settings.Default.theme = comboTheme.SelectedIndex;
            Properties.Settings.Default.topMost = checkBox1.Checked;
            Properties.Settings.Default.Save();
            this.Close();
        }
        void setTheme()
        {
            switch (Properties.Settings.Default.theme)
            {
                case 0: //авто
                    {
                        try
                        {
                            RegistryKey lightThemeStatus = Registry.CurrentUser.OpenSubKey("SOFTWARE").OpenSubKey("Microsoft").OpenSubKey("Windows").OpenSubKey("CurrentVersion").OpenSubKey("Themes").OpenSubKey("Personalize");

                            if (Convert.ToInt32(lightThemeStatus.GetValue("AppsUseLightTheme")) == 0)
                            {
                                setDarkTheme();
                            }
                        }
                        catch { }

                        break;
                    }
                case 2: //темная
                    {
                        setDarkTheme();
                        break;
                    }
                case 3: //черная(AMOLED)
                    {
                        break;
                    }
            }
        }

        void setDarkTheme()
        {
            this.BackColor = Color.FromArgb(25, 25, 25);
            label2.ForeColor = Color.White;
            checkBox1.ForeColor = Color.White;
            comboTheme.ForeColor = Color.White;
            comboTheme.BackColor = Color.FromArgb(32, 32, 32);
            comboTheme.FlatStyle = FlatStyle.Popup;
            btnConfirm.ForeColor = Color.White;
            btnConfirm.BackColor = Color.FromArgb(32, 32, 32);
        }

    }
}
