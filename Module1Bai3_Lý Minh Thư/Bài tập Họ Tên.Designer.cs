﻿namespace Module1Bai3_Lý_Minh_Thư
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
            this.btnHo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bntHoTen = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHo
            // 
            this.btnHo.Location = new System.Drawing.Point(50, 160);
            this.btnHo.Name = "btnHo";
            this.btnHo.Size = new System.Drawing.Size(96, 46);
            this.btnHo.TabIndex = 0;
            this.btnHo.Text = "Họ lót";
            this.btnHo.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(199, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "Tên";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // bntHoTen
            // 
            this.bntHoTen.Location = new System.Drawing.Point(350, 160);
            this.bntHoTen.Name = "bntHoTen";
            this.bntHoTen.Size = new System.Drawing.Size(96, 46);
            this.bntHoTen.TabIndex = 2;
            this.bntHoTen.Text = "Họ và tên";
            this.bntHoTen.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(137, 238);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(198, 52);
            this.button4.TabIndex = 3;
            this.button4.Text = "Thoát chương trình";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(146, 65);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(270, 22);
            this.txtHo.TabIndex = 4;
            // 
            // txtTen
            // 
            this.txtTen.BackColor = System.Drawing.Color.Pink;
            this.txtTen.Location = new System.Drawing.Point(146, 106);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(270, 22);
            this.txtTen.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Họ Lót";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 317);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bntHoTen);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnHo);
            this.Name = "Form1";
            this.Text = "Bài tập Họ Tên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bntHoTen;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

