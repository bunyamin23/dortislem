﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text.ToLower();
                double sonuc = 0;
                string[] parcalar;
                parcalar = textBox1.Text.Split(' ');

                string a = parcalar[1].ToLower();
                if (a == "topla")
                {
                    string[] p1;
                    p1 = textBox1.Text.Split(' ');
                    string x = p1[0];

                    string[] p2;
                    p2 = textBox1.Text.Split(' ');
                    string y = p2[2];

                    sonuc = Convert.ToDouble(x) + Convert.ToDouble(y);
                    listBox1.Items.Add(x + "+" + y + "=" + sonuc.ToString());

                }
                else if (a == "eksi")
                {
                    string[] p1;
                    p1 = textBox1.Text.Split(' ');
                    string x = p1[0];

                    string[] p2;
                    p2 = textBox1.Text.Split(' ');
                    string y = p2[2];

                    sonuc = Convert.ToDouble(x) - Convert.ToDouble(y);
                    listBox1.Items.Add(x + "-" + y + "=" + sonuc.ToString());

                }
                else if (a == "çarpı")
                {
                    string[] p1;
                    p1 = textBox1.Text.Split(' ');
                    string x = p1[0];

                    string[] p2;
                    p2 = textBox1.Text.Split(' ');
                    string y = p2[2];

                    sonuc = Convert.ToDouble(x) * Convert.ToDouble(y);
                    listBox1.Items.Add(x + "x" + y + "=" + sonuc.ToString());

                }
                else if (a == "bölü")
                {
                    string[] p1;
                    p1 = textBox1.Text.Split(' ');
                    string x = p1[0];

                    string[] p2;
                    p2 = textBox1.Text.Split(' ');
                    string y = p2[2];

                    sonuc = Convert.ToDouble(x) / Convert.ToDouble(y);

                    listBox1.Items.Add(x + "/" + y + "=" + sonuc.ToString());
                }
                else
                { label1.Text = "Hatalı işlem yaptınız"; }

                label1.Text = sonuc.ToString();
                textBox1.Clear();
            }
            catch
            {
                label1.Text = "Hatalı bir işlem yaptınız.";
            }
            

        }


        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "";
            listBox1.Items.Clear();
        }

        
    }
}
