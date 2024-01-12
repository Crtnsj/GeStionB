namespace GeStionB.Ordonnances
{
    partial class OrdonnancesDetails
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
            btnCreatePDF = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            SuspendLayout();
            // 
            // btnCreatePDF
            // 
            btnCreatePDF.Location = new Point(935, 644);
            btnCreatePDF.Name = "btnCreatePDF";
            btnCreatePDF.Size = new Size(228, 52);
            btnCreatePDF.TabIndex = 0;
            btnCreatePDF.Text = "Generer le PDF";
            btnCreatePDF.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(126, 133);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 43);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(509, 146);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(225, 43);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(888, 159);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(225, 43);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(344, 339);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(225, 43);
            textBox4.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(108, 451);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(272, 45);
            comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(496, 451);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(272, 45);
            comboBox2.TabIndex = 6;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(860, 451);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(272, 45);
            comboBox3.TabIndex = 7;
            // 
            // OrdonnancesDetails
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1221, 782);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnCreatePDF);
            Name = "OrdonnancesDetails";
            Text = "OrdonnancesDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreatePDF;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
    }
}