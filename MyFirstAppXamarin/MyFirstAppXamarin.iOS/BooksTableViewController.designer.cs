// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace MyFirstAppXamarin.iOS
{
    [Register ("BooksTableViewController")]
    partial class BooksTableViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIBarButtonItem btnAddNewBook { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnAddNewBook != null) {
                btnAddNewBook.Dispose ();
                btnAddNewBook = null;
            }
        }
    }
}