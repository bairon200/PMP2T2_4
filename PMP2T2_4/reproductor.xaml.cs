using LibVLCSharp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PMP2T2_4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class reproductor : ContentPage
    {
        LibVLC _libvlc;
        public reproductor(String ruta_)
        {
            InitializeComponent();
            Core.Initialize();
            _libvlc = new LibVLC();
            MediaPlayer _mediaPlayer = new MediaPlayer(_libvlc)
            {
                Media = new Media(_libvlc, new Uri(ruta_))
            };

            myVideo.MediaPlayer = _mediaPlayer;

            myVideo.MediaPlayer.Play();


            /*-------- TAMBIEN FUNCIONA PERO SIN VIDEOS LOCALES, SOLO EN VIDEOS DEL SERVIDOR
                        var media = new Media(_libvlc, "https://cr10.000webhostapp.com/videoplayback.mp4", FromType.FromLocation);
                        myVideo.MediaPlayer = new MediaPlayer(media) { EnableHardwareDecoding= true};
                        myVideo.MediaPlayer.Play();
            */

        }
    }
}