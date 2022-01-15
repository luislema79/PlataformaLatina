using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using PlataformaLatina.Models;

namespace PlataformaLatina.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Inicio, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Inicio:
                        MenuPages.Add(id, new NavigationPage(new Inicio()));
                        break;
                    case (int)MenuItemType.Radio:
                        MenuPages.Add(id, new NavigationPage(new Radio()));
                        break;
                    case (int)MenuItemType.TV:
                        MenuPages.Add(id, new NavigationPage(new TV()));
                        break;
                    case (int)MenuItemType.Contacto:
                        MenuPages.Add(id, new NavigationPage(new Contacto()));
                        break;
                    case (int)MenuItemType.Servicios:
                        MenuPages.Add(id, new NavigationPage(new Servicios()));
                        break;
                    case (int)MenuItemType.PaginaWeb:
                        MenuPages.Add(id, new NavigationPage(new PaginaWeb()));
                        break;
                    case (int)MenuItemType.Facebook:
                        MenuPages.Add(id, new NavigationPage(new Facebook()));
                        break;
                    case (int)MenuItemType.Twitter:
                        MenuPages.Add(id, new NavigationPage(new Twitter()));
                        break;
                    case (int)MenuItemType.Instagram:
                        MenuPages.Add(id, new NavigationPage(new Instagram()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}