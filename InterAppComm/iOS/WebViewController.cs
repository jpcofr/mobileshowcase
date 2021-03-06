﻿using System;

using UIKit;

namespace InterAppComm.iOS
{
	public partial class WebViewController : UIViewController
	{
		int count = 1;

		public WebViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			var obj = new BehaviorSandBox ();
			// Perform any additional setup after loading the view, typically from a nib.
			Button.AccessibilityIdentifier = "myButton";
			Button.TouchUpInside += delegate {
				var title = string.Format ("{0} clicks!" + " Halla " + obj.WriteHallo (), count++);
				Button.SetTitle (title, UIControlState.Normal);
			};


		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.		
		}
	}
}
