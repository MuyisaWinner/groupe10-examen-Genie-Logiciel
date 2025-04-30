namespace ProjetGroupe10
{
    partial class ajouter_personne
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtPrenom = new TextBox();
            txtPost = new TextBox();
            label2 = new Label();
            txtNom = new TextBox();
            groupBox2 = new GroupBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            txtVille = new TextBox();
            txtCommune = new TextBox();
            label7 = new Label();
            txtQuartier = new TextBox();
            txtAvenue = new TextBox();
            label6 = new Label();
            txtNumero = new TextBox();
            groupBox3 = new GroupBox();
            label12 = new Label();
            label11 = new Label();
            txtNumeroTel = new TextBox();
            txtCode = new TextBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            btnSaveClose = new Button();
            pictureBox2 = new PictureBox();
            btnSave = new Button();
            pictureBox3 = new PictureBox();
            btnClose = new Button();
            pictureBox4 = new PictureBox();
            rdMasculin = new RadioButton();
            rdFeminin = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat SemiBold", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(341, 24);
            label1.Name = "label1";
            label1.Size = new Size(275, 36);
            label1.TabIndex = 0;
            label1.Text = "Ajouter une personne";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.male_9634138;
            pictureBox1.Location = new Point(282, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdFeminin);
            groupBox1.Controls.Add(rdMasculin);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPrenom);
            groupBox1.Controls.Add(txtPost);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNom);
            groupBox1.Location = new Point(35, 119);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 220);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Identité";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 130);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 1;
            label5.Text = "Sexe";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 97);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 1;
            label4.Text = "Prenom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 64);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 1;
            label3.Text = "Post Nom";
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(95, 94);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(149, 27);
            txtPrenom.TabIndex = 0;
            // 
            // txtPost
            // 
            txtPost.Location = new Point(95, 61);
            txtPost.Name = "txtPost";
            txtPost.Size = new Size(149, 27);
            txtPost.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 29);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 1;
            label2.Text = "Nom";
            // 
            // txtNom
            // 
            txtNom.Location = new Point(95, 26);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(149, 27);
            txtNom.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtVille);
            groupBox2.Controls.Add(txtCommune);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtQuartier);
            groupBox2.Controls.Add(txtAvenue);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtNumero);
            groupBox2.Location = new Point(303, 119);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(263, 220);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Adresse";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 168);
            label10.Name = "label10";
            label10.Size = new Size(38, 20);
            label10.TabIndex = 1;
            label10.Text = "Ville";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 135);
            label9.Name = "label9";
            label9.Size = new Size(77, 20);
            label9.TabIndex = 1;
            label9.Text = "Commune";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 101);
            label8.Name = "label8";
            label8.Size = new Size(63, 20);
            label8.TabIndex = 1;
            label8.Text = "Quartier";
            // 
            // txtVille
            // 
            txtVille.Location = new Point(104, 165);
            txtVille.Name = "txtVille";
            txtVille.Size = new Size(149, 27);
            txtVille.TabIndex = 0;
            // 
            // txtCommune
            // 
            txtCommune.Location = new Point(104, 132);
            txtCommune.Name = "txtCommune";
            txtCommune.Size = new Size(149, 27);
            txtCommune.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 68);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 1;
            label7.Text = "Avenue";
            // 
            // txtQuartier
            // 
            txtQuartier.Location = new Point(104, 98);
            txtQuartier.Name = "txtQuartier";
            txtQuartier.Size = new Size(149, 27);
            txtQuartier.TabIndex = 0;
            // 
            // txtAvenue
            // 
            txtAvenue.Location = new Point(104, 65);
            txtAvenue.Name = "txtAvenue";
            txtAvenue.Size = new Size(149, 27);
            txtAvenue.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 33);
            label6.Name = "label6";
            label6.Size = new Size(32, 20);
            label6.TabIndex = 1;
            label6.Text = "No.";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(104, 30);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(149, 27);
            txtNumero.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(txtNumeroTel);
            groupBox3.Controls.Add(txtCode);
            groupBox3.Location = new Point(592, 119);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(265, 220);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Telephone";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(21, 71);
            label12.Name = "label12";
            label12.Size = new Size(63, 20);
            label12.TabIndex = 1;
            label12.Text = "Numero";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(21, 33);
            label11.Name = "label11";
            label11.Size = new Size(44, 20);
            label11.TabIndex = 1;
            label11.Text = "Code";
            // 
            // txtNumeroTel
            // 
            txtNumeroTel.Location = new Point(110, 68);
            txtNumeroTel.Name = "txtNumeroTel";
            txtNumeroTel.Size = new Size(149, 27);
            txtNumeroTel.TabIndex = 0;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(110, 30);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(149, 27);
            txtCode.TabIndex = 0;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // btnSaveClose
            // 
            btnSaveClose.Location = new Point(87, 368);
            btnSaveClose.Name = "btnSaveClose";
            btnSaveClose.Size = new Size(181, 39);
            btnSaveClose.TabIndex = 3;
            btnSaveClose.Text = "Enregistrer et Fermer";
            btnSaveClose.UseVisualStyleBackColor = true;
            btnSaveClose.Click += btnSaveClose_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.decision_18967758;
            pictureBox2.Location = new Point(37, 368);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(341, 368);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(181, 39);
            btnSave.TabIndex = 3;
            btnSave.Text = "Enregistrer";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.check_14025690;
            pictureBox3.Location = new Point(291, 368);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Silver;
            btnClose.Location = new Point(642, 369);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(181, 39);
            btnClose.TabIndex = 3;
            btnClose.Text = "Annuler";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.close_17216753;
            pictureBox4.Location = new Point(592, 369);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(44, 38);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // rdMasculin
            // 
            rdMasculin.AutoSize = true;
            rdMasculin.Checked = true;
            rdMasculin.Location = new Point(95, 135);
            rdMasculin.Name = "rdMasculin";
            rdMasculin.Size = new Size(88, 24);
            rdMasculin.TabIndex = 3;
            rdMasculin.TabStop = true;
            rdMasculin.Text = "Masculin";
            rdMasculin.UseVisualStyleBackColor = true;
            // 
            // rdFeminin
            // 
            rdFeminin.AutoSize = true;
            rdFeminin.Location = new Point(95, 169);
            rdFeminin.Name = "rdFeminin";
            rdFeminin.Size = new Size(82, 24);
            rdFeminin.TabIndex = 4;
            rdFeminin.Text = "Feminin";
            rdFeminin.UseVisualStyleBackColor = true;
            // 
            // ajouter_personne
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 476);
            Controls.Add(pictureBox4);
            Controls.Add(btnClose);
            Controls.Add(pictureBox3);
            Controls.Add(btnSave);
            Controls.Add(pictureBox2);
            Controls.Add(btnSaveClose);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "ajouter_personne";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nouvelle Personne";
            Load += ajouter_personne_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtPrenom;
        private TextBox txtPost;
        private Label label2;
        private TextBox txtNom;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox txtVille;
        private TextBox txtCommune;
        private Label label7;
        private TextBox txtQuartier;
        private TextBox txtAvenue;
        private Label label6;
        private TextBox txtNumero;
        private Label label12;
        private Label label11;
        private TextBox txtNumeroTel;
        private TextBox txtCode;
        private Button btnSaveClose;
        private PictureBox pictureBox2;
        private Button btnSave;
        private PictureBox pictureBox3;
        private Button btnClose;
        private PictureBox pictureBox4;
        private RadioButton rdFeminin;
        private RadioButton rdMasculin;
    }
}