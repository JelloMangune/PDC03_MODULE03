using PDC03_MODULE03.Services;
using PDC03_MODULE03.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MODULE03
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
