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
    [Register ("ScoreBoardController")]
    partial class ScoreBoardController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel OScoreOutputLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton RefreshButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView ScoreBoardViewController { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel XScoreOutputLabel { get; set; }

        [Action ("RefreshButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void RefreshButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (OScoreOutputLabel != null) {
                OScoreOutputLabel.Dispose ();
                OScoreOutputLabel = null;
            }

            if (RefreshButton != null) {
                RefreshButton.Dispose ();
                RefreshButton = null;
            }

            if (ScoreBoardViewController != null) {
                ScoreBoardViewController.Dispose ();
                ScoreBoardViewController = null;
            }

            if (XScoreOutputLabel != null) {
                XScoreOutputLabel.Dispose ();
                XScoreOutputLabel = null;
            }
        }
    }
}