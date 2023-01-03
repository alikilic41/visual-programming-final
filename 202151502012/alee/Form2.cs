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
    public partial class Form2 : Form
    {
        Sepet sepet;

        public Form2()
        {
            InitializeComponent();

          
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 menu = new Form2();
            menu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 anasayfa = new Form1();
            anasayfa.ShowDialog();
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

        private void Form2_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Sepet spt = new Sepet();
            spt.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sepet = new Sepet();
            sepet.Owner = this;

            int toplam;
            toplam = int.Parse(yiyfyt.Text) + int.Parse(icefyt.Text);
            fyttplm.Text = toplam.ToString();  

            sepet.sptlb.Items.Add(menulb1.Text);
            sepet.sptlb.Items.Add(menulb2.Text);
            sepet.sptlb2.Items.Add(fyttplm.Text);
            sepet.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (menulb1.Text == "")
                yiyfyt.Text ="0";
            else if (menulb1.Text == "Hamburger")
                yiyfyt.Text ="45";
            else if (menulb1.Text == "Patso")
                yiyfyt.Text = "25";
            else if (menulb1.Text == "Tavuk Dürüm")
                yiyfyt.Text = "34";
            else if (menulb1.Text == "İskender")
                yiyfyt.Text = "55";
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (menulb2.Text == "")
                icefyt.Text = "0";
            else if (menulb2.Text == "Ayran(200ml)")
                icefyt.Text = "5";
            else if (menulb2.Text == "Pepsi(330ml)")
                icefyt.Text = "10";
            else if (menulb2.Text == "Fanta(330ml)")
                icefyt.Text = "10";
        }

        private void label8_Click(object sender, EventArgs e)
        {
        
        }

        private void yiyfyt_Click(object sender, EventArgs e)
        {
            

        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void yiyfyt_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void icefyt_TextChanged(object sender, EventArgs e)
        {
            fyttplm.Text = (int.Parse(icefyt.Text) + int.Parse(yiyfyt.Text)).ToString();
        }

        private void yiyfyt_TextChanged(object sender, EventArgs e)
        {
            icefyt_TextChanged(new object(), new EventArgs());
        }
    }
}
