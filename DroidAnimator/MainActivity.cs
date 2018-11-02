using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Animation;
using System;
using Android;

namespace DroidAnimator
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
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

            ObjectAnimator.OfFloat(textView, "Alpha", 0, 1).Start();
  
        }

        private void BtnOne_Click(object sender, EventArgs eventArgs )
        {
            ObjectAnimator.OfFloat(textView, "Alpha", 0, 1).Start();
        }

        private void BtnTwo_Click(object sender, EventArgs eventArgs)
        {
            ObjectAnimator.OfFloat(textView, "Angle", 0, 180).Start();
        }

        private void BtnThree_Click(object sender, EventArgs eventArgs)
        {
            ObjectAnimator _ObjAnimation1 = ObjectAnimator.OfFloat(textView, "scaleX", .94f);
            _ObjAnimation1.SetDuration(1250);
            _ObjAnimation1.RepeatCount = 5; /*ValueAnimator.Infinite;*/
            _ObjAnimation1.RepeatMode = ValueAnimatorRepeatMode.Reverse;

            ObjectAnimator _ObjAnimation2 = ObjectAnimator.OfFloat(textView, "scaleY", .94f);
            _ObjAnimation2.SetDuration(1250);
            _ObjAnimation2.RepeatCount = 5;  /*ValueAnimator.Infinite;*/
            _ObjAnimation2.RepeatMode = ValueAnimatorRepeatMode.Reverse;

            AnimatorSet _Animation = new AnimatorSet();
            _Animation.PlayTogether(_ObjAnimation1, _ObjAnimation2);
            _Animation.Start();
        }

        private void BtnFour_Click(object sender, EventArgs eventArgs)
        {
            ObjectAnimator.OfFloat(textView, "Alpha", 0, 1).Start();
        }
    }
}