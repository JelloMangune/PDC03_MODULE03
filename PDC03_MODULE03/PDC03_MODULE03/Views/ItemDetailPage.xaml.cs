using PDC03_MODULE03.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace PDC03_MODULE03.Views
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