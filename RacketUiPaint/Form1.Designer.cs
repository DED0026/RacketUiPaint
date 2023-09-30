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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(0, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 428);
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
            this.scriptv.Location = new System.Drawing.Point(699, 0);
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
            this.scriptthing.Location = new System.Drawing.Point(0, 29);
            this.scriptthing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scriptthing.Name = "scriptthing";
            this.scriptthing.Size = new System.Drawing.Size(800, 425);
            this.scriptthing.TabIndex = 2;
            this.scriptthing.Text = "; welcome to RacketUiPaint\n; click Design View at the top to make something for r" +
    "acket\n(define base(rectangle 0 0 \"solid\" \"white\"))";
            // 
            // color
            // 
            this.color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color.Location = new System.Drawing.Point(571, 0);
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
            this.Clear.Location = new System.Drawing.Point(635, 0);
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
            this.ModeButton.Location = new System.Drawing.Point(469, 0);
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
            "Triangle"});
            this.DrawMode.Location = new System.Drawing.Point(0, 0);
            this.DrawMode.Name = "DrawMode";
            this.DrawMode.Size = new System.Drawing.Size(144, 24);
            this.DrawMode.TabIndex = 1;
            this.DrawMode.SelectedIndexChanged += new System.EventHandler(this.DrawMode_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 454);
            this.ControlBox = false;
            this.Controls.Add(this.DrawMode);
            this.Controls.Add(this.scriptthing);
            this.Controls.Add(this.color);
            this.Controls.Add(this.scriptv);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ModeButton);
            this.Controls.Add(this.Clear);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "RacketUiPaint";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}

