using Android.App;
using Android.Content.PM;
using Android.Graphics.Drawables;
using Android.OS;

namespace BeautifulPlacesApp;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        ColorDrawable cd = new ColorDrawable(Android.Graphics.Color.Argb(255, 246, 246, 246));
        Window.SetDecorFitsSystemWindows(false);
        Window.SetStatusBarColor(Android.Graphics.Color.Transparent);
        Window.SetNavigationBarColor(Android.Graphics.Color.Transparent);
        Window.SetBackgroundDrawable(cd);
    }
}





