using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoevodPalada_Marius_Lab12.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VoevodPalada_Marius_Lab12.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }
    }
}