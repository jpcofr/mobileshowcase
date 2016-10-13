using Android.App;
using Android.Widget;
using Android.OS;
using Android.Webkit;

namespace InterAppComm.Droid
{
	[Activity (Label = "InterAppComm", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		private BehaviorSandBox obj = new BehaviorSandBox ();

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			WebView webView = FindViewById<WebView> (Resource.Id.webView);

			button.Click += delegate {
				webView.LoadData (obj.RequestGenericIFrame (), "text/html", null);
			};
		}
	}
}

/*
using System;
using UIKit;

namespace InterAppComm.iOS
{
	public partial class IFrameLoaderViewController : UIViewController
	{

		private BehaviorSandBox obj = new BehaviorSandBox ();

		public IFrameLoaderViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			Button.TouchUpInside += delegate {
				WebView.LoadHtmlString (obj.RequestGenericIFrame (), null);
			};

			View.AddSubview (WebView);
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
		}


	}
}*/