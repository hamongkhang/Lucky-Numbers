using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerGUI
{
    public partial class Form1 : Form
    {
        Timer timer1;
        public Form1()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        Random rd = new Random(1);
        int i = 0;
        int j = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (j == 10)
            {
                timer1.Stop();
                String mess = "Chúc bạn phát tài !!!";
                    label1.Text = mess.ToString();
            }
            else { 
            i++;
            long so = rd.Next(100000, 999999);
            label1.Text = so.ToString();
                if (j == 1) { so= so / 10; label1.Text = so.ToString();
                    if (i == 100)
                    {
                        timer1.Stop();
                        i = 0;
                        text100.Text = so.ToString();
                        j++;
                    }
                }
                else if (j == 2)
                {
                    so = so / 10; label1.Text = so.ToString();
                    if (i == 100)
                    {
                        timer1.Stop();
                        i = 0;
                        text101.Text = so.ToString();
                        j++;
                    }
                }
                else if (j == 3)
                {
                    so = so / 10; label1.Text = so.ToString();
                    if (i == 100)
                    {
                        timer1.Stop();
                        i = 0;
                        text102.Text = so.ToString(); j++;
                    }
                }
                else if (j == 4)
                {
                    so = so / 10; label1.Text = so.ToString();
                    if (i == 100)
                    {
                        timer1.Stop();
                        i = 0;
                        text103.Text = so.ToString(); j++;
                    }
                }
               else  if (j == 5)
                {
                    so = so / 100; label1.Text = so.ToString();
                    if (i == 100)
                    {
                        timer1.Stop();
                        i = 0;
                        text104.Text = so.ToString(); j++;
                    }
                }
               else  if (j == 6)
                {
                    so = so / 100; label1.Text = so.ToString();
                    if (i == 100)
                    {
                        timer1.Stop();
                        i = 0;
                        text105.Text = so.ToString(); j++;
                    }
                }
               else  if (j == 7)
                {
                    so = so / 1000; label1.Text = so.ToString();
                    if (i == 100)
                    {
                        timer1.Stop();
                        i = 0;
                        text106.Text = so.ToString(); j++;
                    }
                }
               else  if (j == 8)
                {
                    so = so / 10000; label1.Text = so.ToString();
                    if (i == 100)
                    {
                        timer1.Stop();
                        i = 0;
                        text107.Text = so.ToString(); j++;
                    }
                }
                else if (j == 9)
                {
                    label1.Text = so.ToString();
                    if (i == 100)
                    {
                        timer1.Stop();
                        i = 0;
                        text108.Text = so.ToString(); j++;
                    }
                }
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}