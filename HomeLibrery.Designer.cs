namespace п2
{
    partial class HomeLibrery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeLibrery));
            this.dataGridViewLibrary_Table = new System.Windows.Forms.DataGridView();
            this.menuStrip_HomeLibrary = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.УдалитьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.УдалитьАвтораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Изменить_разделБиблиотекиАвтораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.библиотекуВФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переченькнигаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьБиблиотекуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вывестиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.книгиАвтораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.библиотекуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переченьКнигаРазделToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label_Closed = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.dataGridView_AuthotBooks = new System.Windows.Forms.DataGridView();
            this.button_CancelAuthor = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView_BookSection = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibrary_Table)).BeginInit();
            this.menuStrip_HomeLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AuthotBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BookSection)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLibrary_Table
            // 
            this.dataGridViewLibrary_Table.BackgroundColor = System.Drawing.Color.DarkKhaki;
            this.dataGridViewLibrary_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLibrary_Table.Location = new System.Drawing.Point(12, 40);
            this.dataGridViewLibrary_Table.Name = "dataGridViewLibrary_Table";
            this.dataGridViewLibrary_Table.RowHeadersWidth = 51;
            this.dataGridViewLibrary_Table.RowTemplate.Height = 24;
            this.dataGridViewLibrary_Table.Size = new System.Drawing.Size(776, 398);
            this.dataGridViewLibrary_Table.TabIndex = 0;
            // 
            // menuStrip_HomeLibrary
            // 
            this.menuStrip_HomeLibrary.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_HomeLibrary.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.очиститьБиблиотекуToolStripMenuItem,
            this.вывестиToolStripMenuItem,
            this.открытьToolStripMenuItem});
            this.menuStrip_HomeLibrary.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_HomeLibrary.Name = "menuStrip_HomeLibrary";
            this.menuStrip_HomeLibrary.Size = new System.Drawing.Size(800, 28);
            this.menuStrip_HomeLibrary.TabIndex = 1;
            this.menuStrip_HomeLibrary.Text = "menuStrip1";
            this.menuStrip_HomeLibrary.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip_HomeLibrary_MouseDown);
            this.menuStrip_HomeLibrary.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip_HomeLibrary_MouseMove);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click_1);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.УдалитьЗаписьToolStripMenuItem,
            this.УдалитьАвтораToolStripMenuItem});
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // УдалитьЗаписьToolStripMenuItem
            // 
            this.УдалитьЗаписьToolStripMenuItem.Name = "УдалитьЗаписьToolStripMenuItem";
            this.УдалитьЗаписьToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.УдалитьЗаписьToolStripMenuItem.Text = "Запись";
            this.УдалитьЗаписьToolStripMenuItem.Click += new System.EventHandler(this.УдалитьЗаписьToolStripMenuItem_Click);
            // 
            // УдалитьАвтораToolStripMenuItem
            // 
            this.УдалитьАвтораToolStripMenuItem.Name = "УдалитьАвтораToolStripMenuItem";
            this.УдалитьАвтораToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.УдалитьАвтораToolStripMenuItem.Text = "Автора";
            this.УдалитьАвтораToolStripMenuItem.Click += new System.EventHandler(this.УдалитьАвтораToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Изменить_разделБиблиотекиАвтораToolStripMenuItem});
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            // 
            // Изменить_разделБиблиотекиАвтораToolStripMenuItem
            // 
            this.Изменить_разделБиблиотекиАвтораToolStripMenuItem.Name = "Изменить_разделБиблиотекиАвтораToolStripMenuItem";
            this.Изменить_разделБиблиотекиАвтораToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.Изменить_разделБиблиотекиАвтораToolStripMenuItem.Text = "Раздел библиотеки автора";
            this.Изменить_разделБиблиотекиАвтораToolStripMenuItem.Click += new System.EventHandler(this.Изменить_разделБиблиотекиАвтораToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.библиотекуВФайлToolStripMenuItem,
            this.переченькнигаToolStripMenuItem});
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // библиотекуВФайлToolStripMenuItem
            // 
            this.библиотекуВФайлToolStripMenuItem.Name = "библиотекуВФайлToolStripMenuItem";
            this.библиотекуВФайлToolStripMenuItem.Size = new System.Drawing.Size(365, 26);
            this.библиотекуВФайлToolStripMenuItem.Text = "Библиотеку в файл";
            this.библиотекуВФайлToolStripMenuItem.Click += new System.EventHandler(this.библиотекуВФайлToolStripMenuItem_Click);
            // 
            // переченькнигаToolStripMenuItem
            // 
            this.переченькнигаToolStripMenuItem.Name = "переченькнигаToolStripMenuItem";
            this.переченькнигаToolStripMenuItem.Size = new System.Drawing.Size(365, 26);
            this.переченькнигаToolStripMenuItem.Text = "Перечень \"книга - раздел библиотеки\"";
            this.переченькнигаToolStripMenuItem.Click += new System.EventHandler(this.переченькнигаToolStripMenuItem_Click);
            // 
            // очиститьБиблиотекуToolStripMenuItem
            // 
            this.очиститьБиблиотекуToolStripMenuItem.Name = "очиститьБиблиотекуToolStripMenuItem";
            this.очиститьБиблиотекуToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.очиститьБиблиотекуToolStripMenuItem.Text = "Очистить библиотеку";
            this.очиститьБиблиотекуToolStripMenuItem.Click += new System.EventHandler(this.очиститьБиблиотекуToolStripMenuItem_Click);
            // 
            // вывестиToolStripMenuItem
            // 
            this.вывестиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.книгиАвтораToolStripMenuItem});
            this.вывестиToolStripMenuItem.Name = "вывестиToolStripMenuItem";
            this.вывестиToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.вывестиToolStripMenuItem.Text = "Найти";
            // 
            // книгиАвтораToolStripMenuItem
            // 
            this.книгиАвтораToolStripMenuItem.Name = "книгиАвтораToolStripMenuItem";
            this.книгиАвтораToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.книгиАвтораToolStripMenuItem.Text = "Книги автора";
            this.книгиАвтораToolStripMenuItem.Click += new System.EventHandler(this.книгиАвтораToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.библиотекуToolStripMenuItem,
            this.переченьКнигаРазделToolStripMenuItem});
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // библиотекуToolStripMenuItem
            // 
            this.библиотекуToolStripMenuItem.Name = "библиотекуToolStripMenuItem";
            this.библиотекуToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.библиотекуToolStripMenuItem.Text = "Библиотеку";
            this.библиотекуToolStripMenuItem.Click += new System.EventHandler(this.библиотекуToolStripMenuItem_Click);
            // 
            // переченьКнигаРазделToolStripMenuItem
            // 
            this.переченьКнигаРазделToolStripMenuItem.Name = "переченьКнигаРазделToolStripMenuItem";
            this.переченьКнигаРазделToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.переченьКнигаРазделToolStripMenuItem.Text = "Перечень \"Книга - Раздел\"";
            this.переченьКнигаРазделToolStripMenuItem.Click += new System.EventHandler(this.переченьКнигаРазделToolStripMenuItem_Click);
            // 
            // label_Closed
            // 
            this.label_Closed.AutoSize = true;
            this.label_Closed.BackColor = System.Drawing.Color.Transparent;
            this.label_Closed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Closed.Location = new System.Drawing.Point(765, 0);
            this.label_Closed.Name = "label_Closed";
            this.label_Closed.Size = new System.Drawing.Size(23, 22);
            this.label_Closed.TabIndex = 2;
            this.label_Closed.Text = "X";
            this.label_Closed.Click += new System.EventHandler(this.label_Closed_Click);
            // 
            // dataGridView_AuthotBooks
            // 
            this.dataGridView_AuthotBooks.BackgroundColor = System.Drawing.Color.DarkKhaki;
            this.dataGridView_AuthotBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AuthotBooks.Location = new System.Drawing.Point(12, 64);
            this.dataGridView_AuthotBooks.Name = "dataGridView_AuthotBooks";
            this.dataGridView_AuthotBooks.RowHeadersWidth = 51;
            this.dataGridView_AuthotBooks.RowTemplate.Height = 24;
            this.dataGridView_AuthotBooks.Size = new System.Drawing.Size(776, 345);
            this.dataGridView_AuthotBooks.TabIndex = 3;
            // 
            // button_CancelAuthor
            // 
            this.button_CancelAuthor.BackColor = System.Drawing.Color.OliveDrab;
            this.button_CancelAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_CancelAuthor.Location = new System.Drawing.Point(598, 415);
            this.button_CancelAuthor.Name = "button_CancelAuthor";
            this.button_CancelAuthor.Size = new System.Drawing.Size(190, 23);
            this.button_CancelAuthor.TabIndex = 4;
            this.button_CancelAuthor.Text = "Вернуть полную таблицу";
            this.button_CancelAuthor.UseVisualStyleBackColor = false;
            this.button_CancelAuthor.Click += new System.EventHandler(this.button_CancelAuthor_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView_BookSection
            // 
            this.dataGridView_BookSection.BackgroundColor = System.Drawing.Color.DarkKhaki;
            this.dataGridView_BookSection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_BookSection.Location = new System.Drawing.Point(12, 76);
            this.dataGridView_BookSection.Name = "dataGridView_BookSection";
            this.dataGridView_BookSection.RowHeadersWidth = 51;
            this.dataGridView_BookSection.RowTemplate.Height = 24;
            this.dataGridView_BookSection.Size = new System.Drawing.Size(776, 333);
            this.dataGridView_BookSection.TabIndex = 5;
            // 
            // HomeLibrery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_BookSection);
            this.Controls.Add(this.button_CancelAuthor);
            this.Controls.Add(this.dataGridView_AuthotBooks);
            this.Controls.Add(this.label_Closed);
            this.Controls.Add(this.dataGridViewLibrary_Table);
            this.Controls.Add(this.menuStrip_HomeLibrary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_HomeLibrary;
            this.Name = "HomeLibrery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Домашняя библиотека";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibrary_Table)).EndInit();
            this.menuStrip_HomeLibrary.ResumeLayout(false);
            this.menuStrip_HomeLibrary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AuthotBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BookSection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLibrary_Table;
        private System.Windows.Forms.MenuStrip menuStrip_HomeLibrary;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Изменить_разделБиблиотекиАвтораToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьБиблиотекуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem библиотекуВФайлToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem переченькнигаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem УдалитьЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem УдалитьАвтораToolStripMenuItem;
        private System.Windows.Forms.Label label_Closed;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem вывестиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem книгиАвтораToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem библиотекуToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView_AuthotBooks;
        private System.Windows.Forms.Button button_CancelAuthor;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView_BookSection;
        private System.Windows.Forms.ToolStripMenuItem переченьКнигаРазделToolStripMenuItem;
    }
}