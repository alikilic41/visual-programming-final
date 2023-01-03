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
    public partial class adminpaneli : Form
    {
        public adminpaneli()
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
        private MySqlConnection mysqlbaglan;

        private void button7_Click(object sender, EventArgs e)
        {
            admlb.Items.Clear();
            mysqlbaglan = new MySqlConnection("Server=127.0.0.1;Database=aleefastfood;Uid=root;Pwd=;");
            mysqlbaglan.Open();
            MySqlCommand command = new MySqlCommand("select *from kullanicilar", mysqlbaglan);
            MySqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                admlb.Items.Add(read[0] + "         " + read[1] + "         " + read[2] + "         " + read[3]);
            }
            mysqlbaglan.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            admlb.Items.Clear();
            mysqlbaglan = new MySqlConnection("Server=127.0.0.1;Database=aleefastfood;Uid=root;Pwd=;");
            mysqlbaglan.Open();
            MySqlCommand command = new MySqlCommand("select *from urunler", mysqlbaglan);
            MySqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                admlb.Items.Add(read[0] + "         " + read[1] + "         " + read[2] + "         " + read[3]);
            }
            mysqlbaglan.Close();
        }

        private void adminpaneli_Load(object sender, EventArgs e)
        {

        }
    }
}
