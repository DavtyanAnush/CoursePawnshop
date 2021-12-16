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
    public partial class F7AddProduct : Form
    {
        public string CommandText = "SELECT " +
            "[Сдача в ломбард].[Номер]," +
            "[Клиент].[Фамилия]," +
            "[Категории товаров].[Название]," +
            "[Сдача в ломбард].[Дата сдачи]," +
            "[Сдача в ломбард].[Дата возврата]," +
            "[Сдача в ломбард].[Стоимость]," +
            "[Сдача в ломбард].[Комиссионные]" +
            "FROM [Клиент], [Категории товаров], [Сдача в ломбард] " +
            "WHERE ([Сдача в ломбард].[Клиент]=[Клиент].[Номер])" +
            "AND ([Сдача в ломбард].[Товар]=[Категории товаров].[Номер])";

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
        
        public F7AddProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.Text == "")
            {
                
                    DialogResult dr = MessageBox.Show("Не все данные введены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                

            }
            else
            {
                //сохранение в базу, закрытие формы

                F6Tovar F6 = new F6Tovar();
                F10AllTable F10 = new F10AllTable();
                F3Search F3 = new F3Search();

                if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "" || comboBox1.Text!="" )
                {
                    int rc = F6.dataGridView1.Rows.Count;
                    int nRow0 = rc;
                    string nRow1 = textBox1.Text;
                    string nRow2 = comboBox1.Text;
                    string nRow3 = textBox2.Text;
                    string nRow4 = Convert.ToString(dateTimePicker1.Value.Date); 
                    string nRow5 = textBox3.Text;

                    string ComText = "INSERT INTO [Категории товаров] ([Номер], [Категория товаров], [Название], [Примечание])"
                         + "VALUES ('" + nRow0 + "', '" + nRow2 + "', '" + nRow1 + "', '" + nRow3 + "')";

                    My_Execute_Non(ComText);
                   

                    OleDbDataAdapter dAd = new OleDbDataAdapter(CommandText, ConnString);
                    DataSet dse = new DataSet();
                    dAd.Fill(dse, "[Клиент]");
                    F6.dataGridView1.DataSource = dse.Tables[0].DefaultView;
                    F6.dataGridView1.Refresh();


                    int num = F10.dataGridView1.Rows.Count;
                    int klient = 4; // F3.textBox1.Text;
                    int tovar = 4; // F3.textBox1.Text;
                    
                    string datav = dateTimePicker1.Value.AddMonths(1).ToString("dd.MM.yyyy");
                    double k = Convert.ToDouble(textBox3.Text);
                    double komiss = k * 1.2;
                    ComText = "INSERT INTO [Сдача в ломбард] ([Номер], [Клиент], [Товар], [Дата сдачи], [Дата возврата], [Стоимость],[Комиссионные])"
                         + "VALUES ('" + num + "', '" + klient + "', '" + tovar + "', '" + nRow4 + "', '" + datav + "', '" + nRow5 + "', '" + komiss + "')";

                    My_Execute_Non(ComText);
                    
                    OleDbDataAdapter dA = new OleDbDataAdapter(CommandText, ConnString);
                    DataSet ds = new DataSet();
                    dAd.Fill(ds, "[Сдача в ломбард]");
                    F10.dataGridView1.DataSource = ds.Tables["[Сдача в ломбард]"].DefaultView;
                    F10.dataGridView1.Refresh();
                }
                Close();

            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label9.Text = dateTimePicker1.Value.AddMonths(1).ToString("dd.MM.yyyy");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                double a = Convert.ToDouble(textBox3.Text);
                label7.Text = Convert.ToString(a * 1.2);
            }
            else label7.Text = "расчет комиссионных...";

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char n = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (n != 8) && (n != 44) && (n != 45))
                e.Handled = true;

        }
    }
}
