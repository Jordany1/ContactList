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
    [Register ("ContactTableViewCell")]
    partial class ContactTableViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelLocation { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelNumber { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (labelLocation != null) {
                labelLocation.Dispose ();
                labelLocation = null;
            }

            if (labelName != null) {
                labelName.Dispose ();
                labelName = null;
            }

            if (labelNumber != null) {
                labelNumber.Dispose ();
                labelNumber = null;
            }
        }
    }
}