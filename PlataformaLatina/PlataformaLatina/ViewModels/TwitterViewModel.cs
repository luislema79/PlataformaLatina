using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace PlataformaLatina.ViewModels
{
    public class TwitterViewModel : BaseViewModel
    {
        public TwitterViewModel()
        {
            Title = "Twitter";
        }
        public string HtmlString
        {
            get
            {
                return @"<a class=""twitter - timeline"" href=""https://twitter.com/plalatinatv?ref_src=twsrc%5Etfw"">Tweets by plalatinatv</a> <script async src=""https://platform.twitter.com/widgets.js"" charset=""utf-8""></script>";
            }
        }
    }
}