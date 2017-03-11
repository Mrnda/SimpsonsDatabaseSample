// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace SimpsonsDatabase.iOS
{
    [Register ("DetailViewController")]
    partial class DetailViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel AgeLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView DescriptionTextView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel FirstNameLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel GenderLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LastNameLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (AgeLabel != null) {
                AgeLabel.Dispose ();
                AgeLabel = null;
            }

            if (DescriptionTextView != null) {
                DescriptionTextView.Dispose ();
                DescriptionTextView = null;
            }

            if (FirstNameLabel != null) {
                FirstNameLabel.Dispose ();
                FirstNameLabel = null;
            }

            if (GenderLabel != null) {
                GenderLabel.Dispose ();
                GenderLabel = null;
            }

            if (LastNameLabel != null) {
                LastNameLabel.Dispose ();
                LastNameLabel = null;
            }
        }
    }
}