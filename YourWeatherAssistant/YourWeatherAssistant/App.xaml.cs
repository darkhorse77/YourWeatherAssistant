using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YourWeatherAssistant.View;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace YourWeatherAssistant
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            InternetConnection connection = new InternetConnection();

            if (connection.CheckConnection())
            {
                MainPage = new MainPage();
            }
            else
            {
                MainPage = new ErrorPage();
            }
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
