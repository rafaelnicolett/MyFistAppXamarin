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
    [Register ("BookTableViewCell")]
    partial class BookTableViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblNameAuthor { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblNameBook { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (lblNameAuthor != null) {
                lblNameAuthor.Dispose ();
                lblNameAuthor = null;
            }

            if (lblNameBook != null) {
                lblNameBook.Dispose ();
                lblNameBook = null;
            }
        }
    }
}