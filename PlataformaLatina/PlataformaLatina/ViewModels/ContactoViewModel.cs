using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace PlataformaLatina.ViewModels
{
    public class ContactoViewModel : BaseViewModel
    {
        public ContactoViewModel()
        {
            Title = "Contacto";
        }
        public string HtmlString
        {
            get
            {
                return @"<html><body>
                         <p><h2>Plataforma Latina TV</h2>16005 International Blvd. <br>SeaTac, WA 98188<br>206-735-7985 (oficina)<br>206-218-2998 (celular)<br>info@PlataformaLatina.com</p><br>
                         <p><strong>Director de Ingeniería:</strong><br>Luis Lema<br><br><strong>Director de Ventas y Producción:</strong><br>Rolando Cabrera<br><br><strong>Director Administrativo y Financiero:</strong><br>Paco Díaz</p>
                         </body></html>";
            }
        }
    }
}