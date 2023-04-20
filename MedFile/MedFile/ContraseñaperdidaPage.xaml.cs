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
	public partial class ContraseñaperdidaPage : ContentPage
	{
		public ContraseñaperdidaPage ()
		{
			InitializeComponent ();
		}
        private void Button_ContraseñaPerdida(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginUI());
        }
    }
}