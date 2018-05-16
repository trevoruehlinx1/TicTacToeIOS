// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace TicTacToeIOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton AboutButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel cityLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIPickerView CityPicker { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton newGameButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton NewGameButton2 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ScoreBoardButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton squar1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton squar2 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton squar3 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton squar4 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton squar5 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton squar6 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton squar7 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton squar8 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton squar9 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel winnerLabel { get; set; }

        [Action ("AboutButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void AboutButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("NewGameButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void NewGameButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("ScoreBoardButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ScoreBoardButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("UIButton200_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton200_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (AboutButton != null) {
                AboutButton.Dispose ();
                AboutButton = null;
            }

            if (cityLabel != null) {
                cityLabel.Dispose ();
                cityLabel = null;
            }

            if (CityPicker != null) {
                CityPicker.Dispose ();
                CityPicker = null;
            }

            if (newGameButton != null) {
                newGameButton.Dispose ();
                newGameButton = null;
            }

            if (NewGameButton2 != null) {
                NewGameButton2.Dispose ();
                NewGameButton2 = null;
            }

            if (ScoreBoardButton != null) {
                ScoreBoardButton.Dispose ();
                ScoreBoardButton = null;
            }

            if (squar1 != null) {
                squar1.Dispose ();
                squar1 = null;
            }

            if (squar2 != null) {
                squar2.Dispose ();
                squar2 = null;
            }

            if (squar3 != null) {
                squar3.Dispose ();
                squar3 = null;
            }

            if (squar4 != null) {
                squar4.Dispose ();
                squar4 = null;
            }

            if (squar5 != null) {
                squar5.Dispose ();
                squar5 = null;
            }

            if (squar6 != null) {
                squar6.Dispose ();
                squar6 = null;
            }

            if (squar7 != null) {
                squar7.Dispose ();
                squar7 = null;
            }

            if (squar8 != null) {
                squar8.Dispose ();
                squar8 = null;
            }

            if (squar9 != null) {
                squar9.Dispose ();
                squar9 = null;
            }

            if (winnerLabel != null) {
                winnerLabel.Dispose ();
                winnerLabel = null;
            }
        }
    }
}