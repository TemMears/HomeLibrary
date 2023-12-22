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
    public partial class Form_registration : Form
    {
        public Form_registration()
        {
            InitializeComponent();
            Login.Text = "Введите логин";
            Pass.Text = "Введите пароль";
            Login.MaxLength = 40;
            Pass.MaxLength = 40;
        }


        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            // Проверяем, что введено имя автора
            if (!string.IsNullOrEmpty(Login.Text) && !string.IsNullOrEmpty(Pass.Text))
            {
                // Закрываем форму с результатом DialogResult.OK
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите логин и пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string login
        {
            get { return Login.Text; }
        }
        public string password
        {
            get { return Pass.Text; }
        }

        private void Login_Enter(object sender, EventArgs e)
        {
            if (Login.Text == "Введите логин")
            {
                Login.Text = "";
                Login.ForeColor = Color.Olive;
            }
        }

        private void Login_Leave(object sender, EventArgs e)
        {
            if (Login.Text == "")
            {
                Login.Text = "Введите логин";
                Login.ForeColor = Color.Red;
            }
        }

        private void Pass_Enter(object sender, EventArgs e)
        {
            if (Pass.Text == "Введите пароль")
            {
                Pass.Text = "";
                Pass.ForeColor = Color.Olive;
            }
        }

        private void Pass_Leave(object sender, EventArgs e)
        {
            if (Pass.Text == "")
            {
                Pass.Text = "Введите пароль";
                Pass.ForeColor = Color.Red;
            }
        }
        Point lastPoint;

        private void panel_reg_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }

        private void panel_reg_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
