using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacketUiPaint
{
    public partial class Form1 : Form
    {
        string rectangleformula = "(define newran(overlay/xy (rectangle width height \"mode\" color) x y oldran))";
        string lineformula = "(define newran (add-line oldran point1 point2 color))";
        string triangleformula = "(define newran (add-polygon oldran (list (make-posn point1) (make-posn point2) (make-posn point3)) \"mode\" color))";
        string oldrandomstring = "base";
        public Form1()
        {
            InitializeComponent();
            DrawMode.SelectedIndex = 0;
        }
        string[] alphabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
        static Color colorthingy = Color.Black;

        string racketcolor = "0 0 0";

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

        int turn = 1;

        Point point1;
        Point point2;

        private async void drawrectangle()
        {
            switch (turn)
            {
                case 1:
                    point1 = pictureBox1.PointToClient(Cursor.Position);
                    turn++;
                    break;
                case 2:
                    Pen drawingPen = new Pen(colorthingy, 1); 
                    point2 = pictureBox1.PointToClient(Cursor.Position);
                    int width = Math.Abs(point2.X - point1.X); 
                    int height = Math.Abs(point2.Y - point1.Y); 

                    int x = Math.Min(point1.X, point2.X);
                    int y = Math.Min(point1.Y, point2.Y); 
                    if (mode == "outline")
                        pictureBox1.CreateGraphics().DrawRectangle(drawingPen, new Rectangle(x, y, width, height));
                    else
                        pictureBox1.CreateGraphics().FillRectangle(new SolidBrush(drawingPen.Color), new Rectangle(x, y, width, height));

                    drawingPen.Dispose();

                    string newrandomstring = "";
                loob:
                    while (5 > newrandomstring.Length)
                    {
                        newrandomstring += alphabet[new Random().Next(0, 62)];
                        await Task.Delay(1);
                    }
                    if (scriptthing.Text.Contains(newrandomstring))
                    {
                        await Task.Delay(200);
                        goto loob;
                    }
                    x = x - x * 2;
                    y = y - y * 2;
                    scriptthing.Text += "\r" + rectangleformula.Replace("newran", newrandomstring).Replace("height", height.ToString()).Replace("width", width.ToString()).Replace(" x ", " " + x.ToString() + " ").Replace(" y ", " " + y.ToString() + " ").Replace("color", "(make-color " + racketcolor + ")").Replace("mode", mode).Replace("oldran", oldrandomstring);
                    oldrandomstring = newrandomstring;
                    turn = 1;
                    break;
            }
        }


        private async void drawlineconnected()
        {
            switch (turn)
            {
                case 1:
                    point1 = pictureBox1.PointToClient(Cursor.Position);
                    turn++;
                    break;
                case 2:
                    Pen drawingPen = new Pen(colorthingy, 1); 
                    point2 = pictureBox1.PointToClient(Cursor.Position);
                    pictureBox1.CreateGraphics().DrawLine(drawingPen, point1, point2);
                    drawingPen.Dispose();

                    string newrandomstring = "";
                loob:
                    while (5 > newrandomstring.Length)
                    {
                        newrandomstring += alphabet[new Random().Next(0, 62)];
                        await Task.Delay(1);
                    }
                    if (scriptthing.Text.Contains(newrandomstring))
                    {
                        await Task.Delay(200);
                        goto loob;
                    }
                    scriptthing.Text += "\r" + lineformula.Replace("newran", newrandomstring).Replace("point1", point1.X + " " + point1.Y).Replace("point2", point2.X + " " + point2.Y).Replace("color", "(make-color " + racketcolor + ")").Replace("oldran", oldrandomstring);
                    oldrandomstring = newrandomstring;
                    point1 = point2;
                    break;
            }
        }

        private async void drawlineseperate()
        {
            switch (turn)
            {
                case 1:
                    point1 = pictureBox1.PointToClient(Cursor.Position);
                    turn++;
                    break;
                case 2:
                    Pen drawingPen = new Pen(colorthingy, 1); // Customize the pen as needed
                    point2 = pictureBox1.PointToClient(Cursor.Position);
                    pictureBox1.CreateGraphics().DrawLine(drawingPen, point1, point2);
                    drawingPen.Dispose();

                    string newrandomstring = "";
                loob:
                    while (5 > newrandomstring.Length)
                    {
                        newrandomstring += alphabet[new Random().Next(0, 62)];
                        await Task.Delay(1);
                    }
                    if (scriptthing.Text.Contains(newrandomstring))
                    {
                        await Task.Delay(200);
                        goto loob;
                    }
                    scriptthing.Text += "\r" + lineformula.Replace("newran", newrandomstring).Replace("point1", point1.X + " " + point1.Y).Replace("point2", point2.X + " " + point2.Y).Replace("color", "(make-color " + racketcolor + ")").Replace("oldran", oldrandomstring);
                    oldrandomstring = newrandomstring;
                    turn = 1;
                    break;
            }
        }

        private async void drawtriangle()
        {
            switch (turn)
            {
                case 1:
                    point1 = pictureBox1.PointToClient(Cursor.Position);
                    turn++;
                    break;
                case 2:
                    point2 = pictureBox1.PointToClient(Cursor.Position);
                    turn++;
                    break; 
                case 3:
                    Point point3 = pictureBox1.PointToClient(Cursor.Position);
                    Pen drawingPen = new Pen(colorthingy, 1); 
                    int width = Math.Abs(point2.X - point1.X); 
                    int height = Math.Abs(point2.Y - point1.Y); 

                    int x = Math.Min(point1.X, point2.X); 
                    int y = Math.Min(point1.Y, point2.Y);
                    Point[] points = {point1, point2, point3};
                    if (mode == "outline")
                        pictureBox1.CreateGraphics().DrawPolygon(drawingPen, points);
                    else
                        pictureBox1.CreateGraphics().FillPolygon(new SolidBrush(drawingPen.Color), points);
                    drawingPen.Dispose();

                    string newrandomstring = "";
                loob:
                    while (5 > newrandomstring.Length)
                    {
                        newrandomstring += alphabet[new Random().Next(0, 62)];
                        await Task.Delay(1);
                    }
                    if (scriptthing.Text.Contains(newrandomstring))
                    {
                        await Task.Delay(200);
                        goto loob;
                    }
                    x = x - x * 2;
                    y = y - y * 2;
                    //(define newran (add-polygon oldran (list (make-posn point1) (make-posn point2) (make-posn point3) \"mode\" color))
                    scriptthing.Text += "\r" + triangleformula.Replace("newran", newrandomstring).Replace("point1", point1.X + " " + point1.Y).Replace("point2", point2.X + " " + point2.Y).Replace("point3", point3.X + " " + point3.Y).Replace("color", "(make-color " + racketcolor + ")").Replace("mode", mode).Replace("oldran", oldrandomstring);
                    oldrandomstring = newrandomstring;
                    turn = 1;
                    break;
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            switch (DrawMode.SelectedIndex)
            {
                case 0:
                    drawrectangle();
                    break;
                case 1:
                    drawlineconnected();
                    break;
                case 2:
                    drawlineseperate();
                    break;
                case 4:
                    drawtriangle();
                    break;
                default:
                    MessageBox.Show("Uncoded Code Reached: " + DrawMode.SelectedIndex);
                    break;
            }
        }

        private void color_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            colorthingy = colorDialog1.Color;
            racketcolor = colorthingy.R + " " + colorthingy.G + " " + colorthingy.B;
            color.ForeColor = colorthingy;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
            oldrandomstring = "base";
            scriptthing.Text = "; welcome to RacketUiPaint\r; click Design View at the top to make something for racket\r(define base(rectangle 0 0 \"solid\" \"white\"))";
        }
        string mode = "outline";
        private void ModeButton_Click(object sender, EventArgs e)
        {
            if (mode == "outline")
                mode = "solid";
            else
                mode = "outline";
            ModeButton.Text = "Mode: " + mode;
        }

        private void DrawMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            turn = 1;
        }
    }
}