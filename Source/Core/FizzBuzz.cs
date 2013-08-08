using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Main;

namespace Main
{
	public class FizzBuzz : IFizzBuzz
	{
		public string For(int number)
		{
			if (number > 0 && number % 3 == 0) return "Fizz";
			if (number == 3) return "Fizz";
			else if (number == 5) return "Buzz";
			return number.ToString();
		}

		public IEnumerable<string> UpTo(int number)
		{
			throw new NotImplementedException();
		}
	}
}
