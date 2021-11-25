using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Windows.Forms;

namespace Process_Digger
{
    public partial class Form1 : Form
    {
        int processCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setTheme();
            update();
            updateProcess();
        }

        void update()
        {
            this.Size = Properties.Settings.Default.size;
            this.TopMost = Properties.Settings.Default.topMost;
            поверхВсехОконToolStripMenuItem.Checked = Properties.Settings.Default.topMost;
        }

        public void updateProcess()
        {
            dataGridView1.Rows.Clear();
            var allProcess = from pr in Process.GetProcesses(".")
                             orderby pr.Id
                             select pr;
            int i = 0;
            foreach (var proc in allProcess)
            {
                dataGridView1.Rows.Add();
                try
                {
                    dataGridView1.Rows[i].Cells["ColumnPic"].Value = new Bitmap(new Bitmap(Icon.ExtractAssociatedIcon(proc.MainModule.FileName.ToString()).ToBitmap()), new Size(20, 20));//Icon.ExtractAssociatedIcon(proc.StartInfo.FileName.ToString()).ToBitmap();
                }
                catch
                {
                    dataGridView1.Rows[i].Cells["ColumnPic"].Value = new Bitmap(new Bitmap(Properties.Resources.icoWinStandart.ToBitmap()));
                }

                dataGridView1.Rows[i].Cells["ColumnName"].Value = proc.ProcessName + ".exe";
                dataGridView1.Rows[i].Cells["ColumnNum"].Value = proc.Id;
                dataGridView1.Rows[i].Cells["Column3"].Value = (proc.WorkingSet64 - proc.PrivateMemorySize64) / 1048576 + " MB";
                dataGridView1.Rows[i].Cells["Column4"].Value = proc.WorkingSet64 / 1048576 + " MB";
                i++;
            }
            this.dataGridView1.Sort(this.dataGridView1.Columns[Properties.Settings.Default.sortBy], ListSortDirection.Ascending);
            toolStripStatusLabel1.Text = $"Процессов запущено: {dataGridView1.Rows.Count.ToString()}";
            processCount = dataGridView1.Rows.Count;
        }

        void processKill(int id)
        {
            try
            {
                Process process = (Process.GetProcessById(id));
                process.Kill();
                process.WaitForExit();
            }
            catch { MessageBox.Show($"Процесс с идентификатором {id} не удалось завершить", "Process Digger - Ошибка завершения процесса", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            updateProcess();

        }

        void allProcessKill(string name)
        {
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

        private void запуститьПроцессToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewProcess f3 = new FormNewProcess();
            f3.ShowDialog();
        }

        private void btnKill_Click(object sender, EventArgs e)
        {
            FormKillProcess f6 = new FormKillProcess();
            f6.ShowDialog();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    dataGridView1.ClearSelection();
                    dataGridView1[e.ColumnIndex, e.RowIndex].Selected = true;
                }
                catch { }
            }
        }

        private void свойстваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[1].Value != null)
            {
                infoProcess(Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value));
            }
        }

        void infoProcess(int id)
        {
            Process process = Process.GetProcessById(id);
            FileInfo info = new FileInfo(process.MainModule.FileName);
            //info.
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            update();
        }

        private void открытьНастройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSettings f4 = new FormSettings();
            f4.ShowDialog();
        }

        private void поверхВсехОконToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (поверхВсехОконToolStripMenuItem.Checked)
            {
                Properties.Settings.Default.topMost = false;
            }
            else
            {
                Properties.Settings.Default.topMost = true;
            }
            Properties.Settings.Default.Save();
            поверхВсехОконToolStripMenuItem.Checked = Properties.Settings.Default.topMost;
            this.TopMost = Properties.Settings.Default.topMost;
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                Properties.Settings.Default.size = this.Size;
                Properties.Settings.Default.Save();
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfo f2 = new FormInfo();
            f2.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Process.GetProcesses(".").Length != processCount)
            {
                updateProcess();
            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13 && dataGridView1.CurrentRow.Cells[2].Value != null)
            {
                processKill(Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index - 1].Cells[2].Value));
            }
        }

        public void setTheme()
        {
            switch (Properties.Settings.Default.theme)
            {
                case 0: //авто
                    {
                        break;
                    }
                case 1: //светлая
                    {
                        dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                        dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
                        dataGridView1.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;
                        dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
                        break;
                    }
                case 2: //темная
                    {
                        statusStrip1.ForeColor = Color.White;
                        statusStrip1.BackColor = Color.FromArgb(51, 51, 51);
                        menuStrip1.ForeColor = Color.White;
                        menuStrip1.BackColor = Color.FromArgb(51, 51, 51);
                        menuProcess.ForeColor = Color.White;
                        menuProcess.BackColor = Color.FromArgb(51, 51, 51);
                        menuSettings.ForeColor = Color.White;
                        menuSettings.BackColor = Color.FromArgb(51, 51, 51);
                        menuInformation.ForeColor = Color.White;
                        menuInformation.BackColor = Color.FromArgb(51, 51, 51);

                        contextData.BackColor = Color.FromArgb(51, 51, 51);
                        contextData.ForeColor = Color.White;

                        dataGridView1.ForeColor = Color.FromArgb(255, 255, 255);
                        dataGridView1.BackgroundColor = Color.FromArgb(32, 32, 32);
                        dataGridView1.GridColor = Color.FromArgb(32, 32, 32);

                        dataGridView1.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(149, 160, 166);
                        dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(32, 32, 32);

                        dataGridView1.DefaultCellStyle.ForeColor = Color.FromArgb(149, 160, 166);
                        dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(32, 32, 32);

                        dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
                        dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Black;
                        dataGridView1.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.White;
                        dataGridView1.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.Black;

                        dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(149, 160, 166);
                        dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(32, 32, 32);
                        dataGridView1.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(149, 160, 166);
                        dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(32, 32, 32);
                        break;
                    }
                case 3: //черная(AMOLED)
                    {
                        break;
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            statusStrip1.ForeColor = Color.White;
            statusStrip1.BackColor = Color.FromArgb(51, 51, 51);
            menuStrip1.ForeColor = Color.White;
            menuStrip1.BackColor = Color.FromArgb(51, 51, 51);
            menuProcess.ForeColor = Color.White;
            menuProcess.BackColor = Color.FromArgb(51, 51, 51);
            menuSettings.ForeColor = Color.White;
            menuSettings.BackColor = Color.FromArgb(51, 51, 51);
            menuInformation.ForeColor = Color.White;
            menuInformation.BackColor = Color.FromArgb(51, 51, 51);

            contextData.BackColor = Color.FromArgb(51, 51, 51);
            contextData.ForeColor = Color.White;

            dataGridView1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridView1.BackgroundColor = Color.FromArgb(32, 32, 32);
            dataGridView1.GridColor = Color.FromArgb(32, 32, 32);

            dataGridView1.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(149, 160, 166);
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(32, 32, 32);

            dataGridView1.DefaultCellStyle.ForeColor = Color.FromArgb(149, 160, 166);
            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(32, 32, 32);

            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.Black;


            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(149, 160, 166);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(32, 32, 32);
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(149, 160, 166);
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(32, 32, 32);

            //Util.Find<HScrollBar>(dataGridView1).BackColor = Color.Red;
        }

        private void завершитьПроцессToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            processKill(Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value));
        }

        void treeProcessKill(int pid)
        {
            if (pid == 0)
            {
                return;
            }
            ManagementObjectSearcher searcher = new ManagementObjectSearcher
                    ("Select * From Win32_Process Where ParentProcessID=" + pid);
            ManagementObjectCollection moc = searcher.Get();
            foreach (ManagementObject mo in moc)
            {
                treeProcessKill(Convert.ToInt32(mo["ProcessID"]));
            }
            try
            {
                Process proc = Process.GetProcessById(pid);
                proc.Kill();
            }
            catch (ArgumentException)
            {
                // Process already exited.
            }
        }

        private void завершитьПроцессыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            allProcessKill(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString().Replace(".exe", ""));
        }

        private void завершитьДервеоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processKill(Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value));
        }
    }
}
