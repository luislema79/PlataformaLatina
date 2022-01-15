using PlataformaLatina.Models;
using PlataformaLatina.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;
using MenuItem = PlataformaLatina.Models.MenuItem;

namespace PlataformaLatina.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }

        //private ObservableCollection<MenuGroup> _allGroups;
        //private ObservableCollection<MenuGroup> _expandedGroups;
        List<MenuItem> menuItems;

        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<MenuItem>
            {
                new MenuItem { Id = MenuItemType.Inicio, Name="Inicio" },                
                new MenuItem { Id = MenuItemType.Radio, Name="Radio" },
                new MenuItem { Id = MenuItemType.TV, Name = "TV"},                   
                new MenuItem { Id = MenuItemType.PaginaWeb, Name = "Página Web"},
                new MenuItem { Id = MenuItemType.Facebook, Name="Facebook" },
                new MenuItem { Id = MenuItemType.Twitter, Name="Twitter" },
                new MenuItem { Id = MenuItemType.Instagram, Name="Instagram" },
                new MenuItem { Id = MenuItemType.Contacto, Name = "Contacto"}
            };            

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((MenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };

            //_allGroups = MenuGroup.All;
            //UpdateListContent();               
        }

        //private void HeaderTapped(object sender, EventArgs args)
        //{
        //    var entity = ((Label)sender);
        //    entity.BackgroundColor = Color.FromHex("2196F3");
        //    int selectedIndex = _expandedGroups.IndexOf(
        //        ((MenuGroup)entity.BindingContext));
        //    _allGroups[selectedIndex].Expanded = !_allGroups[selectedIndex].Expanded;
        //    UpdateListContent();
        //}

        //private void UpdateListContent()
        //{
        //    _expandedGroups = new ObservableCollection<MenuGroup>();
        //    foreach (MenuGroup group in _allGroups)
        //    {
        //        //Create new MenuGroups so we do not alter original list
        //        MenuGroup newGroup = new MenuGroup(group.Id, group.Title, group.Icon, group.Expanded);
        //        if (group.Expanded)
        //        {
        //            foreach (MenuItem item in group)
        //            {
        //                newGroup.Add(item);
        //            }
        //        }
        //        _expandedGroups.Add(newGroup);
        //    }

        //    ListViewMenu.ItemsSource = _expandedGroups;
            
        //    ListViewMenu.ItemSelected += async (sender, e) =>
        //    {
        //        if (e.SelectedItem == null)
        //            return;

        //        var id = (int)((MenuItem)e.SelectedItem).Id;
        //        await RootPage.NavigateFromMenu(id);
        //    };
        //}       
    }
}