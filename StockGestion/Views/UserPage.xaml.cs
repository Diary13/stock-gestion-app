using Newtonsoft.Json.Linq;
using StockGestion.Entities;
using StockGestion.Filters;
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
    /// Interaction logic for UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        MainWindow window;
        public UserPage(MainWindow w)
        {
            this.window = w;
            InitializeComponent();
        }

        private void quitter_Click(object sender, RoutedEventArgs e)
        {
            this.window.Info.Content = new Accueil(this.window);
            Token.token = null;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            this.PageInfoUser.Content = new Vente();
        }

        private void stock_Click(object sender, RoutedEventArgs e)
        {
            var response = Request.Get("http://localhost:8080/api/Produits");
            //Console.WriteLine(response);
            List<Produit> produits = new List<Produit>();
            var json = JArray.Parse(response);
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
                        Fournisseur = Convert.ToString(json[i]["Four"]["Nom"])
                    });
                }
                this.PageInfoUser.Content = new ListStock(produits.ToArray());
            }
            else
            {
                MessageBox.Show("Stock vide!");
            }
        }

        private void prodFaible_Click(object sender, RoutedEventArgs e)
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
                        Fournisseur = Convert.ToString(json[i]["Four"]["Nom"])
                    });
                }
                this.PageInfoUser.Content = new ProduitsFaibleUser(produits.ToArray());
            }
            else
            {
                MessageBox.Show("Pas de produit faible");
                //this.PageInfoAdmin.Content = new ProduitsFaible(produits.ToArray());
            }

        }

        private void vente_Click(object sender, RoutedEventArgs e)
        {
            this.PageInfoUser.Content = new Vente();
        }
    }
}
