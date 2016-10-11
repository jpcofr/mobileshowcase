using System;
using System.IO;

namespace InterAppComm
{
	public class BehaviorSandBox
	{
		public BehaviorSandBox ()
		{

		}

		public string WriteHallo ()
		{
			Random c = new Random ();
			var n = c.Next () % 3;
			if (n == 0) {
				return "Hey boy";
			} else if (n == 1) {
				return "Hey girl";
			} else {
				return "here we go!";
			}

		}

		public string RequestGenericIFrame ()
		{
			return LoadWebContent ("");
		}

		public string RequestIFrame ()
		{
			return LoadWebContent ("");
		}

		private static String LoadWebContent (string fileName)
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
