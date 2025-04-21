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
            dataGridView1 = new DataGridView();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(524, 412);
            dataGridView1.TabIndex = 0;
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
            // button1
            // 
            button1.Location = new Point(607, 258);
            button1.Name = "button1";
            button1.Size = new Size(181, 39);
            button1.TabIndex = 5;
            button1.Text = "Modifier";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(607, 313);
            button2.Name = "button2";
            button2.Size = new Size(181, 39);
            button2.TabIndex = 5;
            button2.Text = "Supprimer";
            button2.UseVisualStyleBackColor = true;
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
            // button3
            // 
            button3.Location = new Point(607, 201);
            button3.Name = "button3";
            button3.Size = new Size(181, 39);
            button3.TabIndex = 5;
            button3.Text = "Nouveau";
            button3.UseVisualStyleBackColor = true;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(581, 100);
            label1.Name = "label1";
            label1.Size = new Size(207, 20);
            label1.TabIndex = 7;
            label1.Text = "Aucune personne selectionner";
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
            // personnes_list
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "personnes_list";
            Text = "Liste des personnes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private Button button3;
        private PictureBox pictureBox3;
        private Label label1;
        private PictureBox pictureBox4;
    }
}