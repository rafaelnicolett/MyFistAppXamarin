using Foundation;
using System;
using UIKit;
using MvvmCross.iOS.Views;
using MyFirstAppXamarin.ViewModels;

namespace MyFirstAppXamarin.iOS
{
    public partial class HomeViewController : MvxTableViewController<HomeViewModel>
    {
        public HomeViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
		}
    }
}