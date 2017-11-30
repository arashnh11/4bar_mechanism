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

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.start();
            timer1.interval = 1000;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
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
            double B = Convert.ToDouble(textBox5.Text);
            double u = Convert.ToDouble(textBox5.Text);
            double t = Convert.ToDouble(textBox7.Text);
            double f1 = Math.Max(a, b);
            double f2 = Math.Max(f1, c);
            double f3 = Math.Max(f2, d);
            double h1 = Math.Min(a, b);
            double h2 = Math.Min(h1, c);
            double h3 = Math.Min(h2, d);
            double k1 = a + b + c + d - f3 - h3;
            double k2 = f3 + h3;
            t = t / 100;
            if (k2 <= k1)
            {
                textBox6.Text = "At least one bar can rotate 360 degrees in Z plane.";
            }
            else
            {
                textBox6.Text = "There is no bar that can rotate 360 degrees in Z plane.";
            }
            if (checkBox3.Checked == true)
            {
                if (checkBox2.Checked == true)
                {
                    
                        B = B * Math.PI / 180;
                        double s = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) - 2 * a * b * Math.Cos(B));
                        double m = Math.Asin(b / s * Math.Sin(B));
                        double n = Math.Acos((Math.Pow(c, 2) + Math.Pow(s, 2) - Math.Pow(d, 2)) / (2 * c * s));
                        double p = Math.Asin(c / d * Math.Sin(n));
                        double C = n - m;
                        double D = m + p;
                        if (B == C)
                        {
                            break;
                        }
                        a = a * 20; b = b * 20; c = c * 20; d = d * 20;
                        Graphics g = panel1.CreateGraphics();
                        PointF p1 = new PointF(Convert.ToSingle(200), Convert.ToSingle(300));
                        PointF p4 = new PointF(Convert.ToSingle(200 + a), Convert.ToSingle(300));
                        PointF p2 = new PointF(Convert.ToSingle(200 + b * Math.Cos(B)), Convert.ToSingle(300 - b * Math.Sin(B)));
                        PointF p3 = new PointF(Convert.ToSingle(200 + a - d * Math.Cos(D)), Convert.ToSingle(300 - d * Math.Sin(D)));
                        g.Clear(Color.SkyBlue);
                        g.DrawLine(new Pen(Color.Blue, 3), p1, p4);
                        g.DrawLine(new Pen(Color.Blue, 3), p4, p3);
                        g.DrawLine(new Pen(Color.Blue, 3), p1, p2);
                        g.DrawLine(new Pen(Color.Blue, 3), p2, p3);
                        g.DrawEllipse(new Pen(Color.Black, 3), 200 - 2, 300 - 1, 5, 5);
                        g.DrawEllipse(new Pen(Color.Black, 3), Convert.ToSingle(200 + a - 2), Convert.ToSingle(300 - 1), 5, 5);
                        g.DrawEllipse(new Pen(Color.Black, 3), Convert.ToSingle(200 + b * Math.Cos(B) - 2), Convert.ToSingle(300 - b * Math.Sin(B) - 1), 5, 5);
                        g.DrawEllipse(new Pen(Color.Black, 3), Convert.ToSingle(200 + a - d * Math.Cos(D) - 2), Convert.ToSingle(300 - d * Math.Sin(D) - 1), 5, 5);
                        B = B * 180 / Math.PI;
                        a = a / 20; b = b / 20; c = c / 20; d = d / 20;
                        B = B + t;
                    
                }
                else if (checkBox1.Checked == true)
                {
                    {
                        B = B * Math.PI / 180;
                        double s = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) - 2 * a * b * Math.Cos(B));
                        double m = Math.Asin(b / s * Math.Sin(B));
                        double n = Math.Acos((Math.Pow(c, 2) + Math.Pow(s, 2) - Math.Pow(d, 2)) / (2 * c * s));
                        double p = Math.Asin(c / d * Math.Sin(n));
                        double C = n - m;
                        double D = m + p;
                        if (C == D)
                        {
                            break;
                        }
                        a = a * 20; b = b * 20; c = c * 20; d = d * 20;
                        Graphics g = panel1.CreateGraphics();
                        PointF p1 = new PointF(Convert.ToSingle(200), Convert.ToSingle(300));
                        PointF p4 = new PointF(Convert.ToSingle(200 + a), Convert.ToSingle(300));
                        PointF p2 = new PointF(Convert.ToSingle(200 + b * Math.Cos(B)), Convert.ToSingle(300 - b * Math.Sin(B)));
                        PointF p3 = new PointF(Convert.ToSingle(200 + a - d * Math.Cos(D)), Convert.ToSingle(300 - d * Math.Sin(D)));
                        g.Clear(Color.SkyBlue);
                        g.DrawLine(new Pen(Color.Blue, 3), p1, p4);
                        g.DrawLine(new Pen(Color.Blue, 3), p4, p3);
                        g.DrawLine(new Pen(Color.Blue, 3), p1, p2);
                        g.DrawLine(new Pen(Color.Blue, 3), p2, p3);
                        g.DrawEllipse(new Pen(Color.Black, 3), 200 - 2, 300 - 1, 5, 5);
                        g.DrawEllipse(new Pen(Color.Black, 3), Convert.ToSingle(200 + a - 2), Convert.ToSingle(300 - 1), 5, 5);
                        g.DrawEllipse(new Pen(Color.Black, 3), Convert.ToSingle(200 + b * Math.Cos(B) - 2), Convert.ToSingle(300 - b * Math.Sin(B) - 1), 5, 5);
                        g.DrawEllipse(new Pen(Color.Black, 3), Convert.ToSingle(200 + a - d * Math.Cos(D) - 2), Convert.ToSingle(300 - d * Math.Sin(D) - 1), 5, 5);
                        B = B * 180 / Math.PI;
                        a = a / 20; b = b / 20; c = c / 20; d = d / 20;
                        B = B - t;
                    }
                }
            }
            else if (checkBox4.Checked == true)
            {
                if (checkBox2.Checked == true)
                {
                    
                        B = B * Math.PI / 180;
                        double s = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) - 2 * a * b * Math.Cos(B));
                        double m = Math.Asin(b / s * Math.Sin(B));
                        double n = Math.Acos((Math.Pow(c, 2) + Math.Pow(s, 2) - Math.Pow(d, 2)) / (2 * c * s));
                        double p = Math.Asin(c / d * Math.Sin(n));
                        double C = n - m;
                        double D = m + p;
                        if (B == C)
                        {
                            break;
                        }
                        a = a * 20; b = b * 20; c = c * 20; d = d * 20;
                        Graphics w = panel2.CreateGraphics();
                        PointF p1 = new PointF(Convert.ToSingle(200), Convert.ToSingle(300));
                        PointF p4 = new PointF(Convert.ToSingle(200 + a), Convert.ToSingle(300));
                        PointF p2 = new PointF(Convert.ToSingle(200 + b * Math.Cos(B)), Convert.ToSingle(300 - b * Math.Sin(B)));
                        PointF p3 = new PointF(Convert.ToSingle(200 + a - d * Math.Cos(D)), Convert.ToSingle(300 - d * Math.Sin(D)));
                        w.DrawLine(new Pen(Color.Blue, 3), p1, p4);
                        w.DrawLine(new Pen(Color.Blue, 3), p4, p3);
                        w.DrawLine(new Pen(Color.Blue, 3), p1, p2);
                        w.DrawLine(new Pen(Color.Blue, 3), p2, p3);
                        w.DrawEllipse(new Pen(Color.Black, 3), 200 - 2, 300 - 1, 5, 5);
                        w.DrawEllipse(new Pen(Color.Black, 3), Convert.ToSingle(200 + a - 2), Convert.ToSingle(300 - 1), 5, 5);
                        w.DrawEllipse(new Pen(Color.Black, 3), Convert.ToSingle(200 + b * Math.Cos(B) - 2), Convert.ToSingle(300 - b * Math.Sin(B) - 1), 5, 5);
                        w.DrawEllipse(new Pen(Color.Black, 3), Convert.ToSingle(200 + a - d * Math.Cos(D) - 2), Convert.ToSingle(300 - d * Math.Sin(D) - 1), 5, 5);
                        B = B * 180 / Math.PI;
                        a = a / 20; b = b / 20; c = c / 20; d = d / 20;
                        B = B + t;
                }
                else if (checkBox1.Checked == true)
                {
                    
                    
                        B = B * Math.PI / 180;
                        double s = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) - 2 * a * b * Math.Cos(B));
                        double m = Math.Asin(b / s * Math.Sin(B));
                        double n = Math.Acos((Math.Pow(c, 2) + Math.Pow(s, 2) - Math.Pow(d, 2)) / (2 * c * s));
                        double p = Math.Asin(c / d * Math.Sin(n));
                        double C = n - m;
                        double D = m + p;
                        if (C == D)
                        {
                            break;
                        }
                        a = a * 20; b = b * 20; c = c * 20; d = d * 20;
                        Graphics w = panel2.CreateGraphics();
                        PointF p1 = new PointF(Convert.ToSingle(200), Convert.ToSingle(300));
                        PointF p4 = new PointF(Convert.ToSingle(200 + a), Convert.ToSingle(300));
                        PointF p2 = new PointF(Convert.ToSingle(200 + b * Math.Cos(B)), Convert.ToSingle(300 - b * Math.Sin(B)));
                        PointF p3 = new PointF(Convert.ToSingle(200 + a - d * Math.Cos(D)), Convert.ToSingle(300 - d * Math.Sin(D)));
                        w.DrawLine(new Pen(Color.Blue, 3), p1, p4);
                        w.DrawLine(new Pen(Color.Blue, 3), p4, p3);
                        w.DrawLine(new Pen(Color.Blue, 3), p1, p2);
                        w.DrawLine(new Pen(Color.Blue, 3), p2, p3);
                        w.DrawEllipse(new Pen(Color.Black, 3), 200 - 2, 300 - 1, 5, 5);
                        w.DrawEllipse(new Pen(Color.Black, 3), Convert.ToSingle(200 + a - 2), Convert.ToSingle(300 - 1), 5, 5);
                        w.DrawEllipse(new Pen(Color.Black, 3), Convert.ToSingle(200 + b * Math.Cos(B) - 2), Convert.ToSingle(300 - b * Math.Sin(B) - 1), 5, 5);
                        w.DrawEllipse(new Pen(Color.Black, 3), Convert.ToSingle(200 + a - d * Math.Cos(D) - 2), Convert.ToSingle(300 - d * Math.Sin(D) - 1), 5, 5);
                        B = B * 180 / Math.PI;
                        a = a / 20; b = b / 20; c = c / 20; d = d / 20;
                        B = B - t;
                }
            }
            B++;
        }
    }
}