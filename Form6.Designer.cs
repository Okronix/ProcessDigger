
namespace Process_Digger
{
    partial class FormKillProcess
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.textProcessName = new System.Windows.Forms.TextBox();
            this.labelEnterProcess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(185, 61);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnStart
            // 
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Location = new System.Drawing.Point(104, 61);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Завершить";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // textProcessName
            // 
            this.textProcessName.Location = new System.Drawing.Point(12, 30);
            this.textProcessName.Name = "textProcessName";
            this.textProcessName.Size = new System.Drawing.Size(248, 20);
            this.textProcessName.TabIndex = 7;
            this.textProcessName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textProcessName_KeyPress);
            // 
            // labelEnterProcess
            // 
            this.labelEnterProcess.Location = new System.Drawing.Point(9, 9);
            this.labelEnterProcess.Name = "labelEnterProcess";
            this.labelEnterProcess.Size = new System.Drawing.Size(248, 18);
            this.labelEnterProcess.TabIndex = 6;
            this.labelEnterProcess.Text = "Введите название завершаемого процесса:";
            this.labelEnterProcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormKillProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 92);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.textProcessName);
            this.Controls.Add(this.labelEnterProcess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormKillProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Process Digger - Завершение процесса";
            this.Load += new System.EventHandler(this.FormKillProcess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox textProcessName;
        private System.Windows.Forms.Label labelEnterProcess;
    }
}