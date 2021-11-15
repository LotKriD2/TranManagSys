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
    public partial class UpdateCityForm : Form
    {
        public UpdateCityForm()
        {
            InitializeComponent();
            textBoxID.Text = ID.ToString();
            textBoxID.Enabled = false;
            textBoxCity.Text = ValueColumns[1];
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxCity.Text != "")
            {
                ValueColumns = new List<string>() { textBoxID.Text, textBoxCity.Text };
                CreateConditionForUpdate();
                UpdateEntry(NameTable, Condition);
                Form.ActiveForm.Close();
            }
            else
                MessageBox.Show("Незаполнены данные.", "Ошибка", MessageBoxButtons.OK);
        }
    }
}
