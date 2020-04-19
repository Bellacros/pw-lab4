using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kostka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void key_r(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'r') losowanie();
        }
        private void label1_Click(object sender, EventArgs e)
        {
          
        }
        
        private void doSchowka ( object sender, MouseEventArgs e)
        {
            Clipboard.SetText(label1.Text);
            label2.Text = Clipboard.GetText();
        }
        private void losowanie()
        {
            var cube = "123456";
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                Label label = new Label();
                label1.Text = cube[random.Next(0, cube.Length)].ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ;
            MessageBox.Show(Clipboard.GetText());
        }
    }
}

