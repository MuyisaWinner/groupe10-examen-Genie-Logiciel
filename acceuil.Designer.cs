namespace ProjetGroupe10
{
    partial class acceuil
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
            menuStrip1 = new MenuStrip();
            acceuilToolStripMenuItem = new ToolStripMenuItem();
            aProposToolStripMenuItem = new ToolStripMenuItem();
            personnesToolStripMenuItem = new ToolStripMenuItem();
            ajouterUnePersonneToolStripMenuItem = new ToolStripMenuItem();
            listeDesPersonnesToolStripMenuItem = new ToolStripMenuItem();
            parametreToolStripMenuItem = new ToolStripMenuItem();
            connexionBDToolStripMenuItem = new ToolStripMenuItem();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            etatDeSortieToolStripMenuItem = new ToolStripMenuItem();
            toutesLesPersonnesToolStripMenuItem = new ToolStripMenuItem();
            personnesAvecAdresseToolStripMenuItem = new ToolStripMenuItem();
            personnesAvecNumeroToolStripMenuItem = new ToolStripMenuItem();
            paramètreToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { acceuilToolStripMenuItem, personnesToolStripMenuItem, parametreToolStripMenuItem, etatDeSortieToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(876, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // acceuilToolStripMenuItem
            // 
            acceuilToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aProposToolStripMenuItem });
            acceuilToolStripMenuItem.Name = "acceuilToolStripMenuItem";
            acceuilToolStripMenuItem.Size = new Size(71, 24);
            acceuilToolStripMenuItem.Text = "A&cceuil";
            // 
            // aProposToolStripMenuItem
            // 
            aProposToolStripMenuItem.Image = Properties.Resources.info_11712819;
            aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            aProposToolStripMenuItem.Size = new Size(224, 26);
            aProposToolStripMenuItem.Text = "&A propos";
            aProposToolStripMenuItem.Click += aProposToolStripMenuItem_Click;
            // 
            // personnesToolStripMenuItem
            // 
            personnesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ajouterUnePersonneToolStripMenuItem, listeDesPersonnesToolStripMenuItem });
            personnesToolStripMenuItem.Name = "personnesToolStripMenuItem";
            personnesToolStripMenuItem.Size = new Size(88, 24);
            personnesToolStripMenuItem.Text = "P&ersonnes";
            // 
            // ajouterUnePersonneToolStripMenuItem
            // 
            ajouterUnePersonneToolStripMenuItem.Image = Properties.Resources.add_8514918;
            ajouterUnePersonneToolStripMenuItem.Name = "ajouterUnePersonneToolStripMenuItem";
            ajouterUnePersonneToolStripMenuItem.Size = new Size(234, 26);
            ajouterUnePersonneToolStripMenuItem.Text = "&Ajouter une personne";
            ajouterUnePersonneToolStripMenuItem.Click += ajouterUnePersonneToolStripMenuItem_Click;
            // 
            // listeDesPersonnesToolStripMenuItem
            // 
            listeDesPersonnesToolStripMenuItem.Image = Properties.Resources.menu_1990256;
            listeDesPersonnesToolStripMenuItem.Name = "listeDesPersonnesToolStripMenuItem";
            listeDesPersonnesToolStripMenuItem.Size = new Size(234, 26);
            listeDesPersonnesToolStripMenuItem.Text = "Liste des personnes";
            listeDesPersonnesToolStripMenuItem.Click += listeDesPersonnesToolStripMenuItem_Click;
            // 
            // parametreToolStripMenuItem
            // 
            parametreToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { connexionBDToolStripMenuItem, quitterToolStripMenuItem, paramètreToolStripMenuItem });
            parametreToolStripMenuItem.Name = "parametreToolStripMenuItem";
            parametreToolStripMenuItem.Size = new Size(90, 24);
            parametreToolStripMenuItem.Text = "P&aramètre";
            parametreToolStripMenuItem.Click += parametreToolStripMenuItem_Click;
            // 
            // connexionBDToolStripMenuItem
            // 
            connexionBDToolStripMenuItem.Image = Properties.Resources.link_17121507;
            connexionBDToolStripMenuItem.Name = "connexionBDToolStripMenuItem";
            connexionBDToolStripMenuItem.Size = new Size(224, 26);
            connexionBDToolStripMenuItem.Text = "Connexion BD";
            connexionBDToolStripMenuItem.Click += connexionBDToolStripMenuItem_Click;
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Image = Properties.Resources.socket_18080595;
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(224, 26);
            quitterToolStripMenuItem.Text = "&Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
            // 
            // etatDeSortieToolStripMenuItem
            // 
            etatDeSortieToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toutesLesPersonnesToolStripMenuItem, personnesAvecAdresseToolStripMenuItem, personnesAvecNumeroToolStripMenuItem });
            etatDeSortieToolStripMenuItem.Name = "etatDeSortieToolStripMenuItem";
            etatDeSortieToolStripMenuItem.Size = new Size(111, 24);
            etatDeSortieToolStripMenuItem.Text = "E&tat de sortie";
            etatDeSortieToolStripMenuItem.Click += etatDeSortieToolStripMenuItem_Click;
            // 
            // toutesLesPersonnesToolStripMenuItem
            // 
            toutesLesPersonnesToolStripMenuItem.Image = Properties.Resources.paper_15388297;
            toutesLesPersonnesToolStripMenuItem.Name = "toutesLesPersonnesToolStripMenuItem";
            toutesLesPersonnesToolStripMenuItem.Size = new Size(246, 26);
            toutesLesPersonnesToolStripMenuItem.Text = "Toutes les personnes";
            toutesLesPersonnesToolStripMenuItem.Click += toutesLesPersonnesToolStripMenuItem_Click;
            // 
            // personnesAvecAdresseToolStripMenuItem
            // 
            personnesAvecAdresseToolStripMenuItem.Image = Properties.Resources.location_16244249;
            personnesAvecAdresseToolStripMenuItem.Name = "personnesAvecAdresseToolStripMenuItem";
            personnesAvecAdresseToolStripMenuItem.Size = new Size(246, 26);
            personnesAvecAdresseToolStripMenuItem.Text = "Personnes avec adresse";
            // 
            // personnesAvecNumeroToolStripMenuItem
            // 
            personnesAvecNumeroToolStripMenuItem.Image = Properties.Resources.report_5251307;
            personnesAvecNumeroToolStripMenuItem.Name = "personnesAvecNumeroToolStripMenuItem";
            personnesAvecNumeroToolStripMenuItem.Size = new Size(246, 26);
            personnesAvecNumeroToolStripMenuItem.Text = "Personnes avec numero";
            // 
            // paramètreToolStripMenuItem
            // 
            paramètreToolStripMenuItem.Name = "paramètreToolStripMenuItem";
            paramètreToolStripMenuItem.Size = new Size(224, 26);
            paramètreToolStripMenuItem.Text = "P&aramètre";
            // 
            // acceuil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 500);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "acceuil";
            Text = "Acceuil";
            WindowState = FormWindowState.Maximized;
            Load += acceuil_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem acceuilToolStripMenuItem;
        private ToolStripMenuItem personnesToolStripMenuItem;
        private ToolStripMenuItem parametreToolStripMenuItem;
        private ToolStripMenuItem etatDeSortieToolStripMenuItem;
        private ToolStripMenuItem connexionBDToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem ajouterUnePersonneToolStripMenuItem;
        private ToolStripMenuItem listeDesPersonnesToolStripMenuItem;
        private ToolStripMenuItem toutesLesPersonnesToolStripMenuItem;
        private ToolStripMenuItem personnesAvecAdresseToolStripMenuItem;
        private ToolStripMenuItem personnesAvecNumeroToolStripMenuItem;
        private ToolStripMenuItem aProposToolStripMenuItem;
        private ToolStripMenuItem paramètreToolStripMenuItem;
    }
}