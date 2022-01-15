using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PlataformaLatina.Models
{
    public class MenuItem
    {
        public MenuItemType Id { get; set; }
        public string Name { get; set; }        
    }
    
    public enum MenuItemType
    {
        Inicio,        
        Deportes,
        Espectaculos,
        Politica,
        Radio,
        TV,
        Contacto,
        Servicios,
        PaginaWeb,
        Facebook,
        Twitter,
        Instagram
    }
}