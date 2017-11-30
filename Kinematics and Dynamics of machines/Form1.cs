using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double B = 50;
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval=200;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void label8_Click(object sender, EventArgs e)
        {
        }
        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
            Graphics g = panel1.CreateGraphics();
            Graphics w = panel2.CreateGraphics();
            g.Clear(Color.SkyBlue);
            w.Clear(Color.SkyBlue);
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void label8_Click_1(object sender, EventArgs e)
        {
        }
        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Graphics g = panel1.CreateGraphics();
            Graphics w = panel2.CreateGraphics();
            g.Clear(Color.SkyBlue);
            w.Clear(Color.SkyBlue);
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);
            double d = Convert.ToDouble(textBox4.Text);
            double f1 = Math.Max(a, b);
            double f2 = Math.Max(f1, c);
            double f3 = Math.Max(f2, d);
            double h1 = Math.Min(a, b);
            double h2 = Math.Min(h1, c);
            double h3 = Math.Min(h2, d);
            double k1 = a + b + c + d - f3 - h3;
            double k2 = f3 + h3;
            if (k2 < k1)
            {
                textBox6.Text = "At least one bar can rotate 360 degrees in Z plane.";
            }
            else
            {
                textBox6.Text = "There is no bar that can rotate 360 degrees in Z plane.";
            }
            B = B * Math.PI / 180;
            double s0 = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) - 2 * a * b * Math.Cos(B-0.001));
            double s = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) - 2 * a * b * Math.Cos(B));
            double m = Math.Asin(b / s * Math.Sin(B));
            double n0 = Math.Abs(Math.Acos((Math.Pow(c, 2) + Math.Pow(s0, 2) - Math.Pow(d, 2)) / (2 * c * s0)));
            double n = Math.Abs(Math.Acos((Math.Pow(c, 2) + Math.Pow(s, 2) - Math.Pow(d, 2)) / (2 * c * s)));
            double p = Math.Asin(c / d * Math.Sin(n));
            double C = n - m;
            double D = m + p;
            double xx = 200 + a * 15 - d * 15 * Math.Cos(D);
            double yx = 200 + b * 15 * Math.Cos(B) + c * 15 * Math.Cos(C);
            double xy = 200 - d * Math.Sin(D);
            double yy = 200 - b * 15 * Math.Sin(B) - c * 15 * Math.Sin(C);
            if (checkBox1.Checked == true)
            {
                a = a * 15; b = b * 15; c = c * 15; d = d * 15;
                Graphics g = panel1.CreateGraphics();
                Graphics w = panel2.CreateGraphics();
                PointF p1 = new PointF(Convert.ToSingle(200), Convert.ToSingle(200));
                PointF p4 = new PointF(Convert.ToSingle(200 + a), Convert.ToSingle(200));
                PointF p2 = new PointF(Convert.ToSingle(200 + b * Math.Cos(B)), Convert.ToSingle(200 - b * Math.Sin(B)));
                PointF p3 = new PointF(Convert.ToSingle(yx), Convert.ToSingle(yy));
                g.Clear(Color.SkyBlue);
                g.DrawLine(new Pen(Color.Blue, 3), p1, p4);
                g.DrawLine(new Pen(Color.Blue, 3), p4, p3);
                g.DrawLine(new Pen(Color.Blue, 3), p1, p2);
                g.DrawLine(new Pen(Color.Blue, 3), p2, p3);
                g.DrawEllipse(new Pen(Color.Black, 3), 200 - 2, 200 - 1, 5, 5);
                g.DrawEllipse(new Pen(Color.Black, 3), Convert.ToSingle(200 + a - 2), Convert.ToSingle(200 - 1), 5, 5);
                g.DrawEllipse(new Pen(Color.Black, 3), Convert.ToSingle(200 + b * Math.Cos(B) - 2), Convert.ToSingle(200 - b * Math.Sin(B) - 1), 5, 5);
                g.DrawEllipse(new Pen(Color.Black, 3), Convert.ToSingle(yx - 2), Convert.ToSingle(yy - 1), 5, 5);
                w.DrawLine(new Pen(Color.Blue, 3), p1, p4);
                w.DrawLine(new Pen(Color.Blue, 3), p4, p3);
                w.DrawLine(new Pen(Color.Blue, 3), p1, p2);
                w.DrawLine(new Pen(Color.Blue, 3), p2, p3);
                w.DrawEllipse(new Pen(Color.Black, 3), 200 - 2, 200 - 1, 5, 5);
                w.DrawEllipse(new Pen(Color.Black, 3), Convert.ToSingle(200 + a - 2), Convert.ToSingle(200 - 1), 5, 5);
                w.DrawEllipse(new Pen(Color.Black, 3), Convert.ToSingle(200 + b * Math.Cos(B) - 2), Convert.ToSingle(200 - b * Math.Sin(B) - 1), 5, 5);
                w.DrawEllipse(new Pen(Color.Black, 3), Convert.ToSingle(yx - 2), Convert.ToSingle(yy - 1), 5, 5);
                B = B * 180 / Math.PI;
                a = a / 15; b = b / 15; c = c / 15; d = d / 15;
                B--;
            }
            else if (checkBox2.Checked == true)
            {
                a = a * 15; b = b * 15; c = c * 15; d = d * 15;
                Graphics g = panel1.CreateGraphics();
                Graphics w = panel2.CreateGraphics();
                PointF p1 = new PointF(Convert.ToSingle(200), Convert.ToSingle(200));
                PointF p4 = new PointF(Convert.ToSingle(200 + a), Convert.ToSingle(200));
                PointF p2 = new PointF(Convert.ToSingle(200 + b * Math.Cos(B)), Convert.ToSingle(200 - b * Math.Sin(B)));
                PointF p3 = new PointF(Convert.ToSingle(yx), Convert.ToSingle(yy));
                g.Clear(Color.SkyBlue);
                g.DrawLine(new Pen(Color.Blue, 3), p1, p4);
                g.DrawLine(new Pen(Color.Blue, 3), p4, p3);
                g.DrawLine(new Pen(Color.Blue, 3), p1, p2);
                g.DrawLine(new Pen(Color.Blue, 3), p2, p3);
                g.DrawEllipse(new Pen(Color.Black, 3), 200 - 2, 200 - 1, 5, 5);
                g.DrawEllipse(new Pen(Color.Black, 3), Convert.ToSingle(200 + a - 2), Convert.ToSingle(200 - 1), 5, 5);
                g.DrawEllipse(new Pen(Color.Black, 3), Convert.ToSingle(200 + b * Math.Cos(B) - 2), Convert.ToSingle(200 - b * Math.Sin(B) - 1), 5, 5);
                g.DrawEllipse(new Pen(Color.Black, 3), Convert.ToSingle(yx), Convert.ToSingle(yy - 1), 5, 5);
                w.DrawLine(new Pen(Color.Blue, 3), p1, p4);
                w.DrawLine(new Pen(Color.Blue, 3), p4, p3);
                w.DrawLine(new Pen(Color.Blue, 3), p1, p2);
                w.DrawLine(new Pen(Color.Blue, 3), p2, p3);
                w.DrawEllipse(new Pen(Color.Black, 3), 200 - 2, 200 - 1, 5, 5);
                w.DrawEllipse(new Pen(Color.Black, 3), Convert.ToSingle(200 + a - 2), Convert.ToSingle(200 - 1), 5, 5);
                w.DrawEllipse(new Pen(Color.Black, 3), Convert.ToSingle(200 + b * Math.Cos(B) - 2), Convert.ToSingle(200 - b * Math.Sin(B) - 1), 5, 5);
                w.DrawEllipse(new Pen(Color.Black, 3), Convert.ToSingle(yx - 2), Convert.ToSingle(yy - 1), 5, 5);
                B = B * 180 / Math.PI;
                a = a / 15; b = b / 15; c = c / 15; d = d / 15;
                B++;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            B = 50;
            timer1.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                B=B+15;
            }
            else if (checkBox2.Checked == true)
            {
                B=B-15;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (timer1.Interval > 31)
            {
                timer1.Interval = timer1.Interval - 30;
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (timer1.Interval <1000)
            {
                timer1.Interval = timer1.Interval + 30;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                B = B - 15;
            }
            else if (checkBox2.Checked == true)
            {
                B = B + 15;
            }
        }
    }
}