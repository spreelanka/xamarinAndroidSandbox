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
	public class PagedScrollView : ScrollView, View.IOnTouchListener,GestureDetector.IOnGestureListener
	{
		private GestureDetector _gestureDetector;
		private int startGestureY;
		private List<string> fragment_tags=new List<string>(); 
		private Context _context;
		public PagedScrollView (Context context) :
			base (context)
		{
			_context = context;
			Initialize ();
		}

		public PagedScrollView (Context context, IAttributeSet attrs) :
			base (context, attrs)
		{
			Initialize ();
		}

		public PagedScrollView (Context context, IAttributeSet attrs, int defStyle) :
			base (context, attrs, defStyle)
		{
			Initialize ();
		}

		void Initialize ()
		{
			Console.WriteLine ("something");
			this.SetOnTouchListener (this);
			_gestureDetector = new GestureDetector (this);

			FragmentManager fm=((Activity)Context).FragmentManager;
			FragmentTransaction ft =fm.BeginTransaction();
			ft.Add (Resource.Id.infiniteScrollContainer,new GenericFragment (Resource.Layout.blueFragment), "blueFragment");
			ft.Add (Resource.Id.infiniteScrollContainer,new GenericFragment (Resource.Layout.greenFragment), "greenFragment");
			ft.Add (Resource.Id.infiniteScrollContainer,new GenericFragment (Resource.Layout.redFragment), "redFragment");
			ft.Commit ();
			fragment_tags.Add ("blueFragment");
			fragment_tags.Add ("greenFragment");
			fragment_tags.Add ("redFragment");
			//ScrollY = getFragmentHeight ();
		}


//		public override bool OnTouchEvent (MotionEvent e)
//		{
//			return base.OnTouchEvent (e);
//		}
//
		private int getFragmentHeight(){
			Android.Graphics.Rect rect=new Android.Graphics.Rect();
			GetLocalVisibleRect (rect);

			int featureHeight = rect.Height();
			return featureHeight;
		}



		//touchlistener interface
		public bool OnTouch(View v,MotionEvent e){
			if (_gestureDetector.OnTouchEvent (e)) {
				Console.WriteLine ("touched");

					Console.WriteLine ("hello");

					Toast t = new Toast(v.Context);

					t.SetText("hello");
					t.Show();

				return true;
			} else if (e.Action == MotionEventActions.Up || e.Action == MotionEventActions.Cancel) {


				int featureHeight = getFragmentHeight ();
				double mActiveFeature;
				if (startGestureY < ScrollY) {
							mActiveFeature = ((ScrollY + (featureHeight*.9)) / featureHeight);
				} else {
							mActiveFeature = ((ScrollY - (featureHeight *.1)) / featureHeight);

				}
				int scrollTo = ((int)mActiveFeature) * featureHeight;

				SmoothScrollTo(0,scrollTo);
				return true;
			} else {
				return false;
			}

		}
		//gesturelistener interface
		public bool OnDown(MotionEvent e)
		{
			startGestureY =ScrollY;
			return false;
		}
		public bool OnFling(MotionEvent e1, MotionEvent e2, float velocityX, float velocityY)
		{
			return false;
		}
		public void OnLongPress(MotionEvent e) {

		}

		public bool OnScroll(MotionEvent e1, MotionEvent e2, float distanceX, float distanceY)
		{
			return false;
		}
		public void OnShowPress(MotionEvent e) {

		}
		public bool OnSingleTapUp(MotionEvent e)
		{
			return false;
		}



	}
}

