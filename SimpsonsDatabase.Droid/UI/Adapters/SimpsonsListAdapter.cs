using System;
using System.Collections.Generic;
using Android.Content;
using Android.Views;
using Android.Widget;
using Java.Lang;
using SimpsonsDatabase.Models;

namespace SimpsonsDatabase.Droid.UI.Adapters
{
	public class SimpsonsListAdapter : BaseAdapter
	{
		private IList<CharacterModel> list;
		private Context context;

		public SimpsonsListAdapter(Context context, IList<CharacterModel> list)
		{
			this.context = context;
			this.list = list;
		}

		public CharacterModel this[int position]
		{
			get 
			{
				return list[position];	
			}
		}

		public override int Count
		{
			get
			{
				return list.Count;
			}
		}

		public override Java.Lang.Object GetItem(int position)
		{
			return null;
		}

		public override long GetItemId(int position)
		{
			return position;
		}

		public override View GetView(int position, View convertView, ViewGroup parent)
		{
			var inflater = (LayoutInflater) context.GetSystemService(Context.LayoutInflaterService);
			var view = inflater.Inflate(Resource.Layout.item_simpsons_list, parent, false);

			var textView = view.FindViewById<TextView>(Resource.Id.item_simpsons_list_name);

			textView.Text = list[position].FullName;

			return view;
		}
	}
}
