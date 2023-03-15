namespace Authorization
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LogPanel = new System.Windows.Forms.Panel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.key = new System.Windows.Forms.PictureBox();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.PictureBox();
            this.LogPanel2 = new System.Windows.Forms.Panel();
            this.Nazad = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.LogLabel = new System.Windows.Forms.Label();
            this.LogPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.key)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user)).BeginInit();
            this.LogPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogPanel
            // 
            this.LogPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LogPanel.Controls.Add(this.buttonLogin);
            this.LogPanel.Controls.Add(this.PasswordField);
            this.LogPanel.Controls.Add(this.key);
            this.LogPanel.Controls.Add(this.LoginField);
            this.LogPanel.Controls.Add(this.user);
            this.LogPanel.Controls.Add(this.LogPanel2);
            this.LogPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogPanel.Location = new System.Drawing.Point(0, 0);
            this.LogPanel.Name = "LogPanel";
            this.LogPanel.Size = new System.Drawing.Size(340, 304);
            this.LogPanel.TabIndex = 0;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogin.Font = new System.Drawing.Font("RomanS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.Red;
            this.buttonLogin.Location = new System.Drawing.Point(92, 235);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(149, 40);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "Войти";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // PasswordField
            // 
            this.PasswordField.BackColor = System.Drawing.Color.White;
            this.PasswordField.Font = new System.Drawing.Font("RomanS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordField.ForeColor = System.Drawing.Color.Red;
            this.PasswordField.Location = new System.Drawing.Point(92, 164);
            this.PasswordField.Multiline = true;
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Size = new System.Drawing.Size(211, 50);
            this.PasswordField.TabIndex = 5;
            this.PasswordField.UseSystemPasswordChar = true;
            // 
            // key
            // 
            this.key.Image = ((System.Drawing.Image)(resources.GetObject("key.Image")));
            this.key.Location = new System.Drawing.Point(26, 164);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(60, 50);
            this.key.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.key.TabIndex = 4;
            this.key.TabStop = false;
            // 
            // LoginField
            // 
            this.LoginField.BackColor = System.Drawing.Color.White;
            this.LoginField.Font = new System.Drawing.Font("RomanS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginField.ForeColor = System.Drawing.Color.Red;
            this.LoginField.Location = new System.Drawing.Point(92, 92);
            this.LoginField.Multiline = true;
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(211, 55);
            this.LoginField.TabIndex = 2;
            this.LoginField.TextChanged += new System.EventHandler(this.LoginField_TextChanged);
            // 
            // user
            // 
            this.user.Image = ((System.Drawing.Image)(resources.GetObject("user.Image")));
            this.user.Location = new System.Drawing.Point(26, 92);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(60, 55);
            this.user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user.TabIndex = 1;
            this.user.TabStop = false;
            // 
            // LogPanel2
            // 
            this.LogPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LogPanel2.Controls.Add(this.Nazad);
            this.LogPanel2.Controls.Add(this.exit);
            this.LogPanel2.Controls.Add(this.LogLabel);
            this.LogPanel2.Location = new System.Drawing.Point(0, 0);
            this.LogPanel2.Name = "LogPanel2";
            this.LogPanel2.Size = new System.Drawing.Size(362, 77);
            this.LogPanel2.TabIndex = 0;
            // 
            // Nazad
            // 
            this.Nazad.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Nazad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Nazad.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nazad.ForeColor = System.Drawing.Color.Red;
            this.Nazad.Location = new System.Drawing.Point(3, 3);
            this.Nazad.Name = "Nazad";
            this.Nazad.Size = new System.Drawing.Size(62, 23);
            this.Nazad.TabIndex = 1;
            this.Nazad.Text = "Назад";
            this.Nazad.UseVisualStyleBackColor = true;
            this.Nazad.Click += new System.EventHandler(this.Nazad_Click);
            // 
            // exit
            // 
            this.exit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.ForeColor = System.Drawing.Color.Red;
            this.exit.Location = new System.Drawing.Point(289, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(38, 23);
            this.exit.TabIndex = 0;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseEnter += new System.EventHandler(this.mouse_enter);
            this.exit.MouseLeave += new System.EventHandler(this.mouse_leave);
            // 
            // LogLabel
            // 
            this.LogLabel.AutoSize = true;
            this.LogLabel.Font = new System.Drawing.Font("RomanS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.LogLabel.Location = new System.Drawing.Point(43, 31);
            this.LogLabel.Name = "LogLabel";
            this.LogLabel.Size = new System.Drawing.Size(247, 36);
            this.LogLabel.TabIndex = 0;
            this.LogLabel.Text = "Авторизация";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 304);
            this.Controls.Add(this.LogPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.LogPanel.ResumeLayout(false);
            this.LogPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.key)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user)).EndInit();
            this.LogPanel2.ResumeLayout(false);
            this.LogPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LogPanel;
        private System.Windows.Forms.Panel LogPanel2;
        private System.Windows.Forms.Label LogLabel;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.PictureBox user;
        private System.Windows.Forms.PictureBox key;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button Nazad;
    }
}