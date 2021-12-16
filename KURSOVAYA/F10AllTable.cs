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
    public partial class F10AllTable : Form
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

        private void F10AllTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'бД_курсваяDataSet.Сдача_в_ломбард' table. You can move, or remove it, as needed.
            this.сдача_в_ломбардTableAdapter.Fill(this.бД_курсваяDataSet.Сдача_в_ломбард);
            
        }
        public F10AllTable()
        {
            InitializeComponent();
            
            OleDbDataAdapter dA = new OleDbDataAdapter(CommandText, ConnString);
            DataSet ds = new DataSet();
            //Заполняем таблицу
            dA.Fill(ds, "[Сдача в ломбард]");
            dataGridView1.DataSource = ds.Tables["[Сдача в ломбард]"].DefaultView;


        }


        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
