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
            this.Undo = new System.Windows.Forms.Button();
            this.scriptthing = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 450);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 410);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // scriptv
            // 
            this.scriptv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scriptv.Location = new System.Drawing.Point(691, 8);
            this.scriptv.Name = "scriptv";
            this.scriptv.Size = new System.Drawing.Size(102, 26);
            this.scriptv.TabIndex = 1;
            this.scriptv.Text = "Design View";
            this.scriptv.UseVisualStyleBackColor = true;
            this.scriptv.Click += new System.EventHandler(this.scriptv_Click);
            // 
            // Undo
            // 
            this.Undo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Undo.Location = new System.Drawing.Point(597, 8);
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(75, 26);
            this.Undo.TabIndex = 1;
            this.Undo.Text = "Undo";
            this.Undo.UseVisualStyleBackColor = true;
            this.Undo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // scriptthing
            // 
            this.scriptthing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scriptthing.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scriptthing.Location = new System.Drawing.Point(0, 41);
            this.scriptthing.Name = "scriptthing";
            this.scriptthing.Size = new System.Drawing.Size(800, 410);
            this.scriptthing.TabIndex = 2;
            this.scriptthing.Text = "; welcome to RacketUiPaint\n; click Design View at the top to make something for r" +
    "acket\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 860);
            this.ControlBox = false;
            this.Controls.Add(this.scriptthing);
            this.Controls.Add(this.Undo);
            this.Controls.Add(this.scriptv);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button scriptv;
        private System.Windows.Forms.Button Undo;
        private System.Windows.Forms.RichTextBox scriptthing;
    }
}

