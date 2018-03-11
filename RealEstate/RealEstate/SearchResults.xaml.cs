using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;
using Microsoft.Win32;
using System.IO;


namespace RealEstate
{
    /// <summary>
    /// Interaction logic for SearchResults.xaml
    /// </summary>
    public partial class SearchResults : Window
    {
        ObservableCollection<House> Propertys = new ObservableCollection<House>();

        public SearchResults()
        {
            InitializeComponent();

            House p = new House() { streetName = "Ehrgood ", houseNumber = "1121", zipcode = "97914", askingprice = "120,000", bathrooms = "2.5", bedrooms = "3", propertySize = "1200 ", city = "Ontario", state = "Oregon", hoafees = "0", leaselength = "30 Years", pets = "Yes", unitnumber = "14", smoking = "yes", zonedtype = "", pricepersqrfoot = "", leaselength = ''};
            Houses.add(p);

            p = new House() { streetName = "Park street", houseNumber = "1478", zipcode = "97914", askingprice = "170,000", bathrooms = "2", bedrooms = "5", propertySize = "2200 ", city = "Ontario", state = "Oregon", hoafees = "600", leaselength = "30 Years", pets = "No", unitnumber = "69", smoking = "no" };
            Houses.add(p);

            p = new House() { streetName = "Reece", houseNumber = "4452", zipcode = "97914", askingprice = "70,000", bathrooms = "1", bedrooms = "2", propertySize = "700 ", city = "Ontario", state = "Oregon", hoafees = "0" } ;
            Houses.add(p);

            p = new House() { streetName = "Chestnut", houseNumber = "152", zipcode = "97914", askingprice = "150,000", bathrooms = "2", bedrooms = "4", propertySize = "2500 ", city = "Ontario", state = "Oregon", hoafees = "10000" };
            Houses.add(p);

            p = new House() { streetName = "Main ", houseNumber = "6952", zipcode = "97914", city = "Ontario", state = "Oregon", zonedtype = "Commercial", pricepersqrfoot = "100", leaseorown = "Lease" };
            Houses.add(p);

            p = new House() { streetName = "Main ", houseNumber = "4985", zipcode = "97914", city = "Ontario", state = "Oregon", zonedtype = "Commercial", pricepersqrfoot = "250", leaseorown = "Own" };
            Houses.add(p);




            dataGrid.ItemsSource = Houses;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //figure out which patient was clicked on
            House p = ((sender as System.Windows.Controls.Button).DataContext as House);

            //now do something with this data, like open a new window to show the details, or add a diagnosis, etc...
        }


    }
}
