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
    /// Interaction logic for Accueil.xaml
    /// </summary>
    public partial class Accueil : Page
    {
        MainWindow window;
        public Accueil(MainWindow w)
        {
            this.window = w;
            //this.window.icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.Home;
            InitializeComponent();
        }

        private void button_admin_Click(object sender, RoutedEventArgs e)
        {
            this.window.Info.Content = new LoginAdmin(this.window);
        }

        private void button_utilisateur_Click(object sender, RoutedEventArgs e)
        {
            this.window.Info.Content = new LoginUser(this.window);
        }
    }
}
