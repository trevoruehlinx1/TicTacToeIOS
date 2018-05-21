using Foundation;
using System;
using UIKit;

namespace TicTacToeIOS
{
    public partial class ScoreBoardController : UIViewController
    {
        public int XScore { get; set; }
        public int OScore { get; set; }
        public ScoreBoardController (IntPtr handle) : base (handle)
        {
            
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            XScore = ((AppDelegate)(UIApplication.SharedApplication.Delegate)).xScore;
            OScore = ((AppDelegate)(UIApplication.SharedApplication.Delegate)).oScore;
            // Perform any additional setup after loading the view, typically from a nib.
            XScoreOutputLabel.Text = XScore.ToString();
            OScoreOutputLabel.Text = OScore.ToString();
        }
    }
}