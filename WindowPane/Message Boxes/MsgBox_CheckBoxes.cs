using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowPane
{
    internal partial class MsgBox_CheckBoxes : Form
    {
        internal List<string> returnList = new List<string>();
        internal List<CheckBox> checkBoxes = new List<CheckBox>();
        internal CBDisplayType currentType;
        internal CheckedListBox clb = new CheckedListBox();
        internal MsgBox_CheckBoxes(string message, string caption, List<string> DataSource, string buttonText, CBDisplayType type = CBDisplayType.GRID)
        {
            InitializeComponent();
            currentType = type;
            label1.Text = message;
            if (currentType == CBDisplayType.GRID)
            {
                for (int i = 0; i < DataSource.Count; i++)
                {
                    CheckBox checkBox = new CheckBox();
                    checkBox.Name = "CheckBox_" + i;
                    checkBox.Text = DataSource[i];
                    checkBoxes.Add(checkBox);
                }
                flowLayoutPanel1.Controls.AddRange(checkBoxes.ToArray());
                this.Size = new Size(this.Size.Width, 150 + 35 * (int)Math.Ceiling((double)(checkBoxes.Count / 3)));
            }
            else
            {
                clb = new CheckedListBox();
                CheckedListBox.ObjectCollection oc = clb.Items;
                for (int i = 0; i < DataSource.Count; i++)
                {
                    oc.Add(DataSource[i]);
                }
                clb.Dock = DockStyle.Fill;
                clb.CheckOnClick = true;
                tableLayoutPanel1.Controls.RemoveByKey("flowLayoutPanel1");
                tableLayoutPanel1.Controls.Add(clb, 1, 1);
                
                this.Size = new Size(this.Size.Width, 100 + clb.Size.Height);
            }
            button1.Text = buttonText;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (currentType == CBDisplayType.GRID)
            {
                foreach (CheckBox cb in flowLayoutPanel1.Controls)
                {
                    if (cb.Checked)
                        returnList.Add(cb.Text);
                }
            }
            else
            {
                foreach (object o in clb.CheckedItems)
                {
                    returnList.Add(o.ToString());
                }
            }
        }
    }
}
