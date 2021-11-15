
namespace WindowsForms.UpdateEntryForms
{
    partial class UpdateRouteForm
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
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxRoute
            // 
            this.listBoxRoute.FormattingEnabled = true;
            this.listBoxRoute.Location = new System.Drawing.Point(18, 103);
            this.listBoxRoute.Name = "listBoxRoute";
            this.listBoxRoute.Size = new System.Drawing.Size(281, 108);
            this.listBoxRoute.TabIndex = 48;
            // 
            // buttonDeleteRoutePoint
            // 
            this.buttonDeleteRoutePoint.Location = new System.Drawing.Point(178, 73);
            this.buttonDeleteRoutePoint.Name = "buttonDeleteRoutePoint";
            this.buttonDeleteRoutePoint.Size = new System.Drawing.Size(121, 23);
            this.buttonDeleteRoutePoint.TabIndex = 47;
            this.buttonDeleteRoutePoint.Text = "Удалить пункт";
            this.buttonDeleteRoutePoint.UseVisualStyleBackColor = true;
            this.buttonDeleteRoutePoint.Click += new System.EventHandler(this.buttonDeleteRoutePoint_Click);
            // 
            // buttonAddRoutePoint
            // 
            this.buttonAddRoutePoint.Location = new System.Drawing.Point(18, 74);
            this.buttonAddRoutePoint.Name = "buttonAddRoutePoint";
            this.buttonAddRoutePoint.Size = new System.Drawing.Size(121, 23);
            this.buttonAddRoutePoint.TabIndex = 46;
            this.buttonAddRoutePoint.Text = "Добавить пункт";
            this.buttonAddRoutePoint.UseVisualStyleBackColor = true;
            this.buttonAddRoutePoint.Click += new System.EventHandler(this.buttonAddRoutePoint_Click);
            // 
            // comboBoxRoutePoint
            // 
            this.comboBoxRoutePoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoutePoint.FormattingEnabled = true;
            this.comboBoxRoutePoint.Location = new System.Drawing.Point(138, 38);
            this.comboBoxRoutePoint.Name = "comboBoxRoutePoint";
            this.comboBoxRoutePoint.Size = new System.Drawing.Size(161, 21);
            this.comboBoxRoutePoint.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Маршрут:";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(18, 214);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(281, 35);
            this.buttonUpdate.TabIndex = 43;
            this.buttonUpdate.Text = "Изменить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(138, 12);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(161, 20);
            this.textBoxID.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Номер маршрута:";
            // 
            // UpdateRouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 261);
            this.Controls.Add(this.listBoxRoute);
            this.Controls.Add(this.buttonDeleteRoutePoint);
            this.Controls.Add(this.buttonAddRoutePoint);
            this.Controls.Add(this.comboBoxRoutePoint);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(330, 300);
            this.MinimumSize = new System.Drawing.Size(330, 300);
            this.Name = "UpdateRouteForm";
            this.Text = "UpdateRouteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxRoute;
        private System.Windows.Forms.Button buttonDeleteRoutePoint;
        private System.Windows.Forms.Button buttonAddRoutePoint;
        private System.Windows.Forms.ComboBox comboBoxRoutePoint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label1;
    }
}