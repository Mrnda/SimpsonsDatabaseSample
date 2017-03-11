
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
using SimpsonsDatabase.Data;
using SimpsonsDatabase.Droid.UI.Activities.Base;
using SimpsonsDatabase.Droid.UI.Fragments;
using SimpsonsDatabase.Models;

namespace SimpsonsDatabase.Droid.UI.Activities
{
	[Activity(Label = "", ParentActivity = typeof(MainAcitivity), Theme = "@style/AppTheme")]
	public class SimpsonDetailActivity : BaseActivity
	{
		private const string ExtraGuid = "guid";

		public static Intent GetIntent(Context context, Guid id)
		{
			Intent intent = new Intent(context, typeof(SimpsonDetailActivity));
			intent.PutExtra(ExtraGuid, id.ToString());
			return intent;
		}


		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			Guid guid = Guid.Empty;

			if (Intent.HasExtra(ExtraGuid))
			{
				guid = new Guid(Intent.GetStringExtra(ExtraGuid));
			}
			else
			{
				throw new ArgumentException("Simpson detail requires ID of the simpson to show.");
			}

			SetContentView(Resource.Layout.activity_simpson_detail);

			FragmentManager.BeginTransaction()
						   .Add(Resource.Id.container_simpson_detail, SimpsonDetailFragment.NewInstance(guid))
						   .Commit();
		}
	}
}
