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
            comboBox1 = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            groupBox3 = new GroupBox();
            label12 = new Label();
            label11 = new Label();
            textBox10 = new TextBox();
            textBox9 = new TextBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            pictureBox3 = new PictureBox();
            button3 = new Button();
            pictureBox4 = new PictureBox();
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
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(35, 119);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 220);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Identité";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "MASCULIN", "FEMININ" });
            comboBox1.Location = new Point(95, 127);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(147, 28);
            comboBox1.TabIndex = 2;
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
            // textBox3
            // 
            textBox3.Location = new Point(95, 94);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(149, 27);
            textBox3.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(95, 61);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(149, 27);
            textBox2.TabIndex = 0;
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
            // textBox1
            // 
            textBox1.Location = new Point(95, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(149, 27);
            textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(textBox8);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox4);
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
            // textBox8
            // 
            textBox8.Location = new Point(104, 165);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(149, 27);
            textBox8.TabIndex = 0;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(104, 132);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(149, 27);
            textBox7.TabIndex = 0;
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
            // textBox6
            // 
            textBox6.Location = new Point(104, 98);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(149, 27);
            textBox6.TabIndex = 0;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(104, 65);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(149, 27);
            textBox5.TabIndex = 0;
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
            // textBox4
            // 
            textBox4.Location = new Point(104, 30);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(149, 27);
            textBox4.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(textBox10);
            groupBox3.Controls.Add(textBox9);
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
            // textBox10
            // 
            textBox10.Location = new Point(110, 68);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(149, 27);
            textBox10.TabIndex = 0;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(110, 30);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(149, 27);
            textBox9.TabIndex = 0;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // button1
            // 
            button1.Location = new Point(87, 368);
            button1.Name = "button1";
            button1.Size = new Size(181, 39);
            button1.TabIndex = 3;
            button1.Text = "Enregistrer et Fermer";
            button1.UseVisualStyleBackColor = true;
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
            // button2
            // 
            button2.Location = new Point(341, 368);
            button2.Name = "button2";
            button2.Size = new Size(181, 39);
            button2.TabIndex = 3;
            button2.Text = "Enregistrer";
            button2.UseVisualStyleBackColor = true;
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
            // button3
            // 
            button3.BackColor = Color.Silver;
            button3.Location = new Point(642, 369);
            button3.Name = "button3";
            button3.Size = new Size(181, 39);
            button3.TabIndex = 3;
            button3.Text = "Annuler";
            button3.UseVisualStyleBackColor = false;
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
            // ajouter_personne
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 476);
            Controls.Add(pictureBox4);
            Controls.Add(button3);
            Controls.Add(pictureBox3);
            Controls.Add(button2);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "ajouter_personne";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nouvelle Personne";
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
        private ComboBox comboBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox textBox8;
        private TextBox textBox7;
        private Label label7;
        private TextBox textBox6;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox4;
        private Label label12;
        private Label label11;
        private TextBox textBox10;
        private TextBox textBox9;
        private Button button1;
        private PictureBox pictureBox2;
        private Button button2;
        private PictureBox pictureBox3;
        private Button button3;
        private PictureBox pictureBox4;
    }
}