using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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

            Image textColorImage = IndependentFunctions.FontColorImage(Color.Red);
            Image highlightColorImage = IndependentFunctions.HighlightColorImage(Color.Yellow);
            TextColorButton.Image = textColorImage;
            HighlightColorButton.Image = highlightColorImage;

            FontFamily[] ffs = FontFamily.Families;
            ChooseFont.ComboBox.DataSource = ffs.Select(x => x.Name).ToList<string>();

            FontSizeChoose.ComboBox.DataSource = new List<int>() { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 }.Select(x=>x.ToString()).ToList<string>();
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
            try
            {
                Font rtbFont = richTextBox1.SelectionFont;

                if (UnderlineButton.CheckState == CheckState.Checked) isUnderline = true;
                else isUnderline = false;

                if (isUnderline)
                    richTextBox1.SelectionFont = new Font(rtbFont, rtbFont.Style | FontStyle.Underline);
                else
                    richTextBox1.SelectionFont = new Font(rtbFont, rtbFont.Style & ~FontStyle.Underline);
            }
            catch { }
        }

        private void ItalicsButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Font rtbFont = richTextBox1.SelectionFont;
                if (ItalicsButton.CheckState == CheckState.Checked)
                    isItalic = true;
                else
                    isItalic = false;

                if (isItalic)
                    richTextBox1.SelectionFont = new Font(rtbFont, rtbFont.Style | FontStyle.Italic);
                else
                    richTextBox1.SelectionFont = new Font(rtbFont, rtbFont.Style & ~FontStyle.Italic);
            }
            catch { }
        }

        private void BoldButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Font rtbFont = richTextBox1.SelectionFont;

                if (BoldButton.CheckState == CheckState.Checked)
                    isBold = true;
                else
                    isBold = false;

                if (isBold)
                    richTextBox1.SelectionFont = new Font(rtbFont, rtbFont.Style | FontStyle.Bold);
                else
                    richTextBox1.SelectionFont = new Font(rtbFont, rtbFont.Style & ~FontStyle.Bold);
            }
            catch { }
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
          
        }
        
        private void TextColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.AllowFullOpen = true;
            DialogResult dr = cd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                TextColorButton.Image = IndependentFunctions.FontColorImage(cd.Color);
                TextColorButton.Text = String.Format("({0},{1},{2})", cd.Color.R, cd.Color.G, cd.Color.B);

                richTextBox1.SelectionColor = cd.Color;
            }
        }

        private void HighlightColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.AllowFullOpen = true;
            DialogResult dr = cd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                HighlightColorButton.Image = IndependentFunctions.HighlightColorImage(cd.Color);
                HighlightColorButton.Text = String.Format("({0},{1},{2})", cd.Color.R, cd.Color.G, cd.Color.B);

                richTextBox1.SelectionBackColor = cd.Color;
            }
        }

        private void ChooseFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Find corresponding font
            ChooseFont.ComboBox.SelectAll();
            string fontName = ChooseFont.ComboBox.SelectedText;
            FontFamily ff = FontFamily.Families.Where(x => x.Name == fontName).FirstOrDefault();

            if (ff.IsStyleAvailable(richTextBox1.SelectionFont.Style))
                richTextBox1.SelectionFont = new Font(ff, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style);
            else
                richTextBox1.SelectionFont = new Font(ff, richTextBox1.SelectionFont.Size);
        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ChooseFont.ComboBox.SelectAll();
                float size = float.Parse(FontSizeChoose.ComboBox.Text);
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily,size,richTextBox1.SelectionFont.Style);
            }
            catch { }
        }
    }
}
