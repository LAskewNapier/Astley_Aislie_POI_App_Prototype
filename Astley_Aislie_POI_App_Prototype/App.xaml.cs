using Plugin.LocalNotification.EventArgs;
using Plugin.LocalNotification;

namespace Astley_Aislie_POI_App_Prototype
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            LocalNotificationCenter.Current.NotificationActionTapped += OnNotificationTapped;
            MainPage = new NavigationPage(new MainPage());
        }

        private void OnNotificationTapped(NotificationActionEventArgs e)
        {
            if (e.Request.ReturningData == "open_POI1_page")
            {
                // Navigate to SecondPage
                MainThread.BeginInvokeOnMainThread(() =>
                {

                    // If not using Shell, you might use:
                    Application.Current.MainPage = new POIViews.POI1();

                });
            }
            if (e.Request.ReturningData == "open_POI2_page")
            {
                // Navigate to SecondPage
                MainThread.BeginInvokeOnMainThread(() =>
                {

                    // If not using Shell, you might use:
                    Application.Current.MainPage = new POIViews.POI2();

                });
            }
            if (e.Request.ReturningData == "open_POI3_page")
            {
                // Navigate to SecondPage
                MainThread.BeginInvokeOnMainThread(() =>
                {

                    // If not using Shell, you might use:
                    Application.Current.MainPage = new POIViews.POI3();

                });
            }
            if (e.Request.ReturningData == "open_POI4_page")
            {
                // Navigate to SecondPage
                MainThread.BeginInvokeOnMainThread(() =>
                {

                    // If not using Shell, you might use:
                    Application.Current.MainPage = new POIViews.POI4();

                });
            }
            if (e.Request.ReturningData == "open_POI5_page")
            {
                // Navigate to SecondPage
                MainThread.BeginInvokeOnMainThread(() =>
                {

                    // If not using Shell, you might use:
                    Application.Current.MainPage = new POIViews.POI5();

                });
            }
            if (e.Request.ReturningData == "open_POI6_page")
            {
                // Navigate to SecondPage
                MainThread.BeginInvokeOnMainThread(() =>
                {

                    // If not using Shell, you might use:
                    Application.Current.MainPage = new POIViews.POI16();

                });
            }
            if (e.Request.ReturningData == "open_POI7_page")
            {
                // Navigate to SecondPage
                MainThread.BeginInvokeOnMainThread(() =>
                {

                    // If not using Shell, you might use:
                    Application.Current.MainPage = new POIViews.POI7();

                });
            }
            if (e.Request.ReturningData == "open_POI8_page")
            {
                // Navigate to SecondPage
                MainThread.BeginInvokeOnMainThread(() =>
                {

                    // If not using Shell, you might use:
                    Application.Current.MainPage = new POIViews.POI8();

                });
            }
            if (e.Request.ReturningData == "open_POI9_page")
            {
                // Navigate to SecondPage
                MainThread.BeginInvokeOnMainThread(() =>
                {

                    // If not using Shell, you might use:
                    Application.Current.MainPage = new POIViews.POI9();

                });
            }
            if (e.Request.ReturningData == "open_POI10_page")
            {
                // Navigate to SecondPage
                MainThread.BeginInvokeOnMainThread(() =>
                {

                    // If not using Shell, you might use:
                    Application.Current.MainPage = new POIViews.POI10();

                });
            }
            if (e.Request.ReturningData == "open_POI11_page")
            {
                // Navigate to SecondPage
                MainThread.BeginInvokeOnMainThread(() =>
                {

                    // If not using Shell, you might use:
                    Application.Current.MainPage = new POIViews.POI11();

                });
            }
            if (e.Request.ReturningData == "open_POI12_page")
            {
                // Navigate to SecondPage
                MainThread.BeginInvokeOnMainThread(() =>
                {

                    // If not using Shell, you might use:
                    Application.Current.MainPage = new POIViews.POI12();

                });
            }
            if (e.Request.ReturningData == "open_POI13_page")
            {
                // Navigate to SecondPage
                MainThread.BeginInvokeOnMainThread(() =>
                {

                    // If not using Shell, you might use:
                    Application.Current.MainPage = new POIViews.POI13();

                });
            }
            if (e.Request.ReturningData == "open_POI14_page")
            {
                // Navigate to SecondPage
                MainThread.BeginInvokeOnMainThread(() =>
                {

                    // If not using Shell, you might use:
                    Application.Current.MainPage = new POIViews.POI14();

                });
            }
            if (e.Request.ReturningData == "open_POI15_page")
            {
                // Navigate to SecondPage
                MainThread.BeginInvokeOnMainThread(() =>
                {

                    // If not using Shell, you might use:
                    Application.Current.MainPage = new POIViews.POI15();

                });
            }
            if (e.Request.ReturningData == "open_POI16_page")
            {
                // Navigate to SecondPage
                MainThread.BeginInvokeOnMainThread(() =>
                {

                    // If not using Shell, you might use:
                    Application.Current.MainPage = new POIViews.POI16();

                });
            }
            if (e.Request.ReturningData == "open_POI17_page")
            {
                // Navigate to SecondPage
                MainThread.BeginInvokeOnMainThread(() =>
                {

                    // If not using Shell, you might use:
                    Application.Current.MainPage = new POIViews.POI17();

                });
            }
            if (e.Request.ReturningData == "open_POI18_page")
            {
                // Navigate to SecondPage
                MainThread.BeginInvokeOnMainThread(() =>
                {

                    // If not using Shell, you might use:
                    Application.Current.MainPage = new POIViews.POI18();

                });
            }
            if (e.Request.ReturningData == "open_POI19_page")
            {
                // Navigate to SecondPage
                MainThread.BeginInvokeOnMainThread(() =>
                {

                    // If not using Shell, you might use:
                    Application.Current.MainPage = new POIViews.POI19();

                });
            }
            if (e.Request.ReturningData == "open_POI20_page")
            {
                // Navigate to SecondPage
                MainThread.BeginInvokeOnMainThread(() =>
                {

                    // If not using Shell, you might use:
                    Application.Current.MainPage = new POIViews.POI20();

                });
            }
            if (e.Request.ReturningData == "open_POI21_page")
            {
                // Navigate to SecondPage
                MainThread.BeginInvokeOnMainThread(() =>
                {

                    // If not using Shell, you might use:
                    Application.Current.MainPage = new POIViews.POI21();

                });
            }
            if (e.Request.ReturningData == "open_POI22_page")
            {
                // Navigate to SecondPage
                MainThread.BeginInvokeOnMainThread(() =>
                {

                    // If not using Shell, you might use:
                    Application.Current.MainPage = new POIViews.POI22();

                });
            }
        }
    }
}
