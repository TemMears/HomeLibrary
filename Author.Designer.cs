namespace п2
{
    partial class Author
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Author));
            this.textBox_Author = new System.Windows.Forms.TextBox();
            this.button_AuthorInput = new System.Windows.Forms.Button();
            this.label_Input = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Author
            // 
            this.textBox_Author.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textBox_Author.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Author.Location = new System.Drawing.Point(42, 58);
            this.textBox_Author.Name = "textBox_Author";
            this.textBox_Author.Size = new System.Drawing.Size(300, 48);
            this.textBox_Author.TabIndex = 0;
            this.textBox_Author.Enter += new System.EventHandler(this.button_AuthorInput_Enter);
            this.textBox_Author.Leave += new System.EventHandler(this.button_AuthorInput_Leave);
            // 
            // button_AuthorInput
            // 
            this.button_AuthorInput.BackColor = System.Drawing.Color.OliveDrab;
            this.button_AuthorInput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_AuthorInput.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AuthorInput.Location = new System.Drawing.Point(123, 130);
            this.button_AuthorInput.Name = "button_AuthorInput";
            this.button_AuthorInput.Size = new System.Drawing.Size(117, 34);
            this.button_AuthorInput.TabIndex = 1;
            this.button_AuthorInput.Text = "Ввести";
            this.button_AuthorInput.UseVisualStyleBackColor = false;
            // 
            // label_Input
            // 
            this.label_Input.AutoSize = true;
            this.label_Input.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Input.Location = new System.Drawing.Point(99, 9);
            this.label_Input.Name = "label_Input";
            this.label_Input.Size = new System.Drawing.Size(174, 31);
            this.label_Input.TabIndex = 2;
            this.label_Input.Text = "Введите автора";
            // 
            // Author
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(372, 176);
            this.Controls.Add(this.label_Input);
            this.Controls.Add(this.button_AuthorInput);
            this.Controls.Add(this.textBox_Author);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Author";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Author_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Author_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Author;
        private System.Windows.Forms.Button button_AuthorInput;
        private System.Windows.Forms.Label label_Input;
    }
}