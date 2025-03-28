using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module1Bai5_Lý_Minh_Thư
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Text = txtNhapTen.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radRed.Checked = true;
            txtNhapTen.Focus();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void rad_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rad = (RadioButton)sender;
            Color selectedColor;

            switch (rad.Name)
            {
                case "radRed":
                    selectedColor = Color.Red;
                    break;
                case "radGreen":
                    selectedColor = Color.Green;
                    break;
                case "radBlue":
                    selectedColor = Color.Blue;
                    break;
                case "radBlack":
                    selectedColor = Color.Black;
                    break;
                default:
                    selectedColor = Color.Black;
                    break;
            }

            lblLapTrinh.ForeColor = selectedColor;
            txtNhapTen.ForeColor = selectedColor;
        }
        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFont();
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFont();
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFont();
        }
        private void UpdateFont()
        {
            FontStyle newStyle = FontStyle.Regular;

            if (chkBold.Checked)
                newStyle |= FontStyle.Bold;
            if (chkItalic.Checked)
                newStyle |= FontStyle.Italic;
            if (chkUnderline.Checked)
                newStyle |= FontStyle.Underline;

            // Cập nhật font cho cả label và textbox
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.FontFamily, lblLapTrinh.Font.Size, newStyle);
            txtNhapTen.Font = new Font(txtNhapTen.Font.FontFamily, txtNhapTen.Font.Size, newStyle);
        }
    }
}
