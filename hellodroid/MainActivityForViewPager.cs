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
using Android.Support.V4.App;
using Android.Support.V4.View;


namespace hellodroid
{
	[Activity (Label = "MainActivityForViewPager",  MainLauncher = true)]			
	public class MainActivityForViewPager : FragmentActivity
	{
		ViewPager viewPager;
		CollectionFragmentStatePagerAdapter pagerAdapter;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.mainLayoutForViewPager);

			pagerAdapter = new CollectionFragmentStatePagerAdapter (SupportFragmentManager);
			viewPager = FindViewById<ViewPager> (Resource.Id.pager);
			viewPager.Adapter = pagerAdapter;
			//viewPager.
		}
	}
}

