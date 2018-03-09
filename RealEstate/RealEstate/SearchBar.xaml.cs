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
using System.Windows.Shapes;
using System.IO;

namespace RealEstate
{
    /// <summary>
    /// Interaction logic for SearchBar.xaml
    /// </summary>
    public partial class SearchBar : Window
    {
        public SearchBar()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            var SearchBar = Application.Current.Windows.OfType<SearchResults>().FirstOrDefault();


            if (SearchBar == null)

            {

                SearchBar = new SearchResults();

            }

            SearchBar.Show();
            try
            {
                //a stream to the file
                FileStream fs = new FileStream("D:\\Class files\\RealEstateSethJason\\RealEstate\\RealEstate\\PropertiesDoc", FileMode.Open);

                //filePath.TexT = fs.Name;

                //Read line from the file using stream reader
                StreamReader sr = new StreamReader(fs);

                //so long as there is more data, keep reading the file
                while (sr.Peek() != -1)
                {
                    //fileContents.Text += sr.ReadLine();
                }
                //relase file for others to use
                fs.Close();
            }

            catch (FileNotFoundException fnf) {
                //fileContents.Text += "File Not Found"; 
            }
            catch (DirectoryNotFoundException dnf) {
               // fileContents.Text += "Directory Not Found";
            }
            catch (Exception ex) {
               // fileContents.Text += ex.Message;
            }
        }

    }
}


