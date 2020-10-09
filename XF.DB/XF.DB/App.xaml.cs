using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.DB.Services;
using XF.DB.Views;

namespace XF.DB
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
