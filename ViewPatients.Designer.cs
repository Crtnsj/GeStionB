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
            ((System.ComponentModel.ISupportInitialize)PatientGridView).BeginInit();
            SuspendLayout();
            // 
            // PatientGridView
            // 
            PatientGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PatientGridView.Location = new Point(55, 57);
            PatientGridView.Name = "PatientGridView";
            PatientGridView.RowHeadersWidth = 92;
            PatientGridView.Size = new Size(1432, 877);
            PatientGridView.TabIndex = 0;
            // 
            // ViewPatients
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1557, 989);
            Controls.Add(PatientGridView);
            Name = "ViewPatients";
            Text = "Utilisateurs";
            Load += Utilisateurs_Load;
            ((System.ComponentModel.ISupportInitialize)PatientGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView PatientGridView;
    }
}