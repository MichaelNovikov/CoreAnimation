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
            _transform = CGAffineTransform.MakeIdentity();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            #region Black

            var rect1 = new UIView()
            {
                Frame = new CGRect(10, 120, 120, 70),
                BackgroundColor = UIColor.Black
            };

            var rect2 = new UIView()
            {
                Frame = new CGRect(130, 40, 60, 50),
                BackgroundColor = UIColor.Black
            };

            var rect3 = new UIView()
            {
                Frame = new CGRect(160, 100, 200, 80),
                BackgroundColor = UIColor.Black
            };

            var rect4 = new UIView()
            {
                Frame = new CGRect(10, 210, 190, 70),
                BackgroundColor = UIColor.Black
            };

            var rect5 = new UIView()
            {
                Frame = new CGRect(240, 205, 80, 80),
                BackgroundColor = UIColor.Black,
            };
            var trans5 = CGAffineTransform.MakeRotation(-2f);
            rect5.Transform = trans5;

            #endregion

            var viewLine = new UIView()
            {
                Frame = new CGRect(0, 325, View.Frame.Width, 2),
                BackgroundColor = UIColor.Black
            };

            #region Green

            var rect6 = new UIView()
            {
                Frame = new CGRect(10, 350, 140, 80),
                BackgroundColor = UIColor.Green
            };

            var _drawEllipese1 = new DrawerView(new CGRect(170, 350, 180, 75), "ellipese");

            var rect7 = new UIView()
            {
                Frame = new CGRect(10, 450, 190, 70),
                BackgroundColor = UIColor.Green
            };

            var rect8 = new UIView()
            {
                Frame = new CGRect(362, 335, 30, 80),
                BackgroundColor = UIColor.Green
            };
            var trans8 = CGAffineTransform.MakeRotation(-.4f);
            rect8.Transform = trans8;

            var _drawTriangle = new DrawerView(new CGRect(220, 440, 90, 75), "triangle");

            var _drawEllipese2 = new DrawerView(new CGRect(300, 440, 90, 50), "ellipese");
            var transE = CGAffineTransform.MakeRotation(2.5f);
            _drawEllipese2.Transform = transE;

            var rect9 = new UIView()
            {
                Frame = new CGRect(373, 497, 30, 30),
                BackgroundColor = UIColor.Green
            };

            #endregion

            View.AddSubviews(rect1, rect2, rect3, rect4, rect5, viewLine, rect6,
                _drawTriangle, _drawEllipese1, rect7, rect8, _drawEllipese2, rect9);
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
                    figure.Layer.CornerRadius = figure.Layer.Frame.Width / 2;
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