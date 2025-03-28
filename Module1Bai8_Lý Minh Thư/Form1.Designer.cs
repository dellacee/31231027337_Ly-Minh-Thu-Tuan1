namespace Module1Bai8_Lý_Minh_Thư
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
            this.components = new System.ComponentModel.Container();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTinh = new System.Windows.Forms.Button();
            this.txtNghiem = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(542, 328);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 19;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(374, 328);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(255, 328);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 23);
            this.btnTinh.TabIndex = 17;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            // 
            // txtNghiem
            // 
            this.txtNghiem.Location = new System.Drawing.Point(278, 247);
            this.txtNghiem.Name = "txtNghiem";
            this.txtNghiem.Size = new System.Drawing.Size(251, 22);
            this.txtNghiem.TabIndex = 16;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(278, 189);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(251, 22);
            this.txtB.TabIndex = 15;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(278, 139);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(251, 22);
            this.txtA.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nghiệm PT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nhập B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nhập A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "PHƯƠNG TRÌNH: AX + B =0";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtNghiem);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.TextBox txtNghiem;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

