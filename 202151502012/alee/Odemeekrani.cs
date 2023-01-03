using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace alee
{
    public partial class Odemeekrani : Form
    {
        public Odemeekrani()
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

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
        private MySqlConnection mysqlbaglan;
        private void odmbtn_Click(object sender, EventArgs e)
        {
            mysqlbaglan = new MySqlConnection("Server=127.0.0.1;Database=aleefastfood;Uid=root;Pwd=;");
            mysqlbaglan.Open();
          //  MySqlCommand command = new MySqlCommand("select * from urunler where urunad='" + "'and urunadet='" + "'", mysqlbaglan);
           // MySqlDataReader read = command.ExecuteReader();
            mysqlbaglan.Close();

            if (textBox1.Text == "")
            {
                MessageBox.Show("Ad Soyad boş bırakılamaz.");
            }

            if (kartnotxt.Text == "")
            {
                MessageBox.Show("Kart no boş bırakılamaz.");
            }

            if (comboBox1.Text == "")
            {
                MessageBox.Show("Ay bilgisi boş bırakılamaz.");
            }

            if (comboBox2.Text == "")
            {
                MessageBox.Show("Yıl bilgisi boş bırakılamaz.");
            }

            if (maskedTextBox2.Text == "")
            {
                MessageBox.Show("CVV boş bırakılamaz.");
            }
          
                MessageBox.Show("Siparişiniz Alındı.");         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Odemeekrani_Load(object sender, EventArgs e)
        {

        }
    }
}
