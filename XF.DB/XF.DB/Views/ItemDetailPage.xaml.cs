using System.ComponentModel;
using Xamarin.Forms;
using XF.DB.ViewModels;

namespace XF.DB.Views
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