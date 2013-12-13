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
using Android.Support.V4;

namespace hellodroid
{
	public class CounterFragment : Android.Support.V4.App.Fragment
	{
		public static readonly string COUNT_ARG_KEY="COUNT_ARG_KEY";
		public override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Create your fragment here
		}
		public override View OnCreateView(LayoutInflater inflater,ViewGroup container,Bundle state){

			View v = inflater.Inflate (Resource.Layout.counterFragment, container, false);

			((TextView)v.FindViewById (Resource.Id.countTextView))
				.SetText (Arguments.GetInt (COUNT_ARG_KEY).ToString (), TextView.BufferType.Normal);
			return v;
		}
	}
}

