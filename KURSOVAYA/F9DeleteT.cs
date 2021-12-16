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
    public partial class F9DeleteT : Form
    {
        public string CommandText = "SELECT * FROM [Категории товаров]";
        public string ConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\KURSOVAYA\\KURSOVAYA\\БД курсвая.accdb";

        public void My_Execute_Non(string CommandText)
        {
            OleDbConnection conn = new OleDbConnection(ConnString);
            conn.Open();
            OleDbCommand myCommand = conn.CreateCommand();
            myCommand.CommandText = CommandText;
            myCommand.ExecuteNonQuery();
            conn.Close();

        }


        public F9DeleteT()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F6Tovar F6 = new F6Tovar();

            if (textBox1.Text != "")
            {
                string ComText = "DELETE FROM";
                int index = -1;
                for (int i = 0; i < F6.dataGridView1.RowCount; i++)
                {

                    if (F6.dataGridView1.Rows[i].Cells[0].Value != null)
                        if (F6.dataGridView1.Rows[i].Cells[0].Value.ToString().Contains(textBox1.Text))
                        {
                            index = i;
                            break;
                        }

                }
                if (index > -1)
                {
                    string ID = Convert.ToString(F6.dataGridView1[0, index].Value);
                    ComText = "DELETE FROM [Категории товаров] WHERE [Категории товаров].[Номер] = " + ID;

                    My_Execute_Non(ComText);

                    OleDbDataAdapter dAd = new OleDbDataAdapter(CommandText, ConnString);
                    DataSet dse = new DataSet();
                    dAd.Fill(dse, "[Клиент]");
                    F6.dataGridView1.DataSource = dse.Tables[0].DefaultView;
                    F6.dataGridView1.Refresh();
                    Close();
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Нет совпадений!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char n = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (n != 8) && (n != 44) && (n != 45))
                e.Handled = true;

        }
    }
}
