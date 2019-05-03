using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YourWeatherAssistant.ViewModel;

namespace YourWeatherAssistant.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
            this.BindingContext = new MainPageViewModel();
		}
	}
}