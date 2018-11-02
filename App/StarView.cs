using System;
using System.Drawing;

using CoreGraphics;
using Foundation;
using UIKit;

namespace App
{
    public class StarView : UIView
    {
        public StarView()
        {
            Initialize();
        }

        public StarView(RectangleF bounds) : base(bounds)
        {
            Initialize();
        }

        void Initialize()
        {

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

            AddGestureRecognizer(recon);
            AddSubviews(rect);
        }
    }
}