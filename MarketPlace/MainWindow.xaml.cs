using MarketPlace.Models;
using MarketPlace.Pages;
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

namespace MarketPlace
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new LoginPage());
        }

        //private void BTest_Click(object sender, RoutedEventArgs e)
        //{


        //    var login = TBLogin.Text;
        //    var password = TBPassword.Text;
        //    var employee = App.DB.Employee.FirstOrDefault(emp => emp.Username == login && emp.Password == password);
        //    if (employee == null)
        //    {
        //        MessageBox.Show("Wrong login or password");
        //    }
        //    else
        //        MessageBox.Show("Successful login");
        //try
        //{
        //    var searchText = int.Parse(TBSearch.Text);
        //    var employee = App.DB.Employee.FirstOrDefault(emp => emp.Id == searchText);
        //    if (employee == null)
        //    {
        //        MessageBox.Show("Employee not found");
        //    }
        //    else
        //        MessageBox.Show(employee.Name);
        //}
        //catch (ArgumentException argEx)
        //{
        //    MessageBox.Show(argEx.Message);
        //}
        //catch (FormatException argEx)
        //{
        //    MessageBox.Show("Вы ввели неправильные данные");
        //}
        //catch (Exception ex)
        //{
        //    MessageBox.Show("Ошибка");
        //}
        //finally
        //{
        //    MessageBox.Show("Поиск произошел успешно");
        //}
        //}
    }
}
