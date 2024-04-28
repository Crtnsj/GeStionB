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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            Btn_Login_valid = new Button();
            Box_Login_Username = new TextBox();
            Box_Login_Password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btn_addUser = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Btn_Login_valid
            // 
            Btn_Login_valid.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Login_valid.Location = new Point(1321, 767);
            Btn_Login_valid.Name = "Btn_Login_valid";
            Btn_Login_valid.Size = new Size(600, 82);
            Btn_Login_valid.TabIndex = 3;
            Btn_Login_valid.Text = "Valider";
            Btn_Login_valid.UseVisualStyleBackColor = true;
            Btn_Login_valid.Click += Btn_Login_valid_Click;
            // 
            // Box_Login_Username
            // 
            Box_Login_Username.Location = new Point(1321, 559);
            Box_Login_Username.Name = "Box_Login_Username";
            Box_Login_Username.Size = new Size(600, 43);
            Box_Login_Username.TabIndex = 1;
            // 
            // Box_Login_Password
            // 
            Box_Login_Password.Location = new Point(1321, 674);
            Box_Login_Password.Name = "Box_Login_Password";
            Box_Login_Password.Size = new Size(600, 43);
            Box_Login_Password.TabIndex = 2;
            Box_Login_Password.UseSystemPasswordChar = true;
            Box_Login_Password.KeyPress += Box_Login_Password_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1321, 501);
            label1.Name = "label1";
            label1.Size = new Size(138, 37);
            label1.TabIndex = 3;
            label1.Text = "Identifiant";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1321, 616);
            label2.Name = "label2";
            label2.Size = new Size(176, 37);
            label2.TabIndex = 4;
            label2.Text = "Mot de passe";
            // 
            // btn_addUser
            // 
            btn_addUser.Location = new Point(1865, 1104);
            btn_addUser.Name = "btn_addUser";
            btn_addUser.Size = new Size(247, 52);
            btn_addUser.TabIndex = 5;
            btn_addUser.Text = "Créer un compte";
            btn_addUser.UseVisualStyleBackColor = true;
            btn_addUser.Click += btn_addUser_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1321, 132);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(600, 325);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-4, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1069, 1183);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(2134, 1179);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btn_addUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Box_Login_Password);
            Controls.Add(Box_Login_Username);
            Controls.Add(Btn_Login_valid);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginPage";
            Text = "Page de connexion";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}