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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            update();
        }

        void update()
        {
            this.Size = Properties.Settings.Default.size;
            this.TopMost = Properties.Settings.Default.topMost;
            поверхВсехОконToolStripMenuItem.Checked = Properties.Settings.Default.topMost;
            updateProcess();
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
                //string[] arr = { "" + proc.ProcessName, "" + proc.Id, "" + proc.WorkingSet64 /1000000 + " MB", "" + proc.VirtualMemorySize64 / 1000000 + " MB", "" + proc.MachineName, "" + proc.BasePriority};
                //Icon.ExtractAssociatedIcon(proc.StartInfo.FileName).ToBitmap(), arr
                dataGridView1.Rows.Add();
                try
                {
                    dataGridView1.Rows[i].Cells["ColumnPic"].Value = new Bitmap(new Bitmap(Icon.ExtractAssociatedIcon(proc.MainModule.FileName.ToString()).ToBitmap()), new Size(20, 20));//Icon.ExtractAssociatedIcon(proc.StartInfo.FileName.ToString()).ToBitmap();
                }
                catch {
                    dataGridView1.Rows[i].Cells["ColumnPic"].Value = new Bitmap(new Bitmap(Properties.Resources.icoWinStandart.ToBitmap()));
                }
                dataGridView1.Rows[i].Cells["ColumnName"].Value = proc.ProcessName + ".exe";
                dataGridView1.Rows[i].Cells["ColumnNum"].Value = proc.Id;
                dataGridView1.Rows[i].Cells["Column3"].Value = proc.WorkingSet64 / 1048576 + " MB";
                dataGridView1.Rows[i].Cells["Column4"].Value = proc.VirtualMemorySize64 / 1048576 + " MB";
                i++;
            }
            this.dataGridView1.Sort(this.dataGridView1.Columns[Properties.Settings.Default.sortBy], ListSortDirection.Ascending);
            toolStripStatusLabel1.Text = $"Процессов запущено: {dataGridView1.Rows.Count.ToString()}";
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

        void treeProcessKill(int pid)
        {
            if (pid == 0)
            {
                return;
            }

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select * From Win32_Process Where ParentProcessID=" + pid);
            ManagementObjectCollection objectCollection = searcher.Get();

            foreach (ManagementObject obj in objectCollection)
            {
                treeProcessKill(Convert.ToInt32(obj["Process"]));
            }

            try
            {
                Process p = Process.GetProcessById(pid);
                p.Kill();
                p.WaitForExit();
            }
            catch (ArgumentException) { }
        }

        int GetParentProcessId(Process p)
        {
            int parentID = 0;
            try
            {
                ManagementObject managementObject = new ManagementObject("win32_process.handle='" + p.Id + "'");
                managementObject.Get();
                parentID = Convert.ToInt32(managementObject["ParentProcessId"]);
            }
            catch (Exception) { }

            return parentID;
        }

        private void запуститьПроцессToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewProcess   f3 = new FormNewProcess();
            f3.ShowDialog();
        }

        private void btnKill_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[1].Value != null)
            {
                processKill(Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value));
            }
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

        private void toolUpdate_Click(object sender, EventArgs e)
        {
            updateProcess();
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
            Process process = (Process.GetProcessById(id));
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
            Properties.Settings.Default.size = this.Size;
            Properties.Settings.Default.Save();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfo f2 = new FormInfo();
            f2.ShowDialog();
        }
    }
}
