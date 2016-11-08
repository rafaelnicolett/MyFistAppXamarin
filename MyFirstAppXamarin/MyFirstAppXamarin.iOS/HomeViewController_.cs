using System;
using MvvmCross.iOS.Views;
using MyFirstAppXamarin.ViewModels;
using MvvmCross.Core.ViewModels;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.Binding.BindingContext;

namespace MyFirstAppXamarin.iOS
{
    public partial class HomeViewController : MvxTableViewController<HomeViewModel>
    {
        public HomeViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			this.Request = new MvxViewModelRequest<HomeViewModel>(null, null, new MvxRequestedBy());

			base.ViewDidLoad();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            ViewModel.GetAllBooks();

            CreateBind();
        }

        private void CreateBind()
        {
            var source = new MvxStandardTableViewSource(TableView, BookTableViewCell.Key);

            var bindings = this.CreateBindingSet<HomeViewController, HomeViewModel>();

            bindings.Bind(source).To(_ => _.Books);

            bindings.Apply();

            TableView.Source = source;

            TableView.ReloadData();
        }
    }
}