
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using SimpsonsDatabase.Data;
using SimpsonsDatabase.Droid.UI.Acitivities;
using SimpsonsDatabase.Droid.UI.Adapters;
using SimpsonsDatabase.Droid.UI.Fragments.Base;

namespace SimpsonsDatabase.Droid.UI.Fragments
{
	public class SimpsonsListFragment : BaseFragment
	{

		public static SimpsonsListFragment NewInstance()
		{
			return new SimpsonsListFragment();
		}

		ListView listView;

		SimpsonsListAdapter adapter;



		void SimpsonSelected(object sender, AdapterView.ItemClickEventArgs e)
		{
			var guid = adapter[e.Position].Id;

			var intent = SimpsonDetailActivity.GetIntent(Activity, guid);
			StartActivity(intent);
		}

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			var view = inflater.Inflate(Resource.Layout.fragment_simpsons_list, container, false);

			listView = view.FindViewById<ListView>(Resource.Id.simpsons_list_lv);
			listView.ItemClick += SimpsonSelected;
			var simpsons = Activity.Repository.GetAllSimpsons();

			adapter = new SimpsonsListAdapter(Activity, simpsons);
			listView.Adapter = adapter;

			return view;
		}
	}
}
