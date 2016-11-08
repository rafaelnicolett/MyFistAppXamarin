using MvvmCross.Binding.BindingContext;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Views;
using MyFirstAppXamarin.ViewModels;
using System;

namespace MyFirstAppXamarin.iOS
{
    public partial class BookViewController : MvxViewController<BookViewModel>
    {
        public BookViewController (IntPtr handle) : base (handle)
        {

        }

        public override void ViewDidLoad()
        {
            Request = new MvxViewModelRequest<BookViewModel>(null, null, new MvxRequestedBy());

            base.ViewDidLoad();

            var bindings = this.CreateBindingSet<BookViewController, BookViewModel>();
            bindings.Bind(txtNameBook).For(x => x.Text).To(_ => _.Name);
            bindings.Bind(txtNameAuthor).For(x => x.Text).To(_ => _.Author);
            bindings.Bind(btnAddBook).For("TouchUpInside").To(x => x.SaveBookCommand);

            bindings.Apply();
        }
    }
}