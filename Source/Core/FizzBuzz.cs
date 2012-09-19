using System.Collections.Generic;

namespace Main
{
	public class FizzBuzz : IFizzBuzz
	{
		public string For(int i)
		{
			var output = "";
			if (i % 3 == 0) output = "fizz";
			if (i % 5 == 0) output += "buzz";
			return output;
		}
		public IEnumerable<string> UpTo(int lastInt)
		{
			var vals = new string[lastInt];
			for (var i = 0; i < lastInt; i++)
			{
				vals[i] = this.For(i + 1);
			}
			return vals;
		}
	}
}