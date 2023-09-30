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
using static System.Net.Mime.MediaTypeNames;

namespace RacketUiPaint
{
    public partial class Form1 : Form
    {
        static Size bitmapthing;
        Bitmap drawingBitmap;
        int turn = 1;
        Point point1;
        Point point2;
        string[] alphabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
        static Color colorthingy = Color.Black;
        string racketcolor = "0 0 0";
        string rectangleformula = "(define newran(overlay/xy (rectangle width height \"mode\" color) x y oldran))";
        string lineformula = "(define newran (add-line oldran point1 point2 color))";
        string triangleformula = "(define newran (add-polygon oldran (list (make-posn point1) (make-posn point2) (make-posn point3)) \"mode\" color))";
        string circleformula = "(define newran(circle radius mode color) x y oldran)";
        string oldrandomstring = "base";
        public Form1()
        {
            InitializeComponent();
            DrawMode.SelectedIndex = 0;
            bitmapthing = pictureBox1.Size;
            drawingBitmap = new Bitmap(bitmapthing.Width, bitmapthing.Height);
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
                        Graphics.FromImage(drawingBitmap).DrawRectangle(drawingPen, new Rectangle(x, y, width, height));
                    else
                        Graphics.FromImage(drawingBitmap).FillRectangle(new SolidBrush(drawingPen.Color), new Rectangle(x, y, width, height));
                    pictureBox1.Image = drawingBitmap;
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

        private async void drawcircle()
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
                    Pen drawingPen = new Pen(colorthingy, 1);
                    Point point3 = pictureBox1.PointToClient(Cursor.Position);
                    int width = Math.Abs(point2.X - point1.X);
                    int height = Math.Abs(point2.Y - point1.Y);

                    int x = Math.Min(point1.X, point2.X);
                    int y = Math.Min(point1.Y, point2.Y);
                    int radius = Convert.ToInt32(calcdistance(point1, point2)) / 2;
                    if (mode == "outline")
                        Graphics.FromImage(drawingBitmap).DrawEllipse(drawingPen, point3.X - radius, point3.Y - radius, 2 * radius, 2 * radius);//DrawRectangle(drawingPen, new Rectangle(x, y, width, height));
                    else
                        Graphics.FromImage(drawingBitmap).FillEllipse(new SolidBrush(drawingPen.Color), point3.X - radius, point3.Y - radius, 2 * radius, 2 * radius);
                    pictureBox1.Image = drawingBitmap;
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
                    Graphics.FromImage(drawingBitmap).DrawLine(drawingPen, point1, point2);
                    drawingPen.Dispose();
                    pictureBox1.Image = drawingBitmap;
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
                    Graphics.FromImage(drawingBitmap).DrawLine(drawingPen, point1, point2);
                    drawingPen.Dispose();
                    pictureBox1.Image = drawingBitmap;
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
                    int x = Math.Min(point1.X, point2.X);
                    int y = Math.Min(point1.Y, point2.Y);
                    Point[] points = { point1, point2, point3 };
                    if (mode == "outline")
                        Graphics.FromImage(drawingBitmap).DrawPolygon(drawingPen, points);
                    else
                        Graphics.FromImage(drawingBitmap).FillPolygon(new SolidBrush(drawingPen.Color), points);
                    drawingPen.Dispose();
                    pictureBox1.Image = drawingBitmap;
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
                case 3:
                    drawcircle();
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
            drawingBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = drawingBitmap;
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

        private void pictureBox1_SizeChanged(object sender, EventArgs e)
        {
            if (bitmapthing.Width < pictureBox1.Size.Width)
                bitmapthing.Width = pictureBox1.Size.Width;
            if (bitmapthing.Height < pictureBox1.Size.Height)
                bitmapthing.Height = pictureBox1.Size.Height;
            Bitmap thingy = drawingBitmap;
            drawingBitmap = new Bitmap(bitmapthing.Width, bitmapthing.Height);
            Graphics.FromImage(drawingBitmap).DrawImage(thingy, 0, 0);
        }
        double calcdistance(Point p1, Point p2)
        {
            return Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y));// < d * d
        }

        bool timeout = false;
        private async void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!timeout)
            {
                timeout = true;
            }
            else return;

            //preview code, runs every time the mouse moves on the picturebox.
            switch (DrawMode.SelectedIndex)
            {
                case 0:
                    //rectangle
                    if (turn == 2)
                    {
                        Pen drawingPen = new Pen(colorthingy, 1);
                        point2 = pictureBox1.PointToClient(Cursor.Position);
                        int width = Math.Abs(point2.X - point1.X);
                        int height = Math.Abs(point2.Y - point1.Y);

                        int x = Math.Min(point1.X, point2.X);
                        int y = Math.Min(point1.Y, point2.Y);
                        pictureBox1.Invalidate();
                        await Task.Delay(5);
                        if (mode == "outline")
                            pictureBox1.CreateGraphics().DrawRectangle(drawingPen, new Rectangle(x, y, width, height));
                        else
                            pictureBox1.CreateGraphics().FillRectangle(new SolidBrush(drawingPen.Color), new Rectangle(x, y, width, height));
                        drawingPen.Dispose();
                    }
                    break;
                case 1:
                    //connectedline

                    break;
                case 2:
                    //seperate line
                    break;
                case 3:
                    //circle
                    break;
                case 4:
                    //triangle
                    if (turn == 3)
                    {
                        Point point3 = pictureBox1.PointToClient(Cursor.Position);
                        Pen drawingPen = new Pen(colorthingy, 1);
                        Point[] points = { point1, point2, point3 };
                        pictureBox1.Invalidate();
                        await Task.Delay(5);
                        if (mode == "outline")
                            pictureBox1.CreateGraphics().DrawPolygon(drawingPen, points);
                        else
                            pictureBox1.CreateGraphics().FillPolygon(new SolidBrush(drawingPen.Color), points);
                        drawingPen.Dispose();
                    }
                    break;
            }
            await Task.Delay(25);
            timeout = false;
        }
    }
}