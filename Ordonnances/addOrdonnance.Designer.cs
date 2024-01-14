namespace GeStionB.Ordonnances
{
    partial class addOrdonnance
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
            btn_AddOrdonnance = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            box_posologie = new TextBox();
            box_duree = new TextBox();
            box_instructions = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // btn_AddOrdonnance
            // 
            btn_AddOrdonnance.Location = new Point(1131, 862);
            btn_AddOrdonnance.Name = "btn_AddOrdonnance";
            btn_AddOrdonnance.Size = new Size(240, 52);
            btn_AddOrdonnance.TabIndex = 0;
            btn_AddOrdonnance.Text = "Valider la création";
            btn_AddOrdonnance.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 98);
            label1.Name = "label1";
            label1.Size = new Size(134, 37);
            label1.TabIndex = 1;
            label1.Text = "Posologie";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(405, 95);
            label2.Name = "label2";
            label2.Size = new Size(88, 37);
            label2.TabIndex = 2;
            label2.Text = "Durée";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(722, 100);
            label3.Name = "label3";
            label3.Size = new Size(280, 37);
            label3.TabIndex = 3;
            label3.Text = "Instruction specifiques";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 413);
            label4.Name = "label4";
            label4.Size = new Size(99, 37);
            label4.TabIndex = 4;
            label4.Text = "Patient";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(448, 420);
            label5.Name = "label5";
            label5.Size = new Size(165, 37);
            label5.TabIndex = 5;
            label5.Text = "Medicament";
            // 
            // box_posologie
            // 
            box_posologie.Location = new Point(75, 159);
            box_posologie.Name = "box_posologie";
            box_posologie.Size = new Size(225, 43);
            box_posologie.TabIndex = 6;
            // 
            // box_duree
            // 
            box_duree.Location = new Point(413, 154);
            box_duree.Name = "box_duree";
            box_duree.Size = new Size(225, 43);
            box_duree.TabIndex = 7;
            // 
            // box_instructions
            // 
            box_instructions.Location = new Point(740, 161);
            box_instructions.Name = "box_instructions";
            box_instructions.Size = new Size(225, 43);
            box_instructions.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(118, 484);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(272, 45);
            comboBox1.TabIndex = 9;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(463, 489);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(272, 45);
            comboBox2.TabIndex = 10;
            // 
            // addOrdonnance
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1460, 978);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(box_instructions);
            Controls.Add(box_duree);
            Controls.Add(box_posologie);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_AddOrdonnance);
            Name = "addOrdonnance";
            Text = "addOrdonnance";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_AddOrdonnance;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox box_posologie;
        private TextBox box_duree;
        private TextBox box_instructions;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}