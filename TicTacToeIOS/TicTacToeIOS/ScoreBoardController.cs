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
            XScoreOutputLabel.Text = XScore.ToString();
            OScoreOutputLabel.Text = OScore.ToString();
        }

		public override void ViewDidAppear(bool animated)
		{
            XScore = ((AppDelegate)(UIApplication.SharedApplication.Delegate)).xScore;
            OScore = ((AppDelegate)(UIApplication.SharedApplication.Delegate)).oScore;
            XScoreOutputLabel.Text = XScore.ToString();
            OScoreOutputLabel.Text = OScore.ToString();
			base.ViewDidAppear(animated);
		}
    }
}