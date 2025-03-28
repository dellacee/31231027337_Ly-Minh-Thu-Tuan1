using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module1Bai6._1_Lý_Minh_Thư
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolTip.SetToolTip(picSmall, "Click Me");
            toolTip.SetToolTip(picBig, "Click Me");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtName.Focus();

            // Ẩn hiện hình CD-ROM
            picSmall.Visible = true;
            picBig.Visible = false;


        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lblMessage.Text = txtName.Text + " : " + txtMessage.Text;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                btnDisplay.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMessage.Clear();
            txtName.Clear();
        }
        private void radColor_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rad = (RadioButton)sender;
            switch (rad.Name)
            {
                case "radRed":
                    lblMessage.ForeColor = Color.Red;
                    break;
                case "radGreen":
                    lblMessage.ForeColor = Color.Green;
                    break;
                case "radBlue":
                    lblMessage.ForeColor = Color.Blue;
                    break;
                case "radBlack":
                    lblMessage.ForeColor = Color.Black;
                    break;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.Visible = chkVisible.Checked;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picSmall_Click(object sender, EventArgs e)
        {
            picSmall.Visible = false;
            picBig.Visible = true;
        }

        private void picBig_Click(object sender, EventArgs e)
        {
            picSmall.Visible = true;
            picBig.Visible = false;
        }

        private void picSmall_Click_1(object sender, EventArgs e)
        {

        }
    }
}
