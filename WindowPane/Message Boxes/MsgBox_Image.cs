using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowPane
{
    internal partial class MsgBox_Image : Form
    {
        internal Image returnImage = null;
        internal MsgBox_Image(string message, string caption, string buttonText, Image startingImage)
        {
            InitializeComponent();

            textBox2.Text = message;
            this.Text = caption;
            button1.Text = buttonText;

            pictureBox1.Image = startingImage;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                returnImage = pictureBox1.Image;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Please select an image.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files | *.png; *.jpg; *.jpeg; *.bmp; *.gif; *.tiff; *.tif";
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                pictureBox1.Refresh();
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}
