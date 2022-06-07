using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Block1_v11
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Pen pen;
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bitmap);
            pen = new Pen(Color.Black, 2);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e) 
        {
            pictureBox1.Image = bitmap;
            g.Clear(Color.White);
            Rectangle circle = new Rectangle(20, 20, 100, 100);
            int pie = 270;
            g.DrawPie(pen, circle, 0, pie);

            Rectangle ellipse = new Rectangle(20, 150, 125, 75);
            g.FillEllipse(new SolidBrush(Color.Blue), ellipse);

            Point[] frontCube = { new Point(400, 200), new Point(500, 200), new Point(500, 300), new Point(400, 300), new Point(400, 200) };
            Point[] topCube = { new Point(400, 200), new Point(450, 150), new Point(550, 150), new Point(500, 200), new Point(400, 200) };
            Point[] sideCube = { new Point(500, 200), new Point(550, 150), new Point(550, 250), new Point(500, 300), new Point(500, 200) };
            Point[] lowCube = { new Point(400, 300), new Point(450, 250), new Point(550, 250), new Point(500, 300), new Point(400, 300) };
            Point[] backCube = { new Point(450, 150), new Point(550, 150), new Point(550, 250), new Point(450, 250), new Point(450, 150) };
            g.DrawPolygon(pen, frontCube);
            g.DrawPolygon(pen, topCube);
            g.DrawPolygon(pen, sideCube);
            g.DrawPolygon(pen, lowCube);
            g.DrawPolygon(pen, backCube);

            Point[] heptagon = new Point[] {new Point(200,20), new Point(325, 20), new Point(350, 75), new Point(350, 150), new Point(295, 175), new Point(245, 160), new Point(200, 80), new Point(200, 20), };
            g.FillPolygon(new SolidBrush(Color.Red), heptagon);
        }
    }
}
