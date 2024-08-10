using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketSalesProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int seans1 = 0;
        int seans1ucret = 0;
        int seans2 = 0;
        int seans2ucret = 0;
        int seans3 = 0;
        int seans3ucret = 0;
        int misir = 0;
        int misirfiyat = 0;
        int kola = 0;
        int kolafiyat = 0;
        int su = 0;
        int sufiyat = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            seans1++;
            seans1ucret = seans1ucret + 8;
            textBox1.Text = seans1.ToString();
            textBox2.Text = seans1ucret.ToString();
            if (seans1==10)
            {
                button1.Enabled = false;
            }
            if (seans1 >= 0)
            {
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            seans1--;
            seans1ucret = seans1ucret - 8;
            textBox1.Text = seans1.ToString();
            textBox2.Text = seans1ucret.ToString();
            if (seans1 == 0) 
            {
                button2.Enabled = false;
            }
            if (seans1 <= 10)
            {
                button1.Enabled = true;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            seans2++;
            seans2ucret = seans2ucret + 8;
            textBox3.Text = seans2.ToString();
            textBox4.Text = seans2ucret.ToString();
            if (seans2 == 10)
            {
                button3.Enabled = false;
            }
            if (seans2 >= 0)
            {
                button4.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            seans2--;
            seans2ucret = seans2ucret - 8;
            textBox3.Text = seans2.ToString();
            textBox4.Text = seans2ucret.ToString();
            if (seans2 == 0)
            {
                button4.Enabled = false;
            }
            if (seans2 <= 10)
            {
                button3.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            seans3++;
            seans3ucret = seans3ucret + 8;
            textBox5.Text = seans3.ToString();
            textBox6.Text = seans3ucret.ToString();
            if (seans3 == 10)
            {
                button5.Enabled = false;
            }
            if (seans3 >= 0)
            {
                button6.Enabled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            seans3--;
            seans3ucret = seans3ucret - 8;
            textBox5.Text = seans3.ToString();
            textBox6.Text = seans3ucret.ToString();
            if (seans3 == 0)
            {
                button6.Enabled = false;
            }
            if (seans3 <= 10)
            {
                button5.Enabled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            misir++;
            misirfiyat = misirfiyat + 3;
            textBox7.Text = misir.ToString();
            textBox8.Text= misirfiyat.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            misir--;
            misirfiyat=misirfiyat - 3;
            textBox7.Text= misir.ToString();
            textBox8.Text= misirfiyat.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            kola++;
            kolafiyat = kolafiyat + 5;
            textBox9.Text = kola.ToString();
            textBox10.Text = kolafiyat.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            kola--;
            kolafiyat = kolafiyat - 5;
            textBox9.Text = kola.ToString();
            textBox10.Text = kolafiyat.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            su++;
            sufiyat = sufiyat + 2;
            textBox11.Text = su.ToString();
            textBox12.Text = sufiyat.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            su--;
            sufiyat = sufiyat - 2;
            textBox11.Text = su.ToString();
            textBox12.Text = sufiyat.ToString();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            int toplamizleyici,toplamucret;
            toplamizleyici = seans1 + seans2 + seans3;
            label11.Text= toplamizleyici.ToString();
            toplamucret=seans1ucret+ seans2ucret+seans3ucret;
            label12.Text=toplamucret.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int toplamsatilan, toplamfiyat;
            toplamsatilan = kola + misir + su;
            label15.Text=toplamsatilan.ToString();
            toplamfiyat = misirfiyat + kolafiyat + sufiyat;
            label16.Text=toplamfiyat.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
        }
    }
}
