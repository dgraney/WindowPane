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
    internal partial class MsgBox_CheckBoxes : Form
    {
        internal List<string> returnList = new List<string>();
        internal List<CheckBox> checkBoxes = new List<CheckBox>();
        internal MsgBox_CheckBoxes(string message, string caption, List<string> DataSource)
        {
            InitializeComponent();

            for (int i = 0; i < DataSource.Count; i++)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Name = "CheckBox_" + i;
                checkBox.Text = DataSource[i];
                checkBoxes.Add(checkBox);
            }
            
            flowLayoutPanel1.Controls.AddRange(checkBoxes.ToArray());
            this.Size = new Size(this.Size.Width, 100 + 35 * (int)Math.Ceiling((double)(checkBoxes.Count / 3)));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (CheckBox cb in flowLayoutPanel1.Controls)
            {
                if(cb.Checked)
                    returnList.Add(cb.Text);
            }
        }
    }
}
