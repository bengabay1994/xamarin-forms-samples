﻿using Android.App;
using Android.Content.PM;
using Android.OS;

namespace CustomRenderer.Droid
{
    [Activity(Label = "CustomRenderer.Droid", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);
            global::Xamarin.Forms.Forms.Init(this, bundle);

            App.Description = "Custom ListView + Cell";
            LoadApplication(new App());
        }
    }
}

