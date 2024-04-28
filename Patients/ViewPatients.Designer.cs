namespace GeStionB
{
    partial class ViewPatients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPatients));
            PatientGridView = new DataGridView();
            Add_patient_button = new Button();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)PatientGridView).BeginInit();
            SuspendLayout();
            // 
            // PatientGridView
            // 
            PatientGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PatientGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PatientGridView.Location = new Point(423, 11);
            PatientGridView.Margin = new Padding(2);
            PatientGridView.Name = "PatientGridView";
            PatientGridView.ReadOnly = true;
            PatientGridView.RowHeadersWidth = 92;
            PatientGridView.Size = new Size(989, 775);
            PatientGridView.TabIndex = 0;
            PatientGridView.CellContentClick += PatientGridView_CellContentClick;
            // 
            // Add_patient_button
            // 
            Add_patient_button.BackColor = SystemColors.ControlLight;
            Add_patient_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Add_patient_button.Location = new Point(20, 724);
            Add_patient_button.Margin = new Padding(2);
            Add_patient_button.Name = "Add_patient_button";
            Add_patient_button.Size = new Size(370, 62);
            Add_patient_button.TabIndex = 1;
            Add_patient_button.Text = "Ajouter un patient";
            Add_patient_button.UseVisualStyleBackColor = false;
            Add_patient_button.Click += Add_patient_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(52, 107);
            label1.Name = "label1";
            label1.Size = new Size(310, 48);
            label1.TabIndex = 2;
            label1.Text = "Liste des patients";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Location = new Point(12, 11);
            button1.Name = "button1";
            button1.Size = new Size(198, 34);
            button1.TabIndex = 3;
            button1.Text = "Retourner à l'accueil";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ViewPatients
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1423, 797);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(Add_patient_button);
            Controls.Add(PatientGridView);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "ViewPatients";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Patients";
            FormClosed += ViewPatients_FormClosed;
            ((System.ComponentModel.ISupportInitialize)PatientGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView PatientGridView;
        private Button Add_patient_button;
        private Label label1;
        private Button button1;
    }
}