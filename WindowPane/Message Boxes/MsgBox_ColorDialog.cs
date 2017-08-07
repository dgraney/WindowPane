using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowPane
{
    internal partial class MsgBox_ColorDialog : Form
    {
        public Color returnColor;
        internal MsgBox_ColorDialog(string message, string caption, string buttonText, Color startingColor)
        {
            InitializeComponent();

            textBox2.Text = message;
            this.Text = caption;
            button1.Text = buttonText;
            
            pictureBox1.BackColor = startingColor;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            returnColor = pictureBox1.BackColor;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.AnyColor = true;
            DialogResult result = cd.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBox1.BackColor = cd.Color;
            }
        }
    }
}
