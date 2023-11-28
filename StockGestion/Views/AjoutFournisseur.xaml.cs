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
    /// Interaction logic for AjoutFournisseur.xaml
    /// </summary>
    public partial class AjoutFournisseur : Page
    {
        AdminPage adminPage;
        public AjoutFournisseur(AdminPage adm)
        {
            this.adminPage = adm;
            InitializeComponent();
        }

        private void enreg_fournisseur_Click(object sender, RoutedEventArgs e)
        {
            string nom = this.nomFour.Text,
                   localite = this.localFour.Text,
                   mail = this.mailFour.Text,
                   tel = this.telFour.Text;
            if (nom == "" || localite == "" || mail == "" || tel == "")
                MessageBox.Show("Erreur! champ vide");
            else
            {
                List<KeyValuePair<string, string>> fournisseur = new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string, string>("Nom",nom),
                    new KeyValuePair<string, string>("Localite",localite),
                    new KeyValuePair<string, string>("Mail",mail),
                    new KeyValuePair<string, string>("Tel",tel)
                };
                var response = Request.Post("http://localhost:8080/api/Fournisseurs", fournisseur);
                MessageBox.Show("Enregistré");
                this.adminPage.PageInfoAdmin.Content = new Achat(this.adminPage);
            }
            
        }
    }
}
