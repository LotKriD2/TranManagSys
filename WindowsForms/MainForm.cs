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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            Form form = new AthorizationForm();
            form.ShowDialog();
            if (!AuthorizationSuccessful)
            {
                CloseConnection();
                Application.Exit();
            }
            labelUser.Text = Login;
            
        }
    }
}
