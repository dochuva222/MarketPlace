using MarketPlace.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.IO;
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
    /// Interaction logic for ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Page
    {
        Product contextProduct;
        DbPropertyValues oldValues;
        public ProductPage(Product product)
        {
            InitializeComponent();

            CBProviders.ItemsSource = App.DB.Provider.ToList();
            CBTypes.ItemsSource = App.DB.ProductType.ToList();

            contextProduct = product;
            DataContext = contextProduct;
            LVPhotos.ItemsSource = contextProduct.ProductPhoto.ToList();
            if (contextProduct.Id != 0)
            {
                oldValues = App.DB.Entry(contextProduct).CurrentValues.Clone();
            }
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(contextProduct.Name))
            {
                MessageBox.Show("Enter name");
                return;
            }

            if (contextProduct.Provider == null)
            {
                MessageBox.Show("Select Provider");
                return;
            }

            if (contextProduct.Id == 0)
            {
                App.DB.Product.Add(contextProduct);
            }
            App.DB.SaveChanges();
            NavigationService.GoBack();
        }

        private void BCancel_Click(object sender, RoutedEventArgs e)
        {
            if (oldValues != null)
            {
                App.DB.Entry(contextProduct).CurrentValues.SetValues(oldValues);
            }
            NavigationService.GoBack();
        }

        private void BChange_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog() { Multiselect = true };
            if (dialog.ShowDialog().GetValueOrDefault())
            {
                foreach (var fileName in dialog.FileNames)
                {
                    contextProduct.ProductPhoto.Add(new ProductPhoto()
                    {
                        Photo = File.ReadAllBytes(fileName),
                        Product = contextProduct
                    });
                }

                Refresh();
                DataContext = null;
                DataContext = contextProduct;
            }
        }

        private void Refresh()
        {
            LVPhotos.ItemsSource = contextProduct.ProductPhoto.ToList();
        }
    }
}
