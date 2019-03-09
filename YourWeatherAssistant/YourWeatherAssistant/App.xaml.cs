using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace YourWeatherAssistant
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Page mp = new NavigationPage(new WelcomePage());

            NavigationPage.SetHasBackButton(mp, false);
            NavigationPage.SetHasNavigationBar(mp, false);

            MainPage = mp;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
