﻿// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace FigureGame
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton BtnDown { get; set; }

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
        UIKit.UIButton BtnRight { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton BtnRightDown { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton BtnRightUP { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton BtnUp { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView figure { get; set; }

        [Action ("BtnDown_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnDown_TouchUpInside (UIKit.UIButton sender);

        [Action ("BtnLeft_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnLeft_TouchUpInside (UIKit.UIButton sender);

        [Action ("BtnLeftDown_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnLeftDown_TouchUpInside (UIKit.UIButton sender);

        [Action ("BtnLeftUP_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnLeftUP_TouchUpInside (UIKit.UIButton sender);

        [Action ("BtnRight_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnRight_TouchUpInside (UIKit.UIButton sender);

        [Action ("BtnRightDown_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnRightDown_TouchUpInside (UIKit.UIButton sender);

        [Action ("BtnRightUP_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnRightUP_TouchUpInside (UIKit.UIButton sender);

        [Action ("BtnUp_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnUp_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (BtnDown != null) {
                BtnDown.Dispose ();
                BtnDown = null;
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

            if (BtnRight != null) {
                BtnRight.Dispose ();
                BtnRight = null;
            }

            if (BtnRightDown != null) {
                BtnRightDown.Dispose ();
                BtnRightDown = null;
            }

            if (BtnRightUP != null) {
                BtnRightUP.Dispose ();
                BtnRightUP = null;
            }

            if (BtnUp != null) {
                BtnUp.Dispose ();
                BtnUp = null;
            }

            if (figure != null) {
                figure.Dispose ();
                figure = null;
            }
        }
    }
}