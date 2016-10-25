using System;
using System.IO;
using System.Linq;

namespace InterAppComm
{
	public class BehaviorSandBox
	{
		public BehaviorSandBox ()
		{

		}

		public const string IOS_OpenApp = "html/OpenApp.html";
		public const string IOS_OpenStore = "html/OpenStore.html";
		public const string Droid_OpenApp = "./OpenApp.html";
		public const string Droid_OpenStore = "./OpenStore.html";

		public static String LoadWebContent (string fileName)
		{
			string htmlSrc = string.Empty;

			try {
				using (StreamReader sr = new StreamReader (fileName)) {
					String line = sr.ReadToEnd ();
					htmlSrc = line;
				}
			} catch (Exception e) {
				Console.WriteLine ("The file could not be read:");
				Console.WriteLine (e.Message);
			}
			Console.Write (htmlSrc);
			return htmlSrc;
		}
	}
}
