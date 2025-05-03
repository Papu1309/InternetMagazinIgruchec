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
using Microsoft.Win32; 
using System.IO;
using System.Xml.Linq;
using Магазин.Pages;

namespace Магазин.Magas
{
    /// <summary>
    /// Логика взаимодействия для Opisanie.xaml
    /// </summary>
    public partial class Opisanie : Page
    {
        public Opisanie()
        {
            InitializeComponent();
            LoadTextFromFile("C:\\Users\\Ильмир\\source\\repos\\Magazin-Ilmir4323423\\Магазин\\TextBoxs\\Opisanie.txt");
        }
        private void LoadTextFromFile(string filePath)
        {
            txbText.Text = File.ReadAllText(filePath, Encoding.GetEncoding("windows-1251"));

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
            
        }
    }
}
