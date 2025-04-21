namespace ProjetGroupe10
{
    partial class InfosPage
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(485, 124);
            label3.Name = "label3";
            label3.Size = new Size(226, 24);
            label3.TabIndex = 8;
            label3.Text = "1. TSONGO MUYISA WINNER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(147, 335);
            label2.Name = "label2";
            label2.Size = new Size(117, 28);
            label2.TabIndex = 7;
            label2.Text = "GROUPE 10";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat Black", 12F, FontStyle.Bold);
            label1.Location = new Point(55, 304);
            label1.Name = "label1";
            label1.Size = new Size(300, 31);
            label1.TabIndex = 6;
            label1.Text = "COURS DE GENIE LOGICIEL";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_isig;
            pictureBox1.Location = new Point(88, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(238, 177);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // InfosPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "InfosPage";
            Text = "InfosPage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}