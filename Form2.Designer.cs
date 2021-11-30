
namespace Process_Digger
{
    partial class FormInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo));
            this.labelNameDeveloper = new System.Windows.Forms.Label();
            this.labelNameProgram = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureTG = new System.Windows.Forms.PictureBox();
            this.pictureNAB = new System.Windows.Forms.PictureBox();
            this.pictureGH = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNAB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGH)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNameDeveloper
            // 
            this.labelNameDeveloper.AutoSize = true;
            this.labelNameDeveloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameDeveloper.Location = new System.Drawing.Point(156, 224);
            this.labelNameDeveloper.Name = "labelNameDeveloper";
            this.labelNameDeveloper.Size = new System.Drawing.Size(50, 13);
            this.labelNameDeveloper.TabIndex = 3;
            this.labelNameDeveloper.Text = "Okronix";
            // 
            // labelNameProgram
            // 
            this.labelNameProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameProgram.Location = new System.Drawing.Point(83, 12);
            this.labelNameProgram.Name = "labelNameProgram";
            this.labelNameProgram.Size = new System.Drawing.Size(216, 65);
            this.labelNameProgram.TabIndex = 5;
            this.labelNameProgram.Text = "Process Digger";
            this.labelNameProgram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDescription
            // 
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescription.Location = new System.Drawing.Point(9, 105);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(290, 75);
            this.labelDescription.TabIndex = 6;
            this.labelDescription.Text = "Process Digger - интуитивно понятная утилита для упрощенной работы с процессами н" +
    "а ОС Windows";
            // 
            // btnOk
            // 
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.Location = new System.Drawing.Point(12, 219);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureTG
            // 
            this.pictureTG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureTG.Image = global::Process_Digger.Properties.Resources.icon_TG;
            this.pictureTG.Location = new System.Drawing.Point(212, 217);
            this.pictureTG.Name = "pictureTG";
            this.pictureTG.Size = new System.Drawing.Size(25, 25);
            this.pictureTG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureTG.TabIndex = 2;
            this.pictureTG.TabStop = false;
            this.pictureTG.Click += new System.EventHandler(this.pictureTG_Click);
            // 
            // pictureNAB
            // 
            this.pictureNAB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureNAB.Image = global::Process_Digger.Properties.Resources.icon_NAB;
            this.pictureNAB.Location = new System.Drawing.Point(274, 217);
            this.pictureNAB.Name = "pictureNAB";
            this.pictureNAB.Size = new System.Drawing.Size(25, 25);
            this.pictureNAB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureNAB.TabIndex = 1;
            this.pictureNAB.TabStop = false;
            this.pictureNAB.Click += new System.EventHandler(this.pictureNAB_Click);
            // 
            // pictureGH
            // 
            this.pictureGH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureGH.Image = global::Process_Digger.Properties.Resources.icon_GH;
            this.pictureGH.Location = new System.Drawing.Point(243, 217);
            this.pictureGH.Name = "pictureGH";
            this.pictureGH.Size = new System.Drawing.Size(25, 25);
            this.pictureGH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureGH.TabIndex = 0;
            this.pictureGH.TabStop = false;
            this.pictureGH.Click += new System.EventHandler(this.pictureGH_Click);
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 256);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelNameProgram);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelNameDeveloper);
            this.Controls.Add(this.pictureTG);
            this.Controls.Add(this.pictureNAB);
            this.Controls.Add(this.pictureGH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Process Digger - О программе";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNAB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureGH;
        private System.Windows.Forms.PictureBox pictureNAB;
        private System.Windows.Forms.PictureBox pictureTG;
        private System.Windows.Forms.Label labelNameDeveloper;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelNameProgram;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button btnOk;
    }
}