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
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
            textBox_NewPass.Text = "Введите новый пароль";
            textBox_OldPass.Text = "Введите старый пароль";
            textBox_login.Text = "Введите логин";
            this.AcceptButton = change;
            textBox_OldPass.MaxLength = 40;
        }

        private void change_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_login.Text) && !string.IsNullOrEmpty(textBox_OldPass.Text) && !string.IsNullOrEmpty(textBox_NewPass.Text))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите значения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string login
        {
            get { return textBox_login.Text; }
        }
        public string oldPassword
        {
            get { return textBox_OldPass.Text; }
        }
        public string newPassword
        {
            get { return textBox_NewPass.Text; }
        }
        private void textBox_OldPass_Enter(object sender, EventArgs e)
        {
            if (textBox_OldPass.Text == "Введите старый пароль")
            {
                textBox_OldPass.Text = "";
                textBox_OldPass.ForeColor = Color.Olive;
            }
        }

        private void textBox_OldPass_Leave(object sender, EventArgs e)
        {
            if (textBox_OldPass.Text == "")
            {
                textBox_OldPass.Text = "Введите старый пароль";
                textBox_OldPass.ForeColor = Color.Red;
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

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point lastPoint;
        private void ChangePass_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }

        private void ChangePass_MouseDown(object sender, MouseEventArgs e)
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
    }
}
