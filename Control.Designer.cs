namespace п2
{
    partial class Control
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control));
            this.Changepass = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Pass = new System.Windows.Forms.TextBox();
            this.label_InputPass = new System.Windows.Forms.Label();
            this.Enteringpass = new System.Windows.Forms.Button();
            this.ClosedLabel = new System.Windows.Forms.Label();
            this.button_registration = new System.Windows.Forms.Button();
            this.button_Forgot_password = new System.Windows.Forms.Button();
            this.LoginText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Changepass
            // 
            this.Changepass.BackColor = System.Drawing.Color.Cornsilk;
            this.Changepass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Changepass.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Changepass.Location = new System.Drawing.Point(95, 280);
            this.Changepass.Name = "Changepass";
            this.Changepass.Size = new System.Drawing.Size(164, 37);
            this.Changepass.TabIndex = 1;
            this.Changepass.Text = "Сменить пароль";
            this.Changepass.UseVisualStyleBackColor = false;
            this.Changepass.Click += new System.EventHandler(this.Changepass_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(373, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(415, 359);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Pass
            // 
            this.Pass.BackColor = System.Drawing.Color.Cornsilk;
            this.Pass.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass.Location = new System.Drawing.Point(54, 155);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(267, 43);
            this.Pass.TabIndex = 6;
            this.Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Pass.Enter += new System.EventHandler(this.Parol_Enter);
            this.Pass.Leave += new System.EventHandler(this.Parol_Leave);
            // 
            // label_InputPass
            // 
            this.label_InputPass.AutoSize = true;
            this.label_InputPass.BackColor = System.Drawing.Color.YellowGreen;
            this.label_InputPass.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InputPass.Location = new System.Drawing.Point(58, 49);
            this.label_InputPass.Name = "label_InputPass";
            this.label_InputPass.Size = new System.Drawing.Size(274, 35);
            this.label_InputPass.TabIndex = 7;
            this.label_InputPass.Text = "Введите логин и пароль:";
            // 
            // Enteringpass
            // 
            this.Enteringpass.BackColor = System.Drawing.Color.Cornsilk;
            this.Enteringpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Enteringpass.FlatAppearance.BorderSize = 0;
            this.Enteringpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enteringpass.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enteringpass.Location = new System.Drawing.Point(95, 215);
            this.Enteringpass.Name = "Enteringpass";
            this.Enteringpass.Size = new System.Drawing.Size(164, 37);
            this.Enteringpass.TabIndex = 8;
            this.Enteringpass.Text = "Войти";
            this.Enteringpass.UseVisualStyleBackColor = false;
            this.Enteringpass.Click += new System.EventHandler(this.Enteringpass_Click);
            // 
            // ClosedLabel
            // 
            this.ClosedLabel.AutoSize = true;
            this.ClosedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClosedLabel.Location = new System.Drawing.Point(765, 9);
            this.ClosedLabel.Name = "ClosedLabel";
            this.ClosedLabel.Size = new System.Drawing.Size(23, 22);
            this.ClosedLabel.TabIndex = 9;
            this.ClosedLabel.Text = "Х";
            this.ClosedLabel.Click += new System.EventHandler(this.ClosedLabel_Click);
            // 
            // button_registration
            // 
            this.button_registration.BackColor = System.Drawing.Color.Cornsilk;
            this.button_registration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_registration.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_registration.Location = new System.Drawing.Point(95, 391);
            this.button_registration.Name = "button_registration";
            this.button_registration.Size = new System.Drawing.Size(164, 37);
            this.button_registration.TabIndex = 10;
            this.button_registration.Text = "Регистрация";
            this.button_registration.UseVisualStyleBackColor = false;
            this.button_registration.Click += new System.EventHandler(this.button_registration_Click);
            // 
            // button_Forgot_password
            // 
            this.button_Forgot_password.BackColor = System.Drawing.Color.Cornsilk;
            this.button_Forgot_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Forgot_password.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Forgot_password.Location = new System.Drawing.Point(95, 336);
            this.button_Forgot_password.Name = "button_Forgot_password";
            this.button_Forgot_password.Size = new System.Drawing.Size(164, 37);
            this.button_Forgot_password.TabIndex = 11;
            this.button_Forgot_password.Text = "Забыл пароль";
            this.button_Forgot_password.UseVisualStyleBackColor = false;
            this.button_Forgot_password.Click += new System.EventHandler(this.button_Forgot_password_Click);
            // 
            // LoginText
            // 
            this.LoginText.BackColor = System.Drawing.Color.Cornsilk;
            this.LoginText.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginText.Location = new System.Drawing.Point(54, 106);
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(267, 43);
            this.LoginText.TabIndex = 12;
            this.LoginText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoginText.Enter += new System.EventHandler(this.LoginText_Enter);
            this.LoginText.Leave += new System.EventHandler(this.LoginText_Leave);
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoginText);
            this.Controls.Add(this.button_Forgot_password);
            this.Controls.Add(this.button_registration);
            this.Controls.Add(this.ClosedLabel);
            this.Controls.Add(this.Enteringpass);
            this.Controls.Add(this.label_InputPass);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Changepass);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Control";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Домашняя библиотека";
            this.Load += new System.EventHandler(this.Control_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Changepass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.Label label_InputPass;
        private System.Windows.Forms.Button Enteringpass;
        private System.Windows.Forms.Label ClosedLabel;
        private System.Windows.Forms.Button button_registration;
        private System.Windows.Forms.Button button_Forgot_password;
        private System.Windows.Forms.TextBox LoginText;
    }
}

