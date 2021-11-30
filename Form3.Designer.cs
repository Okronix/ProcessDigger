
namespace Process_Digger
{
    partial class FormNewProcess
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelEnterProcess = new System.Windows.Forms.Label();
            this.textProcessName = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.checkStartSystem = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelEnterProcess
            // 
            this.labelEnterProcess.Location = new System.Drawing.Point(9, 9);
            this.labelEnterProcess.Name = "labelEnterProcess";
            this.labelEnterProcess.Size = new System.Drawing.Size(248, 18);
            this.labelEnterProcess.TabIndex = 0;
            this.labelEnterProcess.Text = "Введите название запускаемого процесса:";
            this.labelEnterProcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textProcessName
            // 
            this.textProcessName.Location = new System.Drawing.Point(12, 30);
            this.textProcessName.Name = "textProcessName";
            this.textProcessName.Size = new System.Drawing.Size(248, 20);
            this.textProcessName.TabIndex = 1;
            this.textProcessName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textProcessName_KeyPress);
            // 
            // btnStart
            // 
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Location = new System.Drawing.Point(104, 87);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Запустить";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(185, 87);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkStartSystem
            // 
            this.checkStartSystem.AutoSize = true;
            this.checkStartSystem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkStartSystem.Location = new System.Drawing.Point(15, 56);
            this.checkStartSystem.Name = "checkStartSystem";
            this.checkStartSystem.Size = new System.Drawing.Size(214, 17);
            this.checkStartSystem.TabIndex = 5;
            this.checkStartSystem.Text = "Запустить от имени администратора";
            this.checkStartSystem.UseVisualStyleBackColor = true;
            // 
            // FormNewProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 121);
            this.Controls.Add(this.checkStartSystem);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.textProcessName);
            this.Controls.Add(this.labelEnterProcess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNewProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Process Digger - Запуск нового процесса";
            this.Load += new System.EventHandler(this.FormNewProcess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEnterProcess;
        private System.Windows.Forms.TextBox textProcessName;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox checkStartSystem;
    }
}