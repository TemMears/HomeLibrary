using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace п2
{
    public partial class HomeLibrery : Form
    {
        public HomeLibrery()
        {
            InitializeComponent();
            ConnectToDatabase();
            dataGridViewLibrary_Table.ReadOnly = true;
            dataGridViewLibrary_Table.Visible = true;
            dataGridView_AuthotBooks.Visible = false;
            dataGridView_BookSection.Visible = false;
            button_CancelAuthor.Visible = false;
            dataGridView_AuthotBooks.ReadOnly = true;
            dataGridView_BookSection.ReadOnly = true;
            dataGridViewLibrary_Table.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // Отключаем возможность выделения нескольких строк
            dataGridViewLibrary_Table.MultiSelect = false;
            // Находим столбец с именем "id" и скрываем его
            string columnName = "id";
            if (dataGridViewLibrary_Table.Columns.Contains(columnName))
            {
                dataGridViewLibrary_Table.Columns[columnName].Visible = false;
            }
            dataGridViewLibrary_Table.Columns["author"].HeaderText = "Автор";
            dataGridViewLibrary_Table.Columns["title"].HeaderText = "Название";
            dataGridViewLibrary_Table.Columns["year"].HeaderText = "Год";
            dataGridViewLibrary_Table.Columns["location"].HeaderText = "Место издания";
            dataGridViewLibrary_Table.Columns["category"].HeaderText = "Раздел библиотеки";
            
        }

        private void ConnectToDatabase()
        {
            // Создаем подключение к базе данных MySQL
            string connectionString = "server=localhost;user=root;database=library;password=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            // Открываем подключение
            connection.Open();

            // Создаем команду SQL для выполнения запроса
            string query = "SELECT id, author, title, year, location, category FROM books";
            MySqlCommand command = new MySqlCommand(query, connection);

            // Создаем объект MySqlDataReader для чтения результатов запроса
            MySqlDataReader reader = command.ExecuteReader();

            // Создаем таблицу для хранения данных
            DataTable table = new DataTable();
            table.Load(reader);

            // Закрываем объект MySqlDataReader и подключение к базе данных
            reader.Close();
            connection.Close();

            // Устанавливаем свойство DataSource элемента DataGridView равным созданной таблице, чтобы отобразить данные
            dataGridViewLibrary_Table.DataSource = table;
        }

        private void добавитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddNewBook addNewBook = new AddNewBook();
            addNewBook.ShowDialog();
            ConnectToDatabase();
        }

        private void очиститьБиблиотекуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Показываем окно с подтверждением очистки таблицы
            DialogResult result = MessageBox.Show("Вы уверены, что хотите очистить таблицу?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string connectionString = "server=localhost;user=root;database=library;password=root;";
                MySqlConnection connection = new MySqlConnection(connectionString);

                // Открываем подключение
                connection.Open();

                // Создаем команду SQL для выполнения операции очистки таблицы
                string query = "TRUNCATE TABLE books";
                MySqlCommand command = new MySqlCommand(query, connection);

                // Выполняем команду SQL
                command.ExecuteNonQuery();

                // Закрываем подключение
                connection.Close();

                // Обновляем таблицу после очистки
                ConnectToDatabase();
            }
            
        }



        private void библиотекуВФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Получаем данные из базы данных
            DataTable table = (DataTable)dataGridViewLibrary_Table.DataSource;

            // Создаем строку для хранения содержимого файла
            StringBuilder fileContent = new StringBuilder();

            // Добавляем заголовки столбцов в файл
            fileContent.AppendLine("автор - название книги - год издания - место издания - раздел библиотеки");

            // Добавляем данные из таблицы в файл
            foreach (DataRow row in table.Rows)
            {
                fileContent.AppendLine($"{row["author"]} - {row["title"]} - {row["year"]} - {row["location"]} - {row["category"]}");
            }

            // Открываем диалоговое окно сохранения файла
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
            saveFileDialog.Title = "Сохранить библиотеку";
            saveFileDialog.ShowDialog();

            // Если пользователь выбрал файл и нажал "Сохранить", сохраняем содержимое файла
            if (saveFileDialog.FileName != "")
            {
                File.WriteAllText(saveFileDialog.FileName, fileContent.ToString());
                MessageBox.Show("Данные успешно сохранены в файл.");
            }
        }

        private void УдалитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Показываем окно "Выберите запись", если пользователь не выбрал никакую запись для удаления
            if (dataGridViewLibrary_Table.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите запись");
            }
            else
            {
                // Получаем выбранную запись
                DataGridViewRow selectedRow = dataGridViewLibrary_Table.SelectedRows[0];

                // Получаем значение идентификатора выбранной записи
                int id = Convert.ToInt32(selectedRow.Cells["id"].Value);

                // Показываем диалоговое окно подтверждения удаления
                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить эту запись?", "Подтверждение удаления", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Удаление записи из библиотеки
                    DeleteRecord(id);

                    // Обновление отображения данных
                    ConnectToDatabase();
                }
            }
            
        }
        private void DeleteRecord(int id)
        {
            string connectionString = "server=localhost;user=root;database=library;password=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            // Открываем подключение
            connection.Open();

            // Создаем команду SQL для выполнения операции удаления записи
            string query = "DELETE FROM books WHERE id = @Id";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", id);

            // Выполняем команду SQL
            command.ExecuteNonQuery();

            // Закрываем подключение
            connection.Close();
        }

        private void УдалитьАвтораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Показываем форму DeleteAuthorForm
            DeleteAuthor deleteAuthorForm = new DeleteAuthor();
            DialogResult result = deleteAuthorForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                string author = deleteAuthorForm.AuthorName;

                if (AuthorExistsInDatabase(author))
                {
                    // Выполняем удаление на основе введенного автора
                    if (!string.IsNullOrEmpty(author))
                    {
                        // Показываем диалоговое окно подтверждения
                        DialogResult confirmationResult = MessageBox.Show($"Вы уверены, что хотите удалить все записи для автора '{author}'?", "Подтверждение удаления", MessageBoxButtons.YesNo);

                        if (confirmationResult == DialogResult.Yes)
                        {
                            // Удаляем записи для введенного автора
                            DeleteRecordsForAuthor(author);

                            // Обновляем отображение данных
                            ConnectToDatabase();
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Такого автора нет!");
                }

            }
        }

        private bool AuthorExistsInDatabase(string author)
        {
            string connectionString = "server=localhost;user=root;database=library;password=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            string query = "SELECT COUNT(*) FROM books WHERE author = @author";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@author", author);

            connection.Open();
            int authorCount = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();

            return authorCount > 0;
        }
        private void DeleteRecordsForAuthor(string author)
        {
            string connectionString = "server=localhost;user=root;database=library;password=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                // Открываем подключение
                connection.Open();

                // Создаем команду SQL для выполнения операции удаления записей выбранного автора
                string query = "DELETE FROM books WHERE author = @Author";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Author", author);

                // Выполняем команду SQL
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Обрабатываем исключение при возникновении ошибки удаления
                MessageBox.Show($"Ошибка при удалении записей для автора '{author}': {ex.Message}", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Закрываем подключение
                connection.Close();
            }
        }

        private void Изменить_разделБиблиотекиАвтораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Показываем форму для изменения раздела библиотеки автора
            ChangeCategory changeCategoryForm = new ChangeCategory();
            DialogResult result = changeCategoryForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                string author = changeCategoryForm.AuthorName;
                string newCategory = changeCategoryForm.NewCategory;

                // Добавляем проверку наличия автора в базе данных
                if (AuthorExistsInDatabase(author))
                {
                    // Выполняем изменение раздела библиотеки для выбранного автора
                    if (!string.IsNullOrEmpty(author) && !string.IsNullOrEmpty(newCategory))
                    {
                        // Показываем диалоговое окно подтверждения
                        DialogResult confirmationResult = MessageBox.Show($"Вы уверены, что хотите изменить раздел библиотеки для автора '{author}' на '{newCategory}'?", "Подтверждение изменения", MessageBoxButtons.YesNo);

                        if (confirmationResult == DialogResult.Yes)
                        {
                            // Изменяем раздел библиотеки для автора
                            ChangeAuthorCategory(author, newCategory);

                            // Обновляем отображение данных
                            ConnectToDatabase();
                        }
                    }

                }
                else
                {
                    MessageBox.Show($"Такого автора нет!");
                }
           
            }
        }
        private void ChangeAuthorCategory(string author, string newCategory)
        {
            string connectionString = "server=localhost;user=root;database=library;password=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                // Открываем подключение
                connection.Open();

                // Создаем команду SQL для выполнения операции изменения раздела библиотеки для выбранного автора
                string query = "UPDATE books SET category = @NewCategory WHERE author = @Author";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@NewCategory", newCategory);
                command.Parameters.AddWithValue("@Author", author);

                // Выполняем команду SQL
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Обрабатываем исключение при возникновении ошибки изменения раздела библиотеки
                MessageBox.Show($"Ошибка при изменении раздела библиотеки для автора '{author}': {ex.Message}", "Ошибка изменения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Закрываем подключение
                connection.Close();
            }
        }

        private void переченькнигаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Открываем диалоговое окно сохранения файла
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
            saveFileDialog.Title = "Сохранить перечень книг и раздел библиотеки";
            saveFileDialog.ShowDialog();

            // Если пользователь выбрал файл и нажал "Сохранить", сохраняем данные в файл
            if (saveFileDialog.FileName != "")
            {
                // Получаем данные из таблицы dataGridViewLibrary_Table
                DataTable table = (DataTable)dataGridViewLibrary_Table.DataSource;

                // Создаем строку для хранения содержимого файла
                StringBuilder fileContent = new StringBuilder();

                // Добавляем заголовок в файл
                fileContent.AppendLine("Книга - Раздел библиотеки");

                // Добавляем данные из таблицы в файл
                foreach (DataRow row in table.Rows)
                {
                    fileContent.AppendLine($"{row["title"]} - {row["category"]}");
                }

                // Сохраняем содержимое файла
                File.WriteAllText(saveFileDialog.FileName, fileContent.ToString());

                MessageBox.Show("Перечень книг и раздел библиотеки успешно сохранен в файл.");
            }
        }

        private void ShowBooksByAuthor(string author)
        {
            string connectionString = "server=localhost;user=root;database=library;password=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            // Открываем подключение
            connection.Open();

            // Создаем команду SQL для выполнения запроса
            string query = $"SELECT title, year, place FROM books WHERE author = '{author}'";
            MySqlCommand command = new MySqlCommand(query, connection);

            // Создаем объект MySqlDataReader для чтения результатов запроса
            MySqlDataReader reader = command.ExecuteReader();

            // Выводим результаты запроса на экран
            while (reader.Read())
            {
                string title = reader.GetString("Название");
                int year = reader.GetInt32("Год издания");
                string place = reader.GetString("Место издания");

                Console.WriteLine($"Название: {title}");
                Console.WriteLine($"Год издания: {year}");
                Console.WriteLine($"Место издания: {place}");
                Console.WriteLine();
            }

            // Закрываем объект MySqlDataReader и подключение к базе данных
            reader.Close();
            connection.Close();
        }

        private void книгиАвтораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowBooksByAuthor showbooksByAuthor = new ShowBooksByAuthor();
            DialogResult result = showbooksByAuthor.ShowDialog();

            if (result == DialogResult.OK)
            {
                string author = showbooksByAuthor.AuthorName;
                

                // Добавляем проверку наличия автора в базе данных
                if (AuthorExistsInDatabase(author))
                {
                    dataGridViewLibrary_Table.Visible = false;
                    dataGridView_AuthotBooks.Visible = true;

                    // Создайте подключение к базе данных MySQL
                    string connectionString = "server=localhost;user=root;database=library;password=root;";
                    MySqlConnection connection = new MySqlConnection(connectionString);
                    button_CancelAuthor.Visible = true;
                    menuStrip_HomeLibrary.Visible = false;

                    try
                    {
                        // Открываем подключение
                        connection.Open();

                        // Создаем SQL-запрос для выборки книг указанного автора
                        string query = "SELECT title, year, location FROM books WHERE author = @Author";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Author", author);

                        // Выполняем SQL-запрос и получаем результаты
                        MySqlDataReader reader = command.ExecuteReader();

                        // Создаем таблицу для хранения результатов
                        DataTable table = new DataTable();
                        table.Load(reader);

                        // Закрываем объект MySqlDataReader и подключение к базе данных
                        reader.Close();
                        connection.Close();

                        // Отображаем результаты на экране
                        dataGridView_AuthotBooks.DataSource = table;
                        dataGridView_AuthotBooks.Columns["title"].HeaderText = "Название";
                        dataGridView_AuthotBooks.Columns["year"].HeaderText = "Год издания";
                        dataGridView_AuthotBooks.Columns["location"].HeaderText = "Раздел библиотеки";
                    }
                    catch (MySqlException ex)
                    {
                        // Обработка ошибок подключения к базе данных
                        MessageBox.Show("Ошибка подключения к базе данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show($"Такого автора нет!");
                }
 
            }

        }
        private void button_CancelAuthor_Click_1(object sender, EventArgs e)
        {
            dataGridViewLibrary_Table.Visible = true;
            dataGridView_AuthotBooks.Visible = false;
            dataGridView_BookSection.Visible = false;
            button_CancelAuthor.Visible = false;
            menuStrip_HomeLibrary.Visible = true;
        }

        private void библиотекуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
            openFileDialog.Title = "Выберите файл";
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Предложение сохранить таблицу перед очисткой
                DialogResult saveResult = MessageBox.Show("Хотите сохранить текущую таблицу перед очисткой?", "Сохранение таблицы", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (saveResult == DialogResult.Yes)
                {
                    // Сохранение таблицы в файл
                    библиотекуВФайлToolStripMenuItem_Click(sender, e);
                }
                else if (saveResult == DialogResult.Cancel)
                {
                    return; // Отмена операции
                }

                очиститьБиблиотекуToolStripMenuItem_Click(sender, e);
                // Вызов функции для чтения данных из файла и добавления их в таблицу
                ReadFileAndAddToTable(filePath);
            }
        }
        private void ReadFileAndAddToTable(string filePath)
        {
            // Проверка целостности файла
            if (IsFileIntact(filePath))
            {
                // Чтение данных из файла
                string[] lines = File.ReadAllLines(filePath);

                // Флаг для отслеживания первой строки
                bool isFirstLine = true;

                // Добавление записей в таблицу
                foreach (string line in lines)
                {
                    // Пропуск первой строки
                    if (isFirstLine)
                    {
                        isFirstLine = false;
                        continue;
                    }

                    string[] data = line.Split(new string[] { " - " }, StringSplitOptions.None);
                    if (data.Length == 5)
                    {
                        string author = data[0].Trim();
                        string title = data[1].Trim();
                        int year = int.Parse(data[2].Trim());
                        string location = data[3].Trim();
                        string category = data[4].Trim();

                        // Добавление записи в базу данных или другое хранилище данных
                        AddRecordToTable(author, title, year, location, category);
                    }
                    else
                    {
                        MessageBox.Show("Внимание! Файл был нарушен.");
                        Delete_Library();
                        break;
                    }
                }

                // Обновление отображения данных в таблице
                ConnectToDatabase();
            }
            else
            {
                MessageBox.Show("Файл был изменен и не может быть открыт.", "Ошибка открытия файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsFileIntact(string filePath)
        {
            // Получение хэш-суммы файла до его изменения
            string originalHash = CalculateFileHash(filePath);

            // Получение хэш-суммы файла после его изменения
            string currentHash = CalculateFileHash(filePath);

            // Сравнение хэш-сумм до и после изменения файла
            return originalHash == currentHash;
        }

        private string CalculateFileHash(string filePath)
        {
            using (var md5 = System.Security.Cryptography.MD5.Create())
            {
                using (var stream = File.OpenRead(filePath))
                {
                    byte[] hashBytes = md5.ComputeHash(stream);
                    StringBuilder hashBuilder = new StringBuilder();
                    foreach (byte b in hashBytes)
                    {
                        hashBuilder.Append(b.ToString("x2"));
                    }
                    return hashBuilder.ToString();
                }
            }
        }
        private void AddRecordToTable(string author, string title, int year, string location, string category)
        {
            string connectionString = "server=localhost;user=root;database=library;password=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                // Открываем подключение
                connection.Open();

                // Создаем команду SQL для выполнения операции добавления записи
                string query = "INSERT INTO books (author, title, year, location, category) VALUES (@Author, @Title, @Year, @Location, @Category)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Author", author);
                command.Parameters.AddWithValue("@Title", title);
                command.Parameters.AddWithValue("@Year", year);
                command.Parameters.AddWithValue("@Location", location);
                command.Parameters.AddWithValue("@Category", category);

                // Выполняем команду SQL
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Обрабатываем исключение при возникновении ошибки добавления записи
                MessageBox.Show($"Ошибка при добавлении записи: {ex.Message}", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Закрываем подключение
                connection.Close();
            }
        }

        private void label_Closed_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void Delete_Library()
        {
            string connectionString = "server=localhost;user=root;database=library;password=root;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                // очистка всех данных из таблицы
                string query = "DELETE FROM books";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }


        Point lastPoint;
        private void menuStrip_HomeLibrary_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void menuStrip_HomeLibrary_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }

        private void переченьКнигаРазделToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
            openFileDialog.Title = "Выберите файл";
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Предложение сохранить таблицу перед очисткой
                DialogResult saveResult = MessageBox.Show("Хотите сохранить текущую таблицу перед очисткой?", "Сохранение таблицы", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (saveResult == DialogResult.Yes)
                {
                    // Сохранение таблицы в файл
                    библиотекуВФайлToolStripMenuItem_Click(sender, e);
                }
                else if (saveResult == DialogResult.Cancel)
                {
                    return; // Отмена операции
                }

                очиститьБиблиотекуToolStripMenuItem_Click(sender, e);
                // Вызов функции для чтения данных из файла и добавления их в таблицу
                ReadFileAndAddToTable_Book(filePath);
            }

        }
        private void ReadFileAndAddToTable_Book(string filePath)
        {
            try
            {
                string fileContent = File.ReadAllText(filePath);
                string[] rows = fileContent.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                DataTable table = new DataTable();
                table.Columns.Add("Книга", typeof(string));
                table.Columns.Add("Раздел библиотеки", typeof(string));
                // Флаг для отслеживания первой строки
                bool isFirstLine = true;
                foreach (string row in rows)
                {
                    // Пропуск первой строки
                    if (isFirstLine)
                    {
                        isFirstLine = false;
                        continue;
                    }
                    string[] columns = row.Split(new string[] { " - " }, StringSplitOptions.None);
                    if (columns.Length == 2) // Check if the row has exactly two columns
                    {
                        table.Rows.Add(columns[0], columns[1]);
                    }
                    else
                    {
                        MessageBox.Show("Файл имеет неверную структуру");
                        Delete_Library();
                        break;
                    }
                }
                button_CancelAuthor.Visible = true;
                dataGridViewLibrary_Table.Visible = false;
                dataGridView_AuthotBooks.Visible = false;
                dataGridView_BookSection.Visible = true;
                dataGridView_BookSection.DataSource = table;
                menuStrip_HomeLibrary.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Файл поврежден: " + ex.Message);
            }
        }

    }
}
