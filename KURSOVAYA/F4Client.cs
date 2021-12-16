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
    public partial class F4Client : Form
    {
        public F4Client(int nstr1)
        {
            InitializeComponent();
            F2DataClient main = new F2DataClient();
            
            label2.Text += " " + main.dataGridView1.Rows[nstr1].Cells[1].Value.ToString()
             + " " + main.dataGridView1.Rows[nstr1].Cells[2].Value.ToString()
             + " " + main.dataGridView1.Rows[nstr1].Cells[3].Value.ToString();
            label3.Text += " " + main.dataGridView1.Rows[nstr1].Cells[4].Value.ToString();
            label4.Text += " " + main.dataGridView1.Rows[nstr1].Cells[5].Value.ToString();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void F4Client_Load(object sender, EventArgs e, int nstr1)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_курсваяDataSet.Категории_товаров". При необходимости она может быть перемещена или удалена.
            this.категории_товаровTableAdapter.Fill(this.бД_курсваяDataSet.Категории_товаров);


        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            F7AddProduct F7 = new F7AddProduct();
            F7.ShowDialog();
            F7.Owner = this;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            F9DeleteT F9 = new F9DeleteT();
            F9.ShowDialog();
            F9.Owner = this;
                    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            F10AllTable F10 = new F10AllTable();
            F10.ShowDialog();
            F10.Owner = this;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            F6Tovar F6 = new F6Tovar();
            F6.ShowDialog();
            F6.Owner = this;
        }
    }
}
