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
    /// Interaction logic for Commande.xaml
    /// </summary>
    public partial class Commande : Page
    {
        AdminPage adminPage;
        public Commande(List<string> fournisseurs, AdminPage adm)
        {
            this.adminPage = adm;
            InitializeComponent();
            foreach (var item in fournisseurs)
            {
                fournisseur.Items.Add(item);
            }
        }

        private void commande_button_Click(object sender, RoutedEventArgs e)
        {
            string libelle = this.nomProd.Text,
                prixUnitaire = this.prixUnit.Text,
                quantite = this.quantite.Text,
                nomFour = this.fournisseur.Text;


            if(libelle == "" || prixUnitaire == "" || quantite == "" || nomFour == "")
            {
                MessageBox.Show("Erreur ! Champ vide");
            }
            else
            {
                List<KeyValuePair<string, string>> produits = new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string, string>("Libelle",libelle),
                    new KeyValuePair<string, string>("PrixUnitaire",prixUnitaire),
                    new KeyValuePair<string, string>("Quantite",quantite),
                };
                var response = Request.Post("http://localhost:8080/api/Produits/new/"+nomFour+"",produits);
                //Console.WriteLine(response);
                MessageBox.Show("Enregistré");
                this.adminPage.PageInfoAdmin.Content = new Achat(this.adminPage);
            }
        }
    }
}
