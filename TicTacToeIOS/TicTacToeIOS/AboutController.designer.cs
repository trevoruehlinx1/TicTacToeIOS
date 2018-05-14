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

namespace TicTacToeIOS
{
    [Register ("AboutController")]
    partial class AboutController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView AboutViewController { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (AboutViewController != null) {
                AboutViewController.Dispose ();
                AboutViewController = null;
            }
        }
    }
}