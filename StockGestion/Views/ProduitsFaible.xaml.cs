using Newtonsoft.Json.Linq;
using StockGestion.Entities;
using StockGestion.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StockGestion.Views
{
    /// <summary>
    /// Interaction logic for ProduitsFaible.xaml
    /// </summary>
    public partial class ProduitsFaible : Page
    {

        public ProduitsFaible(Produit[] produits)
        {
            InitializeComponent();
            foreach (var item in produits)
            {
                dataGrid.Items.Add(item);
            }
        }

        private void prodFaible_commande_Click(object sender, RoutedEventArgs e)
        {
            List<Produit> produits = new List<Produit>();
            var response = RequestResponse.GetProduitsFaible();
            var json = JArray.Parse(response);
            Console.WriteLine(json.Count());
            if (json.Count() > 0)
            {
                for (int i = 0; i < json.Count(); i++)
                {
                    produits.Add(new Produit()
                    {
                        Id = Convert.ToInt32(json[i]["Id"]),
                        Libelle = Convert.ToString(json[i]["Libelle"]),
                        Quantite = Convert.ToInt32(json[i]["Quantite"]),
                        PrixUnitaire = Convert.ToInt32(json[i]["PrixUnitaire"]),
                        Fournisseur = Convert.ToString(json[i]["Four"]["Nom"]),
                        IdFour = Convert.ToInt32(json[i]["Four"]["Id"])
                    });
                }
                List<KeyValuePair<string, string>> tmpProduit;
                for (int i = 0; i < produits.Count(); i++)
                {
                    int quantite = produits[i].Quantite + 1000;

                    tmpProduit = new List<KeyValuePair<string, string>>()
                    {
                        new KeyValuePair<string, string>("Id", produits[i].Id.ToString()),
                        new KeyValuePair<string, string>("Libelle", produits[i].Libelle.ToString()),
                        new KeyValuePair<string, string>("PrixUnitaire", produits[i].PrixUnitaire.ToString()),
                        new KeyValuePair<string, string>("Quantite", quantite.ToString()),
                        new KeyValuePair<string, string>("IdFour", produits[i].IdFour.ToString()),
                    };
                    RequestResponse.PostNouveauCommande(produits[i].Id, tmpProduit); 
                };
                MessageBox.Show("Stock plein");
            }
            else
            {
                MessageBox.Show("Pas de produit faible");
            }
        }
    }
}
