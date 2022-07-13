using Plugin.Media;
using PMP2T2_4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PMP2T2_4
{
    public partial class MainPage : ContentPage
    {
        String rutaa = "";

        public MainPage()
        {
            InitializeComponent();
        }
        private async void tomar()
        {
            var takepic = await CrossMedia.Current.TakeVideoAsync(new Plugin.Media.Abstractions.StoreVideoOptions
            {
                Directory = "PhotoApp",
                Name = "TEST.mp4"
            });


            rutaa = takepic.Path;


            if (takepic != null)
            {
                lblTitulo.Text = "Video Tomado";

            }

        }

        private void btnGrabar_Clicked(object sender, EventArgs e)
        {
            tomar();
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            var emple = new contructor
            {

                descripcion = txtDescripcion.Text,
                ruta = rutaa



            };



            var resultado = await App.BaseDatos.EmpleadoGuardar(emple);
            if (resultado != 0)
            {
                await DisplayAlert("Aviso", "Datos Guardados!!", "OK");
                await DisplayAlert("Aviso", rutaa, "OK");
                txtDescripcion.Text = "";




            }

        }

        private async void btnLista_Clicked(object sender, EventArgs e)
        {
            var newpage = new lista();
            await Navigation.PushAsync(newpage);
        }


    }
}
