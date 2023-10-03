namespace RacketUiPaint
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.scriptv = new System.Windows.Forms.Button();
            this.scriptthing = new System.Windows.Forms.RichTextBox();
            this.color = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.ModeButton = new System.Windows.Forms.Button();
            this.DrawMode = new System.Windows.Forms.ComboBox();
            this.polyclose = new System.Windows.Forms.Button();
            this.Text_box = new System.Windows.Forms.TextBox();
            this.Text_Box_Panel = new System.Windows.Forms.Panel();
            this.Number_Box = new System.Windows.Forms.TextBox();
            this.Undoer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Text_Box_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Location = new System.Drawing.Point(0, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(726, 428);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.SizeChanged += new System.EventHandler(this.pictureBox1_SizeChanged);
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // scriptv
            // 
            this.scriptv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scriptv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scriptv.Location = new System.Drawing.Point(625, 0);
            this.scriptv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scriptv.Name = "scriptv";
            this.scriptv.Size = new System.Drawing.Size(101, 26);
            this.scriptv.TabIndex = 1;
            this.scriptv.Text = "Design View";
            this.scriptv.UseVisualStyleBackColor = true;
            this.scriptv.Click += new System.EventHandler(this.scriptv_Click);
            // 
            // scriptthing
            // 
            this.scriptthing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scriptthing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scriptthing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scriptthing.Location = new System.Drawing.Point(0, 26);
            this.scriptthing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scriptthing.Name = "scriptthing";
            this.scriptthing.Size = new System.Drawing.Size(726, 428);
            this.scriptthing.TabIndex = 2;
            this.scriptthing.Text = "; welcome to RacketUiPaint\n; click Design View at the top to make something for r" +
    "acket\n(require 2htdp/image)\n(define base(rectangle 0 0 \"solid\" \"white\"))";
            // 
            // color
            // 
            this.color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color.Location = new System.Drawing.Point(497, 0);
            this.color.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(65, 26);
            this.color.TabIndex = 1;
            this.color.Text = "Color";
            this.color.UseVisualStyleBackColor = true;
            this.color.Click += new System.EventHandler(this.color_Click);
            // 
            // Clear
            // 
            this.Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Location = new System.Drawing.Point(561, 0);
            this.Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(65, 26);
            this.Clear.TabIndex = 1;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // ModeButton
            // 
            this.ModeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeButton.Location = new System.Drawing.Point(395, 0);
            this.ModeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ModeButton.Name = "ModeButton";
            this.ModeButton.Size = new System.Drawing.Size(103, 26);
            this.ModeButton.TabIndex = 1;
            this.ModeButton.Text = "Mode: outline";
            this.ModeButton.UseVisualStyleBackColor = true;
            this.ModeButton.Click += new System.EventHandler(this.ModeButton_Click);
            // 
            // DrawMode
            // 
            this.DrawMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DrawMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrawMode.FormattingEnabled = true;
            this.DrawMode.Items.AddRange(new object[] {
            "Rectangle",
            "Mouse (Connected)",
            "Mouse (Seperate)",
            "Circle",
            "Triangle",
            "Polygon",
            "Text"});
            this.DrawMode.Location = new System.Drawing.Point(0, 0);
            this.DrawMode.Name = "DrawMode";
            this.DrawMode.Size = new System.Drawing.Size(144, 24);
            this.DrawMode.TabIndex = 1;
            this.DrawMode.SelectedIndexChanged += new System.EventHandler(this.DrawMode_SelectedIndexChanged);
            // 
            // polyclose
            // 
            this.polyclose.FlatAppearance.BorderSize = 2;
            this.polyclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.polyclose.ForeColor = System.Drawing.Color.LimeGreen;
            this.polyclose.Location = new System.Drawing.Point(150, 0);
            this.polyclose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.polyclose.Name = "polyclose";
            this.polyclose.Size = new System.Drawing.Size(56, 26);
            this.polyclose.TabIndex = 1;
            this.polyclose.Text = "Done";
            this.polyclose.UseVisualStyleBackColor = true;
            this.polyclose.Click += new System.EventHandler(this.polyclose_Click);
            // 
            // Text_box
            // 
            this.Text_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_box.BackColor = System.Drawing.SystemColors.Control;
            this.Text_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Text_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_box.Location = new System.Drawing.Point(0, 1);
            this.Text_box.Name = "Text_box";
            this.Text_box.Size = new System.Drawing.Size(110, 24);
            this.Text_box.TabIndex = 3;
            this.Text_box.Text = "Text Here";
            // 
            // Text_Box_Panel
            // 
            this.Text_Box_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_Box_Panel.Controls.Add(this.Number_Box);
            this.Text_Box_Panel.Controls.Add(this.Text_box);
            this.Text_Box_Panel.Location = new System.Drawing.Point(206, 0);
            this.Text_Box_Panel.Name = "Text_Box_Panel";
            this.Text_Box_Panel.Size = new System.Drawing.Size(139, 26);
            this.Text_Box_Panel.TabIndex = 0;
            // 
            // Number_Box
            // 
            this.Number_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Number_Box.BackColor = System.Drawing.SystemColors.Control;
            this.Number_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Number_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number_Box.Location = new System.Drawing.Point(109, 1);
            this.Number_Box.Name = "Number_Box";
            this.Number_Box.Size = new System.Drawing.Size(30, 24);
            this.Number_Box.TabIndex = 4;
            this.Number_Box.Text = "5";
            this.Number_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Number_Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_Box_KeyPress);
            // 
            // Undoer
            // 
            this.Undoer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Undoer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Undoer.Location = new System.Drawing.Point(344, 0);
            this.Undoer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Undoer.Name = "Undoer";
            this.Undoer.Size = new System.Drawing.Size(52, 26);
            this.Undoer.TabIndex = 1;
            this.Undoer.Text = "Undo";
            this.Undoer.UseVisualStyleBackColor = true;
            this.Undoer.Click += new System.EventHandler(this.Undoer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 454);
            this.ControlBox = false;
            this.Controls.Add(this.Text_Box_Panel);
            this.Controls.Add(this.ModeButton);
            this.Controls.Add(this.Undoer);
            this.Controls.Add(this.color);
            this.Controls.Add(this.DrawMode);
            this.Controls.Add(this.scriptthing);
            this.Controls.Add(this.scriptv);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.polyclose);
            this.Controls.Add(this.Clear);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(744, 0);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "RacketUiPaint";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Text_Box_Panel.ResumeLayout(false);
            this.Text_Box_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button scriptv;
        private System.Windows.Forms.RichTextBox scriptthing;
        private System.Windows.Forms.Button color;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button ModeButton;
        private System.Windows.Forms.ComboBox DrawMode;
        private System.Windows.Forms.Button polyclose;
        private System.Windows.Forms.TextBox Text_box;
        private System.Windows.Forms.Panel Text_Box_Panel;
        private System.Windows.Forms.TextBox Number_Box;
        private System.Windows.Forms.Button Undoer;
    }
}

