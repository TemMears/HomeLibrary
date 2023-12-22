using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace п2
{
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
            textBox_login.Text = "Введите логин";
            textBox_NewPass.Text = "Введите новый пароль";
            textBox_login.MaxLength = 40;
            textBox_NewPass.MaxLength = 40;
        }

        private void change_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_login.Text) && !string.IsNullOrEmpty(textBox_NewPass.Text))
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
            get { return textBox_login.Text; }
        }
        public string password
        {
            get { return textBox_NewPass.Text; }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Point lastPoint;
        private void ForgotPasswordForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }

        private void ForgotPasswordForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void textBox_login_Enter(object sender, EventArgs e)
        {
            if (textBox_login.Text == "Введите логин")
            {
                textBox_login.Text = "";
                textBox_login.ForeColor = Color.Olive;
            }
        }

        private void textBox_login_Leave(object sender, EventArgs e)
        {
            if (textBox_login.Text == "")
            {
                textBox_login.Text = "Введите логин";
                textBox_login.ForeColor = Color.Red;
            }
        }

        private void textBox_NewPass_Enter(object sender, EventArgs e)
        {
            if (textBox_NewPass.Text == "Введите новый пароль")
            {
                textBox_NewPass.Text = "";
                textBox_NewPass.ForeColor = Color.Olive;
            }
        }

        private void textBox_NewPass_Leave(object sender, EventArgs e)
        {
            if (textBox_NewPass.Text == "")
            {
                textBox_NewPass.Text = "Введите новый пароль";
                textBox_NewPass.ForeColor = Color.Red;
            }
        }
    }
}
