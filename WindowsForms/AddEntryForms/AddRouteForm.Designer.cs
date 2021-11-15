
namespace WindowsForms.AddEntryForms
{
    partial class AddRouteForm
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
            this.listBoxRoute = new System.Windows.Forms.ListBox();
            this.buttonDeleteRoutePoint = new System.Windows.Forms.Button();
            this.buttonAddRoutePoint = new System.Windows.Forms.Button();
            this.comboBoxRoutePoint = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxRoute
            // 
            this.listBoxRoute.FormattingEnabled = true;
            this.listBoxRoute.Location = new System.Drawing.Point(12, 103);
            this.listBoxRoute.Name = "listBoxRoute";
            this.listBoxRoute.Size = new System.Drawing.Size(281, 108);
            this.listBoxRoute.TabIndex = 40;
            // 
            // buttonDeleteRoutePoint
            // 
            this.buttonDeleteRoutePoint.Location = new System.Drawing.Point(172, 73);
            this.buttonDeleteRoutePoint.Name = "buttonDeleteRoutePoint";
            this.buttonDeleteRoutePoint.Size = new System.Drawing.Size(121, 23);
            this.buttonDeleteRoutePoint.TabIndex = 39;
            this.buttonDeleteRoutePoint.Text = "Удалить пункт";
            this.buttonDeleteRoutePoint.UseVisualStyleBackColor = true;
            this.buttonDeleteRoutePoint.Click += new System.EventHandler(this.buttonDeleteRoutePoint_Click);
            // 
            // buttonAddRoutePoint
            // 
            this.buttonAddRoutePoint.Location = new System.Drawing.Point(12, 74);
            this.buttonAddRoutePoint.Name = "buttonAddRoutePoint";
            this.buttonAddRoutePoint.Size = new System.Drawing.Size(121, 23);
            this.buttonAddRoutePoint.TabIndex = 38;
            this.buttonAddRoutePoint.Text = "Добавить пункт";
            this.buttonAddRoutePoint.UseVisualStyleBackColor = true;
            this.buttonAddRoutePoint.Click += new System.EventHandler(this.buttonAddRoutePoint_Click);
            // 
            // comboBoxRoutePoint
            // 
            this.comboBoxRoutePoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoutePoint.FormattingEnabled = true;
            this.comboBoxRoutePoint.Location = new System.Drawing.Point(132, 38);
            this.comboBoxRoutePoint.Name = "comboBoxRoutePoint";
            this.comboBoxRoutePoint.Size = new System.Drawing.Size(161, 21);
            this.comboBoxRoutePoint.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Маршрут:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 214);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(281, 35);
            this.buttonAdd.TabIndex = 35;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(132, 12);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(161, 20);
            this.textBoxID.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Номер маршрута:";
            // 
            // AddRouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 261);
            this.Controls.Add(this.listBoxRoute);
            this.Controls.Add(this.buttonDeleteRoutePoint);
            this.Controls.Add(this.buttonAddRoutePoint);
            this.Controls.Add(this.comboBoxRoutePoint);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(330, 300);
            this.MinimumSize = new System.Drawing.Size(330, 300);
            this.Name = "AddRouteForm";
            this.Text = "AddRouteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxRoute;
        private System.Windows.Forms.Button buttonDeleteRoutePoint;
        private System.Windows.Forms.Button buttonAddRoutePoint;
        private System.Windows.Forms.ComboBox comboBoxRoutePoint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label1;
    }
}