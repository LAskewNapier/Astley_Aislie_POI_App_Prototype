using Plugin.LocalNotification;

namespace Astley_Aislie_POI_App_Prototype;

public partial class NotificationPage : ContentPage
{
	public NotificationPage()
	{
		InitializeComponent();
	}
    private async void Notification1Clicked(object sender, EventArgs e)
    {
        // Only show notification if we have permission
        var request = new NotificationRequest
        {
            NotificationId = 1337,
            Title = "You are near",
            Subtitle = "The Lodges and Gates",
            Description = "This place is near",
            Schedule = new NotificationRequestSchedule
            {
                NotifyTime = DateTime.Now.AddSeconds(2)
            },
            // Add these parameters for navigation
            ReturningData = "open_POI1_page", // Custom data to identify the action
            Android =
                {
                    LaunchAppWhenTapped = true // Ensure app launches when tapped
                }
        };

        await LocalNotificationCenter.Current.Show(request);
    }

    private async void Notification2Clicked(object sender, EventArgs e)
    {
        // Only show notification if we have permission
        var request = new NotificationRequest
        {
            NotificationId = 1337,
            Title = "You are near",
            Subtitle = "Woodlands",
            Description = "This place is near",
            Schedule = new NotificationRequestSchedule
            {
                NotifyTime = DateTime.Now.AddSeconds(2)
            },
            // Add these parameters for navigation
            ReturningData = "open_POI2_page", // Custom data to identify the action
            Android =
                {
                    LaunchAppWhenTapped = true // Ensure app launches when tapped
                }
        };

        await LocalNotificationCenter.Current.Show(request);
    }

    private async void Notification3Clicked(object sender, EventArgs e)
    {
        // Only show notification if we have permission
        var request = new NotificationRequest
        {
            NotificationId = 1337,
            Title = "You are near",
            Subtitle = "Blackford",
            Description = "This place is near",
            Schedule = new NotificationRequestSchedule
            {
                NotifyTime = DateTime.Now.AddSeconds(2)
            },
            // Add these parameters for navigation
            ReturningData = "open_POI3_page", // Custom data to identify the action
            Android =
                {
                    LaunchAppWhenTapped = true // Ensure app launches when tapped
                }
        };

        await LocalNotificationCenter.Current.Show(request);
    }

    private async void Notification4Clicked(object sender, EventArgs e)
    {
        // Only show notification if we have permission
        var request = new NotificationRequest
        {
            NotificationId = 1337,
            Title = "You are near",
            Subtitle = "East and West Wings",
            Description = "This place is near",
            Schedule = new NotificationRequestSchedule
            {
                NotifyTime = DateTime.Now.AddSeconds(2)
            },
            // Add these parameters for navigation
            ReturningData = "open_POI4_page", // Custom data to identify the action
            Android =
                {
                    LaunchAppWhenTapped = true // Ensure app launches when tapped
                }
        };

        await LocalNotificationCenter.Current.Show(request);
    }

    private async void Notification5Clicked(object sender, EventArgs e)
    {
        // Only show notification if we have permission
        var request = new NotificationRequest
        {
            NotificationId = 1337,
            Title = "You are near",
            Subtitle = "Scientific Block",
            Description = "This place is near",
            Schedule = new NotificationRequestSchedule
            {
                NotifyTime = DateTime.Now.AddSeconds(2)
            },
            // Add these parameters for navigation
            ReturningData = "open_POI5_page", // Custom data to identify the action
            Android =
                {
                    LaunchAppWhenTapped = true // Ensure app launches when tapped
                }
        };

        await LocalNotificationCenter.Current.Show(request);
    }

    private async void Notification6Clicked(object sender, EventArgs e)
    {
        // Only show notification if we have permission
        var request = new NotificationRequest
        {
            NotificationId = 1337,
            Title = "You are near",
            Subtitle = "SMART* centre",
            Description = "This place is near",
            Schedule = new NotificationRequestSchedule
            {
                NotifyTime = DateTime.Now.AddSeconds(2)
            },
            // Add these parameters for navigation
            ReturningData = "open_POI6_page", // Custom data to identify the action
            Android =
                {
                    LaunchAppWhenTapped = true // Ensure app launches when tapped
                }
        };

        await LocalNotificationCenter.Current.Show(request);
    }

    private async void Notification7Clicked(object sender, EventArgs e)
    {
        // Only show notification if we have permission
        var request = new NotificationRequest
        {
            NotificationId = 1337,
            Title = "You are near",
            Subtitle = "Occupational Therapy (OT) Department",
            Description = "This place is near",
            Schedule = new NotificationRequestSchedule
            {
                NotifyTime = DateTime.Now.AddSeconds(2)
            },
            // Add these parameters for navigation
            ReturningData = "open_POI7_page", // Custom data to identify the action
            Android =
                {
                    LaunchAppWhenTapped = true // Ensure app launches when tapped
                }
        };

        await LocalNotificationCenter.Current.Show(request);
    }

    private async void Notification8Clicked(object sender, EventArgs e)
    {
        // Only show notification if we have permission
        var request = new NotificationRequest
        {
            NotificationId = 1337,
            Title = "You are near",
            Subtitle = "Wooden army huts",
            Description = "This place is near",
            Schedule = new NotificationRequestSchedule
            {
                NotifyTime = DateTime.Now.AddSeconds(2)
            },
            // Add these parameters for navigation
            ReturningData = "open_POI8_page", // Custom data to identify the action
            Android =
                {
                    LaunchAppWhenTapped = true // Ensure app launches when tapped
                }
        };

        await LocalNotificationCenter.Current.Show(request);
    }

    private async void Notification9Clicked(object sender, EventArgs e)
    {
        // Only show notification if we have permission
        var request = new NotificationRequest
        {
            NotificationId = 1337,
            Title = "You are near",
            Subtitle = "The Cunningham Day Centre",
            Description = "This place is near",
            Schedule = new NotificationRequestSchedule
            {
                NotifyTime = DateTime.Now.AddSeconds(2)
            },
            // Add these parameters for navigation
            ReturningData = "open_POI9_page", // Custom data to identify the action
            Android =
                {
                    LaunchAppWhenTapped = true // Ensure app launches when tapped
                }
        };

        await LocalNotificationCenter.Current.Show(request);
    }

    private async void Notification10Clicked(object sender, EventArgs e)
    {
        // Only show notification if we have permission
        var request = new NotificationRequest
        {
            NotificationId = 1337,
            Title = "You are near",
            Subtitle = "Pet Cemetery",
            Description = "This place is near",
            Schedule = new NotificationRequestSchedule
            {
                NotifyTime = DateTime.Now.AddSeconds(2)
            },
            // Add these parameters for navigation
            ReturningData = "open_POI10_page", // Custom data to identify the action
            Android =
                {
                    LaunchAppWhenTapped = true // Ensure app launches when tapped
                }
        };

        await LocalNotificationCenter.Current.Show(request);
    }

    private async void Notification11Clicked(object sender, EventArgs e)
    {
        // Only show notification if we have permission
        var request = new NotificationRequest
        {
            NotificationId = 1337,
            Title = "You are near",
            Subtitle = "St Roque",
            Description = "This place is near",
            Schedule = new NotificationRequestSchedule
            {
                NotifyTime = DateTime.Now.AddSeconds(2)
            },
            // Add these parameters for navigation
            ReturningData = "open_POI11_page", // Custom data to identify the action
            Android =
                {
                    LaunchAppWhenTapped = true // Ensure app launches when tapped
                }
        };

        await LocalNotificationCenter.Current.Show(request);
    }

    private async void Notification12Clicked(object sender, EventArgs e)
    {
        // Only show notification if we have permission
        var request = new NotificationRequest
        {
            NotificationId = 1337,
            Title = "You are near",
            Subtitle = "Well",
            Description = "This place is near",
            Schedule = new NotificationRequestSchedule
            {
                NotifyTime = DateTime.Now.AddSeconds(2)
            },
            // Add these parameters for navigation
            ReturningData = "open_POI12_page", // Custom data to identify the action
            Android =
                {
                    LaunchAppWhenTapped = true // Ensure app launches when tapped
                }
        };

        await LocalNotificationCenter.Current.Show(request);
    }

    private async void Notification13Clicked(object sender, EventArgs e)
    {
        // Only show notification if we have permission
        var request = new NotificationRequest
        {
            NotificationId = 1337,
            Title = "You are near",
            Subtitle = "Morelands",
            Description = "This place is near",
            Schedule = new NotificationRequestSchedule
            {
                NotifyTime = DateTime.Now.AddSeconds(2)
            },
            // Add these parameters for navigation
            ReturningData = "open_POI13_page", // Custom data to identify the action
            Android =
                {
                    LaunchAppWhenTapped = true // Ensure app launches when tapped
                }
        };

        await LocalNotificationCenter.Current.Show(request);
    }

    private async void Notification14Clicked(object sender, EventArgs e)
    {
        // Only show notification if we have permission
        var request = new NotificationRequest
        {
            NotificationId = 1337,
            Title = "You are near",
            Subtitle = "School",
            Description = "This place is near",
            Schedule = new NotificationRequestSchedule
            {
                NotifyTime = DateTime.Now.AddSeconds(2)
            },
            // Add these parameters for navigation
            ReturningData = "open_POI14_page", // Custom data to identify the action
            Android =
                {
                    LaunchAppWhenTapped = true // Ensure app launches when tapped
                }
        };

        await LocalNotificationCenter.Current.Show(request);
    }

    private async void Notification15Clicked(object sender, EventArgs e)
    {
        // Only show notification if we have permission
        var request = new NotificationRequest
        {
            NotificationId = 1337,
            Title = "You are near",
            Subtitle = "Charles Bell Pavillion",
            Description = "This place is near",
            Schedule = new NotificationRequestSchedule
            {
                NotifyTime = DateTime.Now.AddSeconds(2)
            },
            // Add these parameters for navigation
            ReturningData = "open_POI15_page", // Custom data to identify the action
            Android =
                {
                    LaunchAppWhenTapped = true // Ensure app launches when tapped
                }
        };

        await LocalNotificationCenter.Current.Show(request);
    }

    private async void Notification16Clicked(object sender, EventArgs e)
    {
        // Only show notification if we have permission
        var request = new NotificationRequest
        {
            NotificationId = 1337,
            Title = "You are near",
            Subtitle = "Canaan Park",
            Description = "This place is near",
            Schedule = new NotificationRequestSchedule
            {
                NotifyTime = DateTime.Now.AddSeconds(2)
            },
            // Add these parameters for navigation
            ReturningData = "open_POI16_page", // Custom data to identify the action
            Android =
                {
                    LaunchAppWhenTapped = true // Ensure app launches when tapped
                }
        };

        await LocalNotificationCenter.Current.Show(request);
    }

    private async void Notification17Clicked(object sender, EventArgs e)
    {
        // Only show notification if we have permission
        var request = new NotificationRequest
        {
            NotificationId = 1337,
            Title = "You are near",
            Subtitle = "Canaan House",
            Description = "This place is near",
            Schedule = new NotificationRequestSchedule
            {
                NotifyTime = DateTime.Now.AddSeconds(2)
            },
            // Add these parameters for navigation
            ReturningData = "open_POI17_page", // Custom data to identify the action
            Android =
                {
                    LaunchAppWhenTapped = true // Ensure app launches when tapped
                }
        };

        await LocalNotificationCenter.Current.Show(request);
    }

    private async void Notification18Clicked(object sender, EventArgs e)
    {
        // Only show notification if we have permission
        var request = new NotificationRequest
        {
            NotificationId = 1337,
            Title = "You are near",
            Subtitle = "Doctors Residence",
            Description = "This place is near",
            Schedule = new NotificationRequestSchedule
            {
                NotifyTime = DateTime.Now.AddSeconds(2)
            },
            // Add these parameters for navigation
            ReturningData = "open_POI18_page", // Custom data to identify the action
            Android =
                {
                    LaunchAppWhenTapped = true // Ensure app launches when tapped
                }
        };

        await LocalNotificationCenter.Current.Show(request);
    }

    private async void Notification19Clicked(object sender, EventArgs e)
    {
        // Only show notification if we have permission
        var request = new NotificationRequest
        {
            NotificationId = 1337,
            Title = "You are near",
            Subtitle = "Gates and Sentry Pavilions",
            Description = "This place is near",
            Schedule = new NotificationRequestSchedule
            {
                NotifyTime = DateTime.Now.AddSeconds(2)
            },
            // Add these parameters for navigation
            ReturningData = "open_POI19_page", // Custom data to identify the action
            Android =
                {
                    LaunchAppWhenTapped = true // Ensure app launches when tapped
                }
        };

        await LocalNotificationCenter.Current.Show(request);
    }

    private async void Notification20Clicked(object sender, EventArgs e)
    {
        // Only show notification if we have permission
        var request = new NotificationRequest
        {
            NotificationId = 1337,
            Title = "You are near",
            Subtitle = "The Wall",
            Description = "This place is near",
            Schedule = new NotificationRequestSchedule
            {
                NotifyTime = DateTime.Now.AddSeconds(2)
            },
            // Add these parameters for navigation
            ReturningData = "open_POI20_page", // Custom data to identify the action
            Android =
                {
                    LaunchAppWhenTapped = true // Ensure app launches when tapped
                }
        };

        await LocalNotificationCenter.Current.Show(request);
    }

    private async void Notification21Clicked(object sender, EventArgs e)
    {
        // Only show notification if we have permission
        var request = new NotificationRequest
        {
            NotificationId = 1337,
            Title = "You are near",
            Subtitle = "Millbank",
            Description = "This place is near",
            Schedule = new NotificationRequestSchedule
            {
                NotifyTime = DateTime.Now.AddSeconds(2)
            },
            // Add these parameters for navigation
            ReturningData = "open_POI21_page", // Custom data to identify the action
            Android =
                {
                    LaunchAppWhenTapped = true // Ensure app launches when tapped
                }
        };

        await LocalNotificationCenter.Current.Show(request);
    }

    private async void Notification22Clicked(object sender, EventArgs e)
    {
        // Only show notification if we have permission
        var request = new NotificationRequest
        {
            NotificationId = 1337,
            Title = "You are near",
            Subtitle = "Balfour Pavilion",
            Description = "This place is near",
            Schedule = new NotificationRequestSchedule
            {
                NotifyTime = DateTime.Now.AddSeconds(2)
            },
            // Add these parameters for navigation
            ReturningData = "open_POI22_page", // Custom data to identify the action
            Android =
                {
                    LaunchAppWhenTapped = true // Ensure app launches when tapped
                }
        };

        await LocalNotificationCenter.Current.Show(request);
    }


    private async void OnToHomePageClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomePage());
    }
}