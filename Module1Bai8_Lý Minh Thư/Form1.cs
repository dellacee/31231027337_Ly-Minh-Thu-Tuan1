using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module1Bai8_Lý_Minh_Thư
{
   
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
                // Set trạng thái ban đầu của các nút
                btnTinh.Enabled = false;
                btnXoa.Enabled = false;
            }


            // Kiểm tra dữ liệu nhập vào
            private bool ValidateInput()
            {
                bool isValid = true;

                // Kiểm tra hệ số A
                if (string.IsNullOrWhiteSpace(txtA.Text))
                {
                    errorProvider.SetError(txtA, "Vui lòng nhập hệ số A!");
                    isValid = false;
                }
                else if (!double.TryParse(txtA.Text, out double a))
                {
                    errorProvider.SetError(txtA, "Hệ số A phải là số!");
                    isValid = false;
                }
                else if (double.Parse(txtA.Text) == 0)
                {
                    errorProvider.SetError(txtA, "Hệ số A phải khác 0!");
                    isValid = false;
                }
                else
                {
                    errorProvider.SetError(txtA, "");
                }

                // Kiểm tra hệ số B
                if (string.IsNullOrWhiteSpace(txtB.Text))
                {
                    errorProvider.SetError(txtB, "Vui lòng nhập hệ số B!");
                    isValid = false;
                }
                else if (!double.TryParse(txtB.Text, out double b))
                {
                    errorProvider.SetError(txtB, "Hệ số B phải là số!");
                    isValid = false;
                }
                else
                {
                    errorProvider.SetError(txtB, "");
                }

                // Enable/Disable nút Tính
                btnTinh.Enabled = isValid;
                return isValid;
            }

            private void txtA_TextChanged(object sender, EventArgs e)
            {
                ValidateInput();
            }

            private void txtB_TextChanged(object sender, EventArgs e)
            {
                ValidateInput();
            }

            private void btnTinh_Click(object sender, EventArgs e)
            {
                if (ValidateInput())
                {
                    double a = double.Parse(txtA.Text);
                    double b = double.Parse(txtB.Text);

                    // Giải phương trình ax + b = 0
                    double x = -b / a;
                    txtNghiem.Text = $"x = {x}";

                    // Enable nút Xóa sau khi tính
                    btnXoa.Enabled = true;
                    // Disable nút Tính
                    btnTinh.Enabled = false;
                }
            }

            private void btnXoa_Click(object sender, EventArgs e)
            {
                // Xóa nội dung các TextBox
                txtA.Clear();
                txtB.Clear();
                txtNghiem.Clear();

                // Focus vào TextBox A
                txtA.Focus();

                // Disable nút Xóa
                btnXoa.Enabled = false;

                // Xóa các thông báo lỗi
                errorProvider.Clear();
            }

            private void btnThoat_Click(object sender, EventArgs e)
            {
                DialogResult result = MessageBox.Show(
               "Bạn có chắc chắn muốn thoát?",
               "Xác nhận",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }
    
}
