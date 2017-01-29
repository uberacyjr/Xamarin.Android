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

namespace App6
{
    [Activity(Label = "details")]
    public class details : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //Vincula com o view xml
            SetContentView(Resource.Layout.detailsView);
            var idAgora = Intent.Extras.GetInt("Id", 0);

            //Alerta();
        }
        private void Alerta()
        {
            var dialog = new AlertDialog.Builder(this);
            dialog.SetTitle("BEM VINDO");
            dialog.SetMessage("Primeiro APP");
            dialog.Show();
        }
    }
}