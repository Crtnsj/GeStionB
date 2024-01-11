
namespace GeStionB.Antecedent
{
    partial class ViewAntecedents
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
            Grid_Antecedent = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)Grid_Antecedent).BeginInit();
            SuspendLayout();
            // 
            // Grid_Antecedent
            // 
            Grid_Antecedent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_Antecedent.Location = new Point(45, 34);
            Grid_Antecedent.Name = "Grid_Antecedent";
            Grid_Antecedent.RowHeadersWidth = 92;
            Grid_Antecedent.RowTemplate.Height = 45;
            Grid_Antecedent.Size = new Size(911, 719);
            Grid_Antecedent.TabIndex = 0;
            // 
            // ViewAntecedents
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 820);
            Controls.Add(Grid_Antecedent);
            Name = "ViewAntecedents";
            Text = "ViewAntecedents";
            Load += ViewAntecedents_Load;
            ((System.ComponentModel.ISupportInitialize)Grid_Antecedent).EndInit();
            ResumeLayout(false);
        }

        private DataGridView Grid_Antecedent;
    }
    #endregion
}