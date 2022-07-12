using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tarea2_4.views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tarea2_4.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class listas : ContentPage
    {
        public listas()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            listav.ItemsSource = await App.baseda.listarvid();
        }
        models.videorecord recor;
        private async void listaV_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            recor = (models.videorecord)e.Item;

            await Navigation.PushAsync(new videorepro(this.recor));
        }
    }
}