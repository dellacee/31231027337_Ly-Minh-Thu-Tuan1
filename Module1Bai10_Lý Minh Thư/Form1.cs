using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module1Bai10_Lý_Minh_Thư
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string GetFileSize(long bytes)
        {
            string[] sizes = { "B", "KB", "MB", "GB" };
            double len = bytes;
            int order = 0;

            while (len >= 1024 && order < sizes.Length - 1)
            {
                order++;
                len = len / 1024;
            }

            return String.Format("{0:0.##} {1}", len, sizes[order]);
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                // Set filter cho các loại file ảnh
                ofd.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif|" +
                            "BMP Files (*.bmp)|*.bmp|" +
                            "JPEG Files (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                            "PNG Files (*.png)|*.png|" +
                            "GIF Files (*.gif)|*.gif|" +
                            "All files (*.*)|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Hiển thị thông tin file
                        string fileName = ofd.FileName;
                        FileInfo fileInfo = new FileInfo(fileName);

                        lblDateModified.Text = "File Name: " + fileInfo.Name;
                        lblFileSize.Text = "File Size: " + GetFileSize(fileInfo.Length);
                        lblDateModified.Text = "Date Last Modified: " + fileInfo.LastWriteTime.ToString();
                        lblDateAccessed.Text = "Date Last Accessed: " + fileInfo.LastAccessTime.ToString();

                        // Hiển thị ảnh trong PictureBox
                        pictureBox.Image = Image.FromFile(fileName);
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message);
                    }
                }
            }
        }
    }
}
