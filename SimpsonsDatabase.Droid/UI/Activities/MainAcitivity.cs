
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
using SimpsonsDatabase.Droid.UI.Activities.Base;
using SimpsonsDatabase.Droid.UI.Fragments;

namespace SimpsonsDatabase.Droid.UI.Activities
{
	[Activity(Label = "Simpsons", MainLauncher = true, Theme = "@style/AppTheme")]
	public class MainAcitivity : BaseActivity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.activity_main);

			FragmentManager.BeginTransaction()
						   .Add(Resource.Id.container_main, SimpsonsListFragment.NewInstance())
						   .Commit();
		}
	}
}
