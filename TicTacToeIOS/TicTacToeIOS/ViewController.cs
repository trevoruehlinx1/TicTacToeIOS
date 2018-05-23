using System;
using UIKit;

namespace TicTacToeIOS
{
    public partial class ViewController : UIViewController
    {
        
        int xScore, oScore = 0;
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            string city = ((AppDelegate)(UIApplication.SharedApplication.Delegate)).cityName;
            if (city != null)
            {
                cityLabel2.Text = "Thanks for playing in " + city;
            }
            else
                cityLabel2.Text = "Thanks for playing in Eugene";

            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }
		public override void ViewDidAppear(bool animated)
		{
            string city = ((AppDelegate)(UIApplication.SharedApplication.Delegate)).cityName;
            if (city != null)
            {
                cityLabel2.Text = "Thanks for playing in " + city;
            }
            else
                cityLabel2.Text = "Thanks for playing in Eugene";
			base.ViewDidAppear(animated);
		}

		public override void DidReceiveMemoryWarning()
        {
            
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
        partial void UIButton200_TouchUpInside(UIButton sender)
        {
            string senderName = sender.AccessibilityIdentifier.ToString();
            sender.SetTitle("O", UIControlState.Normal);
            TTTLogic.PlayerMove(senderName);
            sender.Enabled = false;
            if (!TTTLogic.IsTie() && !TTTLogic.IsWinner())
            {
                string square = TTTLogic.ComputerMove();
                switch (square)
                {
                    case "0,0":
                        squar1.SetTitle("X", UIControlState.Normal);
                        squar1.Enabled = false;
                        break;
                    case "0,1":
                        squar2.SetTitle("X", UIControlState.Normal);
                        squar2.Enabled = false;
                        break;
                    case "0,2":
                        squar3.SetTitle("X", UIControlState.Normal);
                        squar3.Enabled = false;
                        break;
                    case "1,0":
                        squar4.SetTitle("X", UIControlState.Normal);
                        squar4.Enabled = false;
                        break;
                    case "1,1":
                        squar5.SetTitle("X", UIControlState.Normal);
                        squar5.Enabled = false;
                        break;
                    case "1,2":
                        squar6.SetTitle("X", UIControlState.Normal);
                        squar6.Enabled = false;
                        break;
                    case "2,0":
                        squar7.SetTitle("X", UIControlState.Normal);
                        squar7.Enabled = false;
                        break;
                    case "2,1":
                        squar8.SetTitle("X", UIControlState.Normal);
                        squar8.Enabled = false;
                        break;
                    case "2,2":
                        squar9.SetTitle("X", UIControlState.Normal);
                        squar9.Enabled = false;
                        break;
                }

                if (TTTLogic.IsWinner() || TTTLogic.IsTie())
                {
                    winnerLabel.Text = TTTLogic.IsWinner() ? "Computer Wins" : "Its a Tie";
                    xScore++;
                    ((AppDelegate)(UIApplication.SharedApplication.Delegate)).xScore = xScore;
                    DisableGame();
                }
            }
            else
            {
                winnerLabel.Text = TTTLogic.IsWinner() ? "You Win" : "Its a Tie";
                oScore++;
                ((AppDelegate)(UIApplication.SharedApplication.Delegate)).oScore = oScore;
                DisableGame();
            }
        }

        private void DisableGame()
        {
            squar1.Enabled = false;
            squar2.Enabled = false;
            squar3.Enabled = false;
            squar4.Enabled = false;
            squar5.Enabled = false;
            squar6.Enabled = false;
            squar7.Enabled = false;
            squar8.Enabled = false;
            squar9.Enabled = false;
        }


        partial void NewGameButton_TouchUpInside(UIButton sender)
        {
            squar1.Enabled = true;
            squar2.Enabled = true;
            squar3.Enabled = true;
            squar4.Enabled = true;
            squar5.Enabled = true;
            squar6.Enabled = true;
            squar7.Enabled = true;
            squar8.Enabled = true;
            squar9.Enabled = true;
            squar1.SetTitle("", UIControlState.Normal);
            squar2.SetTitle("", UIControlState.Normal);
            squar3.SetTitle("", UIControlState.Normal);
            squar4.SetTitle("", UIControlState.Normal);
            squar5.SetTitle("", UIControlState.Normal);
            squar6.SetTitle("", UIControlState.Normal);
            squar7.SetTitle("", UIControlState.Normal);
            squar8.SetTitle("", UIControlState.Normal);
            squar9.SetTitle("", UIControlState.Normal);
            winnerLabel.Text = "";
            TTTLogic.Reset();
        }
    }
}
            //ANIMATION NOTES!!!
            //UIView.BeginAnimations("View CurlUp");
            //UIView.SetAnimationDuration(0.5);
            //UIView.SetAnimationCurve(UIViewAnimationCurve.EaseInOut);
            //UIView.SetAnimationTransition(UIViewAnimationTransition.CurlUp, forView: View, cache: true);
            //UIView.CommitAnimations();