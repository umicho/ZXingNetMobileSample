using System;
using Xamarin.Forms;

namespace ZXingNetMobileSample
{
    public class App
    {
        public static Page GetMainPage()
        {	
            var entry = new Entry();
            var button = new Button();
            button.Text = "Scan";
            button.Clicked += async (s, e) =>
            {
                entry.Text = await DependencyService.Get<IScanner>().ScanAsync();
            };

            return new ContentPage
            { 
                Content = new StackLayout
                {
                    Children =
                    {
                        entry,
                        button,
                    },
                    Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0),
                },
            };
        }
    }
}

