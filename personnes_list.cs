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
    public partial class personnes_list : Form
    {
        List<PersonneClasse> personnes = new List<PersonneClasse>();

        public personnes_list()
        {
            InitializeComponent();
            personnes = new PersonneClasse().GetAll();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgPerson.CurrentRow != null && dgPerson.CurrentRow.Index >= 0)
            {
                var idPersonne = dgPerson.CurrentRow.Cells["id"].Value.ToString();

                var personne = personnes.FirstOrDefault(p => p.id == idPersonne);

                if (personne != null)
                {

                    AdresseClasse adresse = personne.adresse;
                    TelephoneClasse telephone = personne.telephone;


                  //  MessageBox.Show($"Nom : {personne.nom}\nVille : {adresse?.ville}\nTéléphone : {telephone?.numero}");
                }
            }
        }



        //private void AjouterColonnesBoutons()
        //{
        //    // Colonne Modifier
        //    DataGridViewButtonColumn btnModifier = new DataGridViewButtonColumn();
        //    btnModifier.HeaderText = "Action";
        //    btnModifier.Text = "Modifier";
        //    btnModifier.UseColumnTextForButtonValue = true;
        //    dgPerson.Columns.Add(btnModifier);

        //    // Colonne Supprimer
        //    DataGridViewButtonColumn btnSupprimer = new DataGridViewButtonColumn();
        //    btnSupprimer.HeaderText = "";
        //    btnSupprimer.Text = "Supprimer";
        //    btnSupprimer.UseColumnTextForButtonValue = true;
        //    dgPerson.Columns.Add(btnSupprimer);
        //}

        private void ChargerPersonnes()
        {
            var personnes = new PersonneClasse().GetAll();

            var data = personnes.Select(p => new
            {
                p.id,
                p.nom,
                p.post,
                p.prenom,
                p.sexe,
                Numero = p.adresse.numero,
                Avenue = p.adresse.avenue,
                Quartier = p.adresse.quartier,
                Commune = p.adresse.commune,
                Ville = p.adresse.ville,
                
                Telephone = p.telephone.code + ""+  p.telephone?.numero
            }).ToList();

            dgPerson.DataSource = data;

            //AjouterColonnesBoutons();
        }




        private void personnes_list_Load(object sender, EventArgs e)
        {

            ChargerPersonnes();
            btnDelete.Enabled = DbManager.selectedPerson != null;
            btnDelete.Enabled = DbManager.selectedPerson != null;

        }

        private void dgPerson_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {

        }
        private void dgPerson_SelectionChanged(object sender, EventArgs e)
        {
            if (dgPerson.CurrentRow != null && dgPerson.CurrentRow.Index >= 0)
            {
                var idPersonne = dgPerson.CurrentRow.Cells["id"].Value.ToString();

                var personne = personnes.FirstOrDefault(p => p.id == idPersonne);

                if (personne != null)
                {
                    AdresseClasse adresse = personne.adresse;
                    TelephoneClasse telephone = personne.telephone;

                    DbManager.selectedPerson = personne;
                    btnDelete.Enabled = DbManager.selectedPerson != null;
                    btnDelete.Enabled = DbManager.selectedPerson != null;
                    labelPerson.Text = DbManager.selectedPerson.nom + " " + DbManager.selectedPerson.post;

                    // Test
                    //MessageBox.Show($"Nom : {personne.nom}\nVille : {adresse?.ville}\nTéléphone : {telephone?.numero}");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DbManager.selectedPerson = null;
            ajouter_personne frm = new ajouter_personne();
            frm.ShowDialog();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ajouter_personne frm = new ajouter_personne();
            frm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Voulez vous supprimer cette personne ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var person = DbManager.selectedPerson;
                if (person != null)
                {
                    var res1 = person.adresse.Delete();
                    var res2 = person.telephone.delete();
                    var res3 = person.Delete();

                    if (res1 && res2 && res3)
                    {
                        ChargerPersonnes();
                        MessageBox.Show("Suppression effectuer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Suppression Echouer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnRefrech_Click(object sender, EventArgs e)
        {
            ChargerPersonnes();

        }
    }
}
