using PlataformaLatina.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using MenuItem = PlataformaLatina.Models.MenuItem;

namespace PlataformaLatina.ViewModels
{ 
    public class MenuGroup : ObservableCollection<MenuItem>, INotifyPropertyChanged
    {

        private bool _expanded;

        public string Title { get; set; }
        public string Icon { get; set; }     
        public MenuItemType Id { get; set; }

        public bool Expanded
        {
            get { return _expanded; }
            set
            {
                if (_expanded != value)
                {
                    _expanded = value;
                    OnPropertyChanged("Expanded");                   
                }
            }
        }   
        public MenuGroup(MenuItemType id, string title, string icon, bool expanded = true)
        {
            Id = id;
            Title = title;
            Icon = icon;
            Expanded = expanded;
        }

        public static ObservableCollection<MenuGroup> All { private set; get; }

        //static MenuGroup()
        //{
        //    ObservableCollection<MenuGroup> Groups = new ObservableCollection<MenuGroup>{
        //        new MenuGroup(MenuItemType.Inicio, "Inicio", null),                
        //        new MenuGroup(MenuItemType.Noticias, "Noticias", "arrow_small.png"){
        //            new MenuItem {Id = MenuItemType.Deportes, Name = "Deportes"},
        //            new MenuItem {Id = MenuItemType.Espectaculos, Name = "Espectáculos"},
        //            new MenuItem {Id = MenuItemType.Politica, Name = "Política"},
        //        },
        //        new MenuGroup(MenuItemType.Radio, "Radio", null),
        //        new MenuGroup(MenuItemType.TV, "TV", null),
        //        new MenuGroup(MenuItemType.Contacto, "Contacto", null),
        //        new MenuGroup(MenuItemType.Servicios, "Servicios", null)};
        //    All = Groups;
        //}

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}