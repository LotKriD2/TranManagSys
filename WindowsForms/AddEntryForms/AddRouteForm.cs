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
    public partial class AddRouteForm : Form
    {
        Dictionary<string, int> cityDict;
        public AddRouteForm()
        {
            InitializeComponent();
            textBoxID.Text = ID.ToString();
            textBoxID.Enabled = false;
            cityDict = new Dictionary<string, int>();
            DataSet dataSet = GetTable("Города");
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                comboBoxRoutePoint.Items.Add(dataSet.Tables[0].Rows[i][1].ToString());
                cityDict.Add(dataSet.Tables[0].Rows[i][1].ToString(), int.Parse(dataSet.Tables[0].Rows[i][0].ToString()));
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (listBoxRoute.Items.Count != 0)
            {
                string route = "";
                foreach (string item in listBoxRoute.Items)
                    route += cityDict[item] + "-";
                route = route.Remove(route.Length - 1);
                ValueColumns = new List<string>() { textBoxID.Text, route };
                CreateConditionForAdd();
                AddEntry(NameTable, Condition);
                Form.ActiveForm.Close();
            }
            else
                MessageBox.Show("Незаполнены данные.", "Ошибка", MessageBoxButtons.OK);
        }

        private void buttonAddRoutePoint_Click(object sender, EventArgs e)
        {
            if (comboBoxRoutePoint.Text != "")
                listBoxRoute.Items.Add(comboBoxRoutePoint.Text);
        }

        private void buttonDeleteRoutePoint_Click(object sender, EventArgs e)
        {
            if (listBoxRoute.Items.Count > 0)
                listBoxRoute.Items.Remove(listBoxRoute.Items[listBoxRoute.Items.Count - 1]);
        }
    }
}
