using Android.App;
using Android.Widget;
using Android.OS;
using static Android.Views.View;
using static Android.Locations.GpsStatus;
using Android.Content;

namespace App6
{
    [Activity(Label = "App6", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            Button btnSimple = (Button)FindViewById(Resource.Id.redirecionar);

            var intent = new Intent();
            intent.SetClass(this, typeof(details));
            Intent.PutExtra("IdTeste", 1);

            StartActivity(intent);
        }
        
    }
}

