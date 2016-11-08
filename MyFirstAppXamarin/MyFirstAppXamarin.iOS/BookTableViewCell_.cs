using Foundation;
using System;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.Binding.BindingContext;
using MyFirstAppXamarin.Model;

namespace MyFirstAppXamarin.iOS
{
    public partial class BookTableViewCell : MvxTableViewCell
    {
        public static readonly NSString Key = new NSString("bookCell");

        public BookTableViewCell(IntPtr handle) : base(handle)
        {
            this.DelayBind(() =>
               {
                   var binding = this.CreateBindingSet<BookTableViewCell, Book>();
                   binding.Bind(lblNameBook).For(x => x.Text).To(_ => _.Name);
                   binding.Bind(lblNameAuthor).For(x => x.Text).To(_ => _.Author);

                   binding.Apply();
               });
        }
    }
}