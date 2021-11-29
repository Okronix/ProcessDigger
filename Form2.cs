using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
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
            setTheme();
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
            labelNameProgram.ForeColor = Color.White;
            labelNameDeveloper.ForeColor = Color.White;
            labelDescription.ForeColor = Color.White;
            pictureGH.Image = Properties.Resources.icon_GHLight;
            pictureNAB.Image = Properties.Resources.icon_NABLight;
            btnOk.ForeColor = Color.White;
            btnOk.BackColor = Color.FromArgb(32, 32, 32);
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
