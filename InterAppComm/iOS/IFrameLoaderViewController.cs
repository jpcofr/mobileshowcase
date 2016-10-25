using System;
using UIKit;
using System.Resources;

namespace InterAppComm.iOS
{
	public partial class IFrameLoaderViewController : UIViewController
	{
		public IFrameLoaderViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			Button.TouchUpInside += delegate {

				WebView.LoadHtmlString (BehaviorSandBox.LoadWebContent (BehaviorSandBox.IOS_OpenApp), null);
			};

			View.AddSubview (WebView);

		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
		}


	}
}
