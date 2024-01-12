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
            Combo_change_CI = new ComboBox();
            Box_change_libelle = new TextBox();
            btn_MedicamentsDetails_addCI = new Button();
            btn_MedicamentsDetails_Valid = new Button();
            btn_MNGIncompatibilite = new Button();
            SuspendLayout();
            // 
            // Combo_change_CI
            // 
            Combo_change_CI.FormattingEnabled = true;
            Combo_change_CI.Location = new Point(270, 451);
            Combo_change_CI.Name = "Combo_change_CI";
            Combo_change_CI.Size = new Size(272, 45);
            Combo_change_CI.TabIndex = 0;
            // 
            // Box_change_libelle
            // 
            Box_change_libelle.Location = new Point(270, 324);
            Box_change_libelle.Name = "Box_change_libelle";
            Box_change_libelle.Size = new Size(225, 43);
            Box_change_libelle.TabIndex = 1;
            // 
            // btn_MedicamentsDetails_addCI
            // 
            btn_MedicamentsDetails_addCI.Location = new Point(624, 446);
            btn_MedicamentsDetails_addCI.Name = "btn_MedicamentsDetails_addCI";
            btn_MedicamentsDetails_addCI.Size = new Size(539, 52);
            btn_MedicamentsDetails_addCI.TabIndex = 5;
            btn_MedicamentsDetails_addCI.Text = "Ajouter une contre indication (antecent)";
            btn_MedicamentsDetails_addCI.UseVisualStyleBackColor = true;
            btn_MedicamentsDetails_addCI.Click += btn_MedicamentsDetails_addCI_Click;
            // 
            // btn_MedicamentsDetails_Valid
            // 
            btn_MedicamentsDetails_Valid.Location = new Point(926, 733);
            btn_MedicamentsDetails_Valid.Name = "btn_MedicamentsDetails_Valid";
            btn_MedicamentsDetails_Valid.Size = new Size(278, 111);
            btn_MedicamentsDetails_Valid.TabIndex = 6;
            btn_MedicamentsDetails_Valid.Text = "Valider les modifications";
            btn_MedicamentsDetails_Valid.UseVisualStyleBackColor = true;
            btn_MedicamentsDetails_Valid.Click += btn_MedicamentsDetails_Valid_Click;
            // 
            // btn_MNGIncompatibilite
            // 
            btn_MNGIncompatibilite.Location = new Point(624, 324);
            btn_MNGIncompatibilite.Name = "btn_MNGIncompatibilite";
            btn_MNGIncompatibilite.Size = new Size(446, 52);
            btn_MNGIncompatibilite.TabIndex = 7;
            btn_MNGIncompatibilite.Text = "Gérer les incompatibilités";
            btn_MNGIncompatibilite.UseVisualStyleBackColor = true;
            btn_MNGIncompatibilite.Click += button1_Click;
            // 
            // MedicamentsDetails
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1298, 887);
            Controls.Add(btn_MNGIncompatibilite);
            Controls.Add(btn_MedicamentsDetails_Valid);
            Controls.Add(btn_MedicamentsDetails_addCI);
            Controls.Add(Box_change_libelle);
            Controls.Add(Combo_change_CI);
            Name = "MedicamentsDetails";
            Text = "MedicamentsSetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Combo_change_CI;
        private TextBox Box_change_libelle;
        private Button btn_MedicamentsDetails_addCI;
        private Button btn_MedicamentsDetails_Valid;
        private Button btn_MNGIncompatibilite;
    }
}