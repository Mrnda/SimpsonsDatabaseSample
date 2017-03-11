
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
using SimpsonsDatabase.Droid.UI.Activities.Base;

namespace SimpsonsDatabase.Droid
{
	public abstract class BaseFragment : Fragment
	{
		public new BaseActivity Activity
		{
			get
			{
				return base.Activity as BaseActivity;
			}
		}
	}
}
