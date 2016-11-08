using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Views;
using MyFirstAppXamarin.ViewModels;
using System;
using UIKit;

namespace MyFirstAppXamarin.iOS
{
    public partial class BooksTableViewController : MvxTableViewController
    {
        public BooksTableViewController (IntPtr handle) : base (handle)
        {
            
        }

        public override void ViewDidLoad()
        {
            this.Request = new MvxViewModelRequest<HomeViewModel>(null, null, new MvxRequestedBy());

            base.ViewDidLoad();

            var source = new MvxStandardTableViewSource(TableView, BookTableViewCell.Key);

            var bindings = this.CreateBindingSet<BooksTableViewController, HomeViewModel>();

            bindings.Bind(source).To(_ => _.Books);

            bindings.Apply();

            TableView.Source = source;

            TableView.ReloadData();
        }
    }
}