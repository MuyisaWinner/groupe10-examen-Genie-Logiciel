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

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Voulez vous vraiment quitter ?", "Alerte", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result.Equals(DialogResult.Yes))
            {
                Application.Exit();
            }
        }

        private void listeDesPersonnesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personnes_list frm = new personnes_list();
            frm.MdiParent = this;
            frm.Show();

        }

        private void acceuil_Load(object sender, EventArgs e)
        {
            var connected = DbManager.Instance.IsConnected();
            if (!connected)
            {
                connexion con = new connexion();
                con.MdiParent = this;
                con.Show();

            }

        }

        private void toutesLesPersonnesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            etat_de_sortie con = new etat_de_sortie();
            con.MdiParent = this;
            con.Show();

        }

        private void etatDeSortieToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
