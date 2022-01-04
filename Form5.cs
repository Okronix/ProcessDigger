using Microsoft.Win32;
using System;
using System.Drawing;
using System.Management;
using System.Windows.Forms;

namespace Process_Digger
{
    public partial class FormComputer : Form
    {
        public FormComputer()
        {
            InitializeComponent();
        }

        private void FormComputer_Load(object sender, System.EventArgs e)
        {
            this.TopMost = Properties.Settings.Default.topMost;
            setTheme();

            foreach (var mo in new ManagementObjectSearcher("root\\cimv2", "select * from Win32_BaseBoard").Get())
                labelBaseBoard.Text += $"{(string)mo["Manufacturer"]} {(string)mo["Product"]}";

            foreach (var mo in new ManagementObjectSearcher("root\\cimv2", "select * from Win32_Processor").Get())
                labelCPU.Text += (string)mo["Name"];

            foreach (var mo in new ManagementObjectSearcher("root\\cimv2", "select * from Win32_VideoController").Get())
                labelVideoController.Text += (string)mo["Name"];
            try
            {
                foreach (var mo in new ManagementObjectSearcher("root\\wmi", "select * from WmiMonitorID").Get())
                    foreach (var monitor in (ushort[])mo["UserFriendlyName"])
                        labelMonitor.Text += (char)monitor;
            }
            catch { }
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
            labelBaseBoard.ForeColor = Color.White;
            labelCPU.ForeColor = Color.White;
            labelVideoController.ForeColor = Color.White;
            labelMonitor.ForeColor = Color.White;
        }

    }
}
