using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TranManagSysLibrary;
using static TranManagSysLibrary.DBConnection;
using static TranManagSysLibrary.Data;

namespace WindowsForms.UpdateEntryForms
{
    public partial class UpdateRouteForm : Form
    {
        List<City> cities;
        public UpdateRouteForm()
        {
            InitializeComponent();
            textBoxID.Text = ID.ToString();
            textBoxID.Enabled = false;
            cities = new List<City>();
            DataSet dataSet = GetTable("Города");
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                comboBoxRoutePoint.Items.Add(dataSet.Tables[0].Rows[i][1].ToString());
                cities.Add(new City(int.Parse(dataSet.Tables[0].Rows[i][0].ToString()),
                    dataSet.Tables[0].Rows[i][1].ToString()));
            }
            string[] routePoints = ValueColumns[1].Split('-');
            foreach (string point in routePoints)
                foreach (City city in cities)
                    if (city.ID.ToString() == point)
                    {
                        listBoxRoute.Items.Add(city.ToString());
                        break;
                    }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listBoxRoute.Items.Count != 0)
            {
                string route = "";
                foreach (string item in listBoxRoute.Items)
                    foreach (City city in cities)
                        if (city.Name == item)
                        {
                            route += city.ID + "-";
                            break;
                        }
                route = route.Remove(route.Length - 1);
                ValueColumns = new List<string>() { textBoxID.Text, route };
                CreateConditionForUpdate();
                UpdateEntry(NameTable, Condition);
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
