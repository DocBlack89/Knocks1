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
    [Activity(Label = "Choix5")]
    public class Choix5 : Activity
    {
        MediaPlayer _player;
        MediaPlayer _player1;
        MediaPlayer _player2;
        MediaPlayer _player3;

        Button playbutton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Choix2);
            // Create your application here

            _player = MediaPlayer.Create(this, Resource.Raw.Click);
            _player1 = MediaPlayer.Create(this, Resource.Raw.Sons_ambiance);
            _player2 = MediaPlayer.Create(this, Resource.Raw.Porte);
            playbutton = FindViewById<Button>(Resource.Id.button1);
            playbutton.Click += PlayButton_Click;
            Button playbutton1 = FindViewById<Button>(Resource.Id.button2);
            playbutton1.Click += PlayButton2_Click;
            Button playbutton2 = FindViewById<Button>(Resource.Id.button3);
            playbutton2.Click += PlayButton3_Click;
            _player1.Start();
        }
         private void PlayButton_Click(object sender, System.EventArgs e)
         {
            _player.Start();
            _player1.Stop();
            _player2.Start();
            var intent = new Intent(this, typeof(T1Main_1));
            StartActivity(intent);
                }
        private void PlayButton2_Click(object sender, System.EventArgs e)
        {
            _player.Start();
            var intent = new Intent(this, typeof(Knocks4));
            StartActivity(intent);
            }
        private void PlayButton3_Click(object sender, System.EventArgs e)
             {
            _player3 = MediaPlayer.Create(this, Resource.Raw.feuille);
            _player1.Stop();
            _player.Start();
            _player3.Start();
            var intent = new Intent(this, typeof(Knocks4));
            StartActivity(intent);
            }
        }
    }
