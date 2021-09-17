using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace TestApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ATS_Button_Clicked(object sender, EventArgs e)
        {
            var webView = new WebView
            {
                Source = "https://www.arangantech.in",
                MinimumWidthRequest = 200,
                MinimumHeightRequest = 200,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,

            };

            var backButton = new Button();
            backButton.Text = "Back";
            backButton.Clicked += Back_Button_Clicked;

            var stackLayout = new StackLayout();
            this.Content = stackLayout;
            stackLayout.Children.Add(webView);
            stackLayout.Children.Add(backButton);
            stackLayout.HorizontalOptions = LayoutOptions.FillAndExpand;
            stackLayout.VerticalOptions = LayoutOptions.FillAndExpand;
        }

        private void Back_Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}
