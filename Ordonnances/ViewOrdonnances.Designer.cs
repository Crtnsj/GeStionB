namespace GeStionB.Ordonnances
{
    partial class ViewOrdonnances
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
            gridOrdonnance = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridOrdonnance).BeginInit();
            SuspendLayout();
            // 
            // gridOrdonnance
            // 
            gridOrdonnance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridOrdonnance.Location = new Point(60, 57);
            gridOrdonnance.Name = "gridOrdonnance";
            gridOrdonnance.RowHeadersWidth = 92;
            gridOrdonnance.RowTemplate.Height = 45;
            gridOrdonnance.Size = new Size(1304, 838);
            gridOrdonnance.TabIndex = 0;
            gridOrdonnance.CellContentClick += gridOrdonnance_CellContentClick;
            // 
            // ViewOrdonnances
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1440, 953);
            Controls.Add(gridOrdonnance);
            Name = "ViewOrdonnances";
            Text = "ViewOrdonnances";
            ((System.ComponentModel.ISupportInitialize)gridOrdonnance).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridOrdonnance;
    }
}