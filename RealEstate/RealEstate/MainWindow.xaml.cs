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

namespace RealEstate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginWindow_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            var LoginWindow = Application.Current.Windows.OfType<SearchBar>().FirstOrDefault();


            if (LoginWindow == null)

            {

                LoginWindow = new SearchBar();

            }

            LoginWindow.Show();
        }
    }
}
