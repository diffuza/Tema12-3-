using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema12_3_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Graphics g;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
                    

            Brush blueBrush = new SolidBrush(Color.Blue);

            Color cl = Color.FromArgb(255, 255, 255);
            g.Clear(cl);
            Pen myPen = new Pen(Color.Black, 1);
            // Create points that define polygon.
            Point points1 = new Point(10, 10);
            Point points2 = new Point(15, 30);
            Point points3 = new Point(30, 50);
            Point points4 = new Point(40, 30);
            Point points5 = new Point(60, 10);
            Point points6 = new Point(80, 30);
            Point points7 = new Point(100, 100);
            Point[] curvePoints = {
                points1, points2 , points3 , points4 ,  points5 , points6, points7 ,
            };


            g.DrawBeziers(myPen, curvePoints);
            g.DrawLines(myPen, curvePoints);
            g.DrawCurve(myPen, curvePoints, 0);
            g.DrawCurve(myPen, curvePoints, 1);
            g.DrawCurve(myPen, curvePoints, 3);











        }
    }
}
