
namespace WindowsForms.UpdateEntryForms
{
    partial class UpdateTrainForm
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
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker.Location = new System.Drawing.Point(138, 123);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(161, 20);
            this.dateTimePicker.TabIndex = 80;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 79;
            this.label6.Text = "Дата отправления:";
            // 
            // textBoxNumSeats
            // 
            this.textBoxNumSeats.Location = new System.Drawing.Point(138, 96);
            this.textBoxNumSeats.Name = "textBoxNumSeats";
            this.textBoxNumSeats.Size = new System.Drawing.Size(161, 20);
            this.textBoxNumSeats.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "Число мест:";
            // 
            // comboBoxComposition
            // 
            this.comboBoxComposition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComposition.FormattingEnabled = true;
            this.comboBoxComposition.Location = new System.Drawing.Point(138, 69);
            this.comboBoxComposition.Name = "comboBoxComposition";
            this.comboBoxComposition.Size = new System.Drawing.Size(161, 21);
            this.comboBoxComposition.TabIndex = 76;
            this.comboBoxComposition.TextChanged += new System.EventHandler(this.comboBoxComposition_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Состав:";
            // 
            // comboBoxRouts
            // 
            this.comboBoxRouts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRouts.FormattingEnabled = true;
            this.comboBoxRouts.Location = new System.Drawing.Point(138, 42);
            this.comboBoxRouts.Name = "comboBoxRouts";
            this.comboBoxRouts.Size = new System.Drawing.Size(161, 21);
            this.comboBoxRouts.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 73;
            this.label4.Text = "Номер маршрута:";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(18, 149);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(281, 35);
            this.buttonUpdate.TabIndex = 72;
            this.buttonUpdate.Text = "Изменить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(138, 16);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(161, 20);
            this.textBoxID.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Номер поезда:";
            // 
            // UpdateTrainForm
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
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(330, 240);
            this.MinimumSize = new System.Drawing.Size(330, 240);
            this.Name = "UpdateTrainForm";
            this.Text = "UpdateTrainForm";
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
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label1;
    }
}