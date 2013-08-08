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
			if (number > 0)
			{
				if (number%15 == 0) return "FizzBuzz";
				if (number%3 == 0) return "Fizz";
				if (number%5 == 0) return "Buzz";
			}
			return number.ToString();
		}

		public IEnumerable<string> UpTo(int number)
		{
			List<string> result = new List<string>();
			for (int i = 0; i <= number; i++)
			{
				result.Add(this.For(i));
			}

			return result;
		}
	}
}
