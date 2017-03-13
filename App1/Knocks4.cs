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
using Android.Content;
using System.Timers;
using Android.Media;

namespace App1
{

    [Activity(Label = "Knocks4")]
    
    public class Knocks4 : Activity
    {
        Timer time;
        static Knocks4 ka;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            ka = this;
            // Create your application here
            SetContentView(Resource.Layout.Knocks);
            time = new Timer(3000);
            time.Elapsed += new ElapsedEventHandler(ouvre_menu);
            time.Enabled = true;

        }
        static void ouvre_menu(object sender, ElapsedEventArgs e)
        {
            var intent = new Intent(ka, typeof(T1Main_2));
            Application.Context.StartActivity(intent);
            ka.time.Enabled = false;

        }
    }
    }
