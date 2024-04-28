
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAntecedents));
            Grid_Antecedent = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)Grid_Antecedent).BeginInit();
            SuspendLayout();
            // 
            // Grid_Antecedent
            // 
            Grid_Antecedent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Grid_Antecedent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_Antecedent.Location = new Point(11, 11);
            Grid_Antecedent.Margin = new Padding(2, 2, 2, 2);
            Grid_Antecedent.Name = "Grid_Antecedent";
            Grid_Antecedent.RowHeadersWidth = 92;
            Grid_Antecedent.RowTemplate.Height = 45;
            Grid_Antecedent.Size = new Size(607, 486);
            Grid_Antecedent.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(321, 530);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(297, 46);
            button1.TabIndex = 1;
            button1.Text = "Attribuer un nouvel antécédent";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ViewAntecedents
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 597);
            Controls.Add(button1);
            Controls.Add(Grid_Antecedent);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            Name = "ViewAntecedents";
            Text = "Antécédents du patient";
            Load += ViewAntecedents_Load;
            ((System.ComponentModel.ISupportInitialize)Grid_Antecedent).EndInit();
            ResumeLayout(false);
        }

        private DataGridView Grid_Antecedent;
        private Button button1;
    }
    #endregion
}