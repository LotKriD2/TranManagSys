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
        List<string[]> trains;
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
            List<string[]> cities = GetCities();
            for (int i = 0; i < cities.Count; i++)
                if (cities[i][1] != TranManagSysLibrary.User.Location)
                    comboBoxArrivalPoint.Items.Add(cities[i][1]);
            CreateDataGridView();
            trains = GetTrains();
            UpdateDataGridView();
        }
        private void CreateDataGridView()
        {

            DataGridViewColumn column1 = new DataGridViewColumn();
            column1.HeaderText = "Номер поезда";
            column1.Name = "train_number";
            column1.CellTemplate = new DataGridViewTextBoxCell();

            DataGridViewColumn column2 = new DataGridViewColumn();
            column2.HeaderText = "Маршрут";
            column2.Name = "route";
            column2.CellTemplate = new DataGridViewTextBoxCell();

            DataGridViewColumn column3 = new DataGridViewColumn();
            column3.HeaderText = "Число свободных мест";
            column3.Name = "number_available_seats";
            column3.CellTemplate = new DataGridViewTextBoxCell();

            DataGridViewColumn column4 = new DataGridViewColumn();
            column4.HeaderText = "Дата отправления";
            column4.Name = "date";
            column4.CellTemplate = new DataGridViewTextBoxCell();

            dataGridViewTrains.Columns.Add(column1);
            dataGridViewTrains.Columns.Add(column2);
            dataGridViewTrains.Columns.Add(column3);
            dataGridViewTrains.Columns.Add(column4);

            dataGridViewTrains.AllowUserToAddRows = false;
        }
        private void UpdateDataGridView()
        {
            dataGridViewTrains.Rows.Clear();
            for (int i = 0; i < trains.Count; i++)
            {
                dataGridViewTrains.Rows.Add();
                for (int j = 0; j < trains[i].Length; j++)
                {
                    DataGridViewCell dataGridViewCell = dataGridViewTrains.
                        Rows[dataGridViewTrains.Rows.Count - 1].Cells[j];
                    dataGridViewCell.Value = trains[i][j];
                }
            }
        }
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            trains = GetTrains();
            if (checkBoxArrivalPoint.Checked)
                trains = SortTrains(trains, comboBoxArrivalPoint.Text, dateTimePicker.Value);
            else
                trains = SortTrains(trains, dateTimePicker.Value);
            UpdateDataGridView();
        }

        private void comboBoxArrivalPoint_TextChanged(object sender, EventArgs e)
        {
            trains = GetTrains();
            if (checkBoxDate.Checked)
                trains = SortTrains(trains, comboBoxArrivalPoint.Text, dateTimePicker.Value);
            else
                trains = SortTrains(trains, comboBoxArrivalPoint.Text);
            UpdateDataGridView();
        }

        private void checkBoxArrivalPoint_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxArrivalPoint.Checked)
            {
                label2.Visible = true;
                comboBoxArrivalPoint.Visible = true;
            }
            else
            {
                label2.Visible = false;
                comboBoxArrivalPoint.Visible = false;
                trains = GetTrains();
                UpdateDataGridView();
            }
        }

        private void checkBoxDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDate.Checked)
            {
                label1.Visible = true;
                dateTimePicker.Visible = true;
            }
            else
            {
                label1.Visible = false;
                dateTimePicker.Visible = false;
                trains = GetTrains();
                UpdateDataGridView();
            }
        }
        private void buttonSellTiket_Click(object sender, EventArgs e)
        {
            Form form = new SellForm();
            form.ShowDialog();
            trains = GetTrains();
            UpdateDataGridView();
        }
    }
}
