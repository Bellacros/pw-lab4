using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Panel_Logowania
{
    public partial class Form1 : Form
    {


    public Form1()
        {
            InitializeComponent();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        public void button1_Click(object sender, EventArgs e)
        {

            if ((textBox1.Text == "login") && (textBox2.Text == "haslo") || (textBox1.Text == "admin") && (textBox2.Text == "haslo"))
            {
                this.Hide();
                Form2 menu = new Form2();
                menu.Show();

            }
            else
            {
                MessageBox.Show("Niepoprawne dane! Proszę spróbować ponownie");

            } 
        }
    }
}
