using System.Collections.Generic;

namespace Main
{
	public interface IFizzBuzz
	{
		string For(int number);
		IEnumerable<string> UpTo(int number);
	}
}