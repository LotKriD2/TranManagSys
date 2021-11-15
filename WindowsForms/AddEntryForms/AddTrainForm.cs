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
    public partial class AddTrainForm : Form
    {
        Dictionary<string, string> routesDict;
        Dictionary<string, string> compositDict;
        public AddTrainForm()
        {
            InitializeComponent();
            textBoxID.Text = ID.ToString();
            textBoxID.Enabled = false;
            textBoxNumSeats.Text = "0";
            textBoxNumSeats.Enabled = false;
            routesDict = new Dictionary<string, string>();
            compositDict = new Dictionary<string, string>();
            DataSet dataSet = GetTable("Маршруты");
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                comboBoxRouts.Items.Add(dataSet.Tables[0].Rows[i][0].ToString());
                routesDict.Add(dataSet.Tables[0].Rows[i][0].ToString(), dataSet.Tables[0].Rows[i][1].ToString());
            }
            dataSet = GetTable("Составы");
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                comboBoxComposition.Items.Add(dataSet.Tables[0].Rows[i][0].ToString());
                compositDict.Add(dataSet.Tables[0].Rows[i][0].ToString(), dataSet.Tables[0].Rows[i][2].ToString());
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxComposition.Text != "" && comboBoxRouts.Text != "")
            {
                string route = routesDict[comboBoxRouts.Text];
                int numRoutePoints = route.Split('-').Length;
                string availSeats = "";
                for (int i = 0; i < numRoutePoints; i++)
                    availSeats += textBoxNumSeats.Text + "-";
                availSeats = availSeats.Remove(availSeats.Length - 1);
                ValueColumns = new List<string>() { textBoxID.Text, comboBoxRouts.Text,
               comboBoxComposition.Text, textBoxNumSeats.Text, availSeats, dateTimePicker.Value.ToString() };
                CreateConditionForAdd();
                AddEntry(NameTable, Condition);
                Form.ActiveForm.Close();
            }
            else
                MessageBox.Show("Незаполнены данные.", "Ошибка", MessageBoxButtons.OK);
        }

        private void comboBoxComposition_TextChanged(object sender, EventArgs e)
        {
            textBoxNumSeats.Text = compositDict[comboBoxComposition.Text];
        }
    }
}
