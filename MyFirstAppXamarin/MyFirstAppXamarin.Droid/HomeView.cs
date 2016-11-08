
using Android.App;
using Android.Widget;
using Android.OS;
using MvvmCross.Droid.Views;
using MyFirstAppXamarin.ViewModels;

namespace MyFirstAppXamarin.Droid
{
    [Activity (Label = "MyFirstAppXamarin.Droid", MainLauncher = true, Icon = "@drawable/icon")]
	public class HomeView : MvxActivity<HomeViewModel>
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", count++);
			};
		}
	}
}


