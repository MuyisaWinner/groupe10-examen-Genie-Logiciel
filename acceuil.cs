using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetGroupe10
{
    public partial class acceuil : Form
    {
        public acceuil()
        {
            InitializeComponent();
        }

        private void parametreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ajouterUnePersonneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ajouter_personne frm = new ajouter_personne();
            frm.MdiParent = this;
            frm.Show();
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfosPage page = new InfosPage();
            page.MdiParent = this;
            page.Show();
        }

        private void connexionBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connexion con = new connexion();
            con.MdiParent = this;
            con.Show();
            
        }
    }
}
