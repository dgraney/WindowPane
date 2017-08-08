namespace WindowPane
{
    partial class MsgBox_RichTextBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgBox_RichTextBox));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BoldButton = new System.Windows.Forms.ToolStripButton();
            this.ItalicsButton = new System.Windows.Forms.ToolStripButton();
            this.UnderlineButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TextColorButton = new System.Windows.Forms.ToolStripButton();
            this.HighlightColorButton = new System.Windows.Forms.ToolStripButton();
            this.ChooseFont = new System.Windows.Forms.ToolStripComboBox();
            this.FontSizeChoose = new System.Windows.Forms.ToolStripComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(391, 207);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(313, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(5, 5);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(381, 12);
            this.textBox2.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 47);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(385, 127);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.SelectionChanged += new System.EventHandler(this.richTextBox1_SelectionChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BoldButton,
            this.ItalicsButton,
            this.UnderlineButton,
            this.toolStripSeparator1,
            this.TextColorButton,
            this.HighlightColorButton,
            this.ChooseFont,
            this.FontSizeChoose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 22);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(391, 22);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BoldButton
            // 
            this.BoldButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BoldButton.Image = ((System.Drawing.Image)(resources.GetObject("BoldButton.Image")));
            this.BoldButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BoldButton.Name = "BoldButton";
            this.BoldButton.Size = new System.Drawing.Size(23, 19);
            this.BoldButton.Text = "toolStripButton1";
            this.BoldButton.ToolTipText = "Bold";
            // 
            // ItalicsButton
            // 
            this.ItalicsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ItalicsButton.Image = ((System.Drawing.Image)(resources.GetObject("ItalicsButton.Image")));
            this.ItalicsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ItalicsButton.Name = "ItalicsButton";
            this.ItalicsButton.Size = new System.Drawing.Size(23, 19);
            this.ItalicsButton.Text = "Italics";
            // 
            // UnderlineButton
            // 
            this.UnderlineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UnderlineButton.Image = ((System.Drawing.Image)(resources.GetObject("UnderlineButton.Image")));
            this.UnderlineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UnderlineButton.Name = "UnderlineButton";
            this.UnderlineButton.Size = new System.Drawing.Size(23, 19);
            this.UnderlineButton.Text = "toolStripButton2";
            this.UnderlineButton.ToolTipText = "Underline";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 22);
            // 
            // TextColorButton
            // 
            this.TextColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TextColorButton.Image = ((System.Drawing.Image)(resources.GetObject("TextColorButton.Image")));
            this.TextColorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TextColorButton.Name = "TextColorButton";
            this.TextColorButton.Size = new System.Drawing.Size(23, 19);
            this.TextColorButton.Text = "(255,0,0)";
            this.TextColorButton.ToolTipText = "Text Color";
            this.TextColorButton.Click += new System.EventHandler(this.TextColorButton_Click);
            // 
            // HighlightColorButton
            // 
            this.HighlightColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HighlightColorButton.Image = ((System.Drawing.Image)(resources.GetObject("HighlightColorButton.Image")));
            this.HighlightColorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HighlightColorButton.Name = "HighlightColorButton";
            this.HighlightColorButton.Size = new System.Drawing.Size(23, 19);
            this.HighlightColorButton.Text = "toolStripButton1";
            this.HighlightColorButton.ToolTipText = "Highlight Color";
            this.HighlightColorButton.Click += new System.EventHandler(this.HighlightColorButton_Click);
            // 
            // ChooseFont
            // 
            this.ChooseFont.DropDownWidth = 150;
            this.ChooseFont.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.ChooseFont.Name = "ChooseFont";
            this.ChooseFont.Size = new System.Drawing.Size(130, 22);
            this.ChooseFont.SelectedIndexChanged += new System.EventHandler(this.ChooseFont_SelectedIndexChanged);
            // 
            // FontSizeChoose
            // 
            this.FontSizeChoose.DropDownWidth = 75;
            this.FontSizeChoose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.FontSizeChoose.Name = "FontSizeChoose";
            this.FontSizeChoose.Size = new System.Drawing.Size(75, 22);
            this.FontSizeChoose.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox2_SelectedIndexChanged);
            // 
            // MsgBox_RichTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(391, 207);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MsgBox_RichTextBox";
            this.Text = "MsgBox_RichTextBox";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BoldButton;
        private System.Windows.Forms.ToolStripButton ItalicsButton;
        private System.Windows.Forms.ToolStripButton UnderlineButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TextColorButton;
        private System.Windows.Forms.ToolStripButton HighlightColorButton;
        private System.Windows.Forms.ToolStripComboBox ChooseFont;
        private System.Windows.Forms.ToolStripComboBox FontSizeChoose;
    }
}