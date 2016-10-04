using System;
using Foundation;
using UIKit;

namespace InterAppComm.iOS
{
	public partial class IFrameLoaderViewController : UIViewController
	{
		int count = 1;
		private BehaviorSandBox obj = new BehaviorSandBox ();

		public IFrameLoaderViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Perform any additional setup after loading the view, typically from a nib.
			Button.AccessibilityIdentifier = "myButton";
			Button.TouchUpInside += delegate {
				var title = string.Format ("{0} clicks!" + " Halla " + obj.WriteHallo (), count++);
				Button.SetTitle (title, UIControlState.Normal);
			};

			webView = new UIWebView (View.Bounds);
			View.AddSubview (webView);
			var url = "https://xamarin.com"; // NOTE: https required for iOS 9 ATS
			webView.LoadHtmlString (obj.RequestIFrame (), null);
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.		
		}
	}
}
