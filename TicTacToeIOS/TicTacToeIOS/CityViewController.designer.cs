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
    [Register ("CityViewController")]
    partial class CityViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIPickerView CityPicker { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField cityTextField { get; set; }

        [Action ("cityValueChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void cityValueChanged (UIKit.UITextField sender);

        void ReleaseDesignerOutlets ()
        {
            if (CityPicker != null) {
                CityPicker.Dispose ();
                CityPicker = null;
            }

            if (cityTextField != null) {
                cityTextField.Dispose ();
                cityTextField = null;
            }
        }
    }
}