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

namespace WindowsForms
{
    public partial class DBForm : Form
    {
        public DBForm()
        {
            InitializeComponent();
        }

        private void DBForm_Load(object sender, EventArgs e)
        {
            List<string> tables = GetNameTables();
            foreach (string table in tables)
                comboBoxTable.Items.Add(table);
            dataGridViewTable.AllowUserToAddRows = false;
        }

        private void comboBoxTable_TextChanged(object sender, EventArgs e)
        {
            UpdateTable();
            if (comboBoxTable.Text == "Билеты")
            {
                buttonAdd.Enabled = false;
                buttonUpdate.Enabled = false;
                buttonDelete.Enabled = false;
            }
            else
            {
                buttonAdd.Enabled = true;
                buttonUpdate.Enabled = true;
                buttonDelete.Enabled = true;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection row = dataGridViewTable.SelectedRows;
            if (dataGridViewTable.SelectedRows.Count > 0)
            {
                string condition = dataGridViewTable.Columns[0].HeaderText + " = " +
                    dataGridViewTable.SelectedRows[0].Cells[0].Value.ToString();
                DeleteEntry(comboBoxTable.Text, condition);
                UpdateTable();
            }
            else
                MessageBox.Show("Не выбрана запись для удаления", "Ошибка", MessageBoxButtons.OK);
        }
        private void UpdateTable()
        {
            dataGridViewTable.DataSource = GetTable(comboBoxTable.Text).Tables[0].DefaultView;
            dataGridViewTable.ReadOnly = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            UpdateData();
            if (comboBoxTable.Text == "Города")
            {
                Form form = new AddEntryForms.AddCityForm();
                form.ShowDialog();
            }
            else if (comboBoxTable.Text == "Вагоны")
            {
                Form form = new AddEntryForms.AddWagonsForm();
                form.ShowDialog();
            }
            else if (comboBoxTable.Text == "Маршруты")
            {
                Form form = new AddEntryForms.AddRouteForm();
                form.ShowDialog();
            }
            else if (comboBoxTable.Text == "Поезда")
            {
                Form form = new AddEntryForms.AddTrainForm();
                form.ShowDialog();
            }
            else if (comboBoxTable.Text == "Пользователи")
            {
                Form form = new AddEntryForms.AddUserForm();
                form.ShowDialog();
            }
            else if (comboBoxTable.Text == "Права_доступа")
            {
                Form form = new AddEntryForms.AddAccessLevelForm();
                form.ShowDialog();
            }
            else if (comboBoxTable.Text == "Составы")
            {
                Form form = new AddEntryForms.AddCompositionForm();
                form.ShowDialog();
            }
            else
            {
                Form form = new AddEntryForms.AddEntryForm(comboBoxTable.Text);
                form.ShowDialog();
            }
            UpdateTable();
        }
        private void UpdateData()
        {
            List<string> columns = new List<string>();
            int id = dataGridViewTable.RowCount + 1;
            for (int i = 0; i < dataGridViewTable.RowCount; i++)
            {
                if (int.Parse(dataGridViewTable.Rows[i].Cells[0].Value.ToString()) != i + 1)
                {
                    id = i + 1;
                    break;
                }
            }
            for (int i = 0; i < dataGridViewTable.Columns.Count; i++)
                columns.Add(dataGridViewTable.Columns[i].HeaderText);
            ID = id;
            NameColumns = columns;
            NameTable = comboBoxTable.Text;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewTable.SelectedRows.Count > 0)
            {
                UpdateData();
                List<string> value = new List<string>();
                for (int i = 0; i < dataGridViewTable.ColumnCount; i++)
                    value.Add(dataGridViewTable.SelectedRows[0].Cells[i].Value.ToString());
                ID = int.Parse(value[0]);
                ValueColumns = value;
                if (comboBoxTable.Text == "Города")
                {
                    Form form = new UpdateEntryForms.UpdateCityForm();
                    form.ShowDialog();
                }
                else if (comboBoxTable.Text == "Вагоны")
                {
                    Form form = new UpdateEntryForms.UpdateWagonsForm();
                    form.ShowDialog();
                }
                else if (comboBoxTable.Text == "Маршруты")
                {
                    Form form = new UpdateEntryForms.UpdateRouteForm();
                    form.ShowDialog();
                }
                else if (comboBoxTable.Text == "Поезда")
                {
                    Form form = new UpdateEntryForms.UpdateTrainForm();
                    form.ShowDialog();
                }
                else if (comboBoxTable.Text == "Пользователи")
                {
                    Form form = new UpdateEntryForms.UpdateUserForm();
                    form.ShowDialog();
                }
                else if (comboBoxTable.Text == "Права_доступа")
                {
                    Form form = new UpdateEntryForms.UpdateAccessLevelForm();
                    form.ShowDialog();
                }
                else if (comboBoxTable.Text == "Составы")
                {
                    Form form = new UpdateEntryForms.UpdateCompositionForm();
                    form.ShowDialog();
                }
                else
                {
                    Form form = new UpdateEntryForms.UpdateEntryForm();
                    form.ShowDialog();
                }
                UpdateTable();
            }
            else
                MessageBox.Show("Не выбрана запись для изменения", "Ошибка", MessageBoxButtons.OK);
        }
    }
}
