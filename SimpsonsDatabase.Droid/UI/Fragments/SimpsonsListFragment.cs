
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

namespace SimpsonsDatabase.Droid
{
	public class SimpsonsListFragment : BaseFragment
	{

		public static SimpsonsListFragment NewInstance()
		{
			return new SimpsonsListFragment();
		}

		ListView listView;

		SimpsonsListAdapter adapter;

		public override void OnStart()
		{
			base.OnStart();
			ISimpsonsRepository repository = new MockSimpsonsRepository();
			var simpsons = repository.GetAllSimpsons();

			adapter = new SimpsonsListAdapter(Activity, simpsons);
			listView.Adapter = adapter;
		}

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			var view = inflater.Inflate(Resource.Layout.fragment_simpsons_list, container, false);

			listView = view.FindViewById<ListView>(Resource.Id.simpsons_list_lv);

			return view;
		}
	}
}
