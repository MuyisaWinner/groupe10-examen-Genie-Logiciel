namespace ProjetGroupe10
{
    partial class connexion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btn_connexion = new Button();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(297, 152);
            label1.Name = "label1";
            label1.Size = new Size(183, 44);
            label1.TabIndex = 0;
            label1.Text = "Connexion";
            label1.Click += label1_Click;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(285, 238);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "Nom d'utilisateur";
            txtUserName.Size = new Size(222, 27);
            txtUserName.TabIndex = 1;
            txtUserName.TextChanged += textBox1_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(285, 271);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Votre mot de passe";
            txtPassword.Size = new Size(222, 27);
            txtPassword.TabIndex = 1;
            txtPassword.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.profile_6915911;
            pictureBox1.Location = new Point(226, 236);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.key_6338885;
            pictureBox2.Location = new Point(226, 271);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // btn_connexion
            // 
            btn_connexion.Font = new Font("Montserrat", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_connexion.Location = new Point(325, 314);
            btn_connexion.Name = "btn_connexion";
            btn_connexion.Size = new Size(182, 29);
            btn_connexion.TabIndex = 3;
            btn_connexion.Text = "Connexion";
            btn_connexion.UseVisualStyleBackColor = true;
            btn_connexion.Click += btn_connexion_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(226, 196);
            label2.Name = "label2";
            label2.Size = new Size(322, 24);
            label2.TabIndex = 4;
            label2.Text = "Entrer vos identifiant pour vous connecter";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.password_9482478;
            pictureBox3.Location = new Point(310, 30);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(140, 119);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.chat_5251109;
            pictureBox4.Location = new Point(285, 316);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(40, 27);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // connexion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(btn_connexion);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label1);
            Name = "connexion";
            Text = "Connexion";
            Load += connexion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btn_connexion;
        private Label label2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}
