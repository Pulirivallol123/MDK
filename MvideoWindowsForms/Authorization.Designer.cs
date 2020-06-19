namespace MvideoWindowsForms
{
    partial class Authorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.lblUser_Login = new System.Windows.Forms.Label();
            this.tbUser_Login = new System.Windows.Forms.TextBox();
            this.lbl_User_Password = new System.Windows.Forms.Label();
            this.tbUser_Password = new System.Windows.Forms.TextBox();
            this.btEnter = new System.Windows.Forms.Button();
            this.btLeave = new System.Windows.Forms.Button();
            this.btRegistration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUser_Login
            // 
            this.lblUser_Login.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUser_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUser_Login.Location = new System.Drawing.Point(0, 0);
            this.lblUser_Login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser_Login.Name = "lblUser_Login";
            this.lblUser_Login.Size = new System.Drawing.Size(800, 32);
            this.lblUser_Login.TabIndex = 7;
            this.lblUser_Login.Text = "Логин";
            this.lblUser_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbUser_Login
            // 
            this.tbUser_Login.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbUser_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUser_Login.Location = new System.Drawing.Point(0, 32);
            this.tbUser_Login.Margin = new System.Windows.Forms.Padding(4);
            this.tbUser_Login.Name = "tbUser_Login";
            this.tbUser_Login.PasswordChar = '*';
            this.tbUser_Login.Size = new System.Drawing.Size(800, 38);
            this.tbUser_Login.TabIndex = 8;
            this.tbUser_Login.Text = "Ivanov";
            this.tbUser_Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_User_Password
            // 
            this.lbl_User_Password.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_User_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_User_Password.Location = new System.Drawing.Point(0, 70);
            this.lbl_User_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_User_Password.Name = "lbl_User_Password";
            this.lbl_User_Password.Size = new System.Drawing.Size(800, 32);
            this.lbl_User_Password.TabIndex = 9;
            this.lbl_User_Password.Text = "Пароль";
            this.lbl_User_Password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbUser_Password
            // 
            this.tbUser_Password.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbUser_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUser_Password.Location = new System.Drawing.Point(0, 102);
            this.tbUser_Password.Margin = new System.Windows.Forms.Padding(4);
            this.tbUser_Password.Name = "tbUser_Password";
            this.tbUser_Password.PasswordChar = '*';
            this.tbUser_Password.Size = new System.Drawing.Size(800, 38);
            this.tbUser_Password.TabIndex = 10;
            this.tbUser_Password.Text = "Qwerty1";
            this.tbUser_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btEnter
            // 
            this.btEnter.Dock = System.Windows.Forms.DockStyle.Left;
            this.btEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btEnter.Location = new System.Drawing.Point(0, 140);
            this.btEnter.Margin = new System.Windows.Forms.Padding(4);
            this.btEnter.Name = "btEnter";
            this.btEnter.Size = new System.Drawing.Size(265, 310);
            this.btEnter.TabIndex = 11;
            this.btEnter.Text = "Вход";
            this.btEnter.UseVisualStyleBackColor = true;
            this.btEnter.Click += new System.EventHandler(this.button1_Click);
            // 
            // btLeave
            // 
            this.btLeave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btLeave.Location = new System.Drawing.Point(530, 140);
            this.btLeave.Margin = new System.Windows.Forms.Padding(4);
            this.btLeave.Name = "btLeave";
            this.btLeave.Size = new System.Drawing.Size(270, 310);
            this.btLeave.TabIndex = 12;
            this.btLeave.Text = "Выход";
            this.btLeave.UseVisualStyleBackColor = true;
            this.btLeave.Click += new System.EventHandler(this.BtLeave_Click);
            // 
            // btRegistration
            // 
            this.btRegistration.Dock = System.Windows.Forms.DockStyle.Left;
            this.btRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btRegistration.Location = new System.Drawing.Point(265, 140);
            this.btRegistration.Margin = new System.Windows.Forms.Padding(4);
            this.btRegistration.Name = "btRegistration";
            this.btRegistration.Size = new System.Drawing.Size(265, 310);
            this.btRegistration.TabIndex = 13;
            this.btRegistration.Text = "Зарегистрироваться";
            this.btRegistration.UseVisualStyleBackColor = true;
            this.btRegistration.Click += new System.EventHandler(this.btRegistration_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btRegistration);
            this.Controls.Add(this.btLeave);
            this.Controls.Add(this.btEnter);
            this.Controls.Add(this.tbUser_Password);
            this.Controls.Add(this.lbl_User_Password);
            this.Controls.Add(this.tbUser_Login);
            this.Controls.Add(this.lblUser_Login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Authorization";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUser_Login;
        private System.Windows.Forms.TextBox tbUser_Login;
        private System.Windows.Forms.Label lbl_User_Password;
        private System.Windows.Forms.TextBox tbUser_Password;
        private System.Windows.Forms.Button btEnter;
        private System.Windows.Forms.Button btLeave;
        private System.Windows.Forms.Button btRegistration;
    }
}

