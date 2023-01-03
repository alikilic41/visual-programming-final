using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alee
{
    public partial class Form3 : Form
    {
        // private object webBrowser1;//
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 anasayfa = new Form1();
            anasayfa.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 menu = new Form2();
            menu.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 adres = new Form3();
            adres.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 kullanicibilgileri = new Form4();
            kullanicibilgileri.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 ayarlar = new Form5();
            ayarlar.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           
           
        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted_2(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        
        }

        private void button7_Click(object sender, EventArgs e)
        {
            webBrowser2.Navigate("https://goo.gl/maps/sKBmCcL4UReroYA2A");
        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form6 hakkimizda = new Form6();
            hakkimizda.Show();
            this.Hide();
        }
    }
}
