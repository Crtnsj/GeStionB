namespace GeStionB.Medicaments
{
    partial class MedicamentsDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicamentsDetails));
            Box_change_libelle = new TextBox();
            btn_MedicamentsDetails_Valid = new Button();
            btn_MNGIncompatibilite = new Button();
            label_addMedicament_libelle = new Label();
            SuspendLayout();
            // 
            // Box_change_libelle
            // 
            Box_change_libelle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Box_change_libelle.Location = new Point(183, 110);
            Box_change_libelle.Margin = new Padding(2, 2, 2, 2);
            Box_change_libelle.Name = "Box_change_libelle";
            Box_change_libelle.Size = new Size(151, 37);
            Box_change_libelle.TabIndex = 1;
            // 
            // btn_MedicamentsDetails_Valid
            // 
            btn_MedicamentsDetails_Valid.BackColor = SystemColors.ControlLight;
            btn_MedicamentsDetails_Valid.Location = new Point(263, 181);
            btn_MedicamentsDetails_Valid.Margin = new Padding(2, 2, 2, 2);
            btn_MedicamentsDetails_Valid.Name = "btn_MedicamentsDetails_Valid";
            btn_MedicamentsDetails_Valid.Size = new Size(250, 43);
            btn_MedicamentsDetails_Valid.TabIndex = 6;
            btn_MedicamentsDetails_Valid.Text = "Valider les modifications";
            btn_MedicamentsDetails_Valid.UseVisualStyleBackColor = false;
            btn_MedicamentsDetails_Valid.Click += btn_MedicamentsDetails_Valid_Click;
            // 
            // btn_MNGIncompatibilite
            // 
            btn_MNGIncompatibilite.BackColor = SystemColors.ControlLight;
            btn_MNGIncompatibilite.Location = new Point(11, 182);
            btn_MNGIncompatibilite.Margin = new Padding(2, 2, 2, 2);
            btn_MNGIncompatibilite.Name = "btn_MNGIncompatibilite";
            btn_MNGIncompatibilite.Size = new Size(223, 42);
            btn_MNGIncompatibilite.TabIndex = 7;
            btn_MNGIncompatibilite.Text = "Gérer les incompatibilités";
            btn_MNGIncompatibilite.UseVisualStyleBackColor = false;
            btn_MNGIncompatibilite.Click += button1_Click;
            // 
            // label_addMedicament_libelle
            // 
            label_addMedicament_libelle.AutoSize = true;
            label_addMedicament_libelle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label_addMedicament_libelle.Location = new Point(150, 57);
            label_addMedicament_libelle.Margin = new Padding(2, 0, 2, 0);
            label_addMedicament_libelle.Name = "label_addMedicament_libelle";
            label_addMedicament_libelle.Size = new Size(232, 30);
            label_addMedicament_libelle.TabIndex = 8;
            label_addMedicament_libelle.Text = "Libellé du médicament";
            // 
            // MedicamentsDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 247);
            Controls.Add(label_addMedicament_libelle);
            Controls.Add(btn_MNGIncompatibilite);
            Controls.Add(btn_MedicamentsDetails_Valid);
            Controls.Add(Box_change_libelle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            Name = "MedicamentsDetails";
            Text = "Détails du médicament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Box_change_libelle;
        private Button btn_MedicamentsDetails_Valid;
        private Button btn_MNGIncompatibilite;
        private Label label_addMedicament_libelle;
    }
}