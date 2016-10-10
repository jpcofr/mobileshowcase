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
			return LoadWebContent ();
		}

		public string RequestIFrame ()
		{
			return;
		}

		private static void LoadWebContent (string fileName)
		{
			try {   // Open the text file using a stream reader.
				using (StreamReader sr = new StreamReader (fileName)) {
					// Read the stream to a string, and write the string to the console.
					String line = sr.ReadToEnd ();
					Console.WriteLine (line);
				}
			} catch (Exception e) {
				Console.WriteLine ("The file could not be read:");
				Console.WriteLine (e.Message);
			}
		}
	}
}
