using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using Магазин.Connect;
using System.Data.SqlClient;

namespace Магазин.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public static List<Reg> users { get; set; }
        
        public AuthorizationPage()
        {
            InitializeComponent();
            users = Connection1.entities.Reg.ToList();
        }

        private void btnVxod_Click(object sender, RoutedEventArgs e)
        {
            if (loginTb != null && ParolTb != null)
            {
                var NewUser = users.Where(users => users.Email == loginTb.Text && users.Password == ParolTb.Text).FirstOrDefault();
                if (NewUser != null)
                {
                    NavigationService.Navigate(new aa());
                }
            }

        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegistrationPage());
        }
    }
}
