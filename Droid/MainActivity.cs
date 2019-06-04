
using Android.App;
using Android.Content.PM;
using Android.OS;
using CarouselView.FormsPlugin.Android;
using FFImageLoading.Forms.Platform;

namespace KickassUI.FancyTutorial.Droid
{
    [Activity(Label = "Fancy Tutorial", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            CachedImageRenderer.Init(enableFastRenderer: true);
            CarouselViewRenderer.Init();

            LoadApplication(new App());
        }
    }
}
