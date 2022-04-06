using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       int[] yaslar  = new int[20];
 
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (int i in yaslar)
            {
                listBox1.Items.Add(i);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                yaslar[i] = rnd.Next(20, 65);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (int i in yaslar)
                if(i>20 && i<35)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (int i in yaslar)
                if(i>35 && i>50)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (int i in yaslar)
                if(i>50 && i<65)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double toplam = 0, ort;
            foreach (int i in yaslar)
            {
                toplam = toplam + i;
            }
            ort = toplam / 20;

            MessageBox.Show(ort.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int enb = yaslar[0];
            int enk = yaslar[0];

            for (int i = 1; i < yaslar.Length; i++)
            {
                if (enb < yaslar[i])
                    enb = yaslar[i];
                else
                    enk = yaslar[i];
            }
            MessageBox.Show(enb.ToString());
            MessageBox.Show(enk.ToString());
        }
    }
}
