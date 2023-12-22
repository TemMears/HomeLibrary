namespace п2
{
    partial class ChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePass));
            this.change = new System.Windows.Forms.Button();
            this.textBox_OldPass = new System.Windows.Forms.TextBox();
            this.textBox_NewPass = new System.Windows.Forms.TextBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // change
            // 
            this.change.BackColor = System.Drawing.Color.OliveDrab;
            this.change.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.change.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.change.Location = new System.Drawing.Point(76, 291);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(138, 44);
            this.change.TabIndex = 2;
            this.change.Text = "Сменить пароль";
            this.change.UseVisualStyleBackColor = false;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // textBox_OldPass
            // 
            this.textBox_OldPass.BackColor = System.Drawing.Color.Cornsilk;
            this.textBox_OldPass.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_OldPass.Location = new System.Drawing.Point(12, 156);
            this.textBox_OldPass.Name = "textBox_OldPass";
            this.textBox_OldPass.Size = new System.Drawing.Size(276, 43);
            this.textBox_OldPass.TabIndex = 3;
            this.textBox_OldPass.Enter += new System.EventHandler(this.textBox_OldPass_Enter);
            this.textBox_OldPass.Leave += new System.EventHandler(this.textBox_OldPass_Leave);
            // 
            // textBox_NewPass
            // 
            this.textBox_NewPass.BackColor = System.Drawing.Color.Cornsilk;
            this.textBox_NewPass.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NewPass.Location = new System.Drawing.Point(12, 223);
            this.textBox_NewPass.Name = "textBox_NewPass";
            this.textBox_NewPass.Size = new System.Drawing.Size(276, 43);
            this.textBox_NewPass.TabIndex = 5;
            this.textBox_NewPass.Enter += new System.EventHandler(this.textBox_NewPass_Enter);
            this.textBox_NewPass.Leave += new System.EventHandler(this.textBox_NewPass_Leave);
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.OliveDrab;
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Cancel.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Cancel.Location = new System.Drawing.Point(76, 341);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(138, 44);
            this.button_Cancel.TabIndex = 6;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // textBox_login
            // 
            this.textBox_login.BackColor = System.Drawing.Color.Cornsilk;
            this.textBox_login.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_login.Location = new System.Drawing.Point(12, 89);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(276, 43);
            this.textBox_login.TabIndex = 7;
            this.textBox_login.Enter += new System.EventHandler(this.textBox_login_Enter);
            this.textBox_login.Leave += new System.EventHandler(this.textBox_login_Leave);
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(300, 397);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.textBox_NewPass);
            this.Controls.Add(this.textBox_OldPass);
            this.Controls.Add(this.change);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePass";
            this.Text = "Сменить пароль";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChangePass_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangePass_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.TextBox textBox_OldPass;
        private System.Windows.Forms.TextBox textBox_NewPass;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.TextBox textBox_login;
    }
}