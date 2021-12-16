namespace KURSOVAYA
{
    partial class F10AllTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.номерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.клиентDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.товарDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаСдачиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВозвратаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.комиссионныеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сдачаВЛомбардBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бД_курсваяDataSet = new KURSOVAYA.БД_курсваяDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.сдача_в_ломбардTableAdapter = new KURSOVAYA.БД_курсваяDataSetTableAdapters.Сдача_в_ломбардTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сдачаВЛомбардBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_курсваяDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерDataGridViewTextBoxColumn,
            this.клиентDataGridViewTextBoxColumn,
            this.товарDataGridViewTextBoxColumn,
            this.датаСдачиDataGridViewTextBoxColumn,
            this.датаВозвратаDataGridViewTextBoxColumn,
            this.стоимостьDataGridViewTextBoxColumn,
            this.комиссионныеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.сдачаВЛомбардBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(736, 214);
            this.dataGridView1.TabIndex = 0;
            // 
            // номерDataGridViewTextBoxColumn
            // 
            this.номерDataGridViewTextBoxColumn.DataPropertyName = "Номер";
            this.номерDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.номерDataGridViewTextBoxColumn.Name = "номерDataGridViewTextBoxColumn";
            // 
            // клиентDataGridViewTextBoxColumn
            // 
            this.клиентDataGridViewTextBoxColumn.DataPropertyName = "Клиент";
            this.клиентDataGridViewTextBoxColumn.HeaderText = "Клиент";
            this.клиентDataGridViewTextBoxColumn.Name = "клиентDataGridViewTextBoxColumn";
            // 
            // товарDataGridViewTextBoxColumn
            // 
            this.товарDataGridViewTextBoxColumn.DataPropertyName = "Товар";
            this.товарDataGridViewTextBoxColumn.HeaderText = "Товар";
            this.товарDataGridViewTextBoxColumn.Name = "товарDataGridViewTextBoxColumn";
            // 
            // датаСдачиDataGridViewTextBoxColumn
            // 
            this.датаСдачиDataGridViewTextBoxColumn.DataPropertyName = "Дата сдачи";
            this.датаСдачиDataGridViewTextBoxColumn.HeaderText = "Дата сдачи";
            this.датаСдачиDataGridViewTextBoxColumn.Name = "датаСдачиDataGridViewTextBoxColumn";
            // 
            // датаВозвратаDataGridViewTextBoxColumn
            // 
            this.датаВозвратаDataGridViewTextBoxColumn.DataPropertyName = "Дата возврата";
            this.датаВозвратаDataGridViewTextBoxColumn.HeaderText = "Дата возврата";
            this.датаВозвратаDataGridViewTextBoxColumn.Name = "датаВозвратаDataGridViewTextBoxColumn";
            // 
            // стоимостьDataGridViewTextBoxColumn
            // 
            this.стоимостьDataGridViewTextBoxColumn.DataPropertyName = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.Name = "стоимостьDataGridViewTextBoxColumn";
            // 
            // комиссионныеDataGridViewTextBoxColumn
            // 
            this.комиссионныеDataGridViewTextBoxColumn.DataPropertyName = "Комиссионные";
            this.комиссионныеDataGridViewTextBoxColumn.HeaderText = "Комиссионные";
            this.комиссионныеDataGridViewTextBoxColumn.Name = "комиссионныеDataGridViewTextBoxColumn";
            // 
            // сдачаВЛомбардBindingSource
            // 
            this.сдачаВЛомбардBindingSource.DataMember = "Сдача в ломбард";
            this.сдачаВЛомбардBindingSource.DataSource = this.бД_курсваяDataSet;
            // 
            // бД_курсваяDataSet
            // 
            this.бД_курсваяDataSet.DataSetName = "БД_курсваяDataSet";
            this.бД_курсваяDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.button1.Location = new System.Drawing.Point(559, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.label1.Location = new System.Drawing.Point(254, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Клиенты и их товары";
            // 
            // сдача_в_ломбардTableAdapter
            // 
            this.сдача_в_ломбардTableAdapter.ClearBeforeFill = true;
            // 
            // F10AllTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 349);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "F10AllTable";
            this.Text = "Клиенты и их товары";
            this.Load += new System.EventHandler(this.F10AllTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сдачаВЛомбардBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_курсваяDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private БД_курсваяDataSet бД_курсваяDataSet;
        private System.Windows.Forms.BindingSource сдачаВЛомбардBindingSource;
        private БД_курсваяDataSetTableAdapters.Сдача_в_ломбардTableAdapter сдача_в_ломбардTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn клиентDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn товарDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаСдачиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВозвратаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn комиссионныеDataGridViewTextBoxColumn;
    }
}