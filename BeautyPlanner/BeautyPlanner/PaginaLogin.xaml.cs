using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BeautyPlanner
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaLogin : ContentPage
    {
        public PaginaLogin()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (txtusuario.Text == "a" && txtsenha.Text == "a")
            {
                await Shell.Current.GoToAsync($"//{nameof(Home)}");
               //await Navigation.PushAsync();

               //await Shell.Current.GoToAsync("/Home");
            }
            else
            {
               await DisplayAlert("Alerta", "Usuário incorreto", "OK");
            }
           // await Shell.Current.GoToAsync($"{nameof(Home)}");
        }
        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
             await Navigation.PushAsync(new PaginaRegistro());

             //await Shell.Current.GoToAsync("//PaginaRegistro");
        }
    }
}