﻿using Android.App;
using Android.OS;
using Android.Content.PM;

namespace WorkingWithFiles.Droid
{
	[Activity (Label = "WorkingWithFiles.Droid", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, 
		ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
            ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate (bundle);
			global::Xamarin.Forms.Forms.Init (this, bundle);
			LoadApplication (new App ());
		}
	}
}
