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
    public partial class AddEntryForm : Form
    {
        FlowLayoutPanel panel;
        int countControls;
        string nameTable;
        public AddEntryForm(string nameTable)
        {
            this.nameTable = nameTable;
            panel = new FlowLayoutPanel();
            panel.Dock = DockStyle.Fill;
            this.Controls.Add(panel);
            this.Load += OnLoad;
        }
        private void OnLoad(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            for (int i = 0; i < NameColumns.Count; i++)
            {
                Label label = new Label();
                label.Name = "label" + i;
                label.Text = NameColumns[i];
                panel.Controls.Add(label);
                TextBox textBox = new TextBox();
                textBox.Name = "textBox" + i;
                if (i == 0)
                {
                    textBox.Text = ID.ToString();
                    textBox.Enabled = false;
                }
                panel.Controls.Add(textBox);
            }
            countControls = panel.Controls.Count;
            Button button = new Button();
            button.Text = "Добавить";
            button.Click += OnClick;
            panel.Controls.Add(button);
        }
        private void OnClick(object sender, EventArgs e)
        {
            string condition = "";
            string values = "";
            for (int i = 0; i < countControls; i++)
            {
                if (i == 0)
                {
                    condition += "(" + panel.Controls[i].Text + ", ";
                    values += "(" + panel.Controls[i + 1].Text + ", ";
                }
                else if (i != countControls - 2)
                {
                    condition += panel.Controls[i].Text + ", ";
                    values += "'" + panel.Controls[i + 1].Text + "', ";
                }
                else
                {
                    condition += panel.Controls[i].Text + ")";
                    values += "'" + panel.Controls[i + 1].Text + "')";
                }
                i++;
            }
            condition = condition + " values " + values;
            AddEntry(nameTable, condition);
            Form.ActiveForm.Close();
        }
    }
}
