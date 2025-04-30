namespace ProjetGroupe10
{
    partial class personnes_list
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
            dgPerson = new DataGridView();
            pictureBox2 = new PictureBox();
            btnEdit = new Button();
            btnDelete = new Button();
            pictureBox1 = new PictureBox();
            btNouveau = new Button();
            pictureBox3 = new PictureBox();
            labelPerson = new Label();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            btnRefrech = new Button();
            ((System.ComponentModel.ISupportInitialize)dgPerson).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // dgPerson
            // 
            dgPerson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPerson.Location = new Point(22, 23);
            dgPerson.Name = "dgPerson";
            dgPerson.RowHeadersWidth = 51;
            dgPerson.Size = new Size(524, 412);
            dgPerson.TabIndex = 0;
            dgPerson.CellContentClick += dataGridView1_CellContentClick;
            dgPerson.SelectionChanged += dgPerson_SelectionChanged;
            dgPerson.UserAddedRow += dgPerson_UserAddedRow;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.pen_10977638;
            pictureBox2.Location = new Point(557, 258);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(607, 258);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(181, 39);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Modifier";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(607, 313);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(181, 39);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Supprimer";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.delete_3694433;
            pictureBox1.Location = new Point(557, 313);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btNouveau
            // 
            btNouveau.Location = new Point(607, 201);
            btNouveau.Name = "btNouveau";
            btNouveau.Size = new Size(181, 39);
            btNouveau.TabIndex = 5;
            btNouveau.Text = "Nouveau";
            btNouveau.UseVisualStyleBackColor = true;
            btNouveau.Click += button3_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.add_8514918;
            pictureBox3.Location = new Point(557, 201);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // labelPerson
            // 
            labelPerson.AutoSize = true;
            labelPerson.Location = new Point(581, 100);
            labelPerson.Name = "labelPerson";
            labelPerson.Size = new Size(207, 20);
            labelPerson.TabIndex = 7;
            labelPerson.Text = "Aucune personne selectionner";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.male_9634138;
            pictureBox4.Location = new Point(655, 54);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(54, 43);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.rotate_right_7883567;
            pictureBox5.Location = new Point(557, 368);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(44, 38);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // btnRefrech
            // 
            btnRefrech.Location = new Point(607, 368);
            btnRefrech.Name = "btnRefrech";
            btnRefrech.Size = new Size(181, 36);
            btnRefrech.TabIndex = 8;
            btnRefrech.Text = "Actualiser";
            btnRefrech.UseVisualStyleBackColor = true;
            btnRefrech.Click += btnRefrech_Click;
            // 
            // personnes_list
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRefrech);
            Controls.Add(labelPerson);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox1);
            Controls.Add(btnDelete);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(btNouveau);
            Controls.Add(btnEdit);
            Controls.Add(dgPerson);
            Name = "personnes_list";
            Text = "Liste des personnes";
            Load += personnes_list_Load;
            ((System.ComponentModel.ISupportInitialize)dgPerson).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgPerson;
        private PictureBox pictureBox2;
        private Button btnEdit;
        private Button btnDelete;
        private PictureBox pictureBox1;
        private Button btNouveau;
        private PictureBox pictureBox3;
        private Label labelPerson;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Button btnRefrech;
    }
}