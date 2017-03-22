using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Media;

namespace App1
{
    [Activity(Label = "T2Main1")]
    public class T2Main1: Activity
    {
        MediaPlayer _player;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            _player = MediaPlayer.Create(this, Resource.Raw.Sons_ambiance);
            // Create your application here
            SetContentView(Resource.Layout.T2Main1);
            Button button = FindViewById<Button>(Resource.Id.button1);
            button.Click += delegate
            {
                var intent = new Intent(this, typeof(T2Choix1));
                StartActivity(intent);
                _player.Stop();
            };
        }
    }
}