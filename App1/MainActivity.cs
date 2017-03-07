using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using System.Timers;

namespace App1
{
    [Activity(Label = "App1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Timer time;
        static MainActivity ma;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            this.ActionBar.Hide();
            ma = this;

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Launch);
           
            time = new Timer(5000);
            time.Elapsed += new ElapsedEventHandler(ouvre_menu);
            time.Enabled = true;
        }
        static void ouvre_menu(object sender, ElapsedEventArgs e)
        {
            var intent = new Intent(ma, typeof(MenuActivity));
            Application.Context.StartActivity(intent);
            ma.time.Enabled = false;
            
        }
       
    }
     
}

