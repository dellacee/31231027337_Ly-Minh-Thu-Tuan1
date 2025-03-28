namespace Module1Bai10_Lý_Minh_Thư
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDateAccessed = new System.Windows.Forms.Label();
            this.lblDateModified = new System.Windows.Forms.Label();
            this.lblFileSize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDateAccessed);
            this.groupBox1.Controls.Add(this.lblDateModified);
            this.groupBox1.Controls.Add(this.lblFileSize);
            this.groupBox1.Location = new System.Drawing.Point(124, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 122);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Statistics";
            // 
            // lblDateAccessed
            // 
            this.lblDateAccessed.AutoSize = true;
            this.lblDateAccessed.Location = new System.Drawing.Point(33, 93);
            this.lblDateAccessed.Name = "lblDateAccessed";
            this.lblDateAccessed.Size = new System.Drawing.Size(131, 16);
            this.lblDateAccessed.TabIndex = 2;
            this.lblDateAccessed.Text = "Date Last Accessed:";
            // 
            // lblDateModified
            // 
            this.lblDateModified.AutoSize = true;
            this.lblDateModified.Location = new System.Drawing.Point(33, 59);
            this.lblDateModified.Name = "lblDateModified";
            this.lblDateModified.Size = new System.Drawing.Size(122, 16);
            this.lblDateModified.TabIndex = 1;
            this.lblDateModified.Text = "Date Last Modified:";
            // 
            // lblFileSize
            // 
            this.lblFileSize.AutoSize = true;
            this.lblFileSize.Location = new System.Drawing.Point(33, 27);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(61, 16);
            this.lblFileSize.TabIndex = 0;
            this.lblFileSize.Text = "File Size:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Click button to open a picture file:";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Location = new System.Drawing.Point(79, 223);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 207);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(6, 9);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(636, 197);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(610, 20);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 7;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBrowse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDateAccessed;
        private System.Windows.Forms.Label lblDateModified;
        private System.Windows.Forms.Label lblFileSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnBrowse;
    }
}

