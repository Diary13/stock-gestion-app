using Newtonsoft.Json.Linq;
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
    /// Interaction logic for Achat.xaml
    /// </summary>
    public partial class Achat : Page
    {
        AdminPage adminPage;
        public Achat(AdminPage adm)
        {
            this.adminPage = adm;
            InitializeComponent();
        }
        private void AjoutFour_Click(object sender, RoutedEventArgs e)
        {
            this.InfoAchat.Content = new AjoutFournisseur(this.adminPage);
        }

        private void Commande_button_Click(object sender, RoutedEventArgs e)
        {
            //prendre tous les fournisseurs dans la BD et rediriger vers la page commande
            var response = Request.Get("http://localhost:8080/api/Fournisseurs");
            var json = JArray.Parse(response);
            List<string> fournisseurs = new List<string>();
            if (json.Count>0)
            {
                for (int i = 0; i < json.Count(); i++)
                    fournisseurs.Add(""+json[i]["Nom"]);
                this.InfoAchat.Content = new Commande(fournisseurs, this.adminPage);
            }
            else
            {
                MessageBox.Show("Ajouter d'abord un fournisseur");
            }
        }
    }
}
