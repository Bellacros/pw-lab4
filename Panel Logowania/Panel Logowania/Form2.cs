using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panel_Logowania
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private new void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 menu = new Form1();
            menu.Show();
        }

        public void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
