
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

			var tvFirst = view.FindViewById<TextView>(Resource.Id.simpson_detail_first_name_tv);
			var tvLast = view.FindViewById<TextView>(Resource.Id.simpson_detail_last_name_tv);
			var tvAge = view.FindViewById<TextView>(Resource.Id.simpson_detail_age_tv);
			var tvGender = view.FindViewById<TextView>(Resource.Id.simpson_detail_gender_tv);
			var tvDescription = view.FindViewById<TextView>(Resource.Id.simpson_detail_description_tv);

			tvFirst.Text = character.FirstName;
			tvLast.Text = character.LastName;
			tvAge.Text = character.Age.ToString();
			tvDescription.Text = character.Description;
			int genderResource = 0;
			switch (character.Gender)
			{
				case Gender.Female:
					genderResource = Resource.String.simpson_detail_gender_male;
					break;
				case Gender.Male:
					genderResource = Resource.String.simpson_detail_gender_female;
					break;
				case Gender.Unknown:
					genderResource = Resource.String.simpson_detail_gender_unknown;
					break;
			}
			tvGender.Text = Resources.GetString(genderResource);

			return view;
		}
	}
}
