namespace GeStionB.Medicaments
{
    partial class AddMedicament
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
            combo_Antecedent = new ComboBox();
            label_addMedicament_CI = new Label();
            label_addMedicament_libelle = new Label();
            Box_AddMedicament_libelle = new TextBox();
            btn_addMedicament_addCI = new Button();
            Btn_AddMedicament_Ajouter = new Button();
            SuspendLayout();
            // 
            // combo_Antecedent
            // 
            combo_Antecedent.FormattingEnabled = true;
            combo_Antecedent.Location = new Point(192, 496);
            combo_Antecedent.Name = "combo_Antecedent";
            combo_Antecedent.Size = new Size(272, 45);
            combo_Antecedent.TabIndex = 0;
            combo_Antecedent.SelectedIndexChanged += combo_Antecedent_SelectedIndexChanged;
            // 
            // label_addMedicament_CI
            // 
            label_addMedicament_CI.AutoSize = true;
            label_addMedicament_CI.Location = new Point(192, 440);
            label_addMedicament_CI.Name = "label_addMedicament_CI";
            label_addMedicament_CI.Size = new Size(222, 37);
            label_addMedicament_CI.TabIndex = 1;
            label_addMedicament_CI.Text = "Contre indication";
            // 
            // label_addMedicament_libelle
            // 
            label_addMedicament_libelle.AutoSize = true;
            label_addMedicament_libelle.Location = new Point(189, 228);
            label_addMedicament_libelle.Name = "label_addMedicament_libelle";
            label_addMedicament_libelle.Size = new Size(287, 37);
            label_addMedicament_libelle.TabIndex = 2;
            label_addMedicament_libelle.Text = "Libelle du medicament";
            // 
            // Box_AddMedicament_libelle
            // 
            Box_AddMedicament_libelle.Location = new Point(189, 303);
            Box_AddMedicament_libelle.Name = "Box_AddMedicament_libelle";
            Box_AddMedicament_libelle.Size = new Size(225, 43);
            Box_AddMedicament_libelle.TabIndex = 3;
            // 
            // btn_addMedicament_addCI
            // 
            btn_addMedicament_addCI.Location = new Point(506, 489);
            btn_addMedicament_addCI.Name = "btn_addMedicament_addCI";
            btn_addMedicament_addCI.Size = new Size(539, 52);
            btn_addMedicament_addCI.TabIndex = 4;
            btn_addMedicament_addCI.Text = "Ajouter une contre indication (antecent)";
            btn_addMedicament_addCI.UseVisualStyleBackColor = true;
            // 
            // Btn_AddMedicament_Ajouter
            // 
            Btn_AddMedicament_Ajouter.Location = new Point(830, 640);
            Btn_AddMedicament_Ajouter.Name = "Btn_AddMedicament_Ajouter";
            Btn_AddMedicament_Ajouter.Size = new Size(215, 88);
            Btn_AddMedicament_Ajouter.TabIndex = 5;
            Btn_AddMedicament_Ajouter.Text = "Creer le medicament";
            Btn_AddMedicament_Ajouter.UseVisualStyleBackColor = true;
            Btn_AddMedicament_Ajouter.Click += Btn_AddMedicament_Ajouter_Click;
            // 
            // AddMedicament
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 765);
            Controls.Add(Btn_AddMedicament_Ajouter);
            Controls.Add(btn_addMedicament_addCI);
            Controls.Add(Box_AddMedicament_libelle);
            Controls.Add(label_addMedicament_libelle);
            Controls.Add(label_addMedicament_CI);
            Controls.Add(combo_Antecedent);
            Name = "AddMedicament";
            Text = "AddMedicament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox combo_Antecedent;
        private Label label_addMedicament_CI;
        private Label label_addMedicament_libelle;
        private TextBox Box_AddMedicament_libelle;
        private Button btn_addMedicament_addCI;
        private Button Btn_AddMedicament_Ajouter;
    }
}