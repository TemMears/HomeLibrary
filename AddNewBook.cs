using MySql.Data.MySqlClient;
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
    public partial class AddNewBook : Form
    {
        public AddNewBook()
        {
            InitializeComponent();
            txtAuthor.Text = "Автор";
            txtTitle.Text = "Название книги";
            txtYear.Text = "0";
            txtAuthor.MaxLength = 40;
            txtTitle.MaxLength = 40;
            txtYear.MaxLength = 4;
            txtLocation.Text = "Место издания";
            comboBoxCategory.Items.Add("Художественная литература");
            comboBoxCategory.Items.Add("Молодёжная литература");
            comboBoxCategory.Items.Add("Спец. литература");
            comboBoxCategory.Items.Add("Домашнее хозяйство");
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            this.AcceptButton = AddBookButton;
        }

        private void txtAuthor_Enter(object sender, EventArgs e)
        {
            if (txtAuthor.Text == "Автор")
            {
                txtAuthor.Text = "";
                txtAuthor.ForeColor = Color.Olive;
            }
        }

        private void txtAuthor_Leave(object sender, EventArgs e)
        {
            if (txtAuthor.Text == "")
            {
                txtAuthor.Text = "Автор";
                txtAuthor.ForeColor = Color.Red;
            }
        }

        private void txtTitle_Enter(object sender, EventArgs e)
        {
            if (txtTitle.Text == "Название книги")
            {
                txtTitle.Text = "";
                txtTitle.ForeColor = Color.Olive;
            }
        }

        private void txtTitle_Leave(object sender, EventArgs e)
        {
            if (txtTitle.Text == "")
            {
                txtTitle.Text = "Название книги";
                txtTitle.ForeColor = Color.Red;
            }
        }
        private void txtYear_Enter(object sender, EventArgs e)
        {
            if (txtYear.Text == "0")
            {
                txtYear.Text = "";
                txtYear.ForeColor = Color.Olive;
            }
        }

        private void txtYear_Leave(object sender, EventArgs e)
        {
            if (txtYear.Text == "")
            {
                txtYear.Text = "0";
                txtYear.ForeColor = Color.Red;
            }
        }
        private void txtLocation_Enter(object sender, EventArgs e)
        {
            if (txtLocation.Text == "Место издания")
            {
                txtLocation.Text = "";
                txtLocation.ForeColor = Color.Olive;
            }
        }

        private void txtLocation_Leave(object sender, EventArgs e)
        {
            if (txtLocation.Text == "")
            {
                txtLocation.Text = "Место издания";
                txtLocation.ForeColor = Color.Red;
            }
        }

        private void CancelAddsBooksButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            // Получаем значения из элементов управления
            string author = txtAuthor.Text;
            string title = txtTitle.Text;
            //int year = Convert.ToInt32(txtYear.Text);
            string location = txtLocation.Text;
            string category = comboBoxCategory.SelectedItem as string;

            // Проверяем, что раздел библиотеки был выбран
            if (!string.IsNullOrEmpty(category))
            {
                // Проверяем, что все поля заполнены
                if (string.IsNullOrEmpty(author) || string.IsNullOrEmpty(title) || string.IsNullOrEmpty(txtYear.Text) || string.IsNullOrEmpty(location))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Парсим год издания
                if (!int.TryParse(txtYear.Text, out int year))
                {
                    MessageBox.Show("Пожалуйста, введите корректный год издания.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Создаем подключение к базе данных MySQL
                string connectionString = "server=localhost;user=root;database=library;password=root;";
                MySqlConnection connection = new MySqlConnection(connectionString);

                // Открываем подключение
                connection.Open();

                // Создаем команду SQL для выполнения операции добавления записи
                string query = "INSERT INTO books (author, title, year, location, category) VALUES (@Author, @Title, @Year, @Location, @Category)";
                MySqlCommand command = new MySqlCommand(query, connection);

                // Добавляем параметры к команде SQL
                command.Parameters.AddWithValue("@Author", author);
                command.Parameters.AddWithValue("@Title", title);
                command.Parameters.AddWithValue("@Year", year);
                command.Parameters.AddWithValue("@Location", location);
                command.Parameters.AddWithValue("@Category", category);

                // Выполняем операцию добавления записи
                command.ExecuteNonQuery();

                // Закрываем подключение к базе данных
                connection.Close();

                // Закрываем окно "Добавление записи"
                this.Close();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите раздел библиотеки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, является ли нажатая клавиша цифрой или специальным символом
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Отменяем событие KeyPress, чтобы предотвратить ввод значения
                e.Handled = true;
            }
            else if (e.KeyChar != '\b') // Проверяем, что нажата не клавиша Backspace
            {
                // Получаем текущее значение в поле ввода
                string currentText = txtYear.Text + e.KeyChar;

                // Проверяем, что значение находится в диапазоне от 0 до 2030
                if (!string.IsNullOrEmpty(currentText))
                {
                    int year = int.Parse(currentText);
                    if (year < 0 || year > 2030)
                    {
                        // Отменяем событие KeyPress, чтобы предотвратить ввод значения
                        e.Handled = true;
                    }
                }
            }
        }
        Point lastPoint;
        private void AddNewBook_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }

        private void AddNewBook_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
