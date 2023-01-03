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
    public partial class Girisekrani : Form
    {
        public Girisekrani()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (grsad.Text=="KullanıcıAdı")
            {
                grsad.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (grsad.Text == "")
            {
                grsad.Text = "KullanıcıAdı";
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (grsprl.Text =="Parola")
            {
                grsprl.Text = "";
                grsprl.PasswordChar = '*';
            }
        }
        char? none = null;
        private MySqlConnection mysqlbaglan;

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (grsprl.Text =="")
            {
                grsprl.Text = "Parola";
                grsprl.PasswordChar = Convert.ToChar(none);
            }
        }

        private void girisekrani_Load(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Kayitekrani kayit = new Kayitekrani();
            kayit.Show();
            this.Hide();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mysqlbaglan = new MySqlConnection("Server=127.0.0.1;Database=aleefastfood;Uid=root;Pwd=;");

            mysqlbaglan.Open();
            MySqlCommand command = new MySqlCommand("select * from kullanicilar where kulladi='" + grsad.Text + "'and kullpwd='" + grsprl.Text + "'", mysqlbaglan);
            MySqlDataReader dr = command.ExecuteReader();
            
            if (dr.Read())
            {
                MessageBox.Show("Giriş İşleminiz başarılı", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Girisekrani.ActiveForm.Visible = false;
                Form1 fr = new Form1();
                fr.Show();

            }
            else
            {
                MessageBox.Show("Giriş Başarısız.");
            }
            mysqlbaglan.Close();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 anasayfa = new Form1();
            anasayfa.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            admingiris admgrs = new admingiris();
            admgrs.Show();
            this.Hide();
        }
    }
}
