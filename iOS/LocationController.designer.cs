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

namespace Rater.iOS
{
    [Register ("LocationController")]
    partial class LocationController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIPickerView StatePicker { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (StatePicker != null) {
                StatePicker.Dispose ();
                StatePicker = null;
            }
        }
    }
}