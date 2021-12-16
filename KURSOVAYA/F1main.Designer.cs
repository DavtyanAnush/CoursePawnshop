namespace KURSOVAYA
{
    partial class F1main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F1main));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.работаСКлиентомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приемТовараToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работаСТоваромToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарыЛомбардаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(180, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ломбард \r\n\"Облачная страна\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(75, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 92);
            this.button1.TabIndex = 1;
            this.button1.Text = "Прием\r\nтовара";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(350, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 92);
            this.button2.TabIndex = 2;
            this.button2.Text = "Товары\r\nломбарда";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(473, 373);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 39);
            this.button3.TabIndex = 3;
            this.button3.Text = "Выход";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работаСКлиентомToolStripMenuItem,
            this.работаСТоваромToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(627, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // работаСКлиентомToolStripMenuItem
            // 
            this.работаСКлиентомToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.приемТовараToolStripMenuItem});
            this.работаСКлиентомToolStripMenuItem.Name = "работаСКлиентомToolStripMenuItem";
            this.работаСКлиентомToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.работаСКлиентомToolStripMenuItem.Text = "Работа с клиентом";
            // 
            // приемТовараToolStripMenuItem
            // 
            this.приемТовараToolStripMenuItem.Name = "приемТовараToolStripMenuItem";
            this.приемТовараToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.приемТовараToolStripMenuItem.Text = "Прием товара";
            this.приемТовараToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // работаСТоваромToolStripMenuItem
            // 
            this.работаСТоваромToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.товарыЛомбардаToolStripMenuItem});
            this.работаСТоваромToolStripMenuItem.Name = "работаСТоваромToolStripMenuItem";
            this.работаСТоваромToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.работаСТоваромToolStripMenuItem.Text = "Работа с товаром";
            // 
            // товарыЛомбардаToolStripMenuItem
            // 
            this.товарыЛомбардаToolStripMenuItem.Name = "товарыЛомбардаToolStripMenuItem";
            this.товарыЛомбардаToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.товарыЛомбардаToolStripMenuItem.Text = "Товары ломбарда";
            this.товарыЛомбардаToolStripMenuItem.Click += new System.EventHandler(this.Button2_Click);
            // 
            // F1main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(627, 436);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F1main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ломбард ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem работаСКлиентомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem приемТовараToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работаСТоваромToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem товарыЛомбардаToolStripMenuItem;
    }
}

