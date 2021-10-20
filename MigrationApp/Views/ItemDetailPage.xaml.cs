using System.ComponentModel;
using Xamarin.Forms;
using MigrationApp.ViewModels;

namespace MigrationApp.Views
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
