using MarketPlace.Models;
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

namespace MarketPlace.Pages
{
    /// <summary>
    /// Interaction logic for ProductsPage.xaml
    /// </summary>
    public partial class ProductsPage : Page
    {
        public ProductsPage()
        {
            InitializeComponent();
        }

        private void BAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProductPage(new Product()));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DGProducts.ItemsSource = App.DB.Product.ToList();
        }

        private void BEdit_Click(object sender, RoutedEventArgs e)
        {
            var selectedProduct = DGProducts.SelectedItem as Product;
            if (selectedProduct == null)
            {
                MessageBox.Show("Select Product");
                return;
            }
            NavigationService.Navigate(new ProductPage(selectedProduct));
        }
    }
}
