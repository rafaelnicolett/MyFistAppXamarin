using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using MyFirstAppXamarin.Model;
using System;

namespace MyFirstAppXamarin.iOS
{
    public partial class BookTableViewCell : MvxTableViewCell
    {
        public static readonly NSString Key = new NSString("cellBook");

        public BookTableViewCell (IntPtr handle) : base (handle)
        {
            this.DelayBind(() =>
            {
                var binding = this.CreateBindingSet<BookTableViewCell, Book>();
               
                binding.Bind(lblBookName).For(x => x.Text).To(_ => _.Name);
                binding.Bind(lblNameAuthor).For(x => x.Text).To(_ => _.Author);
               
                binding.Apply();
            });
        }
    }
}