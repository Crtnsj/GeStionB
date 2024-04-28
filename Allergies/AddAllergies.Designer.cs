namespace GeStionB.Allergies
{
    partial class AddAllergies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAllergies));
            label_libelleAllergies = new Label();
            Box_libelleAllergie = new TextBox();
            btn_CreateAllergie_Validate = new Button();
            SuspendLayout();
            // 
            // label_libelleAllergies
            // 
            label_libelleAllergies.AutoSize = true;
            label_libelleAllergies.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label_libelleAllergies.Location = new Point(63, 27);
            label_libelleAllergies.Margin = new Padding(2, 0, 2, 0);
            label_libelleAllergies.Name = "label_libelleAllergies";
            label_libelleAllergies.Size = new Size(193, 30);
            label_libelleAllergies.TabIndex = 1;
            label_libelleAllergies.Text = "Libelle de l'allergie";
            // 
            // Box_libelleAllergie
            // 
            Box_libelleAllergie.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Box_libelleAllergie.Location = new Point(73, 71);
            Box_libelleAllergie.Margin = new Padding(2, 2, 2, 2);
            Box_libelleAllergie.Name = "Box_libelleAllergie";
            Box_libelleAllergie.Size = new Size(151, 37);
            Box_libelleAllergie.TabIndex = 2;
            // 
            // btn_CreateAllergie_Validate
            // 
            btn_CreateAllergie_Validate.BackColor = SystemColors.ControlLight;
            btn_CreateAllergie_Validate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_CreateAllergie_Validate.Location = new Point(20, 142);
            btn_CreateAllergie_Validate.Margin = new Padding(2, 2, 2, 2);
            btn_CreateAllergie_Validate.Name = "btn_CreateAllergie_Validate";
            btn_CreateAllergie_Validate.Size = new Size(260, 65);
            btn_CreateAllergie_Validate.TabIndex = 3;
            btn_CreateAllergie_Validate.TabStop = false;
            btn_CreateAllergie_Validate.Text = "Valider la création de l'allergie";
            btn_CreateAllergie_Validate.UseVisualStyleBackColor = false;
            btn_CreateAllergie_Validate.Click += btn_CreateAllergie_Validate_Click;
            // 
            // AddAllergies
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 254);
            Controls.Add(btn_CreateAllergie_Validate);
            Controls.Add(Box_libelleAllergie);
            Controls.Add(label_libelleAllergies);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            Name = "AddAllergies";
            Text = "Créer une allergie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_libelleAllergies;
        private TextBox Box_libelleAllergie;
        private Button btn_CreateAllergie_Validate;
    }
}