using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BeautyPlanner
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

           MainPage = new MainShell();
           // MainPage = new NavigationPage(new PaginaLogin());
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
