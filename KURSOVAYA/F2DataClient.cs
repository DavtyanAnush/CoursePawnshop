using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KURSOVAYA
{
    public partial class F2DataClient : Form
    {
        //Подключение базы данных
        public string CommandText = "SELECT * FROM [Клиент]";
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

        public F2DataClient()
        {
            InitializeComponent();
            
            OleDbDataAdapter dA = new OleDbDataAdapter(CommandText, ConnString);
            DataSet ds = new DataSet();
            //Заполняем таблицу
            dA.Fill(ds, "[Клиент]");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F3Search F3 = new F3Search();
            F3.Owner = this;
            F3.Show();
            int nstr1 = 0;
            F4Client F4 = new F4Client(nstr1);
            F4.Owner = this;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            F5AddClient F5 = new F5AddClient();
            F5.ShowDialog();
            F5.Owner = this;
            if (F5.textBox1.Text != "" && F5.textBox2.Text != "" && F5.textBox3.Text != "" && F5.textBox5.Text != "")
            {
                int rc = dataGridView1.Rows.Count;
                int nRow0 = rc;
                string nRow1 = F5.textBox1.Text;
                string nRow2 = F5.textBox2.Text;

                string nRow3 = F5.textBox3.Text;
                string nRow4 = F5.dateTimePicker1.Value.ToString("dd.MM.yyyy");
                string nRow5 = F5.textBox5.Text;

                string ComText = "INSERT INTO [Клиент] ([Номер], [Фамилия], [Имя], [Отчество], [Дата рождения], [Серия Номер])"
                     + "VALUES ('" + nRow0 + "', '" + nRow1 + "', '" + nRow2 + "', '" + nRow3 + "', '" + nRow4 + "', '" + nRow5 + "')";

                My_Execute_Non(ComText);
                dataGridView1.Refresh();

                OleDbDataAdapter dAd = new OleDbDataAdapter(CommandText, ConnString);
                DataSet dse = new DataSet();
                dAd.Fill(dse, "[Клиент]");
                dataGridView1.DataSource = dse.Tables[0].DefaultView;
                dataGridView1.Refresh();
            }
        }

        private void F2DataClient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_курсваяDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.бД_курсваяDataSet.Клиент);
            
        }

        private void button4_Click(object sender, EventArgs e)//удаление клиента
        {
            F8Delete F8 = new F8Delete();
            F8.ShowDialog();
            F8.Owner = this;
            if (F8.textBox1.Text != "")
            {
                string ComText = "DELETE FROM";
                int index = -1;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {

                    if (dataGridView1.Rows[i].Cells[5].Value != null)
                        if (dataGridView1.Rows[i].Cells[5].Value.ToString().Equals(F8.textBox1.Text))
                        {
                            index = i;
                            break;
                        }


                }
                if (index > -1)
                {
                    string ID = Convert.ToString(dataGridView1[0, index].Value);
                    ComText = "DELETE FROM [Клиент] WHERE [Клиент].[Номер] = " + ID;

                    My_Execute_Non(ComText);

                    OleDbDataAdapter dAd = new OleDbDataAdapter(CommandText, ConnString);
                    DataSet dse = new DataSet();
                    dAd.Fill(dse, "[Клиент]");
                    dataGridView1.DataSource = dse.Tables[0].DefaultView;
                    dataGridView1.Refresh();
                }
                else
                { 
                DialogResult dr = MessageBox.Show("Нет совпадений!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
    

}
