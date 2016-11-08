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
    [Register ("BookViewController")]
    partial class BookViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnAddBook { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtNameAuthor { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtNameBook { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnAddBook != null) {
                btnAddBook.Dispose ();
                btnAddBook = null;
            }

            if (txtNameAuthor != null) {
                txtNameAuthor.Dispose ();
                txtNameAuthor = null;
            }

            if (txtNameBook != null) {
                txtNameBook.Dispose ();
                txtNameBook = null;
            }
        }
    }
}