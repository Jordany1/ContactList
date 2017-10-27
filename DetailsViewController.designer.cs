// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace ContactList
{
    [Register ("DetailsViewController")]
    partial class DetailsViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView ImgContactImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelContactName { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ImgContactImage != null) {
                ImgContactImage.Dispose ();
                ImgContactImage = null;
            }

            if (labelContactName != null) {
                labelContactName.Dispose ();
                labelContactName = null;
            }
        }
    }
}