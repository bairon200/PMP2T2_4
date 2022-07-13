using PMP2T2_4.Models;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PMP2T2_4
{
    public partial class App : Application
    {

        static basededatos basedatos;
        public static basededatos BaseDatos
        {
            get
            {
                if (basedatos == null)
                {
                    basedatos = new basededatos(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "EmpleDB.db3"));
                }
                return basedatos;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
