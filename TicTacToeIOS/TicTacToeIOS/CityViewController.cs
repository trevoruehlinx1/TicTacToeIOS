using Foundation;
using System;
using UIKit;

namespace TicTacToeIOS
{
    public partial class CityViewController : UIViewController
    {
        public CityViewController (IntPtr handle) : base (handle)
        {
        }
        public override void ViewDidLoad()
        {
            if (CityPicker != null)
            {
                CityPicker.Model = new CityPickerModel(cityLabel);
            }
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }
    }
}