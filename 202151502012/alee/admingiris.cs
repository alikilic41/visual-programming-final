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
    public partial class admingiris : Form
    {
        public admingiris()
        {
            InitializeComponent();
        }
        private MySqlConnection mysqlbaglan;
        private void button1_Click(object sender, EventArgs e)
        {
            mysqlbaglan = new MySqlConnection("Server=127.0.0.1;Database=aleefastfood;Uid=root;Pwd=;");

            mysqlbaglan.Open();
            MySqlCommand command = new MySqlCommand("select * from admin where adminadi='" + admgrsad.Text + "'and adminpwd='" + admgrsprl.Text + "'", mysqlbaglan);
            MySqlDataReader dr = command.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Giriş İşleminiz başarılı", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Girisekrani.ActiveForm.Visible = false;
                adminpaneli admpnl = new adminpaneli();
                admpnl.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Giriş Başarısız.");
            }
            mysqlbaglan.Close();


        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 anasayfa = new Form1();
            anasayfa.Show();
            this.Hide();
        }

        private void admgrsprl_Enter(object sender, EventArgs e)
        {
            if (admgrsprl.Text == "Parola")
            {
                admgrsprl.Text = "";
                admgrsprl.PasswordChar = '*';
            }
        }
        char? none = null;
        private void admgrsprl_Leave(object sender, EventArgs e)
        {
            if (admgrsprl.Text == "")
            {
                admgrsprl.Text = "Parola";
                admgrsprl.PasswordChar = Convert.ToChar(none);
            }
        }

        private void admgrsad_TextChanged(object sender, EventArgs e)
        {

        }

        private void admgrsad_Enter(object sender, EventArgs e)
        {
            if (admgrsad.Text == "KullanıcıAdı")
            {
                admgrsad.Text = "";
            }
        }

        private void admgrsad_Leave(object sender, EventArgs e)
        {
            if (admgrsad.Text == "")
            {
                admgrsad.Text = "KullanıcıAdı";
            }
        }
    }
}
