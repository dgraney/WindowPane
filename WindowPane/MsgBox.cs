using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security;
using WindowPane.Message_Boxes;
using System.Threading.Tasks;

namespace WindowPane
{
    /// <summary>
    /// Determines which to return: rtf or text 
    /// </summary>
    public enum RichTextBoxReturnType
    {
        /// <summary>
        /// Returns the rtf string.
        /// </summary>
        RTF_STRING,

        /// <summary>
        /// Returns the text string.
        /// </summary>
        TEXT_STRING
    }

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
        /// <param name="message">The message displayed directly above the color chooser.</param>
        /// <param name="startingColor">The color displayed/used before choosing a color.</param>
        /// <param name="caption">The title of the Message Box form.</param>
        /// <param name="buttonText">The text displayed over the return button.</param>
        /// <returns>A user-chosen color.</returns>
        public static Color _ColorDialog(string message, Color startingColor, string caption = "Message Box", string buttonText = "OK")
        {
            MsgBox_ColorDialog cd = new MsgBox_ColorDialog(message, caption, buttonText, startingColor);
            DialogResult dr = cd.ShowDialog();
            if (dr == DialogResult.OK)
                return cd.returnColor;
            else
                return new Color();

        }

        /// <summary>
        /// Opens a Message Box with a file dialog to choose an image. Returns the chosen file as an image.
        /// </summary>
        /// <param name="message">The message displayed directly above the image selector.</param>
        /// <param name="caption">The title of the Message Box form.</param>
        /// <param name="buttonText">The text displayed over the return button.</param>
        /// <param name="startingImage">The image displayed immediately before any other image is chosen.</param>
        /// <returns></returns>
        public static Image _Image(string message, string caption = "Message Box", string buttonText = "OK", Image startingImage = null)
        {
            MsgBox_Image img = new MsgBox_Image(message, caption, buttonText, startingImage);
            DialogResult dr = img.ShowDialog();
            if (dr == DialogResult.OK)
                return img.returnImage;
            else
                return null;
        }

        /// <summary>
        ///  Opens a Message Box with a rich text box. Returns either the RTF or the text.
        /// </summary>
        /// <param name="message">The message displayed directly above the rich text box.</param>
        /// <param name="caption">The title of the Message Box form.</param>
        /// <param name="buttonText">The text displayed over the return button.</param>
        /// <param name="type">Determines which to return: rtf or text</param>
        /// <returns></returns>
        public static string _RichTextBox(string message, RichTextBoxReturnType type, string caption = "Message Box", string buttonText = "OK")
        {
            if (type == RichTextBoxReturnType.RTF_STRING)
            {
                MsgBox_RichTextBox rtb = new MsgBox_RichTextBox(message, caption, buttonText);
                DialogResult dr = rtb.ShowDialog();
                if (dr == DialogResult.OK)
                    return rtb.returnRTF;
            }
            else if (type == RichTextBoxReturnType.TEXT_STRING)
            {
                MsgBox_RichTextBox rtb = new MsgBox_RichTextBox(message, caption, buttonText);
                DialogResult dr = rtb.ShowDialog();
                if (dr == DialogResult.OK)
                    return rtb.returnText;
            }
            return null;
        }

        /// <summary>
        /// Opens a login dialog. Returns a list of SecureString. First item is the username, second item is the password.
        /// </summary>
        /// <param name="usernameRequestText">Displayed above the username textbox.</param>
        /// <param name="passworkRequestText">Displayed above the username textbox.</param>
        /// <param name="caption">The title of the Message Box form.</param>
        /// <param name="buttonText">The text displayed over the return button.</param>
        /// <returns></returns>
        public static List<SecureString> _Login(string usernameRequestText = "Username", string passworkRequestText = "Password", string caption = "Message Box", string buttonText = "OK")
        {
            MsgBox_Login login = new MsgBox_Login(usernameRequestText, passworkRequestText, caption, buttonText);
            DialogResult dr = login.ShowDialog();
            if (dr == DialogResult.OK)
            {
                List<SecureString> ss = new List<SecureString>();
                ss.Add(login.username);
                ss.Add(login.password);
                return ss;
            }
            return null;
        }

    }
}
