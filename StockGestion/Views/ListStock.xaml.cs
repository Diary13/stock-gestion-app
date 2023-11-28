using Newtonsoft.Json.Linq;
using StockGestion.Entities;
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
    /// Interaction logic for ListStock.xaml
    /// </summary>
    public partial class ListStock : Page
    {
        
        public ListStock(Produit[] produits)
        {
            InitializeComponent();
            foreach (var item in produits)
            {
                dataGrid.Items.Add(item);
            }
        }

        private void rechercheProd_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.rechercheProd.Text = "";
            //this.rechercheProd.Padding = "0,0,0,0";
        }
        //tsy mety
        private void recherche_produit_Click(object sender, RoutedEventArgs e)
        {
            string val = this.rechercheProd.Text;
            List<Produit> produits = new List<Produit>();
          
            var response = Request.Get("http://localhost:8080/api/Produits/name/" + val);
            if (val != "")
            {
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
                            Fournisseur = Convert.ToString(json[i]["Four"]["Nom"]),
                            IdFour = Convert.ToInt32(json[i]["Four"]["Id"])
                        });
                    }
                    dataGrid.Items.Clear();
                    foreach (var item in produits)
                    {
                        dataGrid.Items.Add(item);
                    }
                }
                else
                    MessageBox.Show("Produit introuvable ");
            }
            else
                MessageBox.Show("Produit introuvable ");
        }
    }
}
