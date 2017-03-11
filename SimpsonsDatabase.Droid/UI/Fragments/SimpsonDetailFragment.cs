
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
using SimpsonsDatabase.Models;

namespace SimpsonsDatabase.Droid
{
	public class SimpsonDetailFragment : BaseFragment
	{
		private const string ArgumentGuid = "Guid";

		public static SimpsonDetailFragment NewInstance(Guid id)
		{
			var instance = new SimpsonDetailFragment();
			instance.Arguments = new Bundle();
			instance.Arguments.PutString(ArgumentGuid, id.ToString());
			return instance;
		}

		private CharacterModel character;

		public override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			if (Arguments.ContainsKey(ArgumentGuid))
			{
				var guid = new Guid(Arguments.GetString(ArgumentGuid));
				character = Activity.Repository.GetSimpsonById(guid);
			}
			else
			{
				throw new ArgumentException("Detail requires Guid of character to show.");
			}

			Activity.Title = character.FirstName;
		}

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			var view = inflater.Inflate(Resource.Layout.fragment_simpson_detail, container, false);

			return view;
		}
	}
}
