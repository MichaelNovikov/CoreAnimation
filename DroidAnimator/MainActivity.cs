using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Animation;
using Android.Graphics;
using System;
using Android;
using Android.Views.Animations;

namespace DroidAnimator
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        AnimatorSet _animation;
        ObjectAnimator _rotationAnim;
        TextView textView;
        Button btnOne;
        Button btnTwo;
        Button btnThree;
        Button btnFour;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            textView = FindViewById<TextView>(Resource.Id.textV);
            btnOne = FindViewById<Button>(Resource.Id.btnOne);
            btnTwo = FindViewById<Button>(Resource.Id.btnTwo);
            btnThree = FindViewById<Button>(Resource.Id.btnThree);
            btnFour = FindViewById<Button>(Resource.Id.btnFour);

            btnOne.Click += BtnOne_Click;
            btnTwo.Click += BtnTwo_Click;
            btnThree.Click += BtnThree_Click;
            btnFour.Click += BtnFour_Click;
        }

        private void BtnOne_Click(object sender, EventArgs eventArgs)
        {
            _rotationAnim = ObjectAnimator.OfFloat(textView, "Rotation", 0, 360);
            _rotationAnim.SetDuration(1500).Start();
        }

        private void BtnTwo_Click(object sender, EventArgs eventArgs)
        {
            var animation = new TranslateAnimation(0, 100, 0, 100);
            animation.Duration = 1000;
            animation.FillAfter = false;
            animation.RepeatCount = 3;
            animation.RepeatMode = RepeatMode.Reverse;

            textView.StartAnimation(animation);
        }

        private void BtnThree_Click(object sender, EventArgs eventArgs)
        {
            ObjectAnimator ObjAnimation1 = ObjectAnimator.OfFloat(textView, "ScaleX", 2f);
            ObjAnimation1.SetDuration(1250);
            ObjAnimation1.RepeatCount = 3; /*ValueAnimator.Infinite;*/
            ObjAnimation1.RepeatMode = ValueAnimatorRepeatMode.Reverse;

            ObjectAnimator ObjAnimation2 = ObjectAnimator.OfFloat(textView, "scaleY", 2f);
            ObjAnimation2.SetDuration(1250);
            ObjAnimation2.RepeatCount = 3;  /*ValueAnimator.Infinite;*/
            ObjAnimation2.RepeatMode = ValueAnimatorRepeatMode.Reverse;

            _animation = new AnimatorSet();
            _animation.PlayTogether(ObjAnimation1, ObjAnimation2);
            _animation.Start();
        }

        private void BtnFour_Click(object sender, EventArgs eventArgs)
        {
            textView.ClearAnimation();
            _animation?.Cancel();
            _rotationAnim?.Cancel();
        }
    }
}