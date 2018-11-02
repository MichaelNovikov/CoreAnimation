using CoreGraphics;
using System;
using UIKit;

namespace FigureGame
{
    public partial class ViewController : UIViewController
    {
        private nfloat _step = 0f;
        private nfloat _scale = 1f;
        private bool transFlag = false;
        private bool slid = false;
        private bool slidColor = false;
        private UIView _figure;

        CGAffineTransform _transform;

        public ViewController(IntPtr handle) : base(handle)
        {
            _transform = CGAffineTransform.MakeIdentity();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            _figure = new UIView()
            {
                Frame = new CGRect(30, 30, 50, 50),
                BackgroundColor = UIColor.Black
            };
            _figure.Layer.BorderWidth = 5f;
            _figure.Layer.BorderColor = UIColor.Red.CGColor;

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
                Frame = new CGRect(373, 490, 30, 30),
                BackgroundColor = UIColor.Green
            };

            #endregion
            ;
            #region AddTask

            var featureView = new UIView()
            {
                Frame = new CGRect(0, 0, addView.Frame.Width, addView.Frame.Height),
            };

            var lineUPIn = new UIView()
            {
                Frame = new CGRect((featureView.Frame.Width / 2) - 3, 0, 6, featureView.Frame.GetMidY()),
                BackgroundColor = UIColor.Black
            };

            var lineDownIn = new UIView()
            {
                Frame = new CGRect((featureView.Frame.Width / 2) - 3, featureView.Frame.GetMidY(), 6, featureView.Frame.GetMidY()),
                BackgroundColor = UIColor.Green
            };

            var viewIn = new UIView()
            {
                Frame = new CGRect(0, 0, featureView.Frame.Width, featureView.Frame.Width),
                BackgroundColor = UIColor.Black
            };
            viewIn.Layer.CornerRadius = viewIn.Frame.Width / 2;
            viewIn.Layer.BorderWidth = 5f;
            viewIn.Layer.BorderColor = UIColor.FromRGBA(10, 96, 255, 255).CGColor;

            featureView.AddSubviews(lineUPIn, lineDownIn, viewIn);

            var recon = new UIPanGestureRecognizer(r =>
            {
                nfloat range = featureView.Frame.Width / 2;
                var L = r.LocationInView(r.View);


                switch (r.State)
                {
                    case UIGestureRecognizerState.Possible:
                        break;

                    case UIGestureRecognizerState.Began:
                        if (((L.Y + range) <= featureView.Bounds.GetMaxY()) && ((L.Y - range) >= featureView.Bounds.GetMinY()))
                        {
                            viewIn.Layer.RemoveAllAnimations();
                            slid = true;
                        }
                        break;

                    case UIGestureRecognizerState.Changed:
                        if ((((L.Y + range) <= featureView.Bounds.GetMaxY()) && ((L.Y - range) >= featureView.Bounds.GetMinY())) && slid)
                        {
                            var center = viewIn.Center;
                            center.Y = L.Y;
                            viewIn.Center = center;
                        }
                        UIView.Animate(.2f, () =>
                        {
                            if ((viewIn.Center.Y < featureView.Bounds.GetMidY()) && !slidColor)
                            {
                                viewIn.BackgroundColor = UIColor.Black;
                                _figure.BackgroundColor = UIColor.Black;
                                slidColor = true;
                            }
                            else if ((viewIn.Center.Y > featureView.Bounds.GetMidY()) && slidColor)
                            {
                                viewIn.BackgroundColor = UIColor.Green;
                                _figure.BackgroundColor = UIColor.Green;
                                slidColor = false;
                            }
                        });
                        break;

                    case UIGestureRecognizerState.Ended:
                        UIView.Animate(.2f, () =>
                        {
                            if (viewIn.Center.Y < featureView.Bounds.GetMidY())
                            {
                                var center = viewIn.Center;
                                center.Y = featureView.Bounds.GetMinY() + range - 1;
                                viewIn.Center = center;
                                viewIn.BackgroundColor = UIColor.Black;
                                _figure.BackgroundColor = UIColor.Black;
                            }
                            else
                            {
                                var center = viewIn.Center;
                                center.Y = featureView.Bounds.GetMaxY() - range + 1;
                                viewIn.Center = center;
                                viewIn.BackgroundColor = UIColor.Green;
                                _figure.BackgroundColor = UIColor.Green;
                            }
                        });
                        slid = false;
                        break;

                    case UIGestureRecognizerState.Cancelled:

                        break;

                    case UIGestureRecognizerState.Failed:
                        break;
                }
            });

            featureView.AddGestureRecognizer(recon);

            #endregion

            addView.AddSubview(featureView);

            View.AddSubviews(rect1, rect2, rect3, rect4, rect5, viewLine, rect6,
                _drawTriangle, _drawEllipese1, rect7, rect8, _drawEllipese2, rect9, _figure);

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
                var сenter = _figure.Center;
                сenter.X -= 10;
                сenter.Y -= 10;
                _figure.Center = сenter;
            });
        }

        partial void BtnUp_TouchUpInside(UIButton sender)
        {
            UIView.Animate(0.2f, () =>
            {
                var сenter = _figure.Center;
                сenter.Y -= 10;
                _figure.Center = сenter;
            });
        }

        partial void BtnRightUP_TouchUpInside(UIButton sender)
        {
            UIView.Animate(0.2f, () =>
            {
                var сenter = _figure.Center;
                сenter.Y -= 10;
                сenter.X += 10;
                _figure.Center = сenter;
            });
        }

        partial void BtnLeft_TouchUpInside(UIButton sender)
        {
            UIView.Animate(0.2f, () =>
            {
                var сenter = _figure.Center;
                сenter.X -= 10;
                _figure.Center = сenter;
            });
        }

        partial void BtnRight_TouchUpInside(UIButton sender)
        {
            UIView.Animate(0.2f, () =>
            {
                var сenter = _figure.Center;
                сenter.X += 10;
                _figure.Center = сenter;
            });
        }

        partial void BtnLeftDown_TouchUpInside(UIButton sender)
        {
            UIView.Animate(0.2f, () =>
           {
               var сenter = _figure.Center;
               сenter.Y += 10;
               сenter.X -= 10;
               _figure.Center = сenter;
           }); ;
        }

        partial void BtnDown_TouchUpInside(UIButton sender)
        {
            UIView.Animate(0.2f, () =>
            {
                var center = _figure.Center;
                center.Y += 10;
                _figure.Center = center;
            });
        }

        partial void BtnRightDown_TouchUpInside(UIButton sender)
        {
            UIView.Animate(0.2f, () =>
            {
                var center = _figure.Center;
                center.Y += 10;
                center.X += 10;
                _figure.Center = center;
            });
        }

        partial void BtnScaleUp_TouchUpInside(UIButton sender)
        {
            _scale += .1f;
            UIView.Animate(0.2f, () =>
            {
                _transform.Scale(_scale, _scale);
                _figure.Transform = _transform;

            });
        }

        partial void BtnScaleDown_TouchUpInside(UIButton sender)
        {
            _scale -= .1f;
            UIView.Animate(0.2f, () =>
            {
                _transform.Scale(_scale, _scale);
                _figure.Transform = _transform;
            });
        }

        partial void BtnTransform_TouchUpInside(UIButton sender)
        {
            UIView.Animate(0.2f, () =>
            {
                if (!transFlag)
                {
                    _figure.Layer.CornerRadius = _figure.Layer.Frame.Width / 2;
                    transFlag = true;
                }
                else
                {
                    _figure.Layer.CornerRadius = 0;
                    transFlag = false;
                }
            });
        }

        partial void BtnRotation_TouchUpInside(UIButton sender)
        {
            _step += .3f;
            UIView.Animate(0.2f, () =>
            {
                _transform.Rotate(_step);
                _figure.Transform = _transform;
            });
        }
    }
}