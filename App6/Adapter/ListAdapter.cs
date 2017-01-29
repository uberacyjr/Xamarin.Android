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

namespace App6.Adapter
{
    public class ListAdapter : BaseAdapter<Person>
    {
        List<Person> items;
        Activity context;
        public ListAdapter(Activity context, List<Person> items) : base()
        {
            this.context = context;
            this.items = items;
        }
        public override Person this[int position]
        {
            get
            {
                return items[position];
            }
        }

        public override int Count
        {
            get
            {
                return items.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = items[position];
            if(convertView == null)
            {
                convertView = context.LayoutInflater.Inflate(Resource.Layout.CustomList, null);
            }
            convertView.FindViewById<TextView>(Resource.Id.Name).Text = item.Name;
            convertView.FindViewById<TextView>(Resource.Id.NameUm).Text = item.Name;
            convertView.FindViewById<TextView>(Resource.Id.NameDois).Text ="Descrição";
            return convertView;
        }
    }
}