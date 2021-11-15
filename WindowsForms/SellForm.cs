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
    public partial class SellForm : Form
    {
        List<string[]> trains;
        public SellForm()
        {
            InitializeComponent();
        }

        private void buttonSell_Click(object sender, EventArgs e)
        {
            if (textBoxDeparturePoint.Text == "" ||
                comboBoxArrivalPoint.Text == "" ||
                comboBoxBuyer.Text == "" ||
                comboBoxTrain.Text == "")
                MessageBox.Show("Неверный ввод", "Ошибка");
            else
            {
                bool successful = false;
                for (int i = 0; i < trains.Count; i++)
                {
                    if (trains[i][0] == comboBoxTrain.Text)
                        successful = UpdateAfterSell(trains[i], textBoxDeparturePoint.Text, comboBoxArrivalPoint.Text);
                }
                if (successful)
                {
                    string condition = "( Номер_билета, Покупатель, Поезд, Пункт_отбытия, Пункт_прибытия )";
                    string[] preID = DateTime.Now.ToString().Split(' ');
                    string id = "";
                    string[] preId1;
                    for (int i = 0; i < preID.Length; i++)
                    {
                        if (i == 0)
                        {
                            preId1 = preID[i].Split('.');
                            id += preId1[0];
                        }
                        else
                        {
                            preId1 = preID[i].Split(':');
                            for (int j = 0; j < preId1.Length; j++)
                                id += preId1[j];
                        }
                    }
                    Dictionary<string, int> cities = new Dictionary<string, int>();
                    DataSet dataSet = GetTable("Города");
                    for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                        cities.Add(dataSet.Tables[0].Rows[i][1].ToString(), int.Parse(dataSet.Tables[0].Rows[i][0].ToString()));
                    string values = "( " + id + ", '" + comboBoxBuyer.Text + "', "
                        + comboBoxTrain.Text + ", " + cities[textBoxDeparturePoint.Text] + ", "
                        + cities[comboBoxArrivalPoint.Text] + " )";
                    condition = condition + " values " + values;
                    AddEntry("Билеты", condition);
                    MessageBox.Show("Продажа успешна", "Уведомление", MessageBoxButtons.OK);
                    Form.ActiveForm.Close();
                }
                else
                    MessageBox.Show("Нет свободных мест", "Уведомление", MessageBoxButtons.OK);
            }
        }
        private void SellForm_Load(object sender, EventArgs e)
        {
            textBoxDeparturePoint.Text = TranManagSysLibrary.User.Location;
            textBoxDeparturePoint.Enabled = false;
            List<string> buyers = GetBuyers();
            trains = GetTrains();
            for (int i = 0; i < buyers.Count; i++)
                comboBoxBuyer.Items.Add(buyers[i]);
            for (int i = 0; i < trains.Count; i++)
                comboBoxTrain.Items.Add(trains[i][0]);
        }

        private void comboBoxTrain_TextChanged(object sender, EventArgs e)
        {
            comboBoxArrivalPoint.Items.Clear();
            string train = comboBoxTrain.Text;
            string route = "";
            for (int i = 0; i < trains.Count; i++)
                if (trains[i][0] == train)
                {
                    route = trains[i][1];
                    break;
                }
            string[] route_points = route.Split('-');
            for (int i = 0; i < route_points.Length; i++)
                if (route_points[i] != TranManagSysLibrary.User.Location)
                    comboBoxArrivalPoint.Items.Add(route_points[i]);
        }
    }
}
