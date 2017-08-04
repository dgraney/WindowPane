using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowPane.Message_Boxes
{
    internal partial class MsgBox_Login : Form
    {
        public SecureString username = null;
        public SecureString password = null;
        internal MsgBox_Login(string usernameRequestText, string passwordRequestText, string caption, string buttonText)
        {
            InitializeComponent();

            label1.Text = usernameRequestText;
            label2.Text = passwordRequestText;
            this.Text = caption;
            button1.Text = buttonText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (char c in textBox1.Text)
                username.AppendChar(c);
            foreach (char c in textBox2.Text)
                password.AppendChar(c);
            username.MakeReadOnly();
            password.MakeReadOnly();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
