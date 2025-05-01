using ImageZoomApp;

namespace Astley_Aislie_POI_App_Prototype
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        //open Starting page
        private async void OnStartClickedMain(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        //open Page1
        private async void OnToPage1Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }

        //open Page2
        private async void OnToPage2Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }


        //open Map page
        private async void OnToPage3Clicked(object sender, EventArgs e)
        { 
            await Navigation.PushAsync(new MapPage());
        }

        //Open About us page
        private async void OnToPage4Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3());
        }

        //Open POI page
        private async void OnToPage5Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page4());
        }

        //Open Notifications page
        private async void NotificationPageClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NotificationPage());
        }
    }
}
