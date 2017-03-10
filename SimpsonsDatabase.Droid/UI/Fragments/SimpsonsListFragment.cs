
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
using Com.Lilarcor.Cheeseknife;

namespace SimpsonsDatabase.Droid
{
	public class SimpsonsListFragment : BaseFragment
	{


		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			var view = inflater.Inflate(Resource.Layout.fragment_simpsons_list, container, false);

			var lv = view.FindViewById<ListView>(Resource.Id.simpsons_list_lv);


			return view;
		}
	}
}
