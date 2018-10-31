using Foundation;
using System;
using UIKit;

namespace Game
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

        //partial void BntUp_TouchUpInside(UIButton sender)
        //{
        //    UIView.Animate(0.2f, () =>
        //    {
        //        var frame = Figure.Frame;
        //        frame.Y -= 10;
        //        Figure.Frame = frame;
        //    });
        //}

        //partial void BtnDown_TouchUpInside(UIButton sender)
        //{
        //    UIView.Animate(0.2f, () =>
        //    {
        //        var frame = Figure.Frame;
        //        frame.Y += 10;
        //        Figure.Frame = frame;
        //    });
        //}

        //partial void BtnLeft_TouchUpInside(UIButton sender)
        //{
        //    UIView.Animate(0.2f, () =>
        //    {
        //        var frame = Figure.Frame;
        //        frame.X -= 10;
        //        Figure.Frame = frame;
        //    });
        //}

        //partial void BtnRight_TouchUpInside(UIButton sender)
        //{
        //    UIView.Animate(0.2f, () =>
        //    {
        //        var frame = Figure.Frame;
        //        frame.X += 10;
        //        Figure.Frame = frame;
        //    });
        //}

        //partial void LeftUP_TouchUpInside(UIButton sender)
        //{
        //    UIView.Animate(0.2f, () =>
        //    {
        //        var frame = Figure.Frame;
        //        frame.Y -= 10;
        //        frame.X -= 10;
        //        Figure.Frame = frame;
        //    });
        //}

        //partial void RightUp_TouchUpInside(UIButton sender)
        //{
        //    UIView.Animate(0.2f, () =>
        //    {
        //        var frame = Figure.Frame;
        //        frame.Y -= 10;
        //        frame.X += 10;
        //        Figure.Frame = frame;
        //    });
        //}

        //partial void LeftDown_TouchUpInside(UIButton sender)
        //{
        //    UIView.Animate(0.2f, () =>
        //    {
        //        var frame = Figure.Frame;
        //        frame.Y += 10;
        //        frame.X -= 10;
        //        Figure.Frame = frame;
        //    });
        //}

        //partial void RightDown_TouchUpInside(UIButton sender)
        //{
        //    UIView.Animate(0.2f, () =>
        //    {
        //        var frame = Figure.Frame;
        //        frame.Y += 10;
        //        frame.X += 10;
        //        Figure.Frame = frame;
        //    });
        //}
    }
}