using Microsoft.Win32;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Process_Digger
{
    public partial class FormKillProcess : Form
    {
        public FormKillProcess()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void FormKillProcess_Load(object sender, EventArgs e)
        {
            this.TopMost = Properties.Settings.Default.topMost;
            setTheme();
        }

        private void textProcessName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                processKill();
            }
        }

        void processKill()
        {
            if (textProcessName.Text != "")
            {
                string name = textProcessName.Text.Replace(".exe", "");
                try
                {
                    if (Process.GetProcessesByName(name).Count() != 0)
                    {
                        var process = from pr in Process.GetProcessesByName(name) orderby pr.Id select pr; ;
                        foreach (var proc in process)
                        {
                            proc.Kill();
                            proc.WaitForExit();
                        }
                    }
                    else { MessageBox.Show($"Процесс \"{name}\" не найден", "Process Digger - Ошибка завершения процесса", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                catch { MessageBox.Show($"Процесс \"{name}\" не удалось завершить", "Process Digger - Ошибка завершения процесса", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else { MessageBox.Show($"Введите название процесса", "Process Digger - Ошибка завершения процесса", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            processKill();
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
            labelEnterProcess.ForeColor = Color.White;
            textProcessName.ForeColor = Color.White;
            textProcessName.BackColor = Color.FromArgb(32, 32, 32);
            btnStart.ForeColor = Color.White;
            btnStart.BackColor = Color.FromArgb(32, 32, 32);
            btnCancel.ForeColor = Color.White;
            btnCancel.BackColor = Color.FromArgb(32, 32, 32);
        }
    }
}
