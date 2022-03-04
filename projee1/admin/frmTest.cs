using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projee1.admin
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void btnKare_Click(object sender, EventArgs e)
        {
            int sayi,sonuc;
            sayi = Convert.ToInt32(textBox1.Text);
            sonuc = sayi * sayi;
            label1.Text =sonuc.ToString();


        }

        private void btntekcift_Click(object sender, EventArgs e)
        {
            int sayi=Convert.ToInt32(textBox1.Text);
            if(sayi % 2 == 0)
            {
                label1.Text = "çift";
             }
            else
            {

                label1.Text = "tek";



            
            }
        }

        private void btnBasamak_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            int yuzler, onlar, birler,toplam;

            yuzler = sayi / 100;
            birler = sayi % 10;
            birler = (sayi / 10) % 10;
            toplam = birler + yuzler + onlar;
            label1.Text=toplam.ToString();




          sayi = Convert.ToInt32(textBox1.Text);
          int sonuc;
            sonuc = 2 ^ 24;

         


        }
    }
}
