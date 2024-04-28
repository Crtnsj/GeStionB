namespace GeStionB.Allergies
{
    partial class AttributeAllergies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttributeAllergies));
            combo_Allergies = new ComboBox();
            label_attributeAllergies = new Label();
            btn_attributeAllergies_valid = new Button();
            btn_createAllergie = new Button();
            SuspendLayout();
            // 
            // combo_Allergies
            // 
            combo_Allergies.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            combo_Allergies.FormattingEnabled = true;
            combo_Allergies.Location = new Point(105, 93);
            combo_Allergies.Margin = new Padding(2, 2, 2, 2);
            combo_Allergies.Name = "combo_Allergies";
            combo_Allergies.Size = new Size(192, 38);
            combo_Allergies.TabIndex = 0;
            // 
            // label_attributeAllergies
            // 
            label_attributeAllergies.AutoSize = true;
            label_attributeAllergies.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label_attributeAllergies.Location = new Point(44, 37);
            label_attributeAllergies.Margin = new Padding(2, 0, 2, 0);
            label_attributeAllergies.Name = "label_attributeAllergies";
            label_attributeAllergies.Size = new Size(381, 30);
            label_attributeAllergies.TabIndex = 1;
            label_attributeAllergies.Text = "Quelle allergie voulez-vous attribuer ?";
            label_attributeAllergies.Click += label_attributeAllergies_Click;
            // 
            // btn_attributeAllergies_valid
            // 
            btn_attributeAllergies_valid.BackColor = SystemColors.ControlLight;
            btn_attributeAllergies_valid.Location = new Point(105, 163);
            btn_attributeAllergies_valid.Margin = new Padding(2, 2, 2, 2);
            btn_attributeAllergies_valid.Name = "btn_attributeAllergies_valid";
            btn_attributeAllergies_valid.Size = new Size(192, 55);
            btn_attributeAllergies_valid.TabIndex = 2;
            btn_attributeAllergies_valid.Text = "Valider l'attribution";
            btn_attributeAllergies_valid.UseVisualStyleBackColor = false;
            btn_attributeAllergies_valid.Click += btn_attributeAllergies_valid_Click;
            // 
            // btn_createAllergie
            // 
            btn_createAllergie.BackColor = SystemColors.ControlLight;
            btn_createAllergie.Location = new Point(349, 87);
            btn_createAllergie.Margin = new Padding(2, 2, 2, 2);
            btn_createAllergie.Name = "btn_createAllergie";
            btn_createAllergie.Size = new Size(247, 51);
            btn_createAllergie.TabIndex = 3;
            btn_createAllergie.Text = "Ajouter une allergie à la liste";
            btn_createAllergie.UseVisualStyleBackColor = false;
            btn_createAllergie.Click += btn_createAllergie_Click;
            // 
            // AttributeAllergies
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 244);
            Controls.Add(btn_createAllergie);
            Controls.Add(btn_attributeAllergies_valid);
            Controls.Add(label_attributeAllergies);
            Controls.Add(combo_Allergies);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            Name = "AttributeAllergies";
            Text = "Attribuer des allergies";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox combo_Allergies;
        private Label label_attributeAllergies;
        private Button btn_attributeAllergies_valid;
        private Button btn_createAllergie;
    }
}