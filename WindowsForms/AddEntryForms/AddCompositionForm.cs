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
    public partial class AddCompositionForm : Form
    {
        Dictionary<string, int> wagonsDict;
        Dictionary<int, int> keySeatsDict;
        public AddCompositionForm()
        {
            InitializeComponent();
            textBoxID.Text = ID.ToString();
            textBoxID.Enabled = false;
            textBoxNumSeats.Text = "0";
            textBoxNumSeats.Enabled = false;
            wagonsDict = new Dictionary<string, int>();
            keySeatsDict = new Dictionary<int, int>();
            DataSet dataSet = GetTable("Вагоны");
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                comboBoxWagons.Items.Add(dataSet.Tables[0].Rows[i][1].ToString());
                wagonsDict.Add(dataSet.Tables[0].Rows[i][1].ToString(), int.Parse(dataSet.Tables[0].Rows[i][0].ToString()));
                keySeatsDict.Add(int.Parse(dataSet.Tables[0].Rows[i][0].ToString()), int.Parse(dataSet.Tables[0].Rows[i][2].ToString()));
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (listBoxComposition.Items.Count != 0)
            {
                string composition = "";
                foreach (string item in listBoxComposition.Items)
                    composition += wagonsDict[item] + "-";
                composition = composition.Remove(composition.Length - 1);
                ValueColumns = new List<string>() { textBoxID.Text, composition, textBoxNumSeats.Text };
                CreateConditionForAdd();
                AddEntry(NameTable, Condition);
                Form.ActiveForm.Close();
            }
            else
                MessageBox.Show("Незаполнены данные.", "Ошибка", MessageBoxButtons.OK);
        }

        private void buttonAddWagon_Click(object sender, EventArgs e)
        {
            if (comboBoxWagons.Text != "")
            {
                listBoxComposition.Items.Add(comboBoxWagons.Text);
                int num = int.Parse(textBoxNumSeats.Text);
                num += keySeatsDict[wagonsDict[comboBoxWagons.Text]];
                textBoxNumSeats.Text = num.ToString();
            }
        }

        private void buttonDeleteWagon_Click(object sender, EventArgs e)
        {
            if (listBoxComposition.Items.Count > 0)
            {
                string wagon = listBoxComposition.Items[listBoxComposition.Items.Count - 1].ToString();
                int num = int.Parse(textBoxNumSeats.Text);
                num -= keySeatsDict[wagonsDict[wagon]];
                textBoxNumSeats.Text = num.ToString();
                listBoxComposition.Items.Remove(listBoxComposition.Items[listBoxComposition.Items.Count - 1]);
            }
        }
    }
}
