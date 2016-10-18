using Android.App;
using Android.Widget;
using Android.OS;
using Android.Webkit;
using System.Reflection;
using System.IO;

namespace InterAppComm.Droid
{
	[Activity (Label = "InterAppComm", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			WebView webView = FindViewById<WebView> (Resource.Id.webView);

			////////////////////////////////////////////////////////////////////////////////////////////////////
			var assembly = Assembly.GetExecutingAssembly ();
			//The resources are called 
			// InterAppComm.Droid.Resources.html.OpenApp.html
			// InterAppComm.Droid.Resources.html.OpenStore.html
			Stream stream = assembly.GetManifestResourceStream ("InterAppComm.Droid.Resources.html.OpenApp.html");
			foreach (var resourceName in assembly.GetManifestResourceNames ()) {
				System.Console.WriteLine (resourceName);
			}
			string webPageSource = string.Empty;
			using (var reader = new System.IO.StreamReader (stream)) {
				webPageSource = reader.ReadToEnd ();
			}
			////////////////////////////////////////////////////////////////////////////////////////////////////

			button.Click += delegate {
				//webView.LoadData ("<!DOCTYPE html>\n<html>\n  <head>\n   <body>\n    this is random test to know if the webpage is being served \n   </body>\n</html>\n", "text/html", null);
				System.Console.WriteLine (webPageSource);
				webView.LoadData (webPageSource, "text/html", null);
				//foreach (var resourceName in assembly.GetManifestResourceNames ()) {
				//	System.Console.WriteLine (resourceName);
				//}
			};



		}
	}
}