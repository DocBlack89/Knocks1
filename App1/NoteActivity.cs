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
using System.Timers;



namespace App1
{
    [Activity(Label = "NoteActivity")]
    public class NoteActivity : Activity
    {
        Timer time;
        static NoteActivity na;
        MediaPlayer _player;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            this.ActionBar.Hide();
            na = this;
            _player = MediaPlayer.Create(this, Resource.Raw.feuille);
            // Create your application here
            SetContentView(Resource.Layout.Note);
            time = new Timer(5000);
            time.Elapsed += new ElapsedEventHandler(ouvre_menu);
            time.Enabled = true;
            Button button = FindViewById<Button>(Resource.Id.button1);
            /*button.Click += delegate
            {
                var intent = new Intent(this, typeof(Main1));
                StartActivity(intent);
                _player.Stop();
            };*/
        }
        static void ouvre_menu(object sender, ElapsedEventArgs e)
        {
            var intent = new Intent(na, typeof(Main1));
            Application.Context.StartActivity(intent);
            na.time.Enabled = false;

        }
    }
}