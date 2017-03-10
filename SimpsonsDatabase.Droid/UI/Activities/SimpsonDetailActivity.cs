
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
using SimpsonsDatabase.Models;

namespace SimpsonsDatabase.Droid
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

		CharacterModel simpson;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			if (Intent.HasExtra(ExtraGuid))
			{
				var guidString = Intent.GetStringExtra(ExtraGuid);
				var guid = new Guid(guidString);

				ISimpsonsRepository repository = new MockSimpsonsRepository();

				simpson = repository.GetSimpsonById(guid);

				Title = simpson.FullName;
			}

		}
	}
}
