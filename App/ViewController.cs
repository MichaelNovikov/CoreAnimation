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

            var rectIn = new UIView()
            {
                Frame = new CGRect(0, 1, 40, 40),
                BackgroundColor = UIColor.Black
            };

            var rect = new UIView()
            {
                Frame = new CGRect(0, 50, 40, 200),
                BackgroundColor = UIColor.Cyan
            };
            rect.AddSubview(rectIn);


            var recon = new UIPanGestureRecognizer(r =>
            {
                var L = r.LocationInView(r.View);
                switch (r.State)
                {
                    case UIGestureRecognizerState.Possible:
                        break;

                    case UIGestureRecognizerState.Began:

                        break;

                    case UIGestureRecognizerState.Changed:
                        if (((L.Y + 20) <= rect.Bounds.GetMaxY()) && ((L.Y - 20) >= rect.Bounds.GetMinY()))
                        {
                            var center = rectIn.Center;
                            center.Y = L.Y;
                            rectIn.Center = center;
                        }

                        break;

                    case UIGestureRecognizerState.Ended:
                        UIView.Animate(0.2f, () =>
                        {
                            if (rectIn.Center.Y < rect.Bounds.GetMidY())
                            {
                                var center = rectIn.Center;
                                center.Y = rect.Bounds.GetMinY() + 20;
                                rectIn.Center = center;
                            }
                            else
                            {
                                var center = rectIn.Center;
                                center.Y = rect.Bounds.GetMaxY() - 20;
                                rectIn.Center = center;
                            }
                        });
                        break;

                    case UIGestureRecognizerState.Cancelled:

                        break;

                    case UIGestureRecognizerState.Failed:
                        break;
                }
            });

            rect.AddGestureRecognizer(recon);
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