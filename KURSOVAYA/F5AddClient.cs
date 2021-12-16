using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KURSOVAYA
{
    public partial class F5AddClient : Form
    {
        public F5AddClient()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox5.Text == "")
            {
                
                    DialogResult dr = MessageBox.Show("Не все данные введены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                

            }
            else
            {
              Close();

            }


        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char n = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (n != 8) && (n != 44) && (n != 45))
                e.Handled = true;

        }
    }
}
