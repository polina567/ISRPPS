namespace Frames
{
    partial class Form1
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
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Зерномучные");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Фрукты, овощи");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("Кондитерские изделия");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("Мясо и мясные");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("Рыбная продукция");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("Молочные продукты");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("Напитки");
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("Продукты", new System.Windows.Forms.TreeNode[] {
            treeNode45,
            treeNode46,
            treeNode47,
            treeNode48,
            treeNode49,
            treeNode50,
            treeNode51});
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("Водоснабжение");
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("Газоснабжение");
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("Электричество");
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("Телефон");
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("ЖКХ", new System.Windows.Forms.TreeNode[] {
            treeNode53,
            treeNode54,
            treeNode55,
            treeNode56});
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("Аренда");
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("Кредиты");
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("Налоги");
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("Постоянные затраты", new System.Windows.Forms.TreeNode[] {
            treeNode58,
            treeNode59,
            treeNode60});
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("Бензин");
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("Автомобиль", new System.Windows.Forms.TreeNode[] {
            treeNode62});
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("Общественный транспорт");
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("Транспорт", new System.Windows.Forms.TreeNode[] {
            treeNode63,
            treeNode64});
            System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("Незапланированные затраты");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.удалитьКотегориюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьРасходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(9, 25);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2);
            this.treeView1.Name = "treeView1";
            treeNode45.Name = "Узел1";
            treeNode45.Text = "Зерномучные";
            treeNode46.Name = "Узел2";
            treeNode46.Text = "Фрукты, овощи";
            treeNode47.Name = "Узел4";
            treeNode47.Text = "Кондитерские изделия";
            treeNode48.Name = "Узел5";
            treeNode48.Text = "Мясо и мясные";
            treeNode49.Name = "Узел6";
            treeNode49.Text = "Рыбная продукция";
            treeNode50.Name = "Узел7";
            treeNode50.Text = "Молочные продукты";
            treeNode51.Name = "Узел8";
            treeNode51.Text = "Напитки";
            treeNode52.Name = "Узел0";
            treeNode52.Text = "Продукты";
            treeNode53.Name = "Узел10";
            treeNode53.Text = "Водоснабжение";
            treeNode54.Name = "Узел11";
            treeNode54.Text = "Газоснабжение";
            treeNode55.Name = "Узел12";
            treeNode55.Text = "Электричество";
            treeNode56.Name = "Узел13";
            treeNode56.Text = "Телефон";
            treeNode57.Name = "Узел9";
            treeNode57.Text = "ЖКХ";
            treeNode58.Name = "Узел15";
            treeNode58.Text = "Аренда";
            treeNode59.Name = "Узел16";
            treeNode59.Text = "Кредиты";
            treeNode60.Name = "Узел17";
            treeNode60.Text = "Налоги";
            treeNode61.Name = "Узел14";
            treeNode61.Text = "Постоянные затраты";
            treeNode62.Name = "Узел21";
            treeNode62.Text = "Бензин";
            treeNode63.Name = "Узел20";
            treeNode63.Text = "Автомобиль";
            treeNode64.Name = "Узел22";
            treeNode64.Text = "Общественный транспорт";
            treeNode65.Name = "Узел19";
            treeNode65.Text = "Транспорт";
            treeNode66.Name = "Узел23";
            treeNode66.Text = "Незапланированные затраты";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode52,
            treeNode57,
            treeNode61,
            treeNode65,
            treeNode66});
            this.treeView1.Size = new System.Drawing.Size(229, 154);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьКотегориюToolStripMenuItem,
            this.удалитьРасходToolStripMenuItem1,
            this.очиститьToolStripMenuItem1,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(683, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // удалитьКотегориюToolStripMenuItem
            // 
            this.удалитьКотегориюToolStripMenuItem.Name = "удалитьКотегориюToolStripMenuItem";
            this.удалитьКотегориюToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.удалитьКотегориюToolStripMenuItem.Text = "Удалить категорию";
            this.удалитьКотегориюToolStripMenuItem.Click += new System.EventHandler(this.удалитьКотегориюToolStripMenuItem_Click);
            // 
            // удалитьРасходToolStripMenuItem1
            // 
            this.удалитьРасходToolStripMenuItem1.Name = "удалитьРасходToolStripMenuItem1";
            this.удалитьРасходToolStripMenuItem1.Size = new System.Drawing.Size(108, 20);
            this.удалитьРасходToolStripMenuItem1.Text = "Удалить расход";
            this.удалитьРасходToolStripMenuItem1.Click += new System.EventHandler(this.удалитьРасходToolStripMenuItem1_Click);
            // 
            // очиститьToolStripMenuItem1
            // 
            this.очиститьToolStripMenuItem1.Name = "очиститьToolStripMenuItem1";
            this.очиститьToolStripMenuItem1.Size = new System.Drawing.Size(74, 20);
            this.очиститьToolStripMenuItem1.Text = "Очистить";
            this.очиститьToolStripMenuItem1.Click += new System.EventHandler(this.очиститьToolStripMenuItem1_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(250, 25);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(422, 283);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название";
            this.columnHeader1.Width = 111;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Сумма расхода";
            this.columnHeader2.Width = 127;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Процент от всех расходов";
            this.columnHeader3.Width = 185;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 288);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 289);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 19);
            this.button1.TabIndex = 4;
            this.button1.Text = "Итог";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 183);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(98, 20);
            this.textBox2.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(111, 183);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 19);
            this.button2.TabIndex = 6;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(9, 207);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(98, 20);
            this.textBox3.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(111, 207);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 19);
            this.button3.TabIndex = 8;
            this.button3.Text = "Добавить категорию";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(9, 231);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(98, 20);
            this.textBox4.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(111, 232);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 19);
            this.button4.TabIndex = 10;
            this.button4.Text = "Добавить расход";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 312);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Планер расходов";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem удалитьКотегориюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьРасходToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem1;
    }
}

