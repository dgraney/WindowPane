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
    internal partial class MsgBox_TextBox : Form
    {
        public string returnString = "";
        internal MsgBox_TextBox(string message, string caption, string buttonText)
        {
            InitializeComponent();
            
            textBox2.Text = message;
            this.Text = caption;
            button1.Text = buttonText;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            returnString = textBox1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
