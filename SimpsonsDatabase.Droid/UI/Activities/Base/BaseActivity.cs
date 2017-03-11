
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
using Android.Support.V7.App;
using SimpsonsDatabase.Data;

namespace SimpsonsDatabase.Droid.UI.Activities.Base
{
	
	public abstract class BaseActivity : AppCompatActivity
	{
		private ISimpsonsRepository _repository;
		public ISimpsonsRepository Repository
		{
			get
			{
				if (_repository == null) _repository = new MockSimpsonsRepository();
				return _repository;
			}
		}
	}
}
