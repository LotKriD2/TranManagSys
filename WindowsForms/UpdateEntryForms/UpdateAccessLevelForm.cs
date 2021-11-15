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
    public partial class UpdateAccessLevelForm : Form
    {
        public UpdateAccessLevelForm()
        {
            InitializeComponent();
            textBoxID.Text = ID.ToString();
            textBoxID.Enabled = false;
            textBoxAccess.Text = ValueColumns[1];
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxAccess.Text != "")
            {
                ValueColumns = new List<string>() { textBoxID.Text, textBoxAccess.Text };
                CreateConditionForUpdate();
                UpdateEntry(NameTable, Condition);
                Form.ActiveForm.Close();
            }
            else
                MessageBox.Show("Незаполнены данные.", "Ошибка", MessageBoxButtons.OK);
        }
    }
}
