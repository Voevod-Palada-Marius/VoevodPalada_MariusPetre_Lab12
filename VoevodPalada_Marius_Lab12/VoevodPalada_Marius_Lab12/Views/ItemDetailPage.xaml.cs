using System.ComponentModel;
using VoevodPalada_Marius_Lab12.ViewModels;
using Xamarin.Forms;

namespace VoevodPalada_Marius_Lab12.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}