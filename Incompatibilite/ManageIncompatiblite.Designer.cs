namespace GeStionB.Medicaments
{
    partial class ManageIncompatiblite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageIncompatiblite));
            combo_Medicaments = new ComboBox();
            combo_allergie = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            combo_antecedents = new ComboBox();
            btn_Incompatibilite_valid = new Button();
            SuspendLayout();
            // 
            // combo_Medicaments
            // 
            combo_Medicaments.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            combo_Medicaments.FormattingEnabled = true;
            combo_Medicaments.Location = new Point(77, 131);
            combo_Medicaments.Margin = new Padding(2, 2, 2, 2);
            combo_Medicaments.Name = "combo_Medicaments";
            combo_Medicaments.Size = new Size(183, 38);
            combo_Medicaments.TabIndex = 0;
            // 
            // combo_allergie
            // 
            combo_allergie.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            combo_allergie.FormattingEnabled = true;
            combo_allergie.Location = new Point(319, 131);
            combo_allergie.Margin = new Padding(2, 2, 2, 2);
            combo_allergie.Name = "combo_allergie";
            combo_allergie.Size = new Size(183, 38);
            combo_allergie.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(559, 85);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(124, 30);
            label1.TabIndex = 5;
            label1.Text = "Antecedent";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(319, 85);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 30);
            label2.TabIndex = 6;
            label2.Text = "Allergie";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(77, 85);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(134, 30);
            label3.TabIndex = 7;
            label3.Text = "Medicament";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(43, 30);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(391, 30);
            label4.TabIndex = 8;
            label4.Text = "Ce medicament est incompatible avec :";
            // 
            // combo_antecedents
            // 
            combo_antecedents.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            combo_antecedents.FormattingEnabled = true;
            combo_antecedents.Location = new Point(559, 131);
            combo_antecedents.Margin = new Padding(2, 2, 2, 2);
            combo_antecedents.Name = "combo_antecedents";
            combo_antecedents.Size = new Size(183, 38);
            combo_antecedents.TabIndex = 9;
            // 
            // btn_Incompatibilite_valid
            // 
            btn_Incompatibilite_valid.BackColor = SystemColors.ControlLight;
            btn_Incompatibilite_valid.Location = new Point(480, 194);
            btn_Incompatibilite_valid.Margin = new Padding(2, 2, 2, 2);
            btn_Incompatibilite_valid.Name = "btn_Incompatibilite_valid";
            btn_Incompatibilite_valid.Size = new Size(261, 46);
            btn_Incompatibilite_valid.TabIndex = 10;
            btn_Incompatibilite_valid.Text = "Valider l'incompatibilité";
            btn_Incompatibilite_valid.UseVisualStyleBackColor = false;
            btn_Incompatibilite_valid.Click += btn_Incompatibilite_valid_Click;
            // 
            // ManageIncompatiblite
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 261);
            Controls.Add(btn_Incompatibilite_valid);
            Controls.Add(combo_antecedents);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(combo_allergie);
            Controls.Add(combo_Medicaments);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            Name = "ManageIncompatiblite";
            Text = "Gérer les incompatibilités";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox combo_Medicaments;
        private ComboBox combo_allergie;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox combo_antecedents;
        private Button btn_Incompatibilite_valid;
    }
}