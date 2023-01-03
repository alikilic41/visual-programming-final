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
    public partial class Kayitekrani : Form
    {
        public MySqlConnection mysqlbaglan;

        public Kayitekrani()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (kytad.Text == "KullanıcıAdı")
            {
                kytad.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (kytad.Text == "")
            {
                kytad.Text = "KullanıcıAdı";
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (kytprl2.Text == "ParolaTekrarı")
            {
                kytprl2.Text = "";
                kytprl2.PasswordChar = '*';
            }
        }
        char? none = null;


        private void kayitekrani_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mysqlbaglan = new MySqlConnection("Server=127.0.0.1;Database=aleefastfood;Uid=root;Pwd=;");

            if (kytprl.Text == kytprl2.Text)
            {
                MySqlCommand command2 = new MySqlCommand("insert into kullanicilar(kulladi, kullpwd ) values (@kulladi, @kullpwd)", mysqlbaglan);
                command2.Parameters.AddWithValue("@kulladi", kytad.Text);
                command2.Parameters.AddWithValue("@kullpwd", kytprl.Text);
                mysqlbaglan.Open();
                command2.ExecuteNonQuery();
                mysqlbaglan.Close();
                MessageBox.Show("Kayıt İşleminiz Gerçekleşti.","", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Şifreler Eşleşmiyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Kayitekrani.ActiveForm.Visible = false;
            Form1 fr = new Form1();
            fr.Show();

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (kytprl.Text == "")
            {
                kytprl.Text = "Parola";
                kytprl.PasswordChar = Convert.ToChar(none);
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (kytprl.Text == "Parola")
            {
                kytprl.Text = "";
                kytprl.PasswordChar = '*';
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (kytprl2.Text == "")
            {
                kytprl2.Text = "ParolaTekrarı";
                kytprl2.PasswordChar = Convert.ToChar(none);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 anasayfa = new Form1();
            anasayfa.Show();
            this.Hide();
        }
    }
}
