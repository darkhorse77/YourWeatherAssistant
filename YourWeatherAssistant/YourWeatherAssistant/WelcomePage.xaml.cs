using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace YourWeatherAssistant
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WelcomePage : ContentPage
	{
		public WelcomePage ()
		{
			InitializeComponent ();

            GetWeather gw = new GetWeather();

            gw.GetCurrentWeather();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();

            NavigationPage.SetHasBackButton(mp, false);
            NavigationPage.SetHasNavigationBar(mp, false);

            await Navigation.PushAsync(mp, true);
        }
    }
}