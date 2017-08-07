namespace WindowPane
{
    partial class Notification
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NotificationBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // NotificationBox
            // 
            this.NotificationBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NotificationBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NotificationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotificationBox.Location = new System.Drawing.Point(-1, 0);
            this.NotificationBox.MinimumSize = new System.Drawing.Size(324, 57);
            this.NotificationBox.Name = "NotificationBox";
            this.NotificationBox.ReadOnly = true;
            this.NotificationBox.Size = new System.Drawing.Size(324, 74);
            this.NotificationBox.TabIndex = 2;
            this.NotificationBox.Text = "";
            this.NotificationBox.MouseEnter += new System.EventHandler(this.NotificationBox_MouseEnter);
            this.NotificationBox.MouseLeave += new System.EventHandler(this.NotificationBox_MouseLeave);
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 71);
            this.Controls.Add(this.NotificationBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Notification";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Notification";
            this.Shown += new System.EventHandler(this.Notification_Shown);
            this.MouseEnter += new System.EventHandler(this.Notification_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Notification_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox NotificationBox;
    }
}