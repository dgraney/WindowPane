using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace WindowPane
{
    
    /// <summary>
    /// The static class MsgBox
    /// </summary>
    public static class MessageBox_
    {
        /// <summary>
        /// Opens a Message Box form with a text box. Returns the text entered into the text box.
        /// </summary>
        /// <param name="message">The message displayed directly above the text box.</param>
        /// <param name="caption">The title of the Message Box form.</param>
        /// <param name="buttonText">The text displayed over the return button.</param>
        /// <returns></returns>
        public static string _TextBox(string message, string caption = "Message Box",string buttonText = "OK")
        {
            MsgBox_TextBox form = new MsgBox_TextBox(message, caption, buttonText);
            DialogResult dr = form.ShowDialog();
            if (dr == DialogResult.OK)
            {
                return form.returnString;
            }
            else
                return null;
        }

        /// <summary>
        /// Opens a Message Box form with a drow down. Returns the index of the selected item.
        /// </summary>
        ///<param name = "message" > The message displayed directly above the combo box.</param>
        /// <param name="caption">The title of the Message Box form.</param>
        /// <param name="buttonText">The text displayed over the return button.</param>
        /// <param name="DataSource">The string list to display.</param>
        /// <returns></returns>
        public static int _DropDown_Int(string message, List<string> DataSource, string caption = "Message Box", string buttonText = "OK")
        {
            MsgBox_DropDown form = new MsgBox_DropDown(message, caption, buttonText,DataSource);
            DialogResult dr = form.ShowDialog();
            if (dr == DialogResult.OK)
            {
                return form.returnInt;
            }
            else
                return 0;
        }

        /// <summary>
        /// Opens a Message Box form with a drow down. Returns the string of the selected item.
        /// </summary>
        ///<param name = "message" > The message displayed directly above the combo box.</param>
        /// <param name="caption">The title of the Message Box form.</param>
        /// <param name="buttonText">The text displayed over the return button.</param>
        /// <param name="DataSource">The string list to display.</param>
        /// <returns></returns>
        public static string _DropDown_String(string message, List<string> DataSource, string caption = "Message Box", string buttonText = "OK")
        {
            MsgBox_DropDown form = new MsgBox_DropDown(message, caption, buttonText, DataSource);
            DialogResult dr = form.ShowDialog();
            if (dr == DialogResult.OK)
            {
                return DataSource[form.returnInt];
            }
            else
                return "";
        }

        /// <summary>
        /// Opens a Message Box form with multiple checkboxes (length of the data source). Returns a list of strings representing the text beside each checked check box.
        /// </summary>
        /// <param name="message">The message displayed directly above the list of checkboxes.</param>
        /// <param name="DataSource">The data source representing the list of strings to display checkboxes for.</param>
        /// <param name="caption">The title of the Message Box form.</param>
        /// <param name="buttonText">The text displayed over the return button.</param>
        /// <returns></returns>
        public static List<string> _Checkboxes(string message, List<string> DataSource, string caption = "Message Box",string buttonText = "OK")
        {
            MsgBox_CheckBoxes cb = new MsgBox_CheckBoxes(message, caption, DataSource,buttonText);
            DialogResult dr = cb.ShowDialog();
            if (dr == DialogResult.OK)
            {
                return cb.returnList;
            }
            return null;
        }
        /// <summary>
        /// Opens a Message Box form with a color dialog. Returns a user-chosen color.
        /// </summary>
        /// <param name="message">The message displayed directly above the list of checkboxes.</param>
        /// <param name="caption">The title of the Message Box form.</param>
        /// <param name="buttonText">The text displayed over the return button.</param>
        /// <returns>A user-chosen color.</returns>
        public static Color _ColorDialog(string message, string caption = "Message Box", string buttonText = "OK")
        {
            MsgBox_ColorDialog cd = new WindowPane.MsgBox_ColorDialog(message, caption, buttonText);
            DialogResult dr = cd.ShowDialog();
            if (dr == DialogResult.OK)
                return cd.returnColor;
            else
                return new Color();
        }
    }
}
