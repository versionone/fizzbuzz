using System;
using System.Linq;
using Bowling.Specs.Infrastructure;
using Main;

namespace specs_for_fizz_buzz
{
	public class when_calculating_fizz_buzz : concerns
	{
		private FizzBuzz _fizzBuzz;

		protected override void context()
		{
			_fizzBuzz = new FizzBuzz();
		}

		[Specification]
		public void the_number_3_outputs_fizz()
		{
			_fizzBuzz.For(3).should_equal("fizz");
		}

		[Specification]
		public void the_number_5_outputs_buzz()
		{
			_fizzBuzz.For(5).should_equal("buzz");
		}

		[Specification]
		public void the_number_15_outputs_fizzbuzz()
		{
			_fizzBuzz.For(15).should_equal("fizzbuzz");
		}

		[Specification]
		public void UpTo_20_outputs_20_values()
		{
			_fizzBuzz.UpTo(20).Count().should_equal(20);
		}

		[Specification]
		public void UpTo_20_outputs_the_right_stuff()
		{
			var values = _fizzBuzz.UpTo(15);
			var the_right_values = new string[]
			                       	{
										"","","fizz","","buzz","fizz","","","fizz","buzz","","fizz",
										"","","fizzbuzz"
			                       	};
			values.should_equal(the_right_values);
		}
	}
}