using System;
using System.Security.Cryptography.X509Certificates;
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

		public string RequestIFrame ()
		{
			return "<!DOCTYPE html>\n<html>\n   <body>\n      <h1>iframe provider</h1>\n      <p>This is a basic iframe html container.</p>\n      <iframe src=\"http://eliq.se\">\n      </iframe>\n   </body>\n</html>\n";
		}

	}
}
