
namespace WindowsForms
{
    partial class AthorizationForm
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
            this.comboBoxCities = new System.Windows.Forms.ComboBox();
            this.ButtonSignIn = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.профилиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.администраторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользовательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxCities
            // 
            this.comboBoxCities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCities.FormattingEnabled = true;
            this.comboBoxCities.Location = new System.Drawing.Point(151, 3);
            this.comboBoxCities.Name = "comboBoxCities";
            this.comboBoxCities.Size = new System.Drawing.Size(133, 21);
            this.comboBoxCities.TabIndex = 13;
            // 
            // ButtonSignIn
            // 
            this.ButtonSignIn.Location = new System.Drawing.Point(33, 140);
            this.ButtonSignIn.Name = "ButtonSignIn";
            this.ButtonSignIn.Size = new System.Drawing.Size(227, 37);
            this.ButtonSignIn.TabIndex = 12;
            this.ButtonSignIn.Text = "Войти";
            this.ButtonSignIn.UseVisualStyleBackColor = true;
            this.ButtonSignIn.Click += new System.EventHandler(this.ButtonSignIn_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(75, 98);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(185, 20);
            this.textBoxPassword.TabIndex = 11;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(75, 68);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(185, 20);
            this.textBoxLogin.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Пароль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Логин:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.профилиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // профилиToolStripMenuItem
            // 
            this.профилиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.администраторToolStripMenuItem,
            this.пользовательToolStripMenuItem,
            this.гостьToolStripMenuItem});
            this.профилиToolStripMenuItem.Name = "профилиToolStripMenuItem";
            this.профилиToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.профилиToolStripMenuItem.Text = "Профили";
            // 
            // администраторToolStripMenuItem
            // 
            this.администраторToolStripMenuItem.Name = "администраторToolStripMenuItem";
            this.администраторToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.администраторToolStripMenuItem.Text = "Администратор";
            this.администраторToolStripMenuItem.Click += new System.EventHandler(this.администраторToolStripMenuItem_Click);
            // 
            // пользовательToolStripMenuItem
            // 
            this.пользовательToolStripMenuItem.Name = "пользовательToolStripMenuItem";
            this.пользовательToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.пользовательToolStripMenuItem.Text = "Пользователь";
            this.пользовательToolStripMenuItem.Click += new System.EventHandler(this.пользовательToolStripMenuItem_Click);
            // 
            // гостьToolStripMenuItem
            // 
            this.гостьToolStripMenuItem.Name = "гостьToolStripMenuItem";
            this.гостьToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.гостьToolStripMenuItem.Text = "Гость";
            this.гостьToolStripMenuItem.Click += new System.EventHandler(this.гостьToolStripMenuItem_Click);
            // 
            // AthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.comboBoxCities);
            this.Controls.Add(this.ButtonSignIn);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "AthorizationForm";
            this.Text = "AthorizationForm";
            this.Load += new System.EventHandler(this.AthorizationForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCities;
        private System.Windows.Forms.Button ButtonSignIn;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem профилиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem администраторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользовательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гостьToolStripMenuItem;
    }
}