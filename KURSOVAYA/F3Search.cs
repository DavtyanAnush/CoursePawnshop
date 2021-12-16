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
    public partial class F3Search : Form
    {

        

        public F3Search()
        {
            
            InitializeComponent();
            textBox1.Text = "";
            textBox2.Text = "";
            
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F2DataClient main = this.Owner as F2DataClient;
            if (textBox2.Text != "" && textBox1.Text != "")
            {

            
            int nstr1 = -1, nstr4 = -1;
            if(main != null)
            {


                for(int i = 0; i < main.dataGridView1.RowCount; i++)
                {
                    main.dataGridView1.Rows[i].Selected = false;
                    
                        if (main.dataGridView1.Rows[i].Cells[1].Value !=null)
                            if(main.dataGridView1.Rows[i].Cells[1].Value.ToString().Contains(textBox1.Text))
                            {
                                
                                nstr1 = i;
                                 if (main.dataGridView1.Rows[i].Cells[5].Value != null)

                                    if (main.dataGridView1.Rows[i].Cells[5].Value.ToString().Contains(textBox2.Text))
                                    {
                                        main.dataGridView1.Rows[i].Selected = true;
                                        nstr4 = i;
                                        break;
                                    }
                            }
                       
                }
                
            }
             
            

            if (nstr1 ==nstr4 && nstr1 != -1)
            {
                F4Client F4 = new F4Client(nstr1);
                F4.ShowDialog();
                    
                Close();
            }
            else
            {
                DialogResult dr = MessageBox.Show("Клиент не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            else
            {
                DialogResult dr = MessageBox.Show("Не все поля заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char n = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (n != 8) && (n != 44) && (n != 45))
                e.Handled = true;

        }
    }
}
