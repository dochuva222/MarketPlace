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
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void BTest_Click(object sender, RoutedEventArgs e)
        {
            var login = TBLogin.Text;
            var password = TBPassword.Text;
            var employee = App.DB.User.FirstOrDefault(emp => emp.Login == login && emp.Password == password);
            if (employee == null)
            {
                MessageBox.Show("Wrong login or password");
            }
            else
            {
                MessageBox.Show("Successful login");
                NavigationService.Navigate(new MainPage());
            }
        }
    }
}
