using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacketUiPaint
{
    public partial class Form1 : Form
    {
        static Size bitmapthing;
        Bitmap drawingBitmap;
        int turn = 1;
        Point point1;
        Point point2;
        readonly string[] alphabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
        static Color colorthingy = System.Drawing.Color.Black;
        string pointsforracket;
        string racketcolor = "0 0 0";
        string oldrandomstring = "base";
        string newrandomstring;
        readonly string rectangleformula = "(define newran(overlay/xy (rectangle width height \"mode\" color) x y oldran))";
        readonly string lineformula = "(define newran(add-line oldran point1 point2 color))";
        readonly string triangleformula = "(define newran(add-polygon oldran (list (make-posn point1) (make-posn point2) (make-posn point3)) \"mode\" color))";
        readonly string circleformula = "(define newran(overlay/xy (circle radius \"mode\" color) x y oldran))";
        readonly string polygonformula = "(define newran(add-polygon oldran (listpoints) \"mode\" color))";
        readonly string pointformula = " (make-posn x y)";
        readonly string textformula = "(define newran(overlay/xy (text \" string\" size color) x y oldran))";
        readonly Stack<Bitmap> bitmaphistory = new Stack<Bitmap>();
        readonly Stack<string> randomstack = new Stack<string>();
        readonly Stack<string> scriptstack = new Stack<string>();
        readonly List<Point> pointslist = new List<Point>();
        public Form1()
        {
            InitializeComponent();
            DrawMode.SelectedIndex = 0;
            bitmapthing = Drawbox.Size;
            drawingBitmap = new Bitmap(bitmapthing.Width, bitmapthing.Height);
            Drawbox.Image = drawingBitmap;
            PolyClose.Hide();
            Text_Box_Panel.Hide();
            Undoer.Hide();
            SaveState();
        }

        private void Scripttoggle_Click(object sender, EventArgs e)
        {
            if (Scriptbox.Visible)
            {
                Scriptbox.Visible = false;
                Scripttoggle.Text = "Script View";
            }
            else
            {
                Scriptbox.Visible = true;
                Scripttoggle.Text = "Design View";
            }
        }

        private async void DrawRectangle()
        {
            switch (turn)
            {
                case 1:
                    point1 = Drawbox.PointToClient(Cursor.Position);
                    turn++;
                    break;
                case 2:
                    Pen drawingPen = new Pen(colorthingy, 1);
                    point2 = Drawbox.PointToClient(Cursor.Position);
                    int width = Math.Abs(point2.X - point1.X);
                    int height = Math.Abs(point2.Y - point1.Y);

                    int x = Math.Min(point1.X, point2.X);
                    int y = Math.Min(point1.Y, point2.Y);
                    if (mode == "outline")
                        Graphics.FromImage(drawingBitmap).DrawRectangle(drawingPen, new Rectangle(x, y, width, height));
                    else
                        Graphics.FromImage(drawingBitmap).FillRectangle(drawingPen.Brush, new Rectangle(x, y, width, height));
                    Drawbox.Image = drawingBitmap;
                    drawingPen.Dispose();
                    string newrandomstring = "";
                loob:
                    while (5 > newrandomstring.Length)
                    {
                        newrandomstring += alphabet[new Random().Next(0, 62)];
                        await Task.Delay(1);
                    }
                    if (Scriptbox.Text.Contains(newrandomstring))
                    {
                        await Task.Delay(200);
                        goto loob;
                    }
                    x = -x;
                    y = -y;
                    Scriptbox.Text += "\r" + rectangleformula.Replace("newran", newrandomstring).Replace("height", height.ToString()).Replace("width", width.ToString()).Replace(" x ", " " + x.ToString() + " ").Replace(" y ", " " + y.ToString() + " ").Replace("color", "(make-color " + racketcolor + ")").Replace("mode", mode).Replace("oldran", oldrandomstring);
                    oldrandomstring = newrandomstring;
                    turn = 1;
                    SaveState();
                    break;
            }
        }

        private async void DrawCircle()
        {
            switch (turn)
            {
                case 1:
                    point1 = Drawbox.PointToClient(Cursor.Position);
                    turn++;
                    break;
                case 2:
                    point2 = Drawbox.PointToClient(Cursor.Position);
                    turn++;
                    break;
                case 3:
                    Pen drawingPen = new Pen(colorthingy, 1);
                    Point point3 = Drawbox.PointToClient(Cursor.Position);
                    int radius = Convert.ToInt32(CalcDistance(point1, point2)) / 2;
                    int x = point3.X - radius;
                    int y = point3.Y - radius;
                    if (mode == "outline")
                        Graphics.FromImage(drawingBitmap).DrawEllipse(drawingPen, point3.X - radius, point3.Y - radius, 2 * radius, 2 * radius);//DrawRectangle(drawingPen, new Rectangle(x, y, width, height));
                    else
                        Graphics.FromImage(drawingBitmap).FillEllipse(new SolidBrush(drawingPen.Color), point3.X - radius, point3.Y - radius, 2 * radius, 2 * radius);
                    Drawbox.Image = drawingBitmap;
                    drawingPen.Dispose();
                loob:
                    while (5 > newrandomstring.Length)
                    {
                        newrandomstring += alphabet[new Random().Next(0, 62)];
                        await Task.Delay(1);
                    }
                    if (Scriptbox.Text.Contains(newrandomstring))
                    {
                        await Task.Delay(200);
                        goto loob;
                    }
                    x = -x;
                    y = -y;
                    Scriptbox.Text += "\r" + circleformula.Replace("newran", newrandomstring).Replace("radius", radius.ToString()).Replace(" x ", " " + x.ToString() + " ").Replace(" y ", " " + y.ToString() + " ").Replace("color", "(make-color " + racketcolor + ")").Replace("mode", mode).Replace("oldran", oldrandomstring);
                    oldrandomstring = newrandomstring;
                    turn = 1;
                    SaveState();
                    break;
            }
        }


        private async void DrawLineConnected()
        {
            switch (turn)
            {
                case 1:
                    point1 = Drawbox.PointToClient(Cursor.Position);
                    turn++;
                    break;
                case 2:
                    Pen drawingPen = new Pen(colorthingy, 1);
                    point2 = Drawbox.PointToClient(Cursor.Position);
                    Graphics.FromImage(drawingBitmap).DrawLine(drawingPen, point1, point2);
                    drawingPen.Dispose();
                    Drawbox.Image = drawingBitmap;
                loob:
                    while (5 > newrandomstring.Length)
                    {
                        newrandomstring += alphabet[new Random().Next(0, 62)];
                        await Task.Delay(1);
                    }
                    if (Scriptbox.Text.Contains(newrandomstring))
                    {
                        await Task.Delay(200);
                        goto loob;
                    }
                    Scriptbox.Text += "\r" + lineformula.Replace("newran", newrandomstring).Replace("point1", point1.X + " " + point1.Y).Replace("point2", point2.X + " " + point2.Y).Replace("color", "(make-color " + racketcolor + ")").Replace("oldran", oldrandomstring);
                    oldrandomstring = newrandomstring;
                    point1 = point2;
                    SaveState();
                    break;
            }
        }

        private async void DrawLineSeperate()
        {
            switch (turn)
            {
                case 1:
                    point1 = Drawbox.PointToClient(Cursor.Position);
                    turn++;
                    break;
                case 2:
                    Pen drawingPen = new Pen(colorthingy, 1); // Customize the pen as needed
                    point2 = Drawbox.PointToClient(Cursor.Position);
                    Graphics.FromImage(drawingBitmap).DrawLine(drawingPen, point1, point2);
                    drawingPen.Dispose();
                    Drawbox.Image = drawingBitmap;
                loob:
                    while (5 > newrandomstring.Length)
                    {
                        newrandomstring += alphabet[new Random().Next(0, 62)];
                        await Task.Delay(1);
                    }
                    if (Scriptbox.Text.Contains(newrandomstring))
                    {
                        await Task.Delay(200);
                        goto loob;
                    }
                    Scriptbox.Text += "\r" + lineformula.Replace("newran", newrandomstring).Replace("point1", point1.X + " " + point1.Y).Replace("point2", point2.X + " " + point2.Y).Replace("color", "(make-color " + racketcolor + ")").Replace("oldran", oldrandomstring);
                    oldrandomstring = newrandomstring;
                    turn = 1;
                    SaveState();
                    break;
            }
        }

        private async void DrawTriangle()
        {
            switch (turn)
            {
                case 1:
                    point1 = Drawbox.PointToClient(Cursor.Position);
                    turn++;
                    break;
                case 2:
                    point2 = Drawbox.PointToClient(Cursor.Position);
                    turn++;
                    break;
                case 3:
                    Point point3 = Drawbox.PointToClient(Cursor.Position);
                    Pen drawingPen = new Pen(colorthingy, 1);
                    Point[] points = { point1, point2, point3 };
                    if (mode == "outline")
                        Graphics.FromImage(drawingBitmap).DrawPolygon(drawingPen, points);
                    else
                        Graphics.FromImage(drawingBitmap).FillPolygon(drawingPen.Brush, points);
                    drawingPen.Dispose();
                    Drawbox.Image = drawingBitmap;
                loob:
                    while (5 > newrandomstring.Length)
                    {
                        newrandomstring += alphabet[new Random().Next(0, 62)];
                        await Task.Delay(1);
                    }
                    if (Scriptbox.Text.Contains(newrandomstring))
                    {
                        await Task.Delay(200);
                        goto loob;
                    }
                    //(define newran (add-polygon oldran (list (make-posn point1) (make-posn point2) (make-posn point3) \"mode\" color))
                    Scriptbox.Text += "\r" + triangleformula.Replace("newran", newrandomstring).Replace("point1", point1.X + " " + point1.Y).Replace("point2", point2.X + " " + point2.Y).Replace("point3", point3.X + " " + point3.Y).Replace("color", "(make-color " + racketcolor + ")").Replace("mode", mode).Replace("oldran", oldrandomstring);
                    oldrandomstring = newrandomstring;
                    turn = 1;
                    SaveState();
                    break;
            }
        }

        void DrawPolygon()
        {
            pointslist.Add(Drawbox.PointToClient(Cursor.Position));
            turn++;
            if (turn > 3)
                PolyClose.Show();
        }

        private async void DrawText()
        {
            if (Number_Box.Text.Length > 0 && int.Parse(Number_Box.Text) > 0)
            {
                Point pointthingy = Drawbox.PointToClient(Cursor.Position);
                Graphics.FromImage(drawingBitmap).DrawString(Text_box.Text, new Font("Arial", int.Parse(Number_Box.Text)), new Pen(colorthingy).Brush, pointthingy);
                
                //(define newran(overlay/xy (text \"string\" size color) x y oldran))

                pointthingy.X = -pointthingy.X;
                pointthingy.Y = -pointthingy.Y;
            loob:
                newrandomstring = "";
                while (5 > newrandomstring.Length)
                {
                    newrandomstring += alphabet[new Random().Next(0, 62)];
                    await Task.Delay(1);
                }
                if (Scriptbox.Text.Contains(newrandomstring))
                {
                    await Task.Delay(200);
                    goto loob;
                }
                Scriptbox.Text += "\r" + textformula.Replace("newran", newrandomstring).Replace("string", Text_box.Text).Replace("size", Convert.ToInt32(int.Parse(Number_Box.Text) * 1.6555).ToString()).Replace("color", "(make-color " + racketcolor + ")").Replace(" x ", " " + Convert.ToInt32(pointthingy.X * 1.05 + 2).ToString() + " ").Replace(" y ", " " + pointthingy.Y.ToString() + " ").Replace("oldran", oldrandomstring);
                oldrandomstring = newrandomstring;
                SaveState();
            }
        }

        private async void Drawbox_Click(object sender, EventArgs e)
        {
            switch (DrawMode.SelectedIndex)
            {
                case 0:
                    DrawRectangle();
                    break;
                case 1:
                    DrawLineConnected();
                    break;
                case 2:
                    DrawLineSeperate();
                    break;
                case 3:
                    DrawCircle();
                    break;
                case 4:
                    DrawTriangle();
                    break;
                case 5:
                    DrawPolygon();
                    break;
                case 6:
                    DrawText();
                    break;
                default:
                    MessageBox.Show("Uncoded Code Reached: " + DrawMode.SelectedIndex);
                    break;
            }
            await Task.Delay(100);
            Drawbox.Invalidate();
        }

        private void Color_Click(object sender, EventArgs e)
        {
            Colorpicker.ShowDialog();
            colorthingy = Colorpicker.Color;
            racketcolor = colorthingy.R + " " + colorthingy.G + " " + colorthingy.B;
            Color.ForeColor = colorthingy;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            if (turn != 1)
            {
                turn = 1;
            }
            else
            {
                drawingBitmap.Dispose();
                drawingBitmap = new Bitmap(Drawbox.Width, Drawbox.Height);
                Drawbox.Image = drawingBitmap;
                oldrandomstring = "base";
                Scriptbox.Text = "; welcome to RacketUiPaint\r; click Design View at the top to make something for racket\r(require 2htdp/image)\r(define base(rectangle 0 0 \"solid\" \"white\"))";
            }
            Drawbox.Invalidate();
            SaveState();
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
            Drawbox.Invalidate();
            if (DrawMode.Text.ToLower() == "text")
                Text_Box_Panel.Show();
            else
                Text_Box_Panel.Hide();
        }

        private void Drawbox_SizeChanged(object sender, EventArgs e)
        {
            if (bitmapthing.Width < Drawbox.Size.Width)
                bitmapthing.Width = Drawbox.Size.Width;
            if (bitmapthing.Height < Drawbox.Size.Height)
                bitmapthing.Height = Drawbox.Size.Height;
            Bitmap thingy = drawingBitmap;
            drawingBitmap.Dispose();
            drawingBitmap = new Bitmap(bitmapthing.Width, bitmapthing.Height);
            Graphics.FromImage(drawingBitmap).DrawImage(thingy, 0, 0);
            thingy.Dispose();
        }
        double CalcDistance(Point p1, Point p2) => Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y));// < d * d

        bool timeout = false;
        private async void Drawbox_MouseMove(object sender, MouseEventArgs e)
        {
            if (!timeout)
            {
                timeout = true;
            }
            else return;
            //preview code, runs every time the mouse moves on the Drawbox.
            switch (DrawMode.SelectedIndex)
            {
                case 0:
                    //rectangle
                    if (turn == 2)
                    {
                        Pen drawingPen = new Pen(colorthingy, 1);
                        point2 = Drawbox.PointToClient(Cursor.Position);
                        int width = Math.Abs(point2.X - point1.X);
                        int height = Math.Abs(point2.Y - point1.Y);
                        int x = Math.Min(point1.X, point2.X);
                        int y = Math.Min(point1.Y, point2.Y);
                        Drawbox.Invalidate();
                        await Task.Delay(5);
                        if (mode == "outline")
                            Drawbox.CreateGraphics().DrawRectangle(drawingPen, new Rectangle(x, y, width, height));
                        else
                            Drawbox.CreateGraphics().FillRectangle(drawingPen.Brush, new Rectangle(x, y, width, height));
                        drawingPen.Dispose();
                    }
                    break;
                case 1:
                //connectedline
                case 2:
                    //seperate line
                    if (turn == 2)
                    {
                        Pen drawingPen = new Pen(colorthingy, 1); // Customize the pen as needed
                        point2 = Drawbox.PointToClient(Cursor.Position);
                        Drawbox.Invalidate();
                        await Task.Delay(5);
                        Drawbox.CreateGraphics().DrawLine(drawingPen, point1, point2);
                        drawingPen.Dispose();
                    }
                    break;
                case 3:
                    //circle
                    if (turn == 2)
                    {
                        Pen drawingPen = new Pen(colorthingy, 1);
                        Point point2 = Drawbox.PointToClient(Cursor.Position);
                        int radius = Convert.ToInt32(CalcDistance(point1, point2)) / 2;
                        Drawbox.Invalidate();
                        await Task.Delay(5);
                        Point center = new Point((point1.X + point2.X) / 2, (point1.Y + point2.Y) / 2);
                        if (mode == "outline")
                            Drawbox.CreateGraphics().DrawEllipse(drawingPen, center.X - radius, center.Y - radius, 2 * radius, 2 * radius);//DrawRectangle(drawingPen, new Rectangle(x, y, width, height));
                        else
                            Drawbox.CreateGraphics().FillEllipse(drawingPen.Brush, center.X - radius, center.Y - radius, 2 * radius, 2 * radius);
                        drawingPen.Dispose();
                    }
                    if (turn == 3)
                    {
                        Pen drawingPen = new Pen(colorthingy, 1);
                        Point point3 = Drawbox.PointToClient(Cursor.Position);
                        int radius = Convert.ToInt32(CalcDistance(point1, point2)) / 2;
                        Drawbox.Invalidate();
                        await Task.Delay(5);
                        if (mode == "outline")
                            Drawbox.CreateGraphics().DrawEllipse(drawingPen, point3.X - radius, point3.Y - radius, 2 * radius, 2 * radius);//DrawRectangle(drawingPen, new Rectangle(x, y, width, height));
                        else
                            Drawbox.CreateGraphics().FillEllipse(drawingPen.Brush, point3.X - radius, point3.Y - radius, 2 * radius, 2 * radius);
                        drawingPen.Dispose();
                    }
                    break;
                case 4:
                    //triangle
                    if (turn == 3)
                    {
                        Point point3 = Drawbox.PointToClient(Cursor.Position);
                        Pen drawingPen = new Pen(colorthingy, 1);
                        Point[] points = { point1, point2, point3 };
                        Drawbox.Invalidate();
                        await Task.Delay(5);
                        if (mode == "outline")
                            Drawbox.CreateGraphics().DrawPolygon(drawingPen, points);
                        else
                            Drawbox.CreateGraphics().FillPolygon(drawingPen.Brush, points);
                        drawingPen.Dispose();
                    }
                    break;
                case 5:
                    //    //polygons
                    if (turn > 2)
                    {
                        Drawbox.Invalidate();
                        await Task.Delay(5);
                        List<Point> points = new List<Point>(pointslist)
                        {
                            Drawbox.PointToClient(Cursor.Position)
                        };
                        if (mode == "outline")
                            Drawbox.CreateGraphics().DrawPolygon(new Pen(colorthingy, 1), points.ToArray());
                        else
                            Drawbox.CreateGraphics().FillPolygon(new SolidBrush(colorthingy), points.ToArray());
                    }
                    break;
                case 6:

                    Drawbox.Invalidate();
                    await Task.Delay(5);
                    if (Number_Box.Text.Length > 0 && int.Parse(Number_Box.Text) > 0)
                    {
                        await Task.Delay(5);
                        Drawbox.CreateGraphics().DrawString(Text_box.Text, new Font("Arial", int.Parse(Number_Box.Text)), new Pen(colorthingy).Brush, Drawbox.PointToClient(Cursor.Position));
                    }
                    break;
            }
            await Task.Delay(25);
            timeout = false;
        }

        private async void PolyClose_Click(object sender, EventArgs e)
        {
            if (turn > 3)
            {
                if (mode == "outline")
                    Graphics.FromImage(drawingBitmap).DrawPolygon(new Pen(colorthingy, 1), pointslist.ToArray());
                else
                    Graphics.FromImage(drawingBitmap).FillPolygon(new SolidBrush(colorthingy), pointslist.ToArray());
                Drawbox.Image = drawingBitmap;

                string newrandomstring = "";
            loob:
                while (5 > newrandomstring.Length)
                {
                    newrandomstring += alphabet[new Random().Next(0, 62)];
                    await Task.Delay(1);
                }
                if (Scriptbox.Text.Contains(newrandomstring))
                {
                    await Task.Delay(200);
                    goto loob;
                }
                pointsforracket = "";
                foreach(Point point in pointslist)
                    pointsforracket += pointformula.Replace(" x", " " + point.X).Replace(" y", " " + point.Y);
                //(define newran (add-polygon oldran (listpoints \"mode\" color))
                Scriptbox.Text += "\r" + polygonformula.Replace("newran", newrandomstring).Replace("points", pointsforracket).Replace("mode", mode).Replace("color", "(make-color " + racketcolor + ")").Replace("oldran", oldrandomstring);
                oldrandomstring = newrandomstring;
                turn = 1;
                SaveState();
            }
            PolyClose.Hide();
        }

        private void Number_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numeric characters, Backspace, Delete, and arrow keys
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Undoer_Click(object sender, EventArgs e)
        {
            if (bitmaphistory.Count > 1)
            {
                bitmaphistory.Pop();
                randomstack.Pop();
                scriptstack.Pop();
                oldrandomstring = randomstack.Peek();
                Scriptbox.Text = scriptstack.Peek();
                //pictureBox1.Image = new Bitmap(bitmaphistory.Peek());
                Graphics.FromImage(drawingBitmap).Clear(BackColor);
                Graphics.FromImage(drawingBitmap).DrawImage(bitmaphistory.Peek(), Point.Empty);
                Drawbox.Image = drawingBitmap;
                Drawbox.Invalidate();
            }

            //Graphics.FromImage(drawingBitmap).Clear(BackColor);
            //Graphics.FromImage(drawingBitmap).DrawImage(onebackdrawmap,Point.Empty);
            //oldrandomstring = onebackoldran;
            //scriptthing.Text = onebackscript;
            //pictureBox1.Image = drawingBitmap;
            //Undoer.Hide();
        }

        private void SaveState()
        {
            Undoer.Show();
            bitmaphistory.Push(new Bitmap(Drawbox.Image));
            randomstack.Push(oldrandomstring);
            scriptstack.Push(Scriptbox.Text);
            //onebackdrawmap = new Bitmap(bitmapthing.Width, bitmapthing.Height);
            //Graphics.FromImage(onebackdrawmap).DrawImage(pictureBox1.Image, Point.Empty);
            //onebackoldran = oldrandomstring;
            //onebackscript = scriptthing.Text;
            //Undoer.Show();
        }
    }
}