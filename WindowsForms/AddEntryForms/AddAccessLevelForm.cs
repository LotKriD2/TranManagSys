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

namespace WindowsForms.AddEntryForms
{
    public partial class AddAccessLevelForm : Form
    {
        public AddAccessLevelForm()
        {
            InitializeComponent();
            textBoxID.Text = ID.ToString();
            textBoxID.Enabled = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxAccess.Text != "")
            {
                ValueColumns = new List<string>() { textBoxID.Text, textBoxAccess.Text };
                CreateConditionForAdd();
                AddEntry(NameTable, Condition);
                Form.ActiveForm.Close();
            }
            else
                MessageBox.Show("Незаполнены данные.", "Ошибка", MessageBoxButtons.OK);
        }
    }
}
