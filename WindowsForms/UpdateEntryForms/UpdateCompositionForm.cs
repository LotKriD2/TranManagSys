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
    public partial class UpdateCompositionForm : Form
    {
        List<Wagon> wagons;
        public UpdateCompositionForm()
        {
            InitializeComponent();
            textBoxID.Text = ID.ToString();
            textBoxID.Enabled = false;
            textBoxNumSeats.Text = ValueColumns[2];
            textBoxNumSeats.Enabled = false;
            wagons = new List<Wagon>();
            DataSet dataSet = GetTable("Вагоны");
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                comboBoxWagons.Items.Add(dataSet.Tables[0].Rows[i][1].ToString());
                wagons.Add(new Wagon(int.Parse(dataSet.Tables[0].Rows[i][0].ToString()),
                    dataSet.Tables[0].Rows[i][1].ToString(),
                    int.Parse(dataSet.Tables[0].Rows[i][2].ToString())));
            }
            string[] wag = ValueColumns[1].Split('-');
            foreach (string w in wag)
                foreach (Wagon wagon in wagons)
                    if (wagon.ID.ToString() == w)
                        listBoxComposition.Items.Add(wagon.ToString());
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string composition = "";
            foreach (string item in listBoxComposition.Items)
                foreach (Wagon wagon in wagons)
                    if (wagon.Name == item)
                    {
                        composition += wagon.ID + "-";
                        break;
                    }
            composition = composition.Remove(composition.Length - 1);
            ValueColumns = new List<string>() { textBoxID.Text, composition, textBoxNumSeats.Text };
            CreateConditionForUpdate();
            UpdateEntry(NameTable, Condition);
            Form.ActiveForm.Close();
        }

        private void buttonAddWagon_Click(object sender, EventArgs e)
        {
            if (listBoxComposition.Items.Count != 0)
            {
                if (comboBoxWagons.Text != "")
                {
                    listBoxComposition.Items.Add(comboBoxWagons.Text);
                    int num = int.Parse(textBoxNumSeats.Text);
                    foreach (Wagon wagon in wagons)
                    {
                        if (wagon.Name == comboBoxWagons.Text)
                        {
                            num += wagon.NumSeats;
                        }
                    }
                    textBoxNumSeats.Text = num.ToString();
                }
            }
            else
                MessageBox.Show("Незаполнены данные.", "Ошибка", MessageBoxButtons.OK);
        }

        private void buttonDeleteWagon_Click(object sender, EventArgs e)
        {
            if (listBoxComposition.Items.Count > 0)
            {
                string wag = listBoxComposition.Items[listBoxComposition.Items.Count - 1].ToString();
                int num = int.Parse(textBoxNumSeats.Text);
                foreach (Wagon wagon in wagons)
                {
                    if (wagon.Name == wag)
                    {
                        num -= wagon.NumSeats;
                    }
                }
                textBoxNumSeats.Text = num.ToString();
                listBoxComposition.Items.Remove(listBoxComposition.Items[listBoxComposition.Items.Count - 1]);
            }
        }
    }
}
