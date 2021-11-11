using System;
using System.Collections.Specialized;
using System.Diagnostics;
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
            StringCollection authorNames = new StringCollection();
            string[] names = new string[] {};
            authorNames.AddRange(names);
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

        private void FormNewProcess_Load(object sender, EventArgs e)
        {
            this.TopMost = Properties.Settings.Default.topMost;
        }
    }
}
