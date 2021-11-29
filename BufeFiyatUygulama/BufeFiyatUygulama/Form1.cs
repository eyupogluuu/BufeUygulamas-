using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BufeFiyatUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasa = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, su, cay, bilet, toplam;

            misir = Convert.ToInt32(textmisir.Text);
            su = Convert.ToInt32(textsu.Text);
            cay = Convert.ToInt32(textcay.Text);
            bilet = Convert.ToInt32(textbilet.Text);

            toplam = misir * 4 + su * 1 + cay * 2 + bilet * 8;
            labeltoplam.Text = toplam.ToString() + " TL";

            kasa = kasa + toplam;
            labelkasa.Text = kasa.ToString() + " TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textmisir.Text = " ";
            textcay.Text = " ";
            textsu.Text = " ";
            textbilet.Text = " ";
            labeltoplam.Text = "00 TL ";
            textmisir.Focus();
        }
    }
}
