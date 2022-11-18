
namespace PDFCompare
{
    partial class Form1
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
            this.PDF1 = new System.Windows.Forms.TextBox();
            this.PDF2 = new System.Windows.Forms.TextBox();
            this.pathPDF1btn = new System.Windows.Forms.Button();
            this.pathPDF2btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.compareBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PDF1
            // 
            this.PDF1.Location = new System.Drawing.Point(12, 31);
            this.PDF1.Name = "PDF1";
            this.PDF1.Size = new System.Drawing.Size(100, 20);
            this.PDF1.TabIndex = 0;
            this.PDF1.Text = "C:\\Users\\calci\\OneDrive\\Dokument\\PDF\\first.pdf";
            // 
            // PDF2
            // 
            this.PDF2.Location = new System.Drawing.Point(13, 85);
            this.PDF2.Name = "PDF2";
            this.PDF2.Size = new System.Drawing.Size(100, 20);
            this.PDF2.TabIndex = 0;
            this.PDF2.Text = "C:\\Users\\calci\\OneDrive\\Dokument\\PDF\\second.pdf";
            // 
            // pathPDF1btn
            // 
            this.pathPDF1btn.Location = new System.Drawing.Point(119, 32);
            this.pathPDF1btn.Name = "pathPDF1btn";
            this.pathPDF1btn.Size = new System.Drawing.Size(75, 23);
            this.pathPDF1btn.TabIndex = 1;
            this.pathPDF1btn.Text = "Choose path";
            this.pathPDF1btn.UseVisualStyleBackColor = true;
            this.pathPDF1btn.Click += new System.EventHandler(this.pathPDF1btn_Click);
            // 
            // pathPDF2btn
            // 
            this.pathPDF2btn.Location = new System.Drawing.Point(119, 85);
            this.pathPDF2btn.Name = "pathPDF2btn";
            this.pathPDF2btn.Size = new System.Drawing.Size(75, 23);
            this.pathPDF2btn.TabIndex = 1;
            this.pathPDF2btn.Text = "Choose path";
            this.pathPDF2btn.UseVisualStyleBackColor = true;
            this.pathPDF2btn.Click += new System.EventHandler(this.pathPDF2btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Path of first PDF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Path of second PDF";
            // 
            // compareBtn
            // 
            this.compareBtn.Location = new System.Drawing.Point(12, 140);
            this.compareBtn.Name = "compareBtn";
            this.compareBtn.Size = new System.Drawing.Size(182, 23);
            this.compareBtn.TabIndex = 3;
            this.compareBtn.Text = "Compare";
            this.compareBtn.UseVisualStyleBackColor = true;
            this.compareBtn.Click += new System.EventHandler(this.compareBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(215, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 406);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 185);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(182, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Waiting...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.compareBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pathPDF2btn);
            this.Controls.Add(this.pathPDF1btn);
            this.Controls.Add(this.PDF2);
            this.Controls.Add(this.PDF1);
            this.Name = "Form1";
            this.Text = "PDF";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PDF1;
        private System.Windows.Forms.TextBox PDF2;
        private System.Windows.Forms.Button pathPDF1btn;
        private System.Windows.Forms.Button pathPDF2btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button compareBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
    }
}

