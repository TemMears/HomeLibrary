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
    public partial class DeleteAuthor : Form
    {
        public DeleteAuthor()
        {
            InitializeComponent();
            textBoxAuthor.Text = "Введите автора";
            this.AcceptButton = OK;
            textBoxAuthor.MaxLength = 40;
        }
        public string AuthorName
        {
            get { return textBoxAuthor.Text; }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            // Проверяем, что введено имя автора
            if (!string.IsNullOrEmpty(textBoxAuthor.Text))
            {
                // Закрываем форму с результатом DialogResult.OK
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите имя автора.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxAuthor_Enter(object sender, EventArgs e)
        {
            if (textBoxAuthor.Text == "Введите автора")
            {
                textBoxAuthor.Text = "";
                textBoxAuthor.ForeColor = Color.Olive;
            }
        }

        private void textBoxAuthor_Leave(object sender, EventArgs e)
        {
            if (textBoxAuthor.Text == "")
            {
                textBoxAuthor.Text = "Введите автора";
                textBoxAuthor.ForeColor = Color.Red;
            }
        }
        Point lastPoint;
        private void DeleteAuthorForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void DeleteAuthorForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
   
}
