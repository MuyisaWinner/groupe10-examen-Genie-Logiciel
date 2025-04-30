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

    public partial class ajouter_personne : Form
    {
        private PersonneClasse selected;

        void initialise()
        {
            if (selected != null)
            {
                var adresse = selected.adresse;
                var telephone = selected.telephone;
                rdMasculin.Checked = selected.sexe == "M";
                rdFeminin.Checked = selected.sexe == "F";
                txtNom.Text = selected.nom;
                txtPost.Text = selected.post;
                txtPrenom.Text = selected.prenom;
                txtNumero.Text = adresse.numero;
                txtAvenue.Text = adresse.avenue;
                txtQuartier.Text = adresse.quartier;
                txtCommune.Text = adresse.commune;
                txtVille.Text = adresse.ville;
                txtCode.Text = telephone.code;
                txtNumeroTel.Text = telephone.numero; ;
            }

        }
        public ajouter_personne()
        {

            InitializeComponent();
            this.selected = DbManager.selectedPerson;
        }

        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            add();
            this.Close();

        }
        void add()
        {
            //CREATIOn DE L OBJECT PERSONNE
            var person = new PersonneClasse();
            person.id = selected != null ? selected.id : DbManager.randomID();
            person.nom = txtNom.Text;
            person.post = txtPost.Text;
            person.prenom = txtPrenom.Text;
            person.sexe = rdMasculin.Enabled ? "M" : "F";

            //CREATION DE L OBJECT ADRESSE
            var adresse = new AdresseClasse();
            adresse.id = selected != null ? selected.adresse.id : DbManager.randomID();
            adresse.numero = txtNumero.Text;
            adresse.avenue = txtAvenue.Text;
            adresse.quartier = txtQuartier.Text;
            adresse.commune = txtCommune.Text;
            adresse.ville = txtVille.Text;
            adresse.person = person.id;

            //CREATION DE L OBJECT TELEPHONE

            var telephone = new TelephoneClasse();
            telephone.id = selected != null ? selected.telephone.id : DbManager.randomID();
            telephone.code = txtCode.Text;
            telephone.numero = txtNumeroTel.Text;
            telephone.person = person.id;

            //AJOUT DE LA PERSONNE
            var result1 = person.AddOrUpdate();
            //AJOUT DE L ADRESSE
            var result2 = adresse.AddOrUpdate();
            // AJOUT DU NUMERO DE TELEPHONE
            var result3 = telephone.AddOrUpdate();

            if (result1 && result2 && result3)
            {
                MessageBox.Show("Enregistrement réussis : ", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }



        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            add();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ajouter_personne_Load(object sender, EventArgs e)
        {
            initialise(); 
        }
    }



}
