using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using System.Timers;

namespace App1
{
    [Activity(Label = "App1")]
    public class Game_Over : Activity
    {
        Timer time;
        static Game_Over ga;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            this.ActionBar.Hide();
            ga = this;

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.game_over);

            time = new Timer(5000);
            time.Elapsed += new ElapsedEventHandler(ouvre_menu);
            time.Enabled = true;
        }
        static void ouvre_menu(object sender, ElapsedEventArgs e)
        {
            var intent = new Intent(ga, typeof(MenuActivity));
            Application.Context.StartActivity(intent);
            ga.time.Enabled = false;

        }

    }

}
