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
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();
		}
        private void Boton_Perfil(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PerfilUsuario());
        }
        private void Boton_Historial(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HistorialMedico());
        }
        private void Boton_Receta(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RecetaMedica());
        }
        private void Boton_CitaReciente(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CitaMedicaReciente());
        }
        private void Boton_CitaProxima(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProximaCitaMedica());
        }
        private void Boton_Calendario(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Calendario());
        }
        private void Boton_Mapa(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Mapa());
        }
        private void Boton_Solicitudes(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Solicitudes());
        }
        private void Boton_Salir1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginUI());
        }

    }
}