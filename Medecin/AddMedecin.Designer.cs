﻿namespace GeStionB.Medecin
{
    partial class AddMedecin
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
            box_AddMedecin_nom = new TextBox();
            box_AddMedecin_prenom = new TextBox();
            box_AddMedecin_MDP = new TextBox();
            box_AddMedecin_ID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_addMedecin_Valid = new Button();
            date_AddMedecin = new DateTimePicker();
            SuspendLayout();
            // 
            // box_AddMedecin_nom
            // 
            box_AddMedecin_nom.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            box_AddMedecin_nom.Location = new Point(43, 57);
            box_AddMedecin_nom.Margin = new Padding(2, 2, 2, 2);
            box_AddMedecin_nom.Name = "box_AddMedecin_nom";
            box_AddMedecin_nom.Size = new Size(151, 37);
            box_AddMedecin_nom.TabIndex = 0;
            // 
            // box_AddMedecin_prenom
            // 
            box_AddMedecin_prenom.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            box_AddMedecin_prenom.Location = new Point(43, 141);
            box_AddMedecin_prenom.Margin = new Padding(2, 2, 2, 2);
            box_AddMedecin_prenom.Name = "box_AddMedecin_prenom";
            box_AddMedecin_prenom.Size = new Size(151, 37);
            box_AddMedecin_prenom.TabIndex = 1;
            // 
            // box_AddMedecin_MDP
            // 
            box_AddMedecin_MDP.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            box_AddMedecin_MDP.Location = new Point(43, 383);
            box_AddMedecin_MDP.Margin = new Padding(2, 2, 2, 2);
            box_AddMedecin_MDP.Name = "box_AddMedecin_MDP";
            box_AddMedecin_MDP.Size = new Size(151, 37);
            box_AddMedecin_MDP.TabIndex = 3;
            // 
            // box_AddMedecin_ID
            // 
            box_AddMedecin_ID.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            box_AddMedecin_ID.Location = new Point(43, 323);
            box_AddMedecin_ID.Margin = new Padding(2, 2, 2, 2);
            box_AddMedecin_ID.Name = "box_AddMedecin_ID";
            box_AddMedecin_ID.Size = new Size(151, 37);
            box_AddMedecin_ID.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(46, 21);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 30);
            label1.TabIndex = 5;
            label1.Text = "Nom";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(46, 114);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 30);
            label2.TabIndex = 6;
            label2.Text = "Prénom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(43, 201);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(456, 30);
            label3.TabIndex = 7;
            label3.Text = "Date de naissance format : (Année-Mois-Jour)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(43, 296);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(110, 30);
            label4.TabIndex = 8;
            label4.Text = "Identifiant";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(43, 356);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(144, 30);
            label5.TabIndex = 9;
            label5.Text = "Mot de passe";
            // 
            // btn_addMedecin_Valid
            // 
            btn_addMedecin_Valid.BackColor = SystemColors.ControlLight;
            btn_addMedecin_Valid.Location = new Point(254, 474);
            btn_addMedecin_Valid.Margin = new Padding(2, 2, 2, 2);
            btn_addMedecin_Valid.Name = "btn_addMedecin_Valid";
            btn_addMedecin_Valid.Size = new Size(245, 43);
            btn_addMedecin_Valid.TabIndex = 10;
            btn_addMedecin_Valid.Text = "Valider les informations";
            btn_addMedecin_Valid.UseVisualStyleBackColor = false;
            btn_addMedecin_Valid.Click += btn_addMedecin_Valid_Click;
            // 
            // date_AddMedecin
            // 
            date_AddMedecin.CustomFormat = "yyyy-MM-dd";
            date_AddMedecin.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            date_AddMedecin.Format = DateTimePickerFormat.Custom;
            date_AddMedecin.Location = new Point(43, 235);
            date_AddMedecin.Margin = new Padding(2, 2, 2, 2);
            date_AddMedecin.Name = "date_AddMedecin";
            date_AddMedecin.Size = new Size(301, 37);
            date_AddMedecin.TabIndex = 11;
            // 
            // AddMedecin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 527);
            Controls.Add(date_AddMedecin);
            Controls.Add(btn_addMedecin_Valid);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(box_AddMedecin_ID);
            Controls.Add(box_AddMedecin_MDP);
            Controls.Add(box_AddMedecin_prenom);
            Controls.Add(box_AddMedecin_nom);
            Margin = new Padding(2, 2, 2, 2);
            Name = "AddMedecin";
            Text = "Créer un médecin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox box_AddMedecin_nom;
        private TextBox box_AddMedecin_prenom;
        private TextBox box_AddMedecin_MDP;
        private TextBox box_AddMedecin_ID;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_addMedecin_Valid;
        private DateTimePicker date_AddMedecin;
    }
}