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
            this.Drawbox = new System.Windows.Forms.PictureBox();
            this.Colorpicker = new System.Windows.Forms.ColorDialog();
            this.Scripttoggle = new System.Windows.Forms.Button();
            this.Scriptbox = new System.Windows.Forms.RichTextBox();
            this.Color = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.ModeButton = new System.Windows.Forms.Button();
            this.DrawMode = new System.Windows.Forms.ComboBox();
            this.PolyClose = new System.Windows.Forms.Button();
            this.Text_box = new System.Windows.Forms.TextBox();
            this.Text_Box_Panel = new System.Windows.Forms.Panel();
            this.Number_Box = new System.Windows.Forms.TextBox();
            this.Undoer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Drawbox)).BeginInit();
            this.Text_Box_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Drawbox
            // 
            this.Drawbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Drawbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Drawbox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Drawbox.Location = new System.Drawing.Point(0, 26);
            this.Drawbox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.Drawbox.Name = "Drawbox";
            this.Drawbox.Size = new System.Drawing.Size(726, 428);
            this.Drawbox.TabIndex = 0;
            this.Drawbox.TabStop = false;
            this.Drawbox.SizeChanged += new System.EventHandler(this.Drawbox_SizeChanged);
            this.Drawbox.Click += new System.EventHandler(this.Drawbox_Click);
            this.Drawbox.DragDrop += new System.Windows.Forms.DragEventHandler(this.Drawbox_DragDrop);
            this.Drawbox.DragEnter += new System.Windows.Forms.DragEventHandler(this.Drawbox_DragEnter);
            this.Drawbox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drawbox_MouseMove);
            // 
            // Scripttoggle
            // 
            this.Scripttoggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Scripttoggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Scripttoggle.Location = new System.Drawing.Point(625, 0);
            this.Scripttoggle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Scripttoggle.Name = "Scripttoggle";
            this.Scripttoggle.Size = new System.Drawing.Size(101, 26);
            this.Scripttoggle.TabIndex = 1;
            this.Scripttoggle.Text = "Design View";
            this.Scripttoggle.UseVisualStyleBackColor = true;
            this.Scripttoggle.Click += new System.EventHandler(this.Scripttoggle_Click);
            // 
            // Scriptbox
            // 
            this.Scriptbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Scriptbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Scriptbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scriptbox.Location = new System.Drawing.Point(0, 26);
            this.Scriptbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Scriptbox.Name = "Scriptbox";
            this.Scriptbox.Size = new System.Drawing.Size(726, 428);
            this.Scriptbox.TabIndex = 2;
            this.Scriptbox.Text = "; welcome to RacketUiPaint\n; click Design View at the top to make something for r" +
    "acket\n(require 2htdp/image)\n(define base(rectangle 0 0 \"solid\" \"white\"))";
            // 
            // Color
            // 
            this.Color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Color.Location = new System.Drawing.Point(497, 0);
            this.Color.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(65, 26);
            this.Color.TabIndex = 1;
            this.Color.Text = "Color";
            this.Color.UseVisualStyleBackColor = true;
            this.Color.Click += new System.EventHandler(this.Color_Click);
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
            // PolyClose
            // 
            this.PolyClose.FlatAppearance.BorderSize = 2;
            this.PolyClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PolyClose.ForeColor = System.Drawing.Color.LimeGreen;
            this.PolyClose.Location = new System.Drawing.Point(150, 0);
            this.PolyClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PolyClose.Name = "PolyClose";
            this.PolyClose.Size = new System.Drawing.Size(56, 26);
            this.PolyClose.TabIndex = 1;
            this.PolyClose.Text = "Done";
            this.PolyClose.UseVisualStyleBackColor = true;
            this.PolyClose.Click += new System.EventHandler(this.PolyClose_Click);
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
            this.Controls.Add(this.Color);
            this.Controls.Add(this.DrawMode);
            this.Controls.Add(this.Scriptbox);
            this.Controls.Add(this.Scripttoggle);
            this.Controls.Add(this.Drawbox);
            this.Controls.Add(this.PolyClose);
            this.Controls.Add(this.Clear);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(744, 47);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "RacketUiPaint";
            ((System.ComponentModel.ISupportInitialize)(this.Drawbox)).EndInit();
            this.Text_Box_Panel.ResumeLayout(false);
            this.Text_Box_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Drawbox;
        private System.Windows.Forms.ColorDialog Colorpicker;
        private System.Windows.Forms.Button Scripttoggle;
        private System.Windows.Forms.RichTextBox Scriptbox;
        private System.Windows.Forms.Button Color;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button ModeButton;
        private System.Windows.Forms.ComboBox DrawMode;
        private System.Windows.Forms.Button PolyClose;
        private System.Windows.Forms.TextBox Text_box;
        private System.Windows.Forms.Panel Text_Box_Panel;
        private System.Windows.Forms.TextBox Number_Box;
        private System.Windows.Forms.Button Undoer;
    }
}

