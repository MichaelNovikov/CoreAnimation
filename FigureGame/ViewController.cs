using CoreGraphics;
using Foundation;
using System;
using UIKit;

namespace FigureGame
{
    public partial class ViewController : UIViewController
    {
        private float _step = 0f;
        private float _scale = 1f;
        private bool transFlag = false;
        private bool colorFlag = false;

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

        partial void BtnScaleUp_TouchUpInside(UIButton sender)
        {
            _scale += .1f;
            UIView.Animate(0.2f, () =>
            {
                var frame = figure.Frame;
                frame.Width += _scale;
                frame.Height += _scale;
                figure.Frame = frame;
            });
        }

        partial void BtnScaleDown_TouchUpInside(UIButton sender)
        {
            _scale -= .1f;
            UIView.Animate(0.2f, () =>
            {
                var frame = figure.Frame;
                frame.Width -= _scale;
                frame.Height -= _scale;
                figure.Frame = frame;
                //figure.Transform = CGAffineTransform.MakeScale(_scale, _scale);

            });
        }

        partial void BtnTransform_TouchUpInside(UIButton sender)
        {
            UIView.Animate(0.2f, () =>
            {
                if (!transFlag)
                {

                    figure.Layer.CornerRadius = figure.Frame.Width / 2;
                    transFlag = true;
                }
                else
                {
                    figure.Layer.CornerRadius = 0;
                    transFlag = false;
                }
            });
        }

        partial void BtnColor_TouchUpInside(UIButton sender)
        {
            UIView.Animate(0.2f, () =>
            {
                if (!colorFlag)
                {
                    figure.Layer.BackgroundColor = UIColor.Black.CGColor;
                    colorFlag = true;
                }
                else
                {
                    figure.Layer.BackgroundColor = UIColor.Green.CGColor;
                    colorFlag = false;
                }
            });
        }

        partial void BtnRotation_TouchUpInside(UIButton sender)
        {
            
            _step += .5f;
            UIView.Animate(0.2f, () =>
            {
                //figure.Transform = CGAffineTransform.MakeRotation(_step);
                figure.Frame = 
            });
        }
    }
}