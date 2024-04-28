namespace GeStionB.Ordonnances
{
    partial class addOrdonnance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addOrdonnance));
            btn_AddOrdonnance = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            box_posologie = new TextBox();
            box_instructions = new TextBox();
            comboPatient = new ComboBox();
            comboMedicament = new ComboBox();
            label6 = new Label();
            box_duree = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)box_duree).BeginInit();
            SuspendLayout();
            // 
            // btn_AddOrdonnance
            // 
            btn_AddOrdonnance.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_AddOrdonnance.Location = new Point(36, 522);
            btn_AddOrdonnance.Margin = new Padding(2);
            btn_AddOrdonnance.Name = "btn_AddOrdonnance";
            btn_AddOrdonnance.Size = new Size(426, 49);
            btn_AddOrdonnance.TabIndex = 0;
            btn_AddOrdonnance.Text = "Valider la création";
            btn_AddOrdonnance.UseVisualStyleBackColor = true;
            btn_AddOrdonnance.Click += btn_AddOrdonnance_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(36, 32);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 30);
            label1.TabIndex = 1;
            label1.Text = "Posologie";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(261, 32);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 30);
            label2.TabIndex = 2;
            label2.Text = "Durée";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(36, 269);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(236, 30);
            label3.TabIndex = 3;
            label3.Text = "Instructions specifiques";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(36, 157);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(78, 30);
            label4.TabIndex = 4;
            label4.Text = "Patient";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(261, 157);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(134, 30);
            label5.TabIndex = 5;
            label5.Text = "Medicament";
            // 
            // box_posologie
            // 
            box_posologie.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            box_posologie.Location = new Point(36, 75);
            box_posologie.Margin = new Padding(2);
            box_posologie.Name = "box_posologie";
            box_posologie.Size = new Size(151, 37);
            box_posologie.TabIndex = 6;
            // 
            // box_instructions
            // 
            box_instructions.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            box_instructions.Location = new Point(36, 303);
            box_instructions.Margin = new Padding(2);
            box_instructions.Multiline = true;
            box_instructions.Name = "box_instructions";
            box_instructions.Size = new Size(427, 195);
            box_instructions.TabIndex = 8;
            // 
            // comboPatient
            // 
            comboPatient.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            comboPatient.FormattingEnabled = true;
            comboPatient.Location = new Point(36, 192);
            comboPatient.Margin = new Padding(2);
            comboPatient.Name = "comboPatient";
            comboPatient.Size = new Size(183, 38);
            comboPatient.TabIndex = 9;
            // 
            // comboMedicament
            // 
            comboMedicament.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            comboMedicament.FormattingEnabled = true;
            comboMedicament.Location = new Point(268, 192);
            comboMedicament.Margin = new Padding(2);
            comboMedicament.Name = "comboMedicament";
            comboMedicament.Size = new Size(183, 38);
            comboMedicament.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(368, 192);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 11;
            // 
            // box_duree
            // 
            box_duree.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            box_duree.Location = new Point(268, 76);
            box_duree.Name = "box_duree";
            box_duree.Size = new Size(180, 37);
            box_duree.TabIndex = 12;
            // 
            // addOrdonnance
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 603);
            Controls.Add(box_duree);
            Controls.Add(label6);
            Controls.Add(comboMedicament);
            Controls.Add(comboPatient);
            Controls.Add(box_instructions);
            Controls.Add(box_posologie);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_AddOrdonnance);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "addOrdonnance";
            Text = "Créer une ordonnance";
            ((System.ComponentModel.ISupportInitialize)box_duree).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_AddOrdonnance;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox box_posologie;
        private TextBox box_instructions;
        private ComboBox comboPatient;
        private ComboBox comboMedicament;
        private Label label6;
        private NumericUpDown box_duree;
    }
}