using CoreGraphics;
using UIKit;

namespace FigureGame
{
    public class DrawerView : UIView
    {
        private string _figure;    

        public DrawerView()
        { }

        public DrawerView(CGRect rect, string figure)
        {
            Frame = rect;
            BackgroundColor = UIColor.Clear;
            _figure = figure;
        }

        public override void Draw(CGRect rect)
        {
            base.Draw(rect);
            var context = UIGraphics.GetCurrentContext();

            switch(_figure)
            {
                case "ellipese":
                    DrawEllipse(context, rect);
                    break;
                case "triangle":
                    DrawTriangle(context, rect);
                    break;
            }

            context.SetFillColor(UIColor.Green.CGColor);
            context.FillPath();
            context.DrawPath(CGPathDrawingMode.FillStroke);
        }

        private void DrawEllipse(CGContext context, CGRect rect)
        {
            context.AddEllipseInRect(rect);
        }

        private void DrawTriangle(CGContext context, CGRect rect)
        {
            context.BeginPath();
            context.MoveTo(rect.GetMaxX() / 2, rect.GetMinY());
            context.AddLineToPoint(rect.GetMaxX(), rect.GetMaxY());
            context.AddLineToPoint(rect.GetMinX(), rect.GetMaxY());
            context.ClosePath();
        }
    }
}