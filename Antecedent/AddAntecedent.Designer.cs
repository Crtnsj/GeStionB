namespace GeStionB.Antecedent
{
    partial class AddAntecedent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAntecedent));
            label_libelleAntecedent = new Label();
            Box_addAntecedent_libelle = new TextBox();
            btn_ajoutAntecedent = new Button();
            SuspendLayout();
            // 
            // label_libelleAntecedent
            // 
            label_libelleAntecedent.AutoSize = true;
            label_libelleAntecedent.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label_libelleAntecedent.Location = new Point(62, 39);
            label_libelleAntecedent.Margin = new Padding(2, 0, 2, 0);
            label_libelleAntecedent.Name = "label_libelleAntecedent";
            label_libelleAntecedent.Size = new Size(230, 30);
            label_libelleAntecedent.TabIndex = 0;
            label_libelleAntecedent.Text = "Libelle de l'antecedent";
            // 
            // Box_addAntecedent_libelle
            // 
            Box_addAntecedent_libelle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Box_addAntecedent_libelle.Location = new Point(98, 108);
            Box_addAntecedent_libelle.Margin = new Padding(2, 2, 2, 2);
            Box_addAntecedent_libelle.Name = "Box_addAntecedent_libelle";
            Box_addAntecedent_libelle.Size = new Size(151, 37);
            Box_addAntecedent_libelle.TabIndex = 1;
            // 
            // btn_ajoutAntecedent
            // 
            btn_ajoutAntecedent.BackColor = SystemColors.ControlLight;
            btn_ajoutAntecedent.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ajoutAntecedent.Location = new Point(82, 194);
            btn_ajoutAntecedent.Margin = new Padding(2, 2, 2, 2);
            btn_ajoutAntecedent.Name = "btn_ajoutAntecedent";
            btn_ajoutAntecedent.Size = new Size(188, 49);
            btn_ajoutAntecedent.TabIndex = 2;
            btn_ajoutAntecedent.Text = "Valider la création";
            btn_ajoutAntecedent.UseVisualStyleBackColor = false;
            btn_ajoutAntecedent.Click += btn_ajoutAntecedent_Click;
            // 
            // AddAntecedent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(368, 302);
            Controls.Add(btn_ajoutAntecedent);
            Controls.Add(Box_addAntecedent_libelle);
            Controls.Add(label_libelleAntecedent);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            Name = "AddAntecedent";
            Text = "Créer un antécédent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_libelleAntecedent;
        private TextBox Box_addAntecedent_libelle;
        private Button btn_ajoutAntecedent;
    }
}