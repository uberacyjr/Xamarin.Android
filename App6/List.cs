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
using App6.Adapter;

namespace App6
{
    [Activity(Label = "List")]
    public class List : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            var items =  new string[] {"Bera","Biu" };
            var pessoas = new List<Person>() { new Person { Name="bera"}
            , new Person { Name="CArol"}
            , new Person { Name="CArol"}
            , new Person { Name="CArol"}
            , new Person { Name="CArol"}
            , new Person { Name="CArol"}
            , new Person { Name="CArol"}
            , new Person { Name="CArol"}
            , new Person { Name="CArol"}
            , new Person { Name="CArol"}
            , new Person { Name="CArol"}
            , new Person { Name="CArol"}
            , new Person { Name="CArol"}
            , new Person { Name="CArol"}
            , new Person { Name="CArol"}

            , new Person { Name="CArol"}
            , new Person { Name="CArol"}
            , new Person { Name="CArol"}
            , new Person { Name="CArol"}
            , new Person { Name="CArol"}
            , new Person { Name="CArol"}
            , new Person { Name="CArol"}
            , new Person { Name="CArol"}
            , new Person { Name="CArol"}
            , new Person { Name="CArol"}
            , new Person { Name="CArol"}
            , new Person { Name="CArol"}
            , new Person { Name="CArol"}
            , new Person { Name="CArol"}
            , new Person { Name="CArol"}
            , new Person { Name="CArol"}
            , new Person { Name="CArol"}
            , new Person { Name="CArol"}
            , new Person { Name="CArol"}
            };
            // Create your application here
            SetContentView(Resource.Layout.list_layout);
            ListView itens = FindViewById<ListView>(Resource.Id.listView_teste);
            itens.Adapter = new ListAdapter(this, pessoas);
            itens.FastScrollEnabled = true;
        }
    }
}