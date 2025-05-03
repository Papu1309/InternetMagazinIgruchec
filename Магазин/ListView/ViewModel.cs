using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Data;
using Магазин.Datagrid;

namespace Магазин.ListView
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public List<Spicok> Spicoks { get; set; }
        public ICollectionView PeopleView { get; set; }
        private string _searchText;
        public string SearchText
        {
            get => _searchText;
            set
            {
                _searchText = value;
                OnPropertyChanged(nameof(SearchText));
                PeopleView.Refresh(); // Обновляем представление при изменении текста поиска
            }
        }

        public MainViewModel()
        {
            Spicoks = new List<Spicok>
            {
                new Spicok() { Name = "Родом из сердца", Price = 625, Foto = "/Photo/Родом из сердца.jpg" },
                  new Spicok() { Name = "Странный дом", Price = 689, Foto = "/Photo/Странный дом.jpg" },
                  new Spicok() { Name = "За спиной", Price = 759, Foto = "/Photo/За спиной.jpg" },
                  new Spicok() { Name = "Атомные привычки", Price = 899, Foto = "/Photo/Атомные привычки.jpg" },
                  new Spicok() { Name = "Татуировки менеджера", Price = 1115, Foto = "/Photo/Татуировки менеджера.jpg" },
                  new Spicok() { Name = "Пять языков любви", Price = 487, Foto = "/Photo/Пять языков любви.jpg" },
                  new Spicok() { Name = "Игры королей", Price = 781, Foto = "/Photo/Игры королей.jpg" },
                  new Spicok() { Name = "Записи юного врача", Price = 541, Foto = "/Photo/Записи юного врача.jpg" },
                  new Spicok() { Name = "Еженельник", Price = 428, Foto = "/Photo/Еженельник.jpg" },
                  new Spicok() { Name = "Двадцать шестой", Price = 587, Foto = "/Photo/Двадцать шестой.jpg" },
                  new Spicok() { Name = "Донецкое море", Price = 717, Foto = "/Photo/Донецкое море.jpg" },
                  new Spicok() { Name = "Пластиковый океан", Price = 1195, Foto = "/Photo/Пластиковый океан.jpg" },
                  new Spicok() { Name = "Клиника в Гоблинском переулке", Price = 505, Foto = "/Photo/Клиника в Гоблинском переулке.jpg" },
                  new Spicok() { Name = "Семнадцатый", Price = 1655, Foto = "/Photo/Семнадцатый.jpg" },
           };
            PeopleView = CollectionViewSource.GetDefaultView(Spicoks);
            PeopleView.Filter = obj =>
            {
                if (obj is Spicok spicok)
                    return string.IsNullOrEmpty(SearchText) || spicok.Name.Contains(SearchText);
                return false;
            };
        }
        public void SortByName()
        {
            PeopleView.SortDescriptions.Clear();
            PeopleView.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Ascending));
            PeopleView.Refresh();
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
