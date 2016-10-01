using System;
using System.Security.Cryptography.X509Certificates;
namespace InterAppComm
{
	public class MyClass
	{
		public MyClass ()
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
	}
}
