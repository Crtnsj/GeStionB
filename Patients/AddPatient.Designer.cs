namespace GeStionB.Patients
{
    partial class AddPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPatient));
            Box_AddPatient_Name = new TextBox();
            Box_AddPatient_Prenom = new TextBox();
            Combo_AddPatient_sexe = new ComboBox();
            label_AddPatient_nom = new Label();
            label_AddPatient_prenom = new Label();
            label_AddPatient_sexe = new Label();
            button_AddPatient_Valid = new Button();
            date_AddPatient = new DateTimePicker();
            label3 = new Label();
            SuspendLayout();
            // 
            // Box_AddPatient_Name
            // 
            Box_AddPatient_Name.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Box_AddPatient_Name.Location = new Point(161, 78);
            Box_AddPatient_Name.Margin = new Padding(2);
            Box_AddPatient_Name.Name = "Box_AddPatient_Name";
            Box_AddPatient_Name.Size = new Size(187, 37);
            Box_AddPatient_Name.TabIndex = 0;
            Box_AddPatient_Name.TextChanged += textBox1_TextChanged;
            // 
            // Box_AddPatient_Prenom
            // 
            Box_AddPatient_Prenom.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Box_AddPatient_Prenom.Location = new Point(161, 195);
            Box_AddPatient_Prenom.Margin = new Padding(2);
            Box_AddPatient_Prenom.Name = "Box_AddPatient_Prenom";
            Box_AddPatient_Prenom.Size = new Size(210, 37);
            Box_AddPatient_Prenom.TabIndex = 1;
            // 
            // Combo_AddPatient_sexe
            // 
            Combo_AddPatient_sexe.BackColor = Color.White;
            Combo_AddPatient_sexe.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Combo_AddPatient_sexe.FormattingEnabled = true;
            Combo_AddPatient_sexe.Items.AddRange(new object[] { "Homme", "Femme" });
            Combo_AddPatient_sexe.Location = new Point(161, 301);
            Combo_AddPatient_sexe.Margin = new Padding(2);
            Combo_AddPatient_sexe.Name = "Combo_AddPatient_sexe";
            Combo_AddPatient_sexe.Size = new Size(210, 38);
            Combo_AddPatient_sexe.TabIndex = 8;
            // 
            // label_AddPatient_nom
            // 
            label_AddPatient_nom.AutoSize = true;
            label_AddPatient_nom.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label_AddPatient_nom.Location = new Point(161, 28);
            label_AddPatient_nom.Margin = new Padding(2, 0, 2, 0);
            label_AddPatient_nom.Name = "label_AddPatient_nom";
            label_AddPatient_nom.Size = new Size(71, 36);
            label_AddPatient_nom.TabIndex = 9;
            label_AddPatient_nom.Text = "Nom";
            // 
            // label_AddPatient_prenom
            // 
            label_AddPatient_prenom.AutoSize = true;
            label_AddPatient_prenom.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label_AddPatient_prenom.Location = new Point(161, 147);
            label_AddPatient_prenom.Margin = new Padding(2, 0, 2, 0);
            label_AddPatient_prenom.Name = "label_AddPatient_prenom";
            label_AddPatient_prenom.Size = new Size(105, 36);
            label_AddPatient_prenom.TabIndex = 10;
            label_AddPatient_prenom.Text = "Prenom";
            // 
            // label_AddPatient_sexe
            // 
            label_AddPatient_sexe.AutoSize = true;
            label_AddPatient_sexe.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label_AddPatient_sexe.Location = new Point(161, 251);
            label_AddPatient_sexe.Margin = new Padding(2, 0, 2, 0);
            label_AddPatient_sexe.Name = "label_AddPatient_sexe";
            label_AddPatient_sexe.Size = new Size(69, 36);
            label_AddPatient_sexe.TabIndex = 11;
            label_AddPatient_sexe.Text = "Sexe";
            // 
            // button_AddPatient_Valid
            // 
            button_AddPatient_Valid.BackColor = SystemColors.ControlLight;
            button_AddPatient_Valid.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_AddPatient_Valid.Location = new Point(36, 479);
            button_AddPatient_Valid.Margin = new Padding(2);
            button_AddPatient_Valid.Name = "button_AddPatient_Valid";
            button_AddPatient_Valid.Size = new Size(482, 72);
            button_AddPatient_Valid.TabIndex = 12;
            button_AddPatient_Valid.Text = "Créer le patient";
            button_AddPatient_Valid.UseVisualStyleBackColor = false;
            button_AddPatient_Valid.Click += button_AddPatient_Valid_Click;
            // 
            // date_AddPatient
            // 
            date_AddPatient.CustomFormat = "yyyy-MM-dd";
            date_AddPatient.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            date_AddPatient.Format = DateTimePickerFormat.Custom;
            date_AddPatient.Location = new Point(119, 404);
            date_AddPatient.Margin = new Padding(2);
            date_AddPatient.Name = "date_AddPatient";
            date_AddPatient.Size = new Size(301, 37);
            date_AddPatient.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(45, 357);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(456, 30);
            label3.TabIndex = 15;
            label3.Text = "Date de naissance format : (Année-Mois-Jour)";
            // 
            // AddPatient
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(547, 569);
            Controls.Add(date_AddPatient);
            Controls.Add(label3);
            Controls.Add(button_AddPatient_Valid);
            Controls.Add(label_AddPatient_sexe);
            Controls.Add(label_AddPatient_prenom);
            Controls.Add(label_AddPatient_nom);
            Controls.Add(Combo_AddPatient_sexe);
            Controls.Add(Box_AddPatient_Prenom);
            Controls.Add(Box_AddPatient_Name);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "AddPatient";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ajouter un patient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Box_AddPatient_Name;
        private TextBox Box_AddPatient_Prenom;
        private ComboBox Combo_AddPatient_sexe;
        private Label label_AddPatient_nom;
        private Label label_AddPatient_prenom;
        private Label label_AddPatient_sexe;
        private Button button_AddPatient_Valid;
        private DateTimePicker date_AddPatient;
        private Label label3;
    }
}