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

namespace hellodroid
{
	public class GenericFragment : Fragment
	{
		private int _fragmentResourceId;
		public GenericFragment(int resourceid):base()
		{

			_fragmentResourceId = resourceid;
		}
//		public override void OnCreate (Bundle savedInstanceState)
//		{
//			base.OnCreate (savedInstanceState);
//
//			// Create your fragment here
//		}

		public override View OnCreateView(LayoutInflater inflater,ViewGroup container,Bundle state){
			//if(container==null){return null;}
			View v = inflater.Inflate (_fragmentResourceId, container, false);
			return v;
		}
	}
}

