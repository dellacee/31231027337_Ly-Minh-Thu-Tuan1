namespace Module1BaiSo_Lý_Minh_Thư
{
    partial class frmSimpleEvent
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
            this.bntClickMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntClickMe
            // 
            this.bntClickMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntClickMe.ForeColor = System.Drawing.Color.Red;
            this.bntClickMe.Location = new System.Drawing.Point(175, 87);
            this.bntClickMe.Name = "bntClickMe";
            this.bntClickMe.Size = new System.Drawing.Size(343, 142);
            this.bntClickMe.TabIndex = 0;
            this.bntClickMe.Text = "Click Me";
            this.bntClickMe.UseVisualStyleBackColor = true;
            this.bntClickMe.Click += new System.EventHandler(this.bntClickMe_Click);
            // 
            // frmSimpleEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 358);
            this.Controls.Add(this.bntClickMe);
            this.Name = "frmSimpleEvent";
            this.Text = "Simple Event Example";
            this.Load += new System.EventHandler(this.frmSimpleEvent_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntClickMe;
    }
}

