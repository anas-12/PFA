using System.ComponentModel;
using UIProject.ViewModels;
using Xamarin.Forms;

namespace UIProject.Views
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