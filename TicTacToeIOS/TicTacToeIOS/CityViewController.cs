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
                CityPicker.Model = new CityPickerModel(cityTextField);
            }
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        partial void cityValueChanged(UITextField sender)
        {
            
            string cityNametext = cityTextField.Text;
            //((AppDelegate)(UIApplication.SharedApplication.Delegate)).cityName = cityNametext;
        }
    }
}