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
    internal partial class MsgBox_DropDown : Form
    {
        public int returnInt = 0;
        internal MsgBox_DropDown(string message, string caption, string buttonText,List<string> DataSource)
        {
            InitializeComponent();

            textBox2.Text = message;
            this.Text = caption;
            button1.Text = buttonText;
            comboBox1.DataSource = DataSource;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            returnInt = comboBox1.SelectedIndex;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
