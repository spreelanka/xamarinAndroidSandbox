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
		public PagedScrollView (Context context) :
			base (context)
		{
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
		}
//		public override bool OnTouchEvent (MotionEvent e)
//		{
//			return base.OnTouchEvent (e);
//		}
//
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
//				//int scrollX = getScrollX ();
//				int featureWidth = v.getMeasuredWidth ();
//				mActiveFeature = ((scrollX + (featureWidth / 2)) / featureWidth);
//				int scrollTo = mActiveFeature * featureWidth;
//				smoothScrollTo (scrollTo, 0);
				return true;
			} else {
				return false;
			}

		}
		//gesturelistener interface
		public bool OnDown(MotionEvent e)
		{
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

