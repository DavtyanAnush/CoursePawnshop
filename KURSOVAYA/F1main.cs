using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace KURSOVAYA
{
    public partial class F1main : Form
    {
        public F1main()
        {
            InitializeComponent();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F2DataClient F2 = new F2DataClient();
            F2.ShowDialog();
            F2.Owner = this;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            F6Tovar F6 = new F6Tovar();
            F6.ShowDialog();
            F6.Owner = this;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            F10AllTable F10 = new F10AllTable();
            F10.ShowDialog();
            F10.Owner = this;
        }

      
    }
}
