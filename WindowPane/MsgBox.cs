﻿using System;
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
    public static class MsgBox
    {

        /// <summary>
        /// Opens a Message Box form with a text box. Returns the text entered into the text box.
        /// </summary>
        /// <param name="message">The message displayed directly above the text box.</param>
        /// <param name="caption">The title of the Message Box form.</param>
        /// <param name="buttonText">The text displayed over the button.</param>
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
    }
}