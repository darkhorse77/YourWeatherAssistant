using Xamarin.Forms;

namespace YourWeatherAssistant
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();

            GetWeather gw = new GetWeather(66.659365, 66.388266);

            int precType = gw.GetPrecType();
            int temp = gw.GetTemp();

            Label label1 = CreateLabel(temp.ToString() + "°", 46, TextAlignment.Center, TextAlignment.Center);

            if (temp <= 0)
            {
                label1.TextColor = Color.SteelBlue;
            }
            else
            {
                label1.TextColor = Color.Red;
            }

            Label label2 = CreateLabel(null, 24, TextAlignment.Center, TextAlignment.Center);

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

            Label label3 = CreateLabel(gw.City, 10, TextAlignment.End, TextAlignment.End);

            StackLayout stackLayout1 = new StackLayout()
            {
                Children = { label3, label1, label2 }
            };

            page1.Content = stackLayout1;
        }

        private Label CreateLabel(string text, int fontSize, TextAlignment vertical, TextAlignment horizontal)
        {
            Label label = new Label
            {
                Text = text,
                FontSize = fontSize,
                VerticalTextAlignment = vertical,
                HorizontalTextAlignment = horizontal
            };

            return label;
        }
    }
}
