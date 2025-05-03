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
using Магазин.Magas;
using System.Data.SqlClient;
using Магазин.Connect;

namespace Магазин.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void btnRegOchova_Click(object sender, RoutedEventArgs e)
        {
            RegisterUser(txbLogin.Text, txbPassword.Text);
            NavigationService.Navigate(new aa());
        }
        private void RegisterUser( string email, string password)
        {
            Reg users = new Reg();
            users.Email = email;
            users.Password = password;
            Connection1.entities.Reg.Add(users);
            Connection1.entities.SaveChanges();
        }
    }
}
