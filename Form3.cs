using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Process_Digger
{
    public partial class FormNewProcess : Form
    {
        public FormNewProcess()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            processStart();
        }

        private void textProcessName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                processStart();
            }
        }

        void processStart()
        {
            try
            {
                if (textProcessName.Text != "")
                {
                    if (checkStartSystem.Checked)
                    {
                        Process proc = new Process();
                        proc.StartInfo.FileName = textProcessName.Text;
                        proc.StartInfo.UseShellExecute = true;
                        proc.StartInfo.Verb = "runas";
                        proc.Start();
                    }
                    else
                    {
                        Process.Start(textProcessName.Text);
                    }
                }
                else { MessageBox.Show($"Введите название процесса", "Process Digger - Ошибка запуска процесса", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch
            { MessageBox.Show($"Процесс \"{textProcessName.Text}\" не удалось запустить. Проверьте название", "Process Digger - Ошибка запуска процесса", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }


        private void FormNewProcess_Load(object sender, EventArgs e)
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
                        RegistryKey lightThemeStatus = Registry.CurrentUser.OpenSubKey("SOFTWARE").OpenSubKey("Microsoft").OpenSubKey("Windows").OpenSubKey("CurrentVersion").OpenSubKey("Themes").OpenSubKey("Personalize");

                        if (Convert.ToInt32(lightThemeStatus.GetValue("AppsUseLightTheme")) == 0)
                        {
                            setDarkTheme();
                        }

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
            checkStartSystem.ForeColor = Color.White;
            textProcessName.ForeColor = Color.White;
            textProcessName.BackColor = Color.FromArgb(32, 32, 32);
            btnStart.ForeColor = Color.White;
            btnStart.BackColor = Color.FromArgb(32, 32, 32);
            btnCancel.ForeColor = Color.White;
            btnCancel.BackColor = Color.FromArgb(32, 32, 32);
        }
    }
}
