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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace п2
{
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
            Pass.Text = "Введите пароль";
            LoginText.Text = "Введите логин";
            Pass.MaxLength = 40;
            this.AcceptButton = Enteringpass;
        }
        private void Parol_Enter(object sender, EventArgs e)
        {
            if (Pass.Text == "Введите пароль")
            {
                Pass.Text = "";
                Pass.ForeColor = Color.Olive;
            }
            
        }
        private void Parol_Leave(object sender, EventArgs e)
        {
            if (Pass.Text == "")
            {
                Pass.Text = "Введите пароль";
                Pass.ForeColor = Color.Red;
            }
        }

        private void Enteringpass_Click(object sender, EventArgs e)
        {
            string password = Pass.Text; 
            string login = LoginText.Text;

            if (!string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(login))
            {
                if (ValidateLogin(login, password))
                {
                    HomeLibrery homeLibrery = new HomeLibrery();
                    homeLibrery.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
            }
        }
        private bool ValidateLogin(string login, string password)
        {
            string connectionString = "server=localhost;user=root;database=library;password=root;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM users WHERE login = @login AND password = @password";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@password", password);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private void Changepass_Click(object sender, EventArgs e)
        {
            ChangePass changePasswordForm = new ChangePass();
            DialogResult result = changePasswordForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                string login = changePasswordForm.login;
                string oldPassword = changePasswordForm.oldPassword;
                string newPassword = changePasswordForm.newPassword;

                if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(oldPassword) && !string.IsNullOrEmpty(newPassword))
                {
                    if (ValidateLogin(login, oldPassword))
                    {
                        if (ChangeUserPassword(login, newPassword))
                        {
                            MessageBox.Show("Пароль успешно изменен");
                        }
                        else
                        {
                            MessageBox.Show("Ошибка при изменении пароля");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пользователь не найден или старый пароль неверен");
                    }
                }
            }
        }
        private bool ChangeUserPassword(string login, string newPassword)
        {
            string connectionString = "server=localhost;user=root;database=library;password=root;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE users SET password = @newPassword WHERE login = @login";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@newPassword", newPassword);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        private void ClosedLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Point lastPoint;
        private void Control_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }

        private void Control_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button_registration_Click(object sender, EventArgs e)
        {
            Form_registration form = new Form_registration();
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK) {
                string login = form.login;
                string password = form.password;
                if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password))
                {
                    SaveUserToDatabase(login, password);
                }
            }
        }
        private void SaveUserToDatabase(string login, string password)
        {
            string connectionString = "server=localhost;user=root;database=library;password=root;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO users (login, password) VALUES (@login, @password)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@password", password);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void LoginText_Enter(object sender, EventArgs e)
        {
            if (LoginText.Text == "Введите логин")
            {
                LoginText.Text = "";
                LoginText.ForeColor = Color.Olive;
            }
        }

        private void LoginText_Leave(object sender, EventArgs e)
        {
            if (LoginText.Text == "")
            {
                LoginText.Text = "Введите логин";
                LoginText.ForeColor = Color.Red;
            }
        }

        private void button_Forgot_password_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm forgotPasswordForm = new ForgotPasswordForm();
            DialogResult result = forgotPasswordForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                string login = forgotPasswordForm.login;
                string newPassword = forgotPasswordForm.password;

                if (UserExists(login))
                {
                    if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(newPassword))
                    {
                        if (ChangeUserPassword(login, newPassword))
                        {
                            MessageBox.Show("Пароль успешно изменен");
                        }
                        else
                        {
                            MessageBox.Show("Ошибка при изменении пароля");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Нет такого пользователя!");
                }
            }
        }
        private bool UserExists(string login)
        {
            string connectionString = "server=localhost;user=root;database=library;password=root;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM users WHERE login = @login";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@login", login);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private void Control_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;database=library;password=root;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM users";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    int userCount = Convert.ToInt32(command.ExecuteScalar());
                    if (userCount > 0)
                    {
                        // Скрыть кнопку регистрации
                        button_registration.Visible = false;
                    }
                }
            }
        }
    }
}
