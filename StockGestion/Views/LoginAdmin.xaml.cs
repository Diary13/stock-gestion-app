using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using StockGestion.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
    /// Interaction logic for LoginAdmin.xaml
    /// </summary>
    public partial class LoginAdmin : Page
    {
        MainWindow window;
        public LoginAdmin(MainWindow w)
        {
            this.window = w;
            InitializeComponent();
        }

        private void admin_retour_Click(object sender, RoutedEventArgs e)
        {
            this.window.Info.Content = new Accueil(this.window);
        }

        private void admin_connect_Click(object sender, RoutedEventArgs e)
        {
            if (this.mailAdmin.Text == "" || this.MDPAdmin.Password == "")
                MessageBox.Show("ERREUR! Champ vide");
            else
            {
                List<KeyValuePair<string, string>> adm = new List<KeyValuePair<string, string>>();
                adm.Add(new KeyValuePair<string, string> ("Mail", this.mailAdmin.Text));
                adm.Add(new KeyValuePair<string, string>("MDP", this.MDPAdmin.Password));
                //var content = new FormUrlEncodedContent(adm);
                var response= Request.Post("http://localhost:8080/api/Administrateurs/connect",adm );
                try
                {
                    var json = JObject.Parse(response);
                    //Console.WriteLine(json["IdAdmin"]);
                    if (json["Id"] == null)
                        throw new Exception();
                    Token.token = "1";
                    this.window.Info.Content = new AdminPage(this.window);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                    MessageBox.Show("Impossible de se connecter à ce compte");
                }
            }

        }

        private void mailAdmin_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.mailAdmin.Text = "";
        }

        private void MDPAdmin_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.MDPAdmin.Password = "";
        }

    }
}
