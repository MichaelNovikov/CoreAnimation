using CoreGraphics;
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

        CGAffineTransform _transform;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            _transform = CGAffineTransform.MakeIdentity();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void BtnLeftUP_TouchUpInside(UIButton sender)
        {
            UIView.Animate(0.2f, () =>
            {
                var сenter = figure.Center;
                сenter.X -= 10;
                сenter.Y -= 10;
                figure.Center = сenter;
            });
        }

        partial void BtnUp_TouchUpInside(UIButton sender)
        {
            UIView.Animate(0.2f, () =>
            {
                var сenter = figure.Center;
                сenter.Y -= 10;
                figure.Center = сenter;
            });
        }

        partial void BtnRightUP_TouchUpInside(UIButton sender)
        {
            UIView.Animate(0.2f, () =>
            {
                var сenter = figure.Center;
                сenter.Y -= 10;
                сenter.X += 10;
                figure.Center = сenter;
            });
        }

        partial void BtnLeft_TouchUpInside(UIButton sender)
        {
            UIView.Animate(0.2f, () =>
            {
                var сenter = figure.Center;
                сenter.X -= 10;
                figure.Center = сenter;
            });
        }

        partial void BtnRight_TouchUpInside(UIButton sender)
        {
            UIView.Animate(0.2f, () =>
            {
                var сenter = figure.Center;
                сenter.X += 10;
                figure.Center = сenter;
            });
        }

        partial void BtnLeftDown_TouchUpInside(UIButton sender)
        {
            UIView.Animate(0.2f, () =>
           {
               var сenter = figure.Center;
               сenter.Y += 10;
               сenter.X -= 10;
               figure.Center = сenter;
           }); ;
        }

        partial void BtnDown_TouchUpInside(UIButton sender)
        {
            UIView.Animate(0.2f, () =>
            {
                var center = figure.Center;
                center.Y += 10;
                figure.Center = center;
            });
        }

        partial void BtnRightDown_TouchUpInside(UIButton sender)
        {
            UIView.Animate(0.2f, () =>
            {
                var center = figure.Center;
                center.Y += 10;
                center.X += 10;
                figure.Center = center;
            });
        }

        partial void BtnScaleUp_TouchUpInside(UIButton sender)
        {
            _scale += .1f;
            UIView.Animate(0.2f, () =>
            {
                _transform.Scale(_scale, _scale);
                figure.Transform = _transform;
            });
        }

        partial void BtnScaleDown_TouchUpInside(UIButton sender)
        {
            _scale -= .1f;
            UIView.Animate(0.2f, () =>
            {
                _transform.Scale(_scale, _scale);
                figure.Transform = _transform;
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
            _step += .3f;
            UIView.Animate(0.2f, () =>
            {
                _transform.Rotate(_step);
                figure.Transform = _transform;
            });
        }
    }
}