
namespace Process_Digger
{
    partial class FormComputer
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
            this.labelBaseBoard = new System.Windows.Forms.Label();
            this.labelCPU = new System.Windows.Forms.Label();
            this.labelVideoController = new System.Windows.Forms.Label();
            this.labelMonitor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelBaseBoard
            // 
            this.labelBaseBoard.Location = new System.Drawing.Point(12, 13);
            this.labelBaseBoard.Name = "labelBaseBoard";
            this.labelBaseBoard.Size = new System.Drawing.Size(388, 27);
            this.labelBaseBoard.TabIndex = 0;
            this.labelBaseBoard.Text = "Материнская плата: ";
            // 
            // labelCPU
            // 
            this.labelCPU.Location = new System.Drawing.Point(12, 40);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(388, 27);
            this.labelCPU.TabIndex = 1;
            this.labelCPU.Text = "Процессор: ";
            // 
            // labelVideoController
            // 
            this.labelVideoController.Location = new System.Drawing.Point(12, 67);
            this.labelVideoController.Name = "labelVideoController";
            this.labelVideoController.Size = new System.Drawing.Size(388, 27);
            this.labelVideoController.TabIndex = 2;
            this.labelVideoController.Text = "Видеокарта: ";
            // 
            // labelMonitor
            // 
            this.labelMonitor.Location = new System.Drawing.Point(12, 94);
            this.labelMonitor.Name = "labelMonitor";
            this.labelMonitor.Size = new System.Drawing.Size(388, 27);
            this.labelMonitor.TabIndex = 3;
            this.labelMonitor.Text = "Монитор: ";
            // 
            // FormComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 139);
            this.Controls.Add(this.labelMonitor);
            this.Controls.Add(this.labelVideoController);
            this.Controls.Add(this.labelCPU);
            this.Controls.Add(this.labelBaseBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormComputer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Process Digger - О компьютере";
            this.Load += new System.EventHandler(this.FormComputer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelBaseBoard;
        private System.Windows.Forms.Label labelCPU;
        private System.Windows.Forms.Label labelVideoController;
        private System.Windows.Forms.Label labelMonitor;
    }
}