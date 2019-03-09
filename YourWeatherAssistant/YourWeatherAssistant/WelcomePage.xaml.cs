using System;
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
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();

            NavigationPage.SetHasBackButton(mp, false);
            NavigationPage.SetHasNavigationBar(mp, false);

            button.Clicked -= Button_Clicked;

            button.IsEnabled = false;
            System.Threading.ThreadPool.QueueUserWorkItem(o =>
            {
                System.Threading.Thread.Sleep(500);

                Device.BeginInvokeOnMainThread(() =>
                {
                    button.IsEnabled = true;
                    button.Clicked += Button_Clicked;
                });
            });

            await Navigation.PushAsync(mp, false);
        }
    }
}