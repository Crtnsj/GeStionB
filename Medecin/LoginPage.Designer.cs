namespace GeStionB.Medecin
{
    partial class LoginPage
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
            Btn_Login_valid = new Button();
            Box_Login_Username = new TextBox();
            Box_Login_Password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btn_addUser = new Button();
            SuspendLayout();
            // 
            // Btn_Login_valid
            // 
            Btn_Login_valid.Location = new Point(395, 618);
            Btn_Login_valid.Name = "Btn_Login_valid";
            Btn_Login_valid.Size = new Size(169, 52);
            Btn_Login_valid.TabIndex = 0;
            Btn_Login_valid.Text = "Valider";
            Btn_Login_valid.UseVisualStyleBackColor = true;
            Btn_Login_valid.Click += Btn_Login_valid_Click;
            // 
            // Box_Login_Username
            // 
            Box_Login_Username.Location = new Point(369, 326);
            Box_Login_Username.Name = "Box_Login_Username";
            Box_Login_Username.Size = new Size(225, 43);
            Box_Login_Username.TabIndex = 1;
            // 
            // Box_Login_Password
            // 
            Box_Login_Password.Location = new Point(369, 433);
            Box_Login_Password.Name = "Box_Login_Password";
            Box_Login_Password.Size = new Size(225, 43);
            Box_Login_Password.TabIndex = 2;
            Box_Login_Password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(369, 268);
            label1.Name = "label1";
            label1.Size = new Size(138, 37);
            label1.TabIndex = 3;
            label1.Text = "Identifiant";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(374, 385);
            label2.Name = "label2";
            label2.Size = new Size(176, 37);
            label2.TabIndex = 4;
            label2.Text = "Mot de passe";
            // 
            // btn_addUser
            // 
            btn_addUser.Location = new Point(802, 706);
            btn_addUser.Name = "btn_addUser";
            btn_addUser.Size = new Size(247, 52);
            btn_addUser.TabIndex = 5;
            btn_addUser.Text = "Creer un compte";
            btn_addUser.UseVisualStyleBackColor = true;
            btn_addUser.Click += btn_addUser_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 798);
            Controls.Add(btn_addUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Box_Login_Password);
            Controls.Add(Box_Login_Username);
            Controls.Add(Btn_Login_valid);
            Name = "LoginPage";
            Text = "LoginPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Login_valid;
        private TextBox Box_Login_Username;
        private TextBox Box_Login_Password;
        private Label label1;
        private Label label2;
        private Button btn_addUser;
    }
}