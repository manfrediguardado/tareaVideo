using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tarea2_4.models;
using Xam.Forms.VideoPlayer;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tarea2_4.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class videorepro : ContentPage
    {
        public videorepro(models.videorecord recor)
        {
            InitializeComponent();
            datos(recor);
        }

        private async void btnatras_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private void datos(videorecord video)
        {
            lbldescripcion.Text = video.descripcion;
            UriVideoSource uriVideoSurce = new UriVideoSource()
            {
                Uri = video.uri
            };
            recor.Source = uriVideoSurce;
        }
    }
}