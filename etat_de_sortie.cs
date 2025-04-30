using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetGroupe10
{
    public partial class etat_de_sortie : Form
    {


     
            private Button boutonImprimer;
            private PrintDocument document;

            // Exemple de données à imprimer
            private List<(string Produit, int Quantite, decimal Prix)> lignesRapport = new List<(string, int, decimal)>
        {
            ("Produit A", 5, 1500m),
            ("Produit B", 3, 2500m),
            ("Produit C", 10, 1200m),
        };

            public etat_de_sortie()
            {
                InitializeComponent();
                InitialiserFormulaire();
            }

            private void InitialiserFormulaire()
            {
                this.Text = "Impression d'un Rapport avec Tableau";
                this.Size = new Size(400, 200);

                boutonImprimer = new Button()
                {
                    Text = "Imprimer Rapport",
                    Dock = DockStyle.Fill,
                    Font = new Font("Segoe UI", 12)
                };
                boutonImprimer.Click += BoutonImprimer_Click;
                this.Controls.Add(boutonImprimer);

                document = new PrintDocument();
                document.PrintPage += Document_PrintPage;
            }

            private void BoutonImprimer_Click(object sender, EventArgs e)
            {
                PrintDialog dlg = new PrintDialog();
                dlg.Document = document;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    document.Print();
                }
            }

            private void Document_PrintPage(object sender, PrintPageEventArgs e)
            {
                Graphics g = e.Graphics;
                float x = e.MarginBounds.Left;
                float y = e.MarginBounds.Top;

                Font titreFont = new Font("Arial", 14, FontStyle.Bold);
                Font textFont = new Font("Arial", 10);
                Pen lignePen = Pens.Black;

                // Titre
                g.DrawString("Rapport de Stock", titreFont, Brushes.Black, x, y);
                y += 40;

                // En-têtes du tableau
                float[] colWidths = { 200, 100, 100 };
                string[] headers = { "Produit", "Quantité", "Prix (FCFA)" };

                for (int i = 0; i < headers.Length; i++)
                {
                    g.DrawRectangle(lignePen, x, y, colWidths[i], 30);
                    g.DrawString(headers[i], textFont, Brushes.Black, new RectangleF(x, y, colWidths[i], 30));
                    x += colWidths[i];
                }

                y += 30;
                x = e.MarginBounds.Left;

                // Données du tableau
                foreach (var ligne in lignesRapport)
                {
                    g.DrawRectangle(lignePen, x, y, colWidths[0], 25);
                    g.DrawString(ligne.Produit, textFont, Brushes.Black, new RectangleF(x, y, colWidths[0], 25));

                    g.DrawRectangle(lignePen, x + colWidths[0], y, colWidths[1], 25);
                    g.DrawString(ligne.Quantite.ToString(), textFont, Brushes.Black, new RectangleF(x + colWidths[0], y, colWidths[1], 25));

                    g.DrawRectangle(lignePen, x + colWidths[0] + colWidths[1], y, colWidths[2], 25);
                    g.DrawString(ligne.Prix.ToString("N0"), textFont, Brushes.Black, new RectangleF(x + colWidths[0] + colWidths[1], y, colWidths[2], 25));

                    y += 25;
                }

                // Total
                decimal total = 0;
                foreach (var ligne in lignesRapport)
                    total += ligne.Quantite * ligne.Prix;

                y += 20;
                g.DrawString("Total général : " + total.ToString("N0") + " FCFA", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, x, y);
            }
        }

       
    
}
