using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V4.App;
//using Android.App;

namespace hellodroid
{
	class CollectionFragmentStatePagerAdapter: FragmentStatePagerAdapter
	{
		public CollectionFragmentStatePagerAdapter(Android.Support.V4.App.FragmentManager fm):base(fm)
		{

		}
		public override Fragment GetItem(int i){
			Fragment f = new CounterFragment ();
			Bundle args = new Bundle ();
			args.PutInt (CounterFragment.COUNT_ARG_KEY, i + 1);
			f.Arguments = args;
			return f;
		}

		public override int Count{
			get{
				return 100;
			}
		}

		public string getPageTitle(int pos){
			return "count " + (pos + 1);
		}
	}
}

