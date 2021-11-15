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
    public partial class UpdateUserForm : Form
    {
        Dictionary<string, int> accessLevelDict;
        public UpdateUserForm()
        {
            InitializeComponent();
            textBoxID.Text = ID.ToString();
            textBoxID.Enabled = false;
            textBoxLogin.Text = ValueColumns[1];
            textBoxPassword.Text = ValueColumns[2];
            accessLevelDict = new Dictionary<string, int>();
            DataSet dataSet = GetTable("Права_доступа");
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                comboBoxAccessLevel.Items.Add(dataSet.Tables[0].Rows[i][1].ToString());
                accessLevelDict.Add(dataSet.Tables[0].Rows[i][1].ToString(), int.Parse(dataSet.Tables[0].Rows[i][0].ToString()));
                if (dataSet.Tables[0].Rows[i][0].ToString() == ValueColumns[3])
                    comboBoxAccessLevel.Text = dataSet.Tables[0].Rows[i][1].ToString();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text != "")
            {
                ValueColumns = new List<string>() { textBoxID.Text, textBoxLogin.Text,
               textBoxPassword.Text, accessLevelDict[comboBoxAccessLevel.Text].ToString() };
                CreateConditionForUpdate();
                UpdateEntry(NameTable, Condition);
                Form.ActiveForm.Close();
            }
            else
                MessageBox.Show("Незаполнены данные.", "Ошибка", MessageBoxButtons.OK);
        }
    }
}
