using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace hellodroid
{
	public class FirstFragment:Fragment
	{
//		public FirstFragment ()
//		{
//			var f = new DetailsFragment{ Arguments = new Bundle () };
//
//			//f.Arguments.PutInt ("tag", 1234);
//			return f;
//		}

		public override View OnCreateView(LayoutInflater inflater,ViewGroup container,Bundle state){
			//if(container==null){return null;}
			View v = inflater.Inflate (Resource.Layout.first_fragment, container, false);
			return v;

		}
	}
}

