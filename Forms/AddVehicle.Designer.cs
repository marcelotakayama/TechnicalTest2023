namespace TesteTecnico2023.Forms
{

    partial class AddVehicle
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.txtModelName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWheels = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKMs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbFuel = new System.Windows.Forms.ComboBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo";

            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Combustivel";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(243, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(42, 13);
            this.txtName.TabIndex = 3;
            this.txtName.Text = "Modelo";
            // 
            // txtModelName
            // 
            this.txtModelName.Location = new System.Drawing.Point(289, 51);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.Size = new System.Drawing.Size(155, 20);
            this.txtModelName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Marca";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(61, 52);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 1;
            // 
            // cmbFuel
            // 
            this.cmbFuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuel.FormattingEnabled = true;
            this.cmbFuel.Location = new System.Drawing.Point(92, 110);
            this.cmbFuel.Name = "cmbFuel";
            this.cmbFuel.Size = new System.Drawing.Size(121, 21);
            this.cmbFuel.TabIndex = 6;
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(61, 21);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 21);
            this.cmbType.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(305, 134);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Rodas";
            // 
            // txtWheels
            // 
            this.txtWheels.Location = new System.Drawing.Point(61, 79);
            this.txtWheels.Name = "txtWheels";
            this.txtWheels.Size = new System.Drawing.Size(54, 20);
            this.txtWheels.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "KM por litro";
            // 
            // txtKMs
            // 
            this.txtKMs.Location = new System.Drawing.Point(391, 79);
            this.txtKMs.Name = "txtKMs";
            this.txtKMs.Size = new System.Drawing.Size(54, 20);
            this.txtKMs.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Peso suportado (KG)";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(246, 79);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(63, 20);
            this.txtWeight.TabIndex = 4;
            // 
            // AddVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 202);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKMs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWheels);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtModelName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFuel);
            this.Controls.Add(this.label6);
            this.Name = "AddVehicle";
            this.Text = "AddVehicle";
            this.Load += new System.EventHandler(this.AddVehicle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.TextBox txtModelName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWheels;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKMs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbFuel;

    }
}