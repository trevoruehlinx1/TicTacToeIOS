using Foundation;
using System;
using UIKit;

namespace TicTacToeIOS
{
    public partial class ScoreBoardController : UIViewController
    {
        public int xScore;
        public int oScore;
        public ScoreBoardController (IntPtr handle) : base (handle)
        {
        }
    }
}