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
    public partial class LoadingScreen : Form
    {
        private Form source;

        /// <summary>
        /// Sets the progress bar value. Used in block or continuous progress bar types.
        /// </summary>
        public int progressBarValue
        {
            get { return progressBar1.Value; }
            set { progressBar1.Value = value; }
        }
        /// <summary>
        /// Sets the label text above the progress bar.
        /// </summary>
        public string labelValue
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        /// <summary>
        /// The type of progress bar to display in the loading screen.
        /// </summary>
        public enum ProgressBarType { Marquee, Blocks, Continuous };

        /// <summary>
        /// Displays a loading screen presenting the user with a message and progress bar.
        /// </summary>
        /// <param name="message">The label text displayed above the progress bar.</param>
        /// <param name="type">The type of progress bar to use in the loading screen.</param>
        public LoadingScreen(string message, ProgressBarType type)
        {
            InitializeComponent();
            this.TopMost = true;
            this.TopLevel = true;
            label1.Text = "Loading " + message + "...";
            
            this.StartPosition = FormStartPosition.CenterScreen;
           

            if (type == ProgressBarType.Marquee)
                progressBar1.Style = ProgressBarStyle.Marquee;
            else if (type == ProgressBarType.Blocks)
                progressBar1.Style = ProgressBarStyle.Blocks;
            else
                progressBar1.Style = ProgressBarStyle.Continuous;
        }

        /// <summary>
        /// Used to change the label text displayed above the progress bar.
        /// </summary>
        /// <param name="text">The text to display.</param>
        public void PingLoadingText(string text)
        {
            label1.Text = text;
        }
    }
}

