using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowPane
{
    internal partial class MsgBox_RichTextBox : Form
    {
        public string returnRTF = "";
        public string returnText = "";

        private bool isBold = false;
        private bool isItalic = false;
        private bool isUnderline = false;
        internal MsgBox_RichTextBox(string message, string caption, string buttonText)
        {
            InitializeComponent();

            textBox2.Text = message;
            this.Text = caption;
            button1.Text = buttonText;

            #region ToolStrip Settings
            BoldButton.CheckOnClick = true;
            BoldButton.CheckedChanged += BoldButton_CheckedChanged;

            ItalicsButton.CheckOnClick = true;
            ItalicsButton.CheckedChanged += ItalicsButton_CheckedChanged;

            UnderlineButton.CheckOnClick = true;
            UnderlineButton.CheckedChanged += UnderlineButton_CheckedChanged;
            #endregion

        }

        #region Functions
        private void DoFontStyleChecks()
        {
            Font font = null;

            if (isBold && isItalic && isUnderline)
            { font = new Font(richTextBox1.Font, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline); SetFontStyle(richTextBox1, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline); }
            else if (isUnderline && isItalic)
            { font = new Font(richTextBox1.Font, FontStyle.Underline | FontStyle.Italic); SetFontStyle(richTextBox1, FontStyle.Underline | FontStyle.Italic); }
            else if (isBold && isUnderline)
            { font = new Font(richTextBox1.Font, FontStyle.Bold | FontStyle.Underline); SetFontStyle(richTextBox1, FontStyle.Bold | FontStyle.Underline); }
            else if (isBold && isItalic)
            { font = new Font(richTextBox1.Font, FontStyle.Bold | FontStyle.Italic); SetFontStyle(richTextBox1, FontStyle.Bold | FontStyle.Italic); }
            else if (isBold)
            { font = new Font(richTextBox1.Font, FontStyle.Bold); SetFontStyle(richTextBox1, FontStyle.Bold); }
            else if (isItalic)
            { font = new Font(richTextBox1.Font, FontStyle.Italic); SetFontStyle(richTextBox1, FontStyle.Italic); }
            else if (isUnderline)
            { font = new Font(richTextBox1.Font, richTextBox1.Font.Style | FontStyle.Underline); SetFontStyle(richTextBox1, FontStyle.Underline); }
            else
            { font = new Font(richTextBox1.Font, FontStyle.Regular); SetFontStyle(richTextBox1, FontStyle.Regular); }

            richTextBox1.SelectionFont = font;
        }

        private void SetFontStyle(RichTextBox rtb, FontStyle style)
        {
            int selectionStart = rtb.SelectionStart;
            int selectionLength = rtb.SelectionLength;
            int selectionEnd = selectionStart + selectionLength;

            // select a letter by letter and change font
            for (int x = selectionStart; x < selectionEnd; ++x)
            {
                // select a single letter
                rtb.Select(x, 1);
                // Toggle font style of the selection
                rtb.SelectionFont = new Font(rtb.SelectionFont, rtb.SelectionFont.Style ^ style);
            }
            rtb.Select(selectionStart, selectionLength);
        }
        #endregion

        private void UnderlineButton_CheckedChanged(object sender, EventArgs e)
        {

            if (UnderlineButton.CheckState == CheckState.Checked)
                isUnderline = true;
            else isUnderline = false;

            DoFontStyleChecks();
        }

        private void ItalicsButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ItalicsButton.CheckState == CheckState.Checked)
                isItalic = true;
            else
                isItalic = false;
            DoFontStyleChecks();
        }

        private void BoldButton_CheckedChanged(object sender, EventArgs e)
        {
            if (BoldButton.CheckState == CheckState.Checked)
                isBold = true;
            else
                isBold = false;
            DoFontStyleChecks();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            returnRTF = richTextBox1.Rtf;
            returnText = richTextBox1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Bold)
                BoldButton.Checked = true;
            else
                BoldButton.Checked = false;
            if (richTextBox1.SelectionFont.Italic)
                ItalicsButton.Checked = true;
            else
                ItalicsButton.Checked = false;
            if (richTextBox1.SelectionFont.Underline)
                UnderlineButton.Checked = true;
            else
                UnderlineButton.Checked = false;
        }
    }
}
