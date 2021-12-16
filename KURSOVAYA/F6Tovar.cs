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
    public partial class F6Tovar : Form
    {
        //Подключение базы данных
        public string CmText = "SELECT * FROM [Категории товаров]";
        public string ConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\KURSOVAYA\\KURSOVAYA\\БД курсвая.accdb";

        public F6Tovar()
        {
            InitializeComponent();

            OleDbDataAdapter dA = new OleDbDataAdapter(CmText, ConnString);
            DataSet ds = new DataSet();
            //Заполняем таблицу
            dA.Fill(ds, "[Категории товаров]");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void F6Tovar_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_курсваяDataSet.Категории_товаров". При необходимости она может быть перемещена или удалена.
            this.категории_товаровTableAdapter.Fill(this.бД_курсваяDataSet.Категории_товаров);

        }
    }
}
