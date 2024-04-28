namespace GeStionB.Ordonnances
{
    partial class OrdonnancesDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdonnancesDetails));
            btnCreatePDF = new Button();
            boxPosologie = new TextBox();
            boxDate = new TextBox();
            boxDuree = new TextBox();
            boxInstructions = new TextBox();
            comboMedicament = new ComboBox();
            comboPatient = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            boxId = new TextBox();
            label8 = new Label();
            btn_suppOrdonnance = new Button();
            boxMedecin = new TextBox();
            SuspendLayout();
            // 
            // btnCreatePDF
            // 
            btnCreatePDF.BackColor = SystemColors.ControlLight;
            btnCreatePDF.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreatePDF.ForeColor = SystemColors.ControlText;
            btnCreatePDF.Location = new Point(74, 427);
            btnCreatePDF.Margin = new Padding(2, 2, 2, 2);
            btnCreatePDF.Name = "btnCreatePDF";
            btnCreatePDF.Size = new Size(173, 76);
            btnCreatePDF.TabIndex = 0;
            btnCreatePDF.Text = "Generer le PDF";
            btnCreatePDF.UseVisualStyleBackColor = false;
            btnCreatePDF.Click += btnCreatePDF_Click;
            // 
            // boxPosologie
            // 
            boxPosologie.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            boxPosologie.Location = new Point(75, 100);
            boxPosologie.Margin = new Padding(2, 2, 2, 2);
            boxPosologie.Name = "boxPosologie";
            boxPosologie.Size = new Size(151, 37);
            boxPosologie.TabIndex = 1;
            // 
            // boxDate
            // 
            boxDate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            boxDate.Location = new Point(302, 100);
            boxDate.Margin = new Padding(2, 2, 2, 2);
            boxDate.Name = "boxDate";
            boxDate.ReadOnly = true;
            boxDate.Size = new Size(151, 37);
            boxDate.TabIndex = 2;
            // 
            // boxDuree
            // 
            boxDuree.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            boxDuree.Location = new Point(515, 100);
            boxDuree.Margin = new Padding(2, 2, 2, 2);
            boxDuree.Name = "boxDuree";
            boxDuree.Size = new Size(151, 37);
            boxDuree.TabIndex = 3;
            // 
            // boxInstructions
            // 
            boxInstructions.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            boxInstructions.Location = new Point(75, 217);
            boxInstructions.Margin = new Padding(2, 2, 2, 2);
            boxInstructions.Name = "boxInstructions";
            boxInstructions.Size = new Size(151, 37);
            boxInstructions.TabIndex = 4;
            // 
            // comboMedicament
            // 
            comboMedicament.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            comboMedicament.FormattingEnabled = true;
            comboMedicament.Location = new Point(75, 316);
            comboMedicament.Margin = new Padding(2, 2, 2, 2);
            comboMedicament.Name = "comboMedicament";
            comboMedicament.Size = new Size(183, 38);
            comboMedicament.TabIndex = 5;
            // 
            // comboPatient
            // 
            comboPatient.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            comboPatient.FormattingEnabled = true;
            comboPatient.Location = new Point(321, 316);
            comboPatient.Margin = new Padding(2, 2, 2, 2);
            comboPatient.Name = "comboPatient";
            comboPatient.Size = new Size(183, 38);
            comboPatient.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(75, 55);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 30);
            label1.TabIndex = 8;
            label1.Text = "Posologie";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(302, 55);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(173, 30);
            label2.TabIndex = 9;
            label2.Text = "Date de création";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(511, 55);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(292, 30);
            label3.TabIndex = 10;
            label3.Text = "Durée du traitement en jours";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(75, 171);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(218, 30);
            label4.TabIndex = 11;
            label4.Text = "Instruction spécifique";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(75, 278);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(212, 30);
            label5.TabIndex = 12;
            label5.Text = "Medicament prescrit";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(321, 278);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(78, 30);
            label6.TabIndex = 13;
            label6.Text = "Patient";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(515, 171);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(97, 30);
            label7.TabIndex = 14;
            label7.Text = "Medecin";
            // 
            // boxId
            // 
            boxId.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            boxId.Location = new Point(321, 217);
            boxId.Margin = new Padding(2, 2, 2, 2);
            boxId.Name = "boxId";
            boxId.ReadOnly = true;
            boxId.Size = new Size(151, 37);
            boxId.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(321, 171);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(110, 30);
            label8.TabIndex = 16;
            label8.Text = "Identifiant";
            // 
            // btn_suppOrdonnance
            // 
            btn_suppOrdonnance.ForeColor = Color.Red;
            btn_suppOrdonnance.Location = new Point(569, 468);
            btn_suppOrdonnance.Margin = new Padding(2, 2, 2, 2);
            btn_suppOrdonnance.Name = "btn_suppOrdonnance";
            btn_suppOrdonnance.Size = new Size(211, 35);
            btn_suppOrdonnance.TabIndex = 17;
            btn_suppOrdonnance.Text = "Supprimer l'ordonnance";
            btn_suppOrdonnance.UseVisualStyleBackColor = true;
            btn_suppOrdonnance.Click += btn_suppOrdonnance_Click;
            // 
            // boxMedecin
            // 
            boxMedecin.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            boxMedecin.Location = new Point(515, 217);
            boxMedecin.Margin = new Padding(2, 2, 2, 2);
            boxMedecin.Name = "boxMedecin";
            boxMedecin.ReadOnly = true;
            boxMedecin.Size = new Size(151, 37);
            boxMedecin.TabIndex = 18;
            // 
            // OrdonnancesDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 528);
            Controls.Add(boxMedecin);
            Controls.Add(btn_suppOrdonnance);
            Controls.Add(label8);
            Controls.Add(boxId);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboPatient);
            Controls.Add(comboMedicament);
            Controls.Add(boxInstructions);
            Controls.Add(boxDuree);
            Controls.Add(boxDate);
            Controls.Add(boxPosologie);
            Controls.Add(btnCreatePDF);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            Name = "OrdonnancesDetails";
            Text = "Détails de l'ordonnance";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreatePDF;
        private TextBox boxPosologie;
        private TextBox boxDate;
        private TextBox boxDuree;
        private TextBox boxInstructions;
        private ComboBox comboMedicament;
        private ComboBox comboPatient;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox boxId;
        private Label label8;
        private Button btn_suppOrdonnance;
        private TextBox boxMedecin;
    }
}