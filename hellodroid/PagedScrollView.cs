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
	public class PagedScrollView : ScrollView//, View.IOnTouchListener
	{

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
		}
//		public override bool OnTouchEvent (MotionEvent e)
//		{
//			return base.OnTouchEvent (e);
//		}
//
//		public bool OnTouch(View v,MotionEvent e){
//			if (_gestureDetector.OnTouchEvent (e)) {
//				Console.WriteLine ("touched");
//				return true;
//			} else if (e.Action == MotionEventActions.Up || e.Action == MotionEventActions.Cancel) {
////				//int scrollX = getScrollX ();
////				int featureWidth = v.getMeasuredWidth ();
////				mActiveFeature = ((scrollX + (featureWidth / 2)) / featureWidth);
////				int scrollTo = mActiveFeature * featureWidth;
////				smoothScrollTo (scrollTo, 0);
//				return true;
//			} else {
//				return false;
//			}
//
//		}



	}
}

