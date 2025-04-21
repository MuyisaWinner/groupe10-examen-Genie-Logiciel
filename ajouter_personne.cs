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
        public ajouter_personne()
        {
            InitializeComponent();
        }

        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            add();
            this.Close();

        }
        void add()
        {
            //CREATIO DE L OBJECT PERSONNE
            var person = new PersonneClasse();
            person.id = DbManager.randomID();
            person.nom = txtNom.Text;
            person.post = txtPost.Text;
            person.prenom = txtPrenom.Text;
            person.sexe = cbSexe.Items[cbSexe.SelectedIndex].ToString();

            //CREATION DE L OBJECT ADRESSE
            var adresse = new AdresseClasse();
            adresse.id = DbManager.randomID();
            adresse.numero = txtNumero.Text;
            adresse.avenue = txtAvenue.Text;
            adresse.quartier = txtQuartier.Text;
            adresse.commune = txtCommune.Text;
            adresse.ville = txtVille.Text;
            adresse.person = person.id;

            //CREATION DE L OBJECT TELEPHONE

            var telephone = new TelephoneClasse();
            telephone.id = DbManager.randomID();
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
    }



}
