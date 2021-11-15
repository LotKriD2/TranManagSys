using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TranManagSysLibrary.User;
using static TranManagSysLibrary.DBConnection;

namespace WindowsForms
{
    public partial class AthorizationForm : Form
    {
        public AthorizationForm()
        {
            InitializeComponent();
        }
        private void ButtonSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                string login = textBoxLogin.Text;
                string password = textBoxPassword.Text;
                string city = comboBoxCities.SelectedItem.ToString();
                if (password == "")
                    password = "empty";
                if (login == "")
                    password = "Guest";
                Athorization(login, password, city);
                if (AccessLevel != TranManagSysLibrary.AccessLevel.none)
                    Form.ActiveForm.Close();
                else
                    MessageBox.Show("Не удалось войти в систему", "Ошибка авторизации");
            }
            catch (Exception)
            {
                MessageBox.Show("Неверный ввод", "Ошибка");
            }
        }

        private void AthorizationForm_Load(object sender, EventArgs e)
        {
            Connection();
            List<string[]> cities = GetCities();
            for (int i = 0; i < cities.Count; i++)
                comboBoxCities.Items.Add(cities[i][1]);
        }

        private void администраторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxLogin.Text = "Admin";
            textBoxPassword.Text = "admin";
        }

        private void пользовательToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxLogin.Text = "User";
            textBoxPassword.Text = "user";
        }

        private void гостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxLogin.Text = "Guest";
            textBoxPassword.Text = "";
        }
    }
}
