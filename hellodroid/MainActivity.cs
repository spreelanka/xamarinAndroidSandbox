using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace hellodroid
{
	[Activity (Label = "hellodroid", MainLauncher = true)]
	public class MainActivity : Activity//, View.IOnTouchListener
	{
		int count = 0;
		string firstFragmentTag = "first_fragment";
		string secondFragmentTag= "second_fragment";

		private GestureDetector _gestureDetector;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);


			// Set our view from the "main" layout resource
			//SetContentView (Resource.Layout.Main);
			//PagedScrollView psv = new PagedScrollView ();

//			SetContentView (new PagedScrollView()); 

			SetContentView (Resource.Layout.Main);
//
//			// Get our button from the layout resource,
//			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.switchFragmentButton);

			button.Click += delegate {
				FragmentManager fm=FragmentManager;
				FragmentTransaction ft =fm.BeginTransaction();
				if(count%3==0){
					if(count==0){
						ft.Add(Resource.Id.mainContentGroup,new FirstFragment(),firstFragmentTag);
					}else{
						Fragment frag_to_remove=fm.FindFragmentByTag(secondFragmentTag);
						if(frag_to_remove!=null)
							ft.Detach(frag_to_remove);
						ft.Attach(fm.FindFragmentByTag(firstFragmentTag));
					}
				}else if(count%3==1){
					if(count==1){
						ft.Detach(fm.FindFragmentByTag(firstFragmentTag));
						ft.Add(Resource.Id.mainContentGroup,new SecondFragment(),secondFragmentTag);
					}else{
						ft.Detach(fm.FindFragmentByTag(firstFragmentTag));
						ft.Attach(fm.FindFragmentByTag(secondFragmentTag));
					}
				}else if(count%3==2){
					ft.Detach(fm.FindFragmentByTag(secondFragmentTag));
				}
				count++;
				ft.Commit();
//				button.Text = string.Format ("{0} clicks!", count++);
			};
//			Context c =Context.GetObject ();
//			PagedScrollView psv = new PagedScrollView (c.ApplicationContext);

		}


	}
}


