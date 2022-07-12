using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using tarea2_4.controllers;
using System.IO;
namespace tarea2_4
{
    public partial class App : Application
    {
        static dbvideo basedata;

        public static dbvideo baseda
        {
            get {

                if (basedata == null)
                {
                    basedata = new dbvideo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "dbvideo.db3"));
                }
                return basedata;
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
