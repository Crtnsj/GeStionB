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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewOrdonnances));
            gridOrdonnance = new DataGridView();
            btn_AddOrdonnance = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)gridOrdonnance).BeginInit();
            SuspendLayout();
            // 
            // gridOrdonnance
            // 
            gridOrdonnance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridOrdonnance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridOrdonnance.Location = new Point(-2, -1);
            gridOrdonnance.Margin = new Padding(2);
            gridOrdonnance.Name = "gridOrdonnance";
            gridOrdonnance.RowHeadersWidth = 92;
            gridOrdonnance.RowTemplate.Height = 45;
            gridOrdonnance.Size = new Size(1426, 709);
            gridOrdonnance.TabIndex = 0;
            gridOrdonnance.CellContentClick += gridOrdonnance_CellContentClick;
            // 
            // btn_AddOrdonnance
            // 
            btn_AddOrdonnance.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_AddOrdonnance.Location = new Point(1162, 728);
            btn_AddOrdonnance.Margin = new Padding(2);
            btn_AddOrdonnance.Name = "btn_AddOrdonnance";
            btn_AddOrdonnance.Size = new Size(250, 58);
            btn_AddOrdonnance.TabIndex = 1;
            btn_AddOrdonnance.Text = "Créer une ordonnance";
            btn_AddOrdonnance.UseVisualStyleBackColor = true;
            btn_AddOrdonnance.Click += btn_AddOrdonnance_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Location = new Point(12, 751);
            button1.Name = "button1";
            button1.Size = new Size(198, 34);
            button1.TabIndex = 4;
            button1.Text = "Retourner à l'accueil";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ViewOrdonnances
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1423, 797);
            Controls.Add(button1);
            Controls.Add(btn_AddOrdonnance);
            Controls.Add(gridOrdonnance);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "ViewOrdonnances";
            Text = "Liste des ordonnances";
            FormClosed += ViewOrdonnances_FormClosed;
            ((System.ComponentModel.ISupportInitialize)gridOrdonnance).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridOrdonnance;
        private Button btn_AddOrdonnance;
        private Button button1;
    }
}