
namespace Process_Digger
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnPic = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextData = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.завершитьПроцессToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.завершитьПроцессыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.завершитьДеревоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.свойстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelPath = new System.Windows.Forms.Label();
            this.labelNameWindow = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuProcess = new System.Windows.Forms.ToolStripMenuItem();
            this.запуститьПроцессToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завершитьПроцессToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.поверхВсехОконToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьНастройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.оКомпьютереToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textFind = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextData.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPic,
            this.ColumnName,
            this.ColumnNum,
            this.ColumnCP,
            this.ColumnRam});
            this.dataGridView1.ContextMenuStrip = this.contextData;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(460, 448);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.Sorted += new System.EventHandler(this.dataGridView1_Sorted);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            // 
            // ColumnPic
            // 
            this.ColumnPic.HeaderText = "";
            this.ColumnPic.Name = "ColumnPic";
            this.ColumnPic.ReadOnly = true;
            this.ColumnPic.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnPic.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnPic.Width = 25;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Название";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Width = 180;
            // 
            // ColumnNum
            // 
            this.ColumnNum.HeaderText = "ID";
            this.ColumnNum.Name = "ColumnNum";
            this.ColumnNum.ReadOnly = true;
            this.ColumnNum.Width = 50;
            // 
            // ColumnCP
            // 
            this.ColumnCP.HeaderText = "ЦП, %";
            this.ColumnCP.Name = "ColumnCP";
            this.ColumnCP.ReadOnly = true;
            // 
            // ColumnRam
            // 
            this.ColumnRam.HeaderText = "Память, MB";
            this.ColumnRam.Name = "ColumnRam";
            this.ColumnRam.ReadOnly = true;
            // 
            // contextData
            // 
            this.contextData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.завершитьПроцессToolStripMenuItem1,
            this.завершитьПроцессыToolStripMenuItem1,
            this.завершитьДеревоToolStripMenuItem,
            this.свойстваToolStripMenuItem});
            this.contextData.Name = "contextData";
            this.contextData.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextData.Size = new System.Drawing.Size(182, 92);
            // 
            // завершитьПроцессToolStripMenuItem1
            // 
            this.завершитьПроцессToolStripMenuItem1.Image = global::Process_Digger.Properties.Resources.icon_ProcessKill;
            this.завершитьПроцессToolStripMenuItem1.Name = "завершитьПроцессToolStripMenuItem1";
            this.завершитьПроцессToolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.завершитьПроцессToolStripMenuItem1.Text = "Завершить процесс";
            this.завершитьПроцессToolStripMenuItem1.Click += new System.EventHandler(this.завершитьПроцессToolStripMenuItem1_Click);
            // 
            // завершитьПроцессыToolStripMenuItem1
            // 
            this.завершитьПроцессыToolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control;
            this.завершитьПроцессыToolStripMenuItem1.Image = global::Process_Digger.Properties.Resources.icon_ProcessesKill;
            this.завершитьПроцессыToolStripMenuItem1.Name = "завершитьПроцессыToolStripMenuItem1";
            this.завершитьПроцессыToolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.завершитьПроцессыToolStripMenuItem1.Text = "Завершить процессы";
            this.завершитьПроцессыToolStripMenuItem1.Click += new System.EventHandler(this.завершитьПроцессыToolStripMenuItem1_Click);
            // 
            // завершитьДеревоToolStripMenuItem
            // 
            this.завершитьДеревоToolStripMenuItem.Image = global::Process_Digger.Properties.Resources.icon_TreeProcessKill;
            this.завершитьДеревоToolStripMenuItem.Name = "завершитьДеревоToolStripMenuItem";
            this.завершитьДеревоToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.завершитьДеревоToolStripMenuItem.Text = "Завершить дерево";
            this.завершитьДеревоToolStripMenuItem.Click += new System.EventHandler(this.завершитьДервеоToolStripMenuItem_Click);
            // 
            // свойстваToolStripMenuItem
            // 
            this.свойстваToolStripMenuItem.Image = global::Process_Digger.Properties.Resources.icon_Info;
            this.свойстваToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.свойстваToolStripMenuItem.Name = "свойстваToolStripMenuItem";
            this.свойстваToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.свойстваToolStripMenuItem.Text = "Свойства";
            this.свойстваToolStripMenuItem.Click += new System.EventHandler(this.свойстваToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(748, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(117, 17);
            this.toolStripStatusLabel1.Text = "Процессов запущено:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dataGridView1);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(748, 447);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toolStripContainer1.Name = "toolStripContainer1";
            // 
            // toolStripContainer1.RightToolStripPanel
            // 
            this.toolStripContainer1.RightToolStripPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.toolStripContainer1.Size = new System.Drawing.Size(748, 493);
            this.toolStripContainer1.TabIndex = 8;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.labelDescription);
            this.panel1.Controls.Add(this.labelPath);
            this.panel1.Controls.Add(this.labelNameWindow);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Location = new System.Drawing.Point(462, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 448);
            this.panel1.TabIndex = 8;
            // 
            // labelDescription
            // 
            this.labelDescription.Location = new System.Drawing.Point(4, 101);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(279, 307);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "Описание:\r\n";
            // 
            // labelPath
            // 
            this.labelPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPath.AutoEllipsis = true;
            this.labelPath.Location = new System.Drawing.Point(3, 57);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(280, 44);
            this.labelPath.TabIndex = 2;
            this.labelPath.Text = "Путь к файлу:";
            // 
            // labelNameWindow
            // 
            this.labelNameWindow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNameWindow.Location = new System.Drawing.Point(3, 34);
            this.labelNameWindow.Name = "labelNameWindow";
            this.labelNameWindow.Size = new System.Drawing.Size(280, 23);
            this.labelNameWindow.TabIndex = 1;
            this.labelNameWindow.Text = "Имя окна:";
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.Location = new System.Drawing.Point(3, 11);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(280, 23);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Название:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuProcess,
            this.menuSettings,
            this.menuInformation,
            this.textFind});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(748, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuProcess
            // 
            this.menuProcess.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuProcess.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.запуститьПроцессToolStripMenuItem,
            this.завершитьПроцессToolStripMenuItem});
            this.menuProcess.Name = "menuProcess";
            this.menuProcess.Size = new System.Drawing.Size(60, 20);
            this.menuProcess.Text = "Процесс";
            // 
            // запуститьПроцессToolStripMenuItem
            // 
            this.запуститьПроцессToolStripMenuItem.Image = global::Process_Digger.Properties.Resources.icon_ProcessStart;
            this.запуститьПроцессToolStripMenuItem.Name = "запуститьПроцессToolStripMenuItem";
            this.запуститьПроцессToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.запуститьПроцессToolStripMenuItem.Text = "Запустить процесс";
            this.запуститьПроцессToolStripMenuItem.Click += new System.EventHandler(this.запуститьПроцессToolStripMenuItem_Click);
            // 
            // завершитьПроцессToolStripMenuItem
            // 
            this.завершитьПроцессToolStripMenuItem.Image = global::Process_Digger.Properties.Resources.icon_ProcessesKill;
            this.завершитьПроцессToolStripMenuItem.Name = "завершитьПроцессToolStripMenuItem";
            this.завершитьПроцессToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.завершитьПроцессToolStripMenuItem.Text = "Завершить процессы";
            this.завершитьПроцессToolStripMenuItem.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // menuSettings
            // 
            this.menuSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поверхВсехОконToolStripMenuItem,
            this.открытьНастройкиToolStripMenuItem});
            this.menuSettings.Name = "menuSettings";
            this.menuSettings.Size = new System.Drawing.Size(73, 20);
            this.menuSettings.Text = "Настройки";
            // 
            // поверхВсехОконToolStripMenuItem
            // 
            this.поверхВсехОконToolStripMenuItem.Name = "поверхВсехОконToolStripMenuItem";
            this.поверхВсехОконToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.поверхВсехОконToolStripMenuItem.Text = "Поверх всех окон";
            this.поверхВсехОконToolStripMenuItem.Click += new System.EventHandler(this.поверхВсехОконToolStripMenuItem_Click);
            // 
            // открытьНастройкиToolStripMenuItem
            // 
            this.открытьНастройкиToolStripMenuItem.Image = global::Process_Digger.Properties.Resources.icon_Settings;
            this.открытьНастройкиToolStripMenuItem.Name = "открытьНастройкиToolStripMenuItem";
            this.открытьНастройкиToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.открытьНастройкиToolStripMenuItem.Text = "Открыть настройки";
            this.открытьНастройкиToolStripMenuItem.Click += new System.EventHandler(this.открытьНастройкиToolStripMenuItem_Click);
            // 
            // menuInformation
            // 
            this.menuInformation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuInformation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оКомпьютереToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuInformation.Name = "menuInformation";
            this.menuInformation.Size = new System.Drawing.Size(82, 20);
            this.menuInformation.Text = "Информация";
            // 
            // оКомпьютереToolStripMenuItem
            // 
            this.оКомпьютереToolStripMenuItem.Image = global::Process_Digger.Properties.Resources.icon_AboutPC;
            this.оКомпьютереToolStripMenuItem.Name = "оКомпьютереToolStripMenuItem";
            this.оКомпьютереToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.оКомпьютереToolStripMenuItem.Text = "О компьютере";
            this.оКомпьютереToolStripMenuItem.Click += new System.EventHandler(this.оКомпьютереToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Image = global::Process_Digger.Properties.Resources.icon_AboutProgram;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // textFind
            // 
            this.textFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textFind.Font = new System.Drawing.Font("Tahoma", 8F);
            this.textFind.Name = "textFind";
            this.textFind.Size = new System.Drawing.Size(100, 20);
            this.textFind.ToolTipText = "Поиск процесса";
            this.textFind.Leave += new System.EventHandler(this.textFind_Leave);
            this.textFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textFind_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(748, 493);
            this.Controls.Add(this.toolStripContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(487, 528);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Process Digger";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextData.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ContextMenuStrip contextData;
        private System.Windows.Forms.ToolStripMenuItem завершитьПроцессToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem завершитьПроцессыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem свойстваToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripMenuItem завершитьДеревоToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Label labelNameWindow;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuProcess;
        private System.Windows.Forms.ToolStripMenuItem запуститьПроцессToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завершитьПроцессToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSettings;
        private System.Windows.Forms.ToolStripMenuItem поверхВсехОконToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьНастройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuInformation;
        private System.Windows.Forms.ToolStripMenuItem оКомпьютереToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox textFind;
        private System.Windows.Forms.DataGridViewImageColumn ColumnPic;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRam;
    }
}

