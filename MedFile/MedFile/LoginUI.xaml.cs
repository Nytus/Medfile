using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MedFile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginUI : ContentPage
    {
        public LoginUI()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (txtUsername.Text=="11.111.111-1" && txtPassword.Text=="123")
            {
                Navigation.PushAsync(new HomePage());
            }
            else
            {
                DisplayAlert("Ops..", "Rut o contraseña incorrectos","ok");
            }

        }

        private void Button_Recuperacion(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContraseñaperdidaPage());
        }
        private void OnImageButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HomePage());
        }
    }
}  