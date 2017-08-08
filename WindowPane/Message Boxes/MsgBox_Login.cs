using System;
using System.Collections.Generic;
using System.Security;
using System.Windows.Forms;

namespace WindowPane.Message_Boxes
{
    internal partial class MsgBox_Login : Form
    {

        private string username = "";
        private SecureString password = new SecureString();

        public KeyValuePair<string, SecureString> UsernameAndPasswordResult = new KeyValuePair<string, SecureString>();

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
            username = UsernameTextbox.Text;
            password.MakeReadOnly();

            UsernameAndPasswordResult = new KeyValuePair<string, SecureString>(username, password);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        
        private void PasswordTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            /* Backspaces reset it
             * Left or Right arrows reset it
             * 
             */
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                PasswordTextbox.Text = "";
                password = new SecureString();
                return;
            }
            password.AppendChar(IndependentFunctions.GetChar(e));
        }
       
        private void PasswordTextbox_Click(object sender, EventArgs e)
        {
            PasswordTextbox.Text = "";
            password = new SecureString();
        }
        
    }
}
