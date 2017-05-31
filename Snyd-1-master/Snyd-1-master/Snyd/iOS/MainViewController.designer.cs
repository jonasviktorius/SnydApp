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

namespace Snyd.iOS
{
    [Register ("MainViewController")]
    partial class MainViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton RollDices { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (RollDices != null) {
                RollDices.Dispose ();
                RollDices = null;
            }
        }
    }
}