namespace Authorization
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.buttonRegister = new System.Windows.Forms.Button();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.key = new System.Windows.Forms.PictureBox();
            this.userSurnameField = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.PictureBox();
            this.LogLabel = new System.Windows.Forms.Label();
            this.LogPanel2 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.RegisterForms = new System.Windows.Forms.Panel();
            this.Perexod = new System.Windows.Forms.Button();
            this.userNameField = new System.Windows.Forms.TextBox();
            this.loginField = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.key)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user)).BeginInit();
            this.LogPanel2.SuspendLayout();
            this.RegisterForms.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRegister.Font = new System.Drawing.Font("Complex", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegister.ForeColor = System.Drawing.Color.Maroon;
            this.buttonRegister.Location = new System.Drawing.Point(150, 194);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(292, 40);
            this.buttonRegister.TabIndex = 6;
            this.buttonRegister.Text = "Зарегистрироваться";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // PasswordField
            // 
            this.PasswordField.BackColor = System.Drawing.Color.White;
            this.PasswordField.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordField.ForeColor = System.Drawing.Color.Black;
            this.PasswordField.Location = new System.Drawing.Point(355, 133);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Size = new System.Drawing.Size(193, 34);
            this.PasswordField.TabIndex = 5;
            this.PasswordField.Enter += new System.EventHandler(this.PasswordField_Enter);
            this.PasswordField.Leave += new System.EventHandler(this.PasswordField_Leave);
            // 
            // key
            // 
            this.key.Image = ((System.Drawing.Image)(resources.GetObject("key.Image")));
            this.key.Location = new System.Drawing.Point(276, 93);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(73, 75);
            this.key.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.key.TabIndex = 4;
            this.key.TabStop = false;
            // 
            // userSurnameField
            // 
            this.userSurnameField.BackColor = System.Drawing.Color.White;
            this.userSurnameField.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSurnameField.ForeColor = System.Drawing.Color.Black;
            this.userSurnameField.Location = new System.Drawing.Point(91, 135);
            this.userSurnameField.Name = "userSurnameField";
            this.userSurnameField.Size = new System.Drawing.Size(179, 34);
            this.userSurnameField.TabIndex = 2;
            this.userSurnameField.Enter += new System.EventHandler(this.userSurnameField_Enter);
            this.userSurnameField.Leave += new System.EventHandler(this.userSurnameField_Leave);
            // 
            // user
            // 
            this.user.Image = ((System.Drawing.Image)(resources.GetObject("user.Image")));
            this.user.Location = new System.Drawing.Point(12, 93);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(73, 75);
            this.user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user.TabIndex = 1;
            this.user.TabStop = false;
            // 
            // LogLabel
            // 
            this.LogLabel.AutoSize = true;
            this.LogLabel.Font = new System.Drawing.Font("Complex", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.LogLabel.Location = new System.Drawing.Point(153, 21);
            this.LogLabel.Name = "LogLabel";
            this.LogLabel.Size = new System.Drawing.Size(277, 46);
            this.LogLabel.TabIndex = 0;
            this.LogLabel.Text = "Регистрация";
            this.LogLabel.Click += new System.EventHandler(this.LogLabel_Click);
            // 
            // LogPanel2
            // 
            this.LogPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.LogPanel2.Controls.Add(this.exit);
            this.LogPanel2.Controls.Add(this.LogLabel);
            this.LogPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogPanel2.Location = new System.Drawing.Point(0, 0);
            this.LogPanel2.Name = "LogPanel2";
            this.LogPanel2.Size = new System.Drawing.Size(560, 77);
            this.LogPanel2.TabIndex = 0;
            // 
            // exit
            // 
            this.exit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.ForeColor = System.Drawing.Color.Red;
            this.exit.Location = new System.Drawing.Point(519, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(38, 23);
            this.exit.TabIndex = 0;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // RegisterForms
            // 
            this.RegisterForms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.RegisterForms.Controls.Add(this.Perexod);
            this.RegisterForms.Controls.Add(this.userNameField);
            this.RegisterForms.Controls.Add(this.loginField);
            this.RegisterForms.Controls.Add(this.buttonRegister);
            this.RegisterForms.Controls.Add(this.PasswordField);
            this.RegisterForms.Controls.Add(this.key);
            this.RegisterForms.Controls.Add(this.userSurnameField);
            this.RegisterForms.Controls.Add(this.user);
            this.RegisterForms.Controls.Add(this.LogPanel2);
            this.RegisterForms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegisterForms.Location = new System.Drawing.Point(0, 0);
            this.RegisterForms.Name = "RegisterForms";
            this.RegisterForms.Size = new System.Drawing.Size(560, 298);
            this.RegisterForms.TabIndex = 1;
            this.RegisterForms.Paint += new System.Windows.Forms.PaintEventHandler(this.RegisterForms_Paint);
            this.RegisterForms.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegisterForms_MouseDown);
            this.RegisterForms.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseMove);
            // 
            // Perexod
            // 
            this.Perexod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Perexod.Font = new System.Drawing.Font("Complex", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Perexod.Location = new System.Drawing.Point(125, 240);
            this.Perexod.Name = "Perexod";
            this.Perexod.Size = new System.Drawing.Size(338, 34);
            this.Perexod.TabIndex = 9;
            this.Perexod.Text = "Уже зарегистрированы? Войти";
            this.Perexod.UseVisualStyleBackColor = false;
            this.Perexod.Click += new System.EventHandler(this.Perexod_Click);
            // 
            // userNameField
            // 
            this.userNameField.BackColor = System.Drawing.Color.White;
            this.userNameField.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameField.ForeColor = System.Drawing.Color.Black;
            this.userNameField.Location = new System.Drawing.Point(91, 93);
            this.userNameField.Name = "userNameField";
            this.userNameField.Size = new System.Drawing.Size(179, 34);
            this.userNameField.TabIndex = 8;
            this.userNameField.Enter += new System.EventHandler(this.userNameField_Enter);
            this.userNameField.Leave += new System.EventHandler(this.userNameField_Leave);
            // 
            // loginField
            // 
            this.loginField.BackColor = System.Drawing.Color.White;
            this.loginField.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginField.ForeColor = System.Drawing.Color.Black;
            this.loginField.Location = new System.Drawing.Point(355, 93);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(193, 34);
            this.loginField.TabIndex = 7;
            this.loginField.Enter += new System.EventHandler(this.loginField_Enter);
            this.loginField.Leave += new System.EventHandler(this.loginField_Leave);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 298);
            this.Controls.Add(this.RegisterForms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.key)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user)).EndInit();
            this.LogPanel2.ResumeLayout(false);
            this.LogPanel2.PerformLayout();
            this.RegisterForms.ResumeLayout(false);
            this.RegisterForms.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.PictureBox key;
        private System.Windows.Forms.TextBox userSurnameField;
        private System.Windows.Forms.PictureBox user;
        private System.Windows.Forms.Label LogLabel;
        private System.Windows.Forms.Panel LogPanel2;
        private System.Windows.Forms.Panel RegisterForms;
        private System.Windows.Forms.TextBox userNameField;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button Perexod;
    }
}