﻿namespace GeStionB.Patients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientsDetails));
            nom_p_label = new Label();
            prenom_p_label = new Label();
            Box_change_nom = new TextBox();
            Box_change_prenom = new TextBox();
            sexe_label = new Label();
            combo_change_sexe = new ComboBox();
            User_change_button = new Button();
            btn_PatientsDetails_Allergies = new Button();
            btn_PatientsDetails_Antec = new Button();
            date_PatientDetails = new DateTimePicker();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // nom_p_label
            // 
            nom_p_label.AutoSize = true;
            nom_p_label.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            nom_p_label.Location = new Point(185, 9);
            nom_p_label.Margin = new Padding(2, 0, 2, 0);
            nom_p_label.Name = "nom_p_label";
            nom_p_label.Size = new Size(61, 30);
            nom_p_label.TabIndex = 0;
            nom_p_label.Text = "Nom";
            nom_p_label.Click += label1_Click;
            // 
            // prenom_p_label
            // 
            prenom_p_label.AutoSize = true;
            prenom_p_label.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            prenom_p_label.Location = new Point(185, 100);
            prenom_p_label.Margin = new Padding(2, 0, 2, 0);
            prenom_p_label.Name = "prenom_p_label";
            prenom_p_label.Size = new Size(89, 30);
            prenom_p_label.TabIndex = 1;
            prenom_p_label.Text = "Prenom";
            // 
            // Box_change_nom
            // 
            Box_change_nom.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Box_change_nom.Location = new Point(185, 41);
            Box_change_nom.Margin = new Padding(2);
            Box_change_nom.Name = "Box_change_nom";
            Box_change_nom.Size = new Size(151, 37);
            Box_change_nom.TabIndex = 1;
            // 
            // Box_change_prenom
            // 
            Box_change_prenom.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Box_change_prenom.Location = new Point(185, 132);
            Box_change_prenom.Margin = new Padding(2);
            Box_change_prenom.Name = "Box_change_prenom";
            Box_change_prenom.Size = new Size(151, 37);
            Box_change_prenom.TabIndex = 2;
            // 
            // sexe_label
            // 
            sexe_label.AutoSize = true;
            sexe_label.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            sexe_label.Location = new Point(187, 190);
            sexe_label.Margin = new Padding(2, 0, 2, 0);
            sexe_label.Name = "sexe_label";
            sexe_label.Size = new Size(59, 30);
            sexe_label.TabIndex = 6;
            sexe_label.Text = "Sexe";
            // 
            // combo_change_sexe
            // 
            combo_change_sexe.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            combo_change_sexe.FormattingEnabled = true;
            combo_change_sexe.Items.AddRange(new object[] { "H", "F" });
            combo_change_sexe.Location = new Point(185, 231);
            combo_change_sexe.Margin = new Padding(2);
            combo_change_sexe.Name = "combo_change_sexe";
            combo_change_sexe.Size = new Size(187, 38);
            combo_change_sexe.TabIndex = 5;
            // 
            // User_change_button
            // 
            User_change_button.BackColor = SystemColors.ControlLight;
            User_change_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            User_change_button.Location = new Point(22, 450);
            User_change_button.Margin = new Padding(2);
            User_change_button.Name = "User_change_button";
            User_change_button.Size = new Size(498, 64);
            User_change_button.TabIndex = 7;
            User_change_button.Text = "Valider les changements";
            User_change_button.UseVisualStyleBackColor = false;
            User_change_button.Click += User_change_button_Click;
            // 
            // btn_PatientsDetails_Allergies
            // 
            btn_PatientsDetails_Allergies.BackColor = SystemColors.ControlLight;
            btn_PatientsDetails_Allergies.Location = new Point(347, 400);
            btn_PatientsDetails_Allergies.Margin = new Padding(2);
            btn_PatientsDetails_Allergies.Name = "btn_PatientsDetails_Allergies";
            btn_PatientsDetails_Allergies.Size = new Size(173, 35);
            btn_PatientsDetails_Allergies.TabIndex = 3;
            btn_PatientsDetails_Allergies.Text = "Gerer les allergies";
            btn_PatientsDetails_Allergies.UseVisualStyleBackColor = false;
            btn_PatientsDetails_Allergies.Click += btn_PatientsDetails_Allergies_Click;
            // 
            // btn_PatientsDetails_Antec
            // 
            btn_PatientsDetails_Antec.BackColor = SystemColors.ControlLight;
            btn_PatientsDetails_Antec.Location = new Point(25, 400);
            btn_PatientsDetails_Antec.Margin = new Padding(2);
            btn_PatientsDetails_Antec.Name = "btn_PatientsDetails_Antec";
            btn_PatientsDetails_Antec.Size = new Size(194, 35);
            btn_PatientsDetails_Antec.TabIndex = 4;
            btn_PatientsDetails_Antec.Text = "Gerer les antecedents";
            btn_PatientsDetails_Antec.UseVisualStyleBackColor = false;
            btn_PatientsDetails_Antec.Click += btn_PatientsDetails_Antec_Click;
            // 
            // date_PatientDetails
            // 
            date_PatientDetails.CustomFormat = "yyyy-MM-dd";
            date_PatientDetails.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            date_PatientDetails.Format = DateTimePickerFormat.Custom;
            date_PatientDetails.Location = new Point(138, 327);
            date_PatientDetails.Margin = new Padding(2);
            date_PatientDetails.Name = "date_PatientDetails";
            date_PatientDetails.Size = new Size(301, 37);
            date_PatientDetails.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(64, 284);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(456, 30);
            label3.TabIndex = 17;
            label3.Text = "Date de naissance format : (Année-Mois-Jour)";
            // 
            // button1
            // 
            button1.ForeColor = Color.Red;
            button1.Location = new Point(333, 523);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(187, 35);
            button1.TabIndex = 18;
            button1.Text = "Supprimer le patient";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PatientsDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(547, 569);
            Controls.Add(button1);
            Controls.Add(date_PatientDetails);
            Controls.Add(label3);
            Controls.Add(btn_PatientsDetails_Antec);
            Controls.Add(btn_PatientsDetails_Allergies);
            Controls.Add(User_change_button);
            Controls.Add(combo_change_sexe);
            Controls.Add(sexe_label);
            Controls.Add(Box_change_prenom);
            Controls.Add(Box_change_nom);
            Controls.Add(prenom_p_label);
            Controls.Add(nom_p_label);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "PatientsDetails";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Détails du patient";
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
        private DateTimePicker date_PatientDetails;
        private Label label3;
        private Button button1;
    }
}