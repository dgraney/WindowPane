using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowPane
{
    public partial class Notification : Form
    {
        private string notif;
        private Timer decreaseOpacityTimer = new Timer();
        private Timer closeTimer = new Timer();
        private Timer beginDecreaseOpacityTimer = new Timer();
        private Point location;

        /// <summary>
        /// Displays a notification window with a specified text. Disappears after a few seconds.
        /// </summary>
        /// <param name="notificationText">The text to display as a notification</param>
        /// <param name="title_">The Name of the notification form.</param>
        /// <param name="location_"></param>
        public Notification(string notificationText, Point location_, string title_ = "Notification")
        {
            InitializeComponent();

            NotificationBox.Text = notificationText;
            this.Text = title_;
            this.TopMost = true;
            this.TopLevel = true;
            location = location_;
        }

        private void Notification_Shown(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.TopLevel = true;

            SetWindowSize();

            beginDecreaseOpacityTimer.Interval = 5000;
            beginDecreaseOpacityTimer.Tick += BeginDecreaseOpacityTimer_Tick;
            beginDecreaseOpacityTimer.Start();

            closeTimer.Interval = 7000;
            closeTimer.Tick += T__Tick;
            closeTimer.Start();
        }

        #region Timers
        //Wait a bit then decrease the opacity
        private void BeginDecreaseOpacityTimer_Tick(object sender, EventArgs e)
        {
            beginDecreaseOpacityTimer.Stop();

            decreaseOpacityTimer.Interval = 100;
            decreaseOpacityTimer.Tick += T_Tick;
            decreaseOpacityTimer.Start();
        }

        //Closes the notification
        private void T__Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        // Each tick decreases the opacity
        private void T_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.05;
        }
        #endregion

        #region Functions
        private void SetWindowSize()
        {
            int notificationCount = notif.ToCharArray().Count(t => t == '•');
            if (notificationCount > 1)
            {
                this.Size = new Size(this.Width, (int)(notificationCount * 42));
                NotificationBox.Size = new Size(this.Width - 10, (int)(notificationCount * 42));
            }
            else
            {
                Size totalSize = TextRenderer.MeasureText(notif, NotificationBox.Font);
                int totalLines = (int)totalSize.Width / NotificationBox.Size.Width;
                NotificationBox.Size = new Size(NotificationBox.Size.Width, totalLines);
                this.Size = new Size(NotificationBox.Size.Width + 10, NotificationBox.Size.Height + 32);
            }
        }


        private void KeepNotificationUp()
        {
            beginDecreaseOpacityTimer.Stop();
            decreaseOpacityTimer.Stop();
            closeTimer.Stop();
            this.Opacity = 1;
        }

        private void FadeNotification()
        {
            beginDecreaseOpacityTimer.Start();
            closeTimer.Start();
        }
        #endregion
        #region Mouse Events
        private void Notification_MouseEnter(object sender, EventArgs e)
        {
            KeepNotificationUp();
        }

        private void Notification_MouseLeave(object sender, EventArgs e)
        {
            FadeNotification();
        }

        private void NotificationBox_Click(object sender, EventArgs e)
        {
            KeepNotificationUp();
            this.Focus();
        }

        private void TITLE_MouseEnter(object sender, EventArgs e)
        {
            KeepNotificationUp();
        }

        private void TITLE_MouseLeave(object sender, EventArgs e)
        {
            FadeNotification();
        }

        private void NotificationBox_MouseEnter(object sender, EventArgs e)
        {
            KeepNotificationUp();
        }

        private void NotificationBox_MouseLeave(object sender, EventArgs e)
        {
            FadeNotification();
        }
        #endregion
    }
}
