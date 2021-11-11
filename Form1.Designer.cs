
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.процессToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запуститьПроцессToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завершитьПроцессToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завершитьДревоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поверхВсехОконToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьНастройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оКомпьютереToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnPic = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextData = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.завершитьПроцессToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.завершитьДревоToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.свойстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextData.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.процессToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.информацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(457, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // процессToolStripMenuItem
            // 
            this.процессToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.запуститьПроцессToolStripMenuItem,
            this.завершитьПроцессToolStripMenuItem,
            this.завершитьДревоToolStripMenuItem});
            this.процессToolStripMenuItem.Name = "процессToolStripMenuItem";
            this.процессToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.процессToolStripMenuItem.Text = "Процесс";
            // 
            // запуститьПроцессToolStripMenuItem
            // 
            this.запуститьПроцессToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("запуститьПроцессToolStripMenuItem.Image")));
            this.запуститьПроцессToolStripMenuItem.Name = "запуститьПроцессToolStripMenuItem";
            this.запуститьПроцессToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.запуститьПроцессToolStripMenuItem.Text = "Запустить процесс";
            this.запуститьПроцессToolStripMenuItem.Click += new System.EventHandler(this.запуститьПроцессToolStripMenuItem_Click);
            // 
            // завершитьПроцессToolStripMenuItem
            // 
            this.завершитьПроцессToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("завершитьПроцессToolStripMenuItem.Image")));
            this.завершитьПроцессToolStripMenuItem.Name = "завершитьПроцессToolStripMenuItem";
            this.завершитьПроцессToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.завершитьПроцессToolStripMenuItem.Text = "Завершить процесс";
            this.завершитьПроцессToolStripMenuItem.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // завершитьДревоToolStripMenuItem
            // 
            this.завершитьДревоToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("завершитьДревоToolStripMenuItem.Image")));
            this.завершитьДревоToolStripMenuItem.Name = "завершитьДревоToolStripMenuItem";
            this.завершитьДревоToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.завершитьДревоToolStripMenuItem.Text = "Завершить древо";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поверхВсехОконToolStripMenuItem,
            this.открытьНастройкиToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
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
            this.открытьНастройкиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("открытьНастройкиToolStripMenuItem.Image")));
            this.открытьНастройкиToolStripMenuItem.Name = "открытьНастройкиToolStripMenuItem";
            this.открытьНастройкиToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.открытьНастройкиToolStripMenuItem.Text = "Открыть настройки";
            this.открытьНастройкиToolStripMenuItem.Click += new System.EventHandler(this.открытьНастройкиToolStripMenuItem_Click);
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оКомпьютереToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.информацияToolStripMenuItem.Text = "Информация";
            // 
            // оКомпьютереToolStripMenuItem
            // 
            this.оКомпьютереToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("оКомпьютереToolStripMenuItem.Image")));
            this.оКомпьютереToolStripMenuItem.Name = "оКомпьютереToolStripMenuItem";
            this.оКомпьютереToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.оКомпьютереToolStripMenuItem.Text = "О компьютере";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("оПрограммеToolStripMenuItem.Image")));
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolUpdate,
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(457, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolUpdate
            // 
            this.toolUpdate.Image = ((System.Drawing.Image)(resources.GetObject("toolUpdate.Image")));
            this.toolUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolUpdate.Name = "toolUpdate";
            this.toolUpdate.Size = new System.Drawing.Size(77, 22);
            this.toolUpdate.Text = "Обновить";
            this.toolUpdate.Click += new System.EventHandler(this.toolUpdate_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(126, 22);
            this.toolStripButton1.Text = "Завершить процесс";
            this.toolStripButton1.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(117, 22);
            this.toolStripButton2.Text = "Завершить древо";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPic,
            this.ColumnName,
            this.ColumnNum,
            this.Column3,
            this.Column4});
            this.dataGridView1.ContextMenuStrip = this.contextData;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 49);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(457, 444);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
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
            this.ColumnName.Width = 180;
            // 
            // ColumnNum
            // 
            this.ColumnNum.HeaderText = "ID";
            this.ColumnNum.Name = "ColumnNum";
            this.ColumnNum.Width = 50;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Память";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Память";
            this.Column4.Name = "Column4";
            // 
            // contextData
            // 
            this.contextData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.завершитьПроцессToolStripMenuItem1,
            this.завершитьДревоToolStripMenuItem1,
            this.свойстваToolStripMenuItem});
            this.contextData.Name = "contextData";
            this.contextData.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextData.Size = new System.Drawing.Size(174, 70);
            // 
            // завершитьПроцессToolStripMenuItem1
            // 
            this.завершитьПроцессToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("завершитьПроцессToolStripMenuItem1.Image")));
            this.завершитьПроцессToolStripMenuItem1.Name = "завершитьПроцессToolStripMenuItem1";
            this.завершитьПроцессToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.завершитьПроцессToolStripMenuItem1.Text = "Завершить процесс";
            this.завершитьПроцессToolStripMenuItem1.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // завершитьДревоToolStripMenuItem1
            // 
            this.завершитьДревоToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("завершитьДревоToolStripMenuItem1.Image")));
            this.завершитьДревоToolStripMenuItem1.Name = "завершитьДревоToolStripMenuItem1";
            this.завершитьДревоToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.завершитьДревоToolStripMenuItem1.Text = "Завершить древо";
            // 
            // свойстваToolStripMenuItem
            // 
            this.свойстваToolStripMenuItem.Name = "свойстваToolStripMenuItem";
            this.свойстваToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.свойстваToolStripMenuItem.Text = "Свойства";
            this.свойстваToolStripMenuItem.Click += new System.EventHandler(this.свойстваToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 471);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(457, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(117, 17);
            this.toolStripStatusLabel1.Text = "Процессов запущено:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(457, 493);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(460, 528);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Process Digger";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextData.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolUpdate;
        private System.Windows.Forms.ToolStripMenuItem процессToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запуститьПроцессToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завершитьПроцессToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завершитьДревоToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextData;
        private System.Windows.Forms.ToolStripMenuItem завершитьПроцессToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem завершитьДревоToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem свойстваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьНастройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поверхВсехОконToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оКомпьютереToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.DataGridViewImageColumn ColumnPic;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

