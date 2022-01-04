using Microsoft.Win32;
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
            Program.f1 = this;
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            checkTheme();
            update();
            updateProcess();
        }

        void update()
        {
            this.Size = Properties.Settings.Default.size;
            this.TopMost = Properties.Settings.Default.topMost;
            this.dataGridView1.Sort(this.dataGridView1.Columns[Properties.Settings.Default.sortBy], ListSortDirection.Ascending);
            поверхВсехОконToolStripMenuItem.Checked = Properties.Settings.Default.topMost;
        }

        public void updateProcess()
        {
            string selectedProcess = "";
            try
            {
                selectedProcess = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            }
            catch { }


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
                    dataGridView1.Rows[i].Cells["ColumnPic"].Value = new Bitmap(new Bitmap(Properties.Resources.ico_WinStandart.ToBitmap()));
                }


                dataGridView1.Rows[i].Cells["ColumnName"].Value = proc.ProcessName + ".exe";
                dataGridView1.Rows[i].Cells["ColumnNum"].Value = proc.Id;
                try
                {
                    var wallTime = DateTime.Now - proc.StartTime;
                    if (proc.HasExited) wallTime = proc.ExitTime - proc.StartTime;
                    var procTime = proc.TotalProcessorTime;
                    var cpuUsage = 100 * procTime.TotalMilliseconds / wallTime.TotalMilliseconds;
                    dataGridView1.Rows[i].Cells["ColumnCP"].Value = Math.Round(cpuUsage, 2);
                }
                catch
                {

                }
                dataGridView1.Rows[i].Cells["ColumnRam"].Value = (proc.PrivateMemorySize64) / 1048576;

                i++;
            }
            dataGridView1.Sort(dataGridView1.Columns[Properties.Settings.Default.sortBy], ListSortDirection.Ascending);
            toolStripStatusLabel1.Text = $"Процессов запущено: {dataGridView1.Rows.Count.ToString()}";
            processCount = dataGridView1.Rows.Count;

            //findProcess(selectedProcess);
            findProcess(textFind.Text);

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

        void infoProcess(int id)
        {
            Process process = Process.GetProcessById(id);
            FileInfo info = new FileInfo(process.MainModule.FileName);
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

        public void checkTheme()
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
                                setTheme(Color.White, Color.FromArgb(43, 43, 43), Color.FromArgb(25, 25, 25), Color.FromArgb(32, 32, 32), Color.FromArgb(52, 52, 52), Color.FromArgb(255, 255, 255), Color.FromArgb(119, 119, 119), Color.FromArgb(149, 160, 166));
                            }
                            else if (Convert.ToInt32(lightThemeStatus.GetValue("AppsUseLightTheme")) == 1)
                            {
                                setTheme(Color.Black, Color.FromArgb(240, 240, 240), Color.FromArgb(240, 240, 240), Color.White, Color.White, Color.White, Color.FromArgb(0, 120, 215), Color.White);
                            }
                        }
                        catch
                        {
                            setTheme(Color.Black, Color.FromArgb(240, 240, 240), Color.FromArgb(240, 240, 240), Color.White, Color.White, Color.White, Color.FromArgb(0, 120, 215), Color.White);
                        }
                        break;
                    }
                case 1: //Светлая
                    {
                        setTheme(Color.Black, Color.FromArgb(240, 240, 240), Color.FromArgb(240, 240, 240), Color.White, Color.White, Color.White, Color.FromArgb(0, 120, 215), Color.White);
                        break;
                    }
                case 2: //темная
                    {
                        setTheme(Color.White, Color.FromArgb(43, 43, 43), Color.FromArgb(25, 25, 25), Color.FromArgb(32, 32, 32), Color.FromArgb(52, 52, 52), Color.FromArgb(255, 255, 255), Color.FromArgb(119, 119, 119), Color.FromArgb(149, 160, 166));
                        break;
                    }
                case 3: //черная(AMOLED)
                    {
                        break;
                    }
            }
        }

        void setLightTheme()
        {
            //Color ColorText = Color.Black;
            //Color ColorBack = Color.FromArgb(240, 240, 240);
            //Color ColorControlBack = Color.FromArgb(240, 240, 240);
            //Color ColorGrid = Color.Black;
            //Color ColorTextFind = Color.White;
            //Color ColorDataGrid = Color.White;
            //Color ColorDataGridSelectBack = Color.FromArgb(0, 120, 215);
            //Color ColorDataGridHeader = Color.White;
        }

        void setTheme(Color ColorText, Color ColorBack, Color ColorControlBack, Color ColorGrid, Color ColorTextFind, Color ColorDataGrid, Color ColorDataGridSelectBack, Color ColorDataGridHeader)
        {
            //Color ColorText = Color.White;
            //Color ColorBack = Color.FromArgb(43, 43, 43);
            //Color ColorControlBack = Color.FromArgb(25, 25, 25);
            //Color ColorGrid = Color.FromArgb(32, 32, 32);
            //Color ColorTextFind = Color.FromArgb(52, 52, 52);
            //Color ColorDataGrid = Color.FromArgb(255, 255, 255);
            //Color ColorDataGridSelectBack = Color.FromArgb(119, 119, 119);
            //Color ColorDataGridHeader = Color.FromArgb(149, 160, 166);

            statusStrip1.ForeColor = ColorText;
            statusStrip1.BackColor = ColorControlBack;
            menuStrip1.ForeColor = ColorText;
            menuStrip1.BackColor = ColorControlBack;

            menuProcess.ForeColor = ColorText;
            menuProcess.BackColor = ColorControlBack;
            запуститьПроцессToolStripMenuItem.ForeColor = ColorText;
            запуститьПроцессToolStripMenuItem.BackColor = ColorBack;
            завершитьПроцессToolStripMenuItem.ForeColor = ColorText;
            завершитьПроцессToolStripMenuItem.BackColor = ColorBack;

            menuSettings.ForeColor = ColorText;
            menuSettings.BackColor = ColorControlBack;
            поверхВсехОконToolStripMenuItem.ForeColor = ColorText;
            поверхВсехОконToolStripMenuItem.BackColor = ColorBack;
            открытьНастройкиToolStripMenuItem.ForeColor = ColorText;
            открытьНастройкиToolStripMenuItem.BackColor = ColorBack;

            menuInformation.ForeColor = ColorText;
            menuInformation.BackColor = ColorControlBack;
            оКомпьютереToolStripMenuItem.ForeColor = ColorText;
            оКомпьютереToolStripMenuItem.BackColor = ColorBack;
            оПрограммеToolStripMenuItem.ForeColor = ColorText;
            оПрограммеToolStripMenuItem.BackColor = ColorBack;

            textFind.ForeColor = ColorText;
            textFind.BackColor = ColorTextFind;

            contextData.BackColor = ColorBack;
            contextData.ForeColor = ColorText;
            завершитьПроцессToolStripMenuItem1.BackColor = 
            завершитьПроцессыToolStripMenuItem1.BackColor = ColorBack;
            завершитьДеревоToolStripMenuItem.BackColor = ColorBack;

            dataGridView1.ForeColor = ColorDataGrid;
            dataGridView1.BackgroundColor = ColorGrid;
            dataGridView1.GridColor = ColorGrid;


            dataGridView1.AlternatingRowsDefaultCellStyle.ForeColor = ColorText;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = ColorGrid;

            dataGridView1.DefaultCellStyle.ForeColor = ColorText;
            dataGridView1.DefaultCellStyle.BackColor = ColorGrid;

            dataGridView1.DefaultCellStyle.SelectionForeColor = ColorText;
            dataGridView1.DefaultCellStyle.SelectionBackColor = ColorDataGridSelectBack;
            dataGridView1.AlternatingRowsDefaultCellStyle.SelectionForeColor = ColorText;
            dataGridView1.AlternatingRowsDefaultCellStyle.SelectionBackColor = ColorDataGridSelectBack;

            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = ColorText;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = ColorControlBack;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionForeColor = ColorDataGridHeader;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = ColorControlBack;

            toolStripContainer1.ContentPanel.BackColor = ColorControlBack;

            panel1.BackColor = ColorControlBack;
            labelName.ForeColor = ColorText;
            labelNameWindow.ForeColor = ColorText;
            labelPath.ForeColor = ColorText;
            labelDescription.ForeColor = ColorText;

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
            catch {}
        }

        private void завершитьПроцессыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            allProcessKill(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString().Replace(".exe", ""));
        }

        private void завершитьДервеоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processKill(Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value));
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int pid = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value);
                Process proc = Process.GetProcessById(pid);

                labelName.Text = $"Имя: {proc.ProcessName}";
                labelNameWindow.Text = $"Имя окна: ";
                labelNameWindow.Text = $"Имя окна: {proc.MainWindowTitle}";

                labelPath.Text = $"Путь к файлу: ";
                labelPath.Text = $"Путь к файлу: {proc.MainModule.FileName.ToString()}";

            }
            catch { }

        }

        private void textFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (textFind.Text != "")
                {
                    findProcess(textFind.Text);
                    //if (!dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString().ToLower().Contains(findText))
                    //{ MessageBox.Show($"Ничего не найдено", "Process Digger - Ошибка поиска процесса", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                }
                else { MessageBox.Show($"Введите название процесса", "Process Digger - Ошибка поиска процесса", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            {
                findProcess(textFind.Text);
            }
        }

        void findProcess(string findText)
        {
            findText = findText.ToLower();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[1].Value.ToString().ToLower().Contains(findText))
                {
                    dataGridView1.Rows[i].Visible = true;
                    //dataGridView1.ClearSelection();
                    //dataGridView1.Rows[i].Selected = true;
                    //dataGridView1.FirstDisplayedScrollingRowIndex = i;
                    //break;
                }
                else
                {
                    dataGridView1.Rows[i].Visible = false;
                }
            }
        }

        private void оКомпьютереToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormComputer f5 = new FormComputer();
            f5.ShowDialog();
        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            Properties.Settings.Default.sortBy = dataGridView1.SortedColumn.Index;
            Properties.Settings.Default.Save();
        }

        private void textFind_Leave(object sender, EventArgs e)
        {
            findProcess(textFind.Text);
        }


    }
}
