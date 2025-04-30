using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace ProjetGroupe10
{
    public partial class etat_de_sortie : Form
    {
        private Button boutonImprimer;
        private PrintDocument document;
        private CheckBox checkBoxAdresse;
        private CheckBox checkBoxTelephone;

        public etat_de_sortie()
        {
            InitializeComponent();
            InitialiserFormulaire();
        }

        private void InitialiserFormulaire()
        {
            this.Text = "Impression d'un Rapport de Personnes";
            this.Size = new Size(800, 600);

            FlowLayoutPanel panel = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 60,
                Padding = new Padding(10)
            };

            checkBoxAdresse = new CheckBox
            {
                Text = "Afficher les adresses",
                Checked = true,
                AutoSize = true,
                Margin = new Padding(10)
            };

            checkBoxTelephone = new CheckBox
            {
                Text = "Afficher les numéros",
                Checked = true,
                AutoSize = true,
                Margin = new Padding(10)
            };

            boutonImprimer = new Button
            {
                Text = "🖨️ Imprimer Rapport",
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                AutoSize = true,
                Margin = new Padding(10),
                BackColor = Color.LightSteelBlue
            };
            boutonImprimer.Click += BoutonImprimer_Click;

            panel.Controls.Add(checkBoxAdresse);
            panel.Controls.Add(checkBoxTelephone);
            panel.Controls.Add(boutonImprimer);
            this.Controls.Add(panel);

            document = new PrintDocument();
            document.PrintPage += Document_PrintPage;
        }

        private void BoutonImprimer_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog previewDialog = new PrintPreviewDialog
            {
                Document = document,
                Width = 1000,
                Height = 800
            };
            previewDialog.ShowDialog();
        }

        private List<dynamic> ChargerPersonnes()
        {
            var personnes = new PersonneClasse().GetAll();

            var data = personnes.Select(p => new
            {
                NomComplet = $"{p.nom.ToUpper()} {p.post.ToUpper()} {p.prenom.ToUpper()}",
                Sexe = p.sexe,
                Adresse = (p.adresse != null)
                    ? CultureInfo.CurrentCulture.TextInfo.ToTitleCase($"{p.adresse.numero}, {p.adresse.avenue}, {p.adresse.quartier}, {p.adresse.commune}, {p.adresse.ville}".ToLower())
                    : "Aucune adresse",
                Telephone = (p.telephone != null)
                    ? $"{p.telephone.code} {p.telephone.numero}"
                    : "Aucun numéro"
            }).ToList();

            return data.Cast<dynamic>().ToList();
        }

        private void Document_PrintPage(object sender, PrintPageEventArgs e)
        {
            var personnes = ChargerPersonnes();

            Graphics g = e.Graphics;
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;

            Font titreFont = new Font("Arial", 14, FontStyle.Bold);
            Font headerFont = new Font("Arial", 10, FontStyle.Bold);
            Font textFont = new Font("Arial", 10);
            Pen lignePen = Pens.Black;

            int cellPadding = 10;

            // Titre
            g.DrawString("Liste des Personnes", titreFont, Brushes.Black, x, y);
            y += 50;

            // Colonnes à afficher
            List<(string Titre, Func<dynamic, string> GetValeur, float Largeur)> colonnes = new()
            {
                ("Nom complet", p => p.NomComplet, 220),
                ("Sexe", p => p.Sexe, 60)
            };

            if (checkBoxAdresse.Checked)
                colonnes.Add(("Adresse", p => p.Adresse, 250));
            if (checkBoxTelephone.Checked)
                colonnes.Add(("Téléphone", p => p.Telephone, 150));

            // En-têtes
            float currentX = x;
            foreach (var col in colonnes)
            {
                g.FillRectangle(Brushes.LightGray, currentX, y, col.Largeur, 30);
                g.DrawRectangle(lignePen, currentX, y, col.Largeur, 30);
                g.DrawString(col.Titre, headerFont, Brushes.Black, new RectangleF(currentX + cellPadding, y + 5, col.Largeur - 2 * cellPadding, 30));
                currentX += col.Largeur;
            }

            y += 30;

            // Contenu
            foreach (var p in personnes)
            {
                currentX = x;
                foreach (var col in colonnes)
                {
                    string valeur = col.GetValeur(p);
                    g.DrawRectangle(lignePen, currentX, y, col.Largeur, 25);
                    g.DrawString(valeur, textFont, Brushes.Black, new RectangleF(currentX + cellPadding, y + 5, col.Largeur - 2 * cellPadding, 25));
                    currentX += col.Largeur;
                }

                y += 25;

                if (y + 25 > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }
        }
    }
}
