// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Game
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton bntUp { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnDown { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton BtnDown { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnLeft { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton BtnLeft { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton BtnLeftDown { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton BtnLeftUP { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnRight { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton BtnRight { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton BtnRightDown { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton BtnRightUp { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton BtnUp { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView figure { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView Figure { get; set; }

        [Action ("BntUp_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BntUp_TouchUpInside (UIKit.UIButton sender);

        [Action ("BtnDown_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnDown_TouchUpInside (UIKit.UIButton sender);

        [Action ("BtnLeft_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnLeft_TouchUpInside (UIKit.UIButton sender);

        [Action ("BtnRight_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnRight_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (bntUp != null) {
                bntUp.Dispose ();
                bntUp = null;
            }

            if (btnDown != null) {
                btnDown.Dispose ();
                btnDown = null;
            }

            if (BtnDown != null) {
                BtnDown.Dispose ();
                BtnDown = null;
            }

            if (btnLeft != null) {
                btnLeft.Dispose ();
                btnLeft = null;
            }

            if (BtnLeft != null) {
                BtnLeft.Dispose ();
                BtnLeft = null;
            }

            if (BtnLeftDown != null) {
                BtnLeftDown.Dispose ();
                BtnLeftDown = null;
            }

            if (BtnLeftUP != null) {
                BtnLeftUP.Dispose ();
                BtnLeftUP = null;
            }

            if (btnRight != null) {
                btnRight.Dispose ();
                btnRight = null;
            }

            if (BtnRight != null) {
                BtnRight.Dispose ();
                BtnRight = null;
            }

            if (BtnRightDown != null) {
                BtnRightDown.Dispose ();
                BtnRightDown = null;
            }

            if (BtnRightUp != null) {
                BtnRightUp.Dispose ();
                BtnRightUp = null;
            }

            if (BtnUp != null) {
                BtnUp.Dispose ();
                BtnUp = null;
            }

            if (figure != null) {
                figure.Dispose ();
                figure = null;
            }

            if (Figure != null) {
                Figure.Dispose ();
                Figure = null;
            }
        }
    }
}