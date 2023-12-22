using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace п2
{
    public partial class ChangeCategory : Form
    {
        public string AuthorName { get; private set; }
        public string NewCategory { get; private set; }
        public ChangeCategory()
        {
            InitializeComponent();
            textBox_Author.Text = "Введите автора";
            comboBox_Category.Items.Add("Художественная литература");
            comboBox_Category.Items.Add("Молодёжная литература");
            comboBox_Category.Items.Add("Спец. литература");
            comboBox_Category.Items.Add("Домашнее хозяйство");
            comboBox_Category.DropDownStyle = ComboBoxStyle.DropDownList;
            this.AcceptButton = button_OK;
            textBox_Author.MaxLength = 40;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (comboBox_Category.SelectedItem != null)
            {
                AuthorName = textBox_Author.Text;
                NewCategory = comboBox_Category.SelectedItem.ToString();
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите категорию.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_Author_Enter(object sender, EventArgs e)
        {
            if (textBox_Author.Text == "Введите автора")
            {
                textBox_Author.Text = "";
                textBox_Author.ForeColor = Color.Olive;
            }
        }

        private void textBox_Author_Leave(object sender, EventArgs e)
        {
            if (textBox_Author.Text == "")
            {
                textBox_Author.Text = "Введите автора";
                textBox_Author.ForeColor = Color.Red;
            }
        }
        Point lastPoint;
        private void ChangeCategoryForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }

        private void AuthorChangeCategoryForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
