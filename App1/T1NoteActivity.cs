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
    [Activity(Label = "T1NoteActivity")]
    public class T1NoteActivity : Activity
    {
        Timer time;
        static T1NoteActivity na;
        MediaPlayer _player;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            this.ActionBar.Hide();
            na = this;
            _player = MediaPlayer.Create(this, Resource.Raw.feuille);
            // Create your application here
            SetContentView(Resource.Layout.Note);
            time = new Timer(2000);
            time.Elapsed += new ElapsedEventHandler(ouvre_menu);
            time.Enabled = true;
        }
        static void ouvre_menu(object sender, ElapsedEventArgs e)
        {
            var intent = new Intent(na, typeof(T1Note));
            Application.Context.StartActivity(intent);
            na.time.Enabled = false;

        }
    }
}