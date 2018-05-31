using System;
using Android.App;
using Android.OS;
using Android.Content.PM;
using Xamarin.Forms;

namespace Chat.Droid
{
    [Activity(Label = "Chat", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            Acr.UserDialogs.UserDialogs.Init(() => (Activity)Forms.Context);
            LoadApplication(new App());
        }
    }
}

