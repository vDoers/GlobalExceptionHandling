using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace GlobalExceptionsHandling.Droid
{
	[Activity (Label = "Fatal Ex", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 0;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            //Divided / 0
            //Forcefully rasing exception 
            int valOne = 7, result = 0;
            result = valOne / count;
        }
	}
}


