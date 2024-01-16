namespace GeStionB.Patients
{
    partial class PatientsDetails
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
            nom_p_label = new Label();
            prenom_p_label = new Label();
            Box_change_nom = new TextBox();
            Box_change_prenom = new TextBox();
            sexe_label = new Label();
            combo_change_sexe = new ComboBox();
            User_change_button = new Button();
            btn_PatientsDetails_Allergies = new Button();
            btn_PatientsDetails_Antec = new Button();
            SuspendLayout();
            // 
            // nom_p_label
            // 
            nom_p_label.AutoSize = true;
            nom_p_label.Location = new Point(136, 171);
            nom_p_label.Name = "nom_p_label";
            nom_p_label.Size = new Size(76, 37);
            nom_p_label.TabIndex = 0;
            nom_p_label.Text = "Nom";
            nom_p_label.Click += label1_Click;
            // 
            // prenom_p_label
            // 
            prenom_p_label.AutoSize = true;
            prenom_p_label.Location = new Point(141, 354);
            prenom_p_label.Name = "prenom_p_label";
            prenom_p_label.Size = new Size(109, 37);
            prenom_p_label.TabIndex = 1;
            prenom_p_label.Text = "Prenom";
            // 
            // Box_change_nom
            // 
            Box_change_nom.Location = new Point(141, 255);
            Box_change_nom.Name = "Box_change_nom";
            Box_change_nom.Size = new Size(225, 43);
            Box_change_nom.TabIndex = 2;
            // 
            // Box_change_prenom
            // 
            Box_change_prenom.Location = new Point(143, 468);
            Box_change_prenom.Name = "Box_change_prenom";
            Box_change_prenom.Size = new Size(225, 43);
            Box_change_prenom.TabIndex = 3;
            // 
            // sexe_label
            // 
            sexe_label.AutoSize = true;
            sexe_label.Location = new Point(136, 564);
            sexe_label.Name = "sexe_label";
            sexe_label.Size = new Size(71, 37);
            sexe_label.TabIndex = 6;
            sexe_label.Text = "Sexe";
            // 
            // combo_change_sexe
            // 
            combo_change_sexe.FormattingEnabled = true;
            combo_change_sexe.Items.AddRange(new object[] { "H", "F" });
            combo_change_sexe.Location = new Point(143, 639);
            combo_change_sexe.Name = "combo_change_sexe";
            combo_change_sexe.Size = new Size(279, 45);
            combo_change_sexe.TabIndex = 7;
            // 
            // User_change_button
            // 
            User_change_button.Location = new Point(600, 755);
            User_change_button.Name = "User_change_button";
            User_change_button.Size = new Size(329, 77);
            User_change_button.TabIndex = 8;
            User_change_button.Text = "Valider les changements";
            User_change_button.UseVisualStyleBackColor = true;
            User_change_button.Click += User_change_button_Click;
            // 
            // btn_PatientsDetails_Allergies
            // 
            btn_PatientsDetails_Allergies.Location = new Point(600, 306);
            btn_PatientsDetails_Allergies.Name = "btn_PatientsDetails_Allergies";
            btn_PatientsDetails_Allergies.Size = new Size(260, 52);
            btn_PatientsDetails_Allergies.TabIndex = 9;
            btn_PatientsDetails_Allergies.Text = "Gerer les allergies";
            btn_PatientsDetails_Allergies.UseVisualStyleBackColor = true;
            btn_PatientsDetails_Allergies.Click += btn_PatientsDetails_Allergies_Click;
            // 
            // btn_PatientsDetails_Antec
            // 
            btn_PatientsDetails_Antec.Location = new Point(600, 468);
            btn_PatientsDetails_Antec.Name = "btn_PatientsDetails_Antec";
            btn_PatientsDetails_Antec.Size = new Size(291, 52);
            btn_PatientsDetails_Antec.TabIndex = 10;
            btn_PatientsDetails_Antec.Text = "Gerer les antecedents";
            btn_PatientsDetails_Antec.UseVisualStyleBackColor = true;
            btn_PatientsDetails_Antec.Click += btn_PatientsDetails_Antec_Click;
            // 
            // PatientsDetails
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 894);
            Controls.Add(btn_PatientsDetails_Antec);
            Controls.Add(btn_PatientsDetails_Allergies);
            Controls.Add(User_change_button);
            Controls.Add(combo_change_sexe);
            Controls.Add(sexe_label);
            Controls.Add(Box_change_prenom);
            Controls.Add(Box_change_nom);
            Controls.Add(prenom_p_label);
            Controls.Add(nom_p_label);
            Name = "PatientsDetails";
            Text = "PatientsDatails";
            Load += PatientsDatails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nom_p_label;
        private Label prenom_p_label;
        private TextBox Box_change_nom;
        private TextBox Box_change_prenom;
        private Label sexe_label;
        private ComboBox combo_change_sexe;
        private Button User_change_button;
        private Button btn_PatientsDetails_Allergies;
        private Button btn_PatientsDetails_Antec;
    }
}