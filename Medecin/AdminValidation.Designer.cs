namespace GeStionB.Medecin
{
    partial class AdminValidation
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
            Box_mdpAdmin = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // Box_mdpAdmin
            // 
            Box_mdpAdmin.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Box_mdpAdmin.Location = new Point(207, 108);
            Box_mdpAdmin.Margin = new Padding(2, 2, 2, 2);
            Box_mdpAdmin.Name = "Box_mdpAdmin";
            Box_mdpAdmin.Size = new Size(151, 37);
            Box_mdpAdmin.TabIndex = 0;
            Box_mdpAdmin.KeyPress += Box_mdpAdmin_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 42);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(578, 30);
            label1.TabIndex = 1;
            label1.Text = "Mot de passe administrateur, valider avec la touche entrée";
            // 
            // AdminValidation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 173);
            Controls.Add(label1);
            Controls.Add(Box_mdpAdmin);
            Margin = new Padding(2, 2, 2, 2);
            Name = "AdminValidation";
            Text = "Validation administrateur";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Box_mdpAdmin;
        private Label label1;
    }
}