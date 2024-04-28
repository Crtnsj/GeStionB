namespace GeStionB.Medicaments
{
    partial class ViewMedicaments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMedicaments));
            MedicamentGridView = new DataGridView();
            Button_addMedicament = new Button();
            button1 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)MedicamentGridView).BeginInit();
            SuspendLayout();
            // 
            // MedicamentGridView
            // 
            MedicamentGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MedicamentGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MedicamentGridView.Location = new Point(473, 11);
            MedicamentGridView.Margin = new Padding(2);
            MedicamentGridView.Name = "MedicamentGridView";
            MedicamentGridView.RowHeadersWidth = 92;
            MedicamentGridView.RowTemplate.Height = 45;
            MedicamentGridView.Size = new Size(680, 775);
            MedicamentGridView.TabIndex = 0;
            MedicamentGridView.CellContentClick += MedicamentGridView_CellContentClick;
            // 
            // Button_addMedicament
            // 
            Button_addMedicament.BackColor = SystemColors.ControlLight;
            Button_addMedicament.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_addMedicament.Location = new Point(61, 696);
            Button_addMedicament.Margin = new Padding(2);
            Button_addMedicament.Name = "Button_addMedicament";
            Button_addMedicament.Size = new Size(274, 65);
            Button_addMedicament.TabIndex = 1;
            Button_addMedicament.Text = "Ajouter un médicament";
            Button_addMedicament.UseVisualStyleBackColor = false;
            Button_addMedicament.Click += Button_addMedicament_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(191, 34);
            button1.TabIndex = 2;
            button1.Text = "Retouner à l'accueil";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(21, 114);
            label1.Name = "label1";
            label1.Size = new Size(431, 48);
            label1.TabIndex = 3;
            label1.Text = "Liste des médicamments";
            label1.Click += label1_Click;
            // 
            // ViewMedicaments
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 797);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(Button_addMedicament);
            Controls.Add(MedicamentGridView);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "ViewMedicaments";
            Text = "Liste des medicaments";
            FormClosed += ViewMedicaments_FormClosed;
            ((System.ComponentModel.ISupportInitialize)MedicamentGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView MedicamentGridView;
        private Button Button_addMedicament;
        private Button button1;
        private Label label1;
    }
}