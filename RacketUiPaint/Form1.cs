using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacketUiPaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            if (e.KeyCode == Keys.I)
            {
                MessageBox.Show("thanks for using racketuipaint\rthis application is made to paint in racket using shapes\rpress:\rESC to close the app\rI to close this menu\rC for colors\rS for shapes");
            }
        }

        private bool isDrawing = false;
        private Point previousPoint;
        private Pen drawingPen = new Pen(Color.HotPink, 1); // Customize the pen as needed
        private List<GraphicsPath> drawnPaths = new List<GraphicsPath>();
        private int currentPathIndex = -1; // Current index in the list

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            previousPoint = e.Location;
            // Create a new GraphicsPath for the current drawing
            GraphicsPath path = new GraphicsPath();
            //path.AddLine(previousPoint, previousPoint);
            drawnPaths.Add(path);
            currentPathIndex++;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                using (Graphics g = pictureBox1.CreateGraphics())
                {
                    g.DrawLine(drawingPen, previousPoint, e.Location);
                    previousPoint = e.Location;
                    drawnPaths[currentPathIndex].AddLine(previousPoint, e.Location);
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var path in drawnPaths)
            {
                e.Graphics.DrawPath(drawingPen, path);
            }
        }

        private void scriptv_Click(object sender, EventArgs e)
        {
            if (scriptthing.Visible)
            {
                scriptthing.Visible = false;
                scriptv.Text = "Script View";
            }
            else
            {
                scriptthing.Visible = true;
                scriptv.Text = "Design View";
            }
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            if (currentPathIndex >= 0)
            {
                drawnPaths.RemoveAt(currentPathIndex);
                currentPathIndex--;
                pictureBox1.Refresh(); // Repaint the PictureBox
            }
        }
    }
}
