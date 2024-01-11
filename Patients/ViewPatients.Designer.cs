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
            PatientGridView = new DataGridView();
            Add_patient_button = new Button();
            ((System.ComponentModel.ISupportInitialize)PatientGridView).BeginInit();
            SuspendLayout();
            // 
            // PatientGridView
            // 
            PatientGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PatientGridView.Location = new Point(45, 39);
            PatientGridView.Name = "PatientGridView";
            PatientGridView.RowHeadersWidth = 92;
            PatientGridView.Size = new Size(1432, 877);
            PatientGridView.TabIndex = 0;
            PatientGridView.CellContentClick += PatientGridView_CellContentClick;
            // 
            // Add_patient_button
            // 
            Add_patient_button.Location = new Point(1237, 966);
            Add_patient_button.Name = "Add_patient_button";
            Add_patient_button.Size = new Size(240, 61);
            Add_patient_button.TabIndex = 1;
            Add_patient_button.Text = "Ajouter un patient";
            Add_patient_button.UseVisualStyleBackColor = true;
            Add_patient_button.Click += Add_patient_button_Click;
            // 
            // ViewPatients
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1522, 1070);
            Controls.Add(Add_patient_button);
            Controls.Add(PatientGridView);
            Name = "ViewPatients";
            Text = "Utilisateurs";
            ((System.ComponentModel.ISupportInitialize)PatientGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView PatientGridView;
        private Button Add_patient_button;
    }
}