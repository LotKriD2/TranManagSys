
namespace WindowsForms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewTrains = new System.Windows.Forms.DataGridView();
            this.labelUser = new System.Windows.Forms.Label();
            this.groupBoxSort = new System.Windows.Forms.GroupBox();
            this.checkBoxDate = new System.Windows.Forms.CheckBox();
            this.checkBoxArrivalPoint = new System.Windows.Forms.CheckBox();
            this.comboBoxArrivalPoint = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrains)).BeginInit();
            this.groupBoxSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTrains
            // 
            this.dataGridViewTrains.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTrains.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrains.Location = new System.Drawing.Point(12, 99);
            this.dataGridViewTrains.Name = "dataGridViewTrains";
            this.dataGridViewTrains.Size = new System.Drawing.Size(660, 215);
            this.dataGridViewTrains.TabIndex = 5;
            // 
            // labelUser
            // 
            this.labelUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(645, 6);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(27, 13);
            this.labelUser.TabIndex = 4;
            this.labelUser.Text = "user";
            // 
            // groupBoxSort
            // 
            this.groupBoxSort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSort.Controls.Add(this.checkBoxDate);
            this.groupBoxSort.Controls.Add(this.checkBoxArrivalPoint);
            this.groupBoxSort.Controls.Add(this.comboBoxArrivalPoint);
            this.groupBoxSort.Controls.Add(this.label2);
            this.groupBoxSort.Controls.Add(this.label1);
            this.groupBoxSort.Controls.Add(this.dateTimePicker);
            this.groupBoxSort.Location = new System.Drawing.Point(13, 23);
            this.groupBoxSort.Name = "groupBoxSort";
            this.groupBoxSort.Size = new System.Drawing.Size(659, 68);
            this.groupBoxSort.TabIndex = 8;
            this.groupBoxSort.TabStop = false;
            this.groupBoxSort.Text = "Сортировки";
            // 
            // checkBoxDate
            // 
            this.checkBoxDate.AutoSize = true;
            this.checkBoxDate.Location = new System.Drawing.Point(270, 41);
            this.checkBoxDate.Name = "checkBoxDate";
            this.checkBoxDate.Size = new System.Drawing.Size(66, 17);
            this.checkBoxDate.TabIndex = 10;
            this.checkBoxDate.Text = "По дате";
            this.checkBoxDate.UseVisualStyleBackColor = true;
            this.checkBoxDate.CheckedChanged += new System.EventHandler(this.checkBoxDate_CheckedChanged);
            // 
            // checkBoxArrivalPoint
            // 
            this.checkBoxArrivalPoint.AutoSize = true;
            this.checkBoxArrivalPoint.Location = new System.Drawing.Point(270, 19);
            this.checkBoxArrivalPoint.Name = "checkBoxArrivalPoint";
            this.checkBoxArrivalPoint.Size = new System.Drawing.Size(128, 17);
            this.checkBoxArrivalPoint.TabIndex = 9;
            this.checkBoxArrivalPoint.Text = "По пункту прибытия";
            this.checkBoxArrivalPoint.UseVisualStyleBackColor = true;
            this.checkBoxArrivalPoint.CheckedChanged += new System.EventHandler(this.checkBoxArrivalPoint_CheckedChanged);
            // 
            // comboBoxArrivalPoint
            // 
            this.comboBoxArrivalPoint.FormattingEnabled = true;
            this.comboBoxArrivalPoint.Location = new System.Drawing.Point(10, 42);
            this.comboBoxArrivalPoint.Name = "comboBoxArrivalPoint";
            this.comboBoxArrivalPoint.Size = new System.Drawing.Size(165, 21);
            this.comboBoxArrivalPoint.TabIndex = 8;
            this.comboBoxArrivalPoint.Visible = false;
            this.comboBoxArrivalPoint.TextChanged += new System.EventHandler(this.comboBoxArrivalPoint_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "По пункту прибытия:";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "По дате:";
            this.label1.Visible = false;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.CustomFormat = "";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker.Location = new System.Drawing.Point(453, 42);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 5;
            this.dateTimePicker.Visible = false;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.groupBoxSort);
            this.Controls.Add(this.dataGridViewTrains);
            this.Controls.Add(this.labelUser);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrains)).EndInit();
            this.groupBoxSort.ResumeLayout(false);
            this.groupBoxSort.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTrains;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.GroupBox groupBoxSort;
        private System.Windows.Forms.CheckBox checkBoxDate;
        private System.Windows.Forms.CheckBox checkBoxArrivalPoint;
        private System.Windows.Forms.ComboBox comboBoxArrivalPoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}

