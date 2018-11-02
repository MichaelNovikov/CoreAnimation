using CoreGraphics;
using System;
using UIKit;

namespace App
{
    public partial class ViewController : UIViewController
    {

        private bool flag = false;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var rect = new StarView()
            {
                Frame = new CGRect(0, 1, 40, 40),
                BackgroundColor = UIColor.Blue
            };

            View.AddSubviews(rect);
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}