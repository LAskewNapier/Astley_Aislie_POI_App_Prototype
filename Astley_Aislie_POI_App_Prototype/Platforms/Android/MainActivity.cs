using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Plugin.LocalNotification;

namespace Astley_Aislie_POI_App_Prototype
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnNewIntent(Intent intent)
        {
            base.OnNewIntent(intent);

            // This ensures notification taps are handled when app is in background
            LocalNotificationCenter.NotifyNotificationTapped(intent);
        }
    }
}
