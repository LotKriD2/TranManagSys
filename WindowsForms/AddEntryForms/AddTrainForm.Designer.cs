
namespace WindowsForms.AddEntryForms
{
    partial class AddTrainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNumSeats = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxComposition = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxRouts = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker.Location = new System.Drawing.Point(131, 119);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(161, 20);
            this.dateTimePicker.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 68;
            this.label6.Text = "Дата отправления:";
            // 
            // textBoxNumSeats
            // 
            this.textBoxNumSeats.Location = new System.Drawing.Point(131, 92);
            this.textBoxNumSeats.Name = "textBoxNumSeats";
            this.textBoxNumSeats.Size = new System.Drawing.Size(161, 20);
            this.textBoxNumSeats.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Число мест:";
            // 
            // comboBoxComposition
            // 
            this.comboBoxComposition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComposition.FormattingEnabled = true;
            this.comboBoxComposition.Location = new System.Drawing.Point(131, 65);
            this.comboBoxComposition.Name = "comboBoxComposition";
            this.comboBoxComposition.Size = new System.Drawing.Size(161, 21);
            this.comboBoxComposition.TabIndex = 65;
            this.comboBoxComposition.TextChanged += new System.EventHandler(this.comboBoxComposition_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Состав:";
            // 
            // comboBoxRouts
            // 
            this.comboBoxRouts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRouts.FormattingEnabled = true;
            this.comboBoxRouts.Location = new System.Drawing.Point(131, 38);
            this.comboBoxRouts.Name = "comboBoxRouts";
            this.comboBoxRouts.Size = new System.Drawing.Size(161, 21);
            this.comboBoxRouts.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Номер маршрута:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(11, 145);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(281, 35);
            this.buttonAdd.TabIndex = 61;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(131, 12);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(161, 20);
            this.textBoxID.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Номер поезда:";
            // 
            // AddTrainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 201);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxNumSeats);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxComposition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxRouts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(330, 240);
            this.MinimumSize = new System.Drawing.Size(330, 240);
            this.Name = "AddTrainForm";
            this.Text = "AddTrainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNumSeats;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxComposition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxRouts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label1;
    }
}