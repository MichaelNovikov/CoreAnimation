using Foundation;
using System;
using UIKit;

namespace FigureGame
{
    public partial class ViewController : UIViewController
    {
        public ViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning ()
        {
            base.DidReceiveMemoryWarning ();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void BtnLeftUP_TouchUpInside(UIButton sender)
        {
            UIView.Animate(0.2f, () =>
            {
                var frame = figure.Frame;
                frame.X -= 10;
                frame.Y -= 10;
                figure.Frame = frame;
            });
        }

        partial void BtnUp_TouchUpInside(UIButton sender)
        {
            UIView.Animate(0.2f, () =>
            {
                var frame = figure.Frame;
                frame.Y -= 10;
                figure.Frame = frame;
            });
        }

        partial void BtnRightUP_TouchUpInside(UIButton sender)
        {
            UIView.Animate(0.2f, () =>
            {
                var frame = figure.Frame;
                frame.Y -= 10;
                frame.X += 10;
                figure.Frame = frame;
            });
        }

        partial void BtnLeft_TouchUpInside(UIButton sender)
        {
            UIView.Animate(0.2f, () =>
            {
                var frame = figure.Frame;
                frame.X -= 10;
                figure.Frame = frame;
            });
        }

        partial void BtnRight_TouchUpInside(UIButton sender)
        {
            UIView.Animate(0.2f, () =>
            {
                var frame = figure.Frame;
                frame.X += 10;
                figure.Frame = frame;
            });
        }

        partial void BtnLeftDown_TouchUpInside(UIButton sender)
        {
             UIView.Animate(0.2f, () =>
            {
                var frame = figure.Frame;
                frame.Y += 10;
                frame.X -= 10;
                figure.Frame = frame;
            }); ;
        }

        partial void BtnDown_TouchUpInside(UIButton sender)
        {
            UIView.Animate(0.2f, () =>
            {
                var frame = figure.Frame;
                frame.Y += 10;
                figure.Frame = frame;
            });
        }

        partial void BtnRightDown_TouchUpInside(UIButton sender)
        {
            UIView.Animate(0.2f, () =>
            {
                var frame = figure.Frame;
                frame.Y += 10;
                frame.X += 10;
                figure.Frame = frame;
            });
        }
    }
}