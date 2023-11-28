using Newtonsoft.Json.Linq;
using StockGestion.Filters;
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
    /// Interaction logic for LoginUser.xaml
    /// </summary>
    public partial class LoginUser : Page
    {
        MainWindow window;
        public LoginUser(MainWindow w)
        {
            this.window = w;
            InitializeComponent();
        }

        private void user_retour_Click(object sender, RoutedEventArgs e)
        {
            this.window.Info.Content = new Accueil(this.window);
        }

        private void user_connect_Click(object sender, RoutedEventArgs e)
        {
            if (this.mailUser.Text == "" || this.MDPUser.Password == "")
                MessageBox.Show("ERREUR! Champ vide");
            else
            {
                List<KeyValuePair<string, string>> user = new List<KeyValuePair<string, string>>();
                user.Add(new KeyValuePair<string, string>("Mail", this.mailUser.Text));
                user.Add(new KeyValuePair<string, string>("MDP", this.MDPUser.Password));
                //var content = new FormUrlEncodedContent(adm);
                var response = Request.Post("http://localhost:8080/api/Employes/connect", user);
                try
                {
                    var json = JObject.Parse(response);
                    //Console.WriteLine(json["IdAdmin"]);
                    if (json["Id"] == null)
                        throw new Exception();
                    Token.token = "1";
                    this.window.Info.Content = new UserPage(this.window);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    MessageBox.Show("Impossible de se connecter à ce compte");
                }
            }

        }

        private void mailUser_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.mailUser.Text = "";
        }

        private void MDPUser_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.MDPUser.Password = "";
        }

    }
}
