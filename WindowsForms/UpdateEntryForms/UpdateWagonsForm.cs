using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TranManagSysLibrary.DBConnection;
using static TranManagSysLibrary.Data;

namespace WindowsForms.UpdateEntryForms
{
    public partial class UpdateWagonsForm : Form
    {
        public UpdateWagonsForm()
        {
            InitializeComponent();
            textBoxID.Text = ID.ToString();
            textBoxID.Enabled = false;
            textBoxWagon.Text = ValueColumns[1];
            textBoxNumSeats.Text = ValueColumns[2];
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxWagon.Text != "" && textBoxNumSeats.Text != "")
            {
                ValueColumns = new List<string>() { textBoxID.Text, textBoxWagon.Text,
               textBoxNumSeats.Text };
                CreateConditionForUpdate();
                UpdateEntry(NameTable, Condition);
                Form.ActiveForm.Close();
            }
            else
                MessageBox.Show("Незаполнены данные.", "Ошибка", MessageBoxButtons.OK);
        }
    }
}
