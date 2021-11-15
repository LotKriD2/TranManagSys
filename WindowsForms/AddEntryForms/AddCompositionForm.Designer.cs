
namespace WindowsForms.AddEntryForms
{
    partial class AddCompositionForm
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
            this.textBoxNumSeats = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxComposition = new System.Windows.Forms.ListBox();
            this.buttonDeleteWagon = new System.Windows.Forms.Button();
            this.buttonAddWagon = new System.Windows.Forms.Button();
            this.comboBoxWagons = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNumSeats
            // 
            this.textBoxNumSeats.Location = new System.Drawing.Point(134, 216);
            this.textBoxNumSeats.Name = "textBoxNumSeats";
            this.textBoxNumSeats.Size = new System.Drawing.Size(161, 20);
            this.textBoxNumSeats.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Количество мест:";
            // 
            // listBoxComposition
            // 
            this.listBoxComposition.FormattingEnabled = true;
            this.listBoxComposition.Location = new System.Drawing.Point(14, 103);
            this.listBoxComposition.Name = "listBoxComposition";
            this.listBoxComposition.Size = new System.Drawing.Size(281, 108);
            this.listBoxComposition.TabIndex = 50;
            // 
            // buttonDeleteWagon
            // 
            this.buttonDeleteWagon.Location = new System.Drawing.Point(174, 73);
            this.buttonDeleteWagon.Name = "buttonDeleteWagon";
            this.buttonDeleteWagon.Size = new System.Drawing.Size(121, 23);
            this.buttonDeleteWagon.TabIndex = 49;
            this.buttonDeleteWagon.Text = "Удалить вагон";
            this.buttonDeleteWagon.UseVisualStyleBackColor = true;
            this.buttonDeleteWagon.Click += new System.EventHandler(this.buttonDeleteWagon_Click);
            // 
            // buttonAddWagon
            // 
            this.buttonAddWagon.Location = new System.Drawing.Point(14, 74);
            this.buttonAddWagon.Name = "buttonAddWagon";
            this.buttonAddWagon.Size = new System.Drawing.Size(121, 23);
            this.buttonAddWagon.TabIndex = 48;
            this.buttonAddWagon.Text = "Добавить вагон";
            this.buttonAddWagon.UseVisualStyleBackColor = true;
            this.buttonAddWagon.Click += new System.EventHandler(this.buttonAddWagon_Click);
            // 
            // comboBoxWagons
            // 
            this.comboBoxWagons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWagons.FormattingEnabled = true;
            this.comboBoxWagons.Location = new System.Drawing.Point(134, 38);
            this.comboBoxWagons.Name = "comboBoxWagons";
            this.comboBoxWagons.Size = new System.Drawing.Size(161, 21);
            this.comboBoxWagons.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Состав:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(13, 250);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(281, 35);
            this.buttonAdd.TabIndex = 45;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(134, 12);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(161, 20);
            this.textBoxID.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Код состава:";
            // 
            // AddCompositionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 291);
            this.Controls.Add(this.textBoxNumSeats);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxComposition);
            this.Controls.Add(this.buttonDeleteWagon);
            this.Controls.Add(this.buttonAddWagon);
            this.Controls.Add(this.comboBoxWagons);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(330, 330);
            this.MinimumSize = new System.Drawing.Size(330, 330);
            this.Name = "AddCompositionForm";
            this.Text = "AddCompositionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumSeats;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxComposition;
        private System.Windows.Forms.Button buttonDeleteWagon;
        private System.Windows.Forms.Button buttonAddWagon;
        private System.Windows.Forms.ComboBox comboBoxWagons;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label1;
    }
}