using System;
using System.IO;

namespace InterAppComm
{
	public class BehaviorSandBox
	{
		public BehaviorSandBox ()
		{

		}

		public const string IOS_OpenApp = "./mobileshowcase/InterAppComm/InterAppComm/html/OpenApp.html";
		public const string IOS_OpenStore = "./mobileshowcase/InterAppComm/InterAppComm/html/OpenStore.html";

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
			return htmlSrc;
		}
	}
}
