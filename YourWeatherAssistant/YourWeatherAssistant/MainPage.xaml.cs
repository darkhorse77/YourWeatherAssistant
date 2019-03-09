using Xamarin.Forms;

namespace YourWeatherAssistant
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            GetWeather gw = new GetWeather();

            int precType = gw.GetPrecType();
            int temp = gw.GetTemp();

            Label label1 = new Label
            {
                Text = temp.ToString() + "°",
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                FontSize = 46,
            };

            if (temp <= 0)
            {
                label1.TextColor = Color.SteelBlue;
            }
            else
            {
                label1.TextColor = Color.Red;
            }

            Label label2 = new Label();

            switch (precType)
            {
                case 0:
                    label2.Text = "На улице без осадков";
                    break;
                case 1:
                    label2.Text = "На улице дождь, возьмите зонтик";
                    break;
                case 2:
                    label2.Text = "На улице дождь со снегом, оденьтесь потеплее и не забудьте зонтик!";
                    break;
                case 3:
                    label2.Text = "На улице идёт снег";
                    break;
            }

            label2.VerticalTextAlignment = TextAlignment.Center;
            label2.HorizontalTextAlignment = TextAlignment.Center;
            label2.TextColor = Color.Black;
            label2.FontSize = 24;

            Label label3 = new Label
            {
                Text = gw.city,
                HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.End,
                FontSize = 10
            };

            StackLayout stackLayout = new StackLayout()
            {
                Padding = 10,
                Children = { label3, label1, label2 }
            };

            Content = stackLayout;
        }
    }
}
