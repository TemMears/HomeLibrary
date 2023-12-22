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
    public partial class Author : Form
    {
        public Author()
        {
            InitializeComponent();
            button_AuthorInput.Text = "Введите автора";
            textBox_Author.MaxLength = 40;

            this.AcceptButton = button_AuthorInput;
        }

        private void button_AuthorInput_Enter(object sender, EventArgs e)
        {
            if (button_AuthorInput.Text == "Введите автора")
            {
                button_AuthorInput.Text = "";
                button_AuthorInput.ForeColor = Color.Olive;
            }
        }

        private void button_AuthorInput_Leave(object sender, EventArgs e)
        {
            if (button_AuthorInput.Text == "")
            {
                button_AuthorInput.Text = "Введите автора";
                button_AuthorInput.ForeColor = Color.Red;
            }
        }
        Point lastPoint;
        private void Author_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }

        private void Author_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
