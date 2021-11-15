
namespace WindowsForms
{
    partial class SellForm
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
            this.comboBoxArrivalPoint = new System.Windows.Forms.ComboBox();
            this.comboBoxTrain = new System.Windows.Forms.ComboBox();
            this.comboBoxBuyer = new System.Windows.Forms.ComboBox();
            this.buttonSell = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDeparturePoint = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxArrivalPoint
            // 
            this.comboBoxArrivalPoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxArrivalPoint.FormattingEnabled = true;
            this.comboBoxArrivalPoint.Location = new System.Drawing.Point(104, 90);
            this.comboBoxArrivalPoint.Name = "comboBoxArrivalPoint";
            this.comboBoxArrivalPoint.Size = new System.Drawing.Size(168, 21);
            this.comboBoxArrivalPoint.TabIndex = 20;
            // 
            // comboBoxTrain
            // 
            this.comboBoxTrain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTrain.FormattingEnabled = true;
            this.comboBoxTrain.Location = new System.Drawing.Point(104, 38);
            this.comboBoxTrain.Name = "comboBoxTrain";
            this.comboBoxTrain.Size = new System.Drawing.Size(168, 21);
            this.comboBoxTrain.TabIndex = 19;
            this.comboBoxTrain.TextChanged += new System.EventHandler(this.comboBoxTrain_TextChanged);
            // 
            // comboBoxBuyer
            // 
            this.comboBoxBuyer.FormattingEnabled = true;
            this.comboBoxBuyer.Location = new System.Drawing.Point(104, 12);
            this.comboBoxBuyer.Name = "comboBoxBuyer";
            this.comboBoxBuyer.Size = new System.Drawing.Size(168, 21);
            this.comboBoxBuyer.TabIndex = 18;
            // 
            // buttonSell
            // 
            this.buttonSell.Location = new System.Drawing.Point(16, 134);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(256, 52);
            this.buttonSell.TabIndex = 17;
            this.buttonSell.Text = "Продать";
            this.buttonSell.UseVisualStyleBackColor = true;
            this.buttonSell.Click += new System.EventHandler(this.buttonSell_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Пункт прибытия:";
            // 
            // textBoxDeparturePoint
            // 
            this.textBoxDeparturePoint.Location = new System.Drawing.Point(104, 64);
            this.textBoxDeparturePoint.Name = "textBoxDeparturePoint";
            this.textBoxDeparturePoint.Size = new System.Drawing.Size(168, 20);
            this.textBoxDeparturePoint.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Пункт отбытия:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Поезд:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Покупатель:";
            // 
            // SellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.comboBoxArrivalPoint);
            this.Controls.Add(this.comboBoxTrain);
            this.Controls.Add(this.comboBoxBuyer);
            this.Controls.Add(this.buttonSell);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDeparturePoint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(300, 350);
            this.MinimumSize = new System.Drawing.Size(300, 350);
            this.Name = "SellForm";
            this.Text = "SellForm";
            this.Load += new System.EventHandler(this.SellForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxArrivalPoint;
        private System.Windows.Forms.ComboBox comboBoxTrain;
        private System.Windows.Forms.ComboBox comboBoxBuyer;
        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDeparturePoint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}