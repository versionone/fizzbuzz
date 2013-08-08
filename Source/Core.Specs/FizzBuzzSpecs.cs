using System;
using System.Collections.Generic;
using System.Linq;
using Bowling.Specs.Infrastructure;
using Main;

namespace specs_for_fizz_buzz_individual_numbers
{
	public class when_fizzing_a_zero : concerns
	{
		private IFizzBuzz _fizzer;
		private string _output;

		protected override void context()
		{
			_fizzer = new FizzBuzz();
			_output = _fizzer.For(0);
		}

		[Specification]
		public void it_outputs_zero()
		{
			_output.should_equal("0");
		}

	}

	public class when_fizzing_a_three : concerns
	{
		private IFizzBuzz _fizzer;
		private string _output;

		protected override void context()
		{
			_fizzer = new FizzBuzz();
			_output = _fizzer.For(3);

		}

		[Specification]
		public void it_outputs_fizz()
		{
			_output.should_equal("Fizz");
		}
	}

	public class when_fizzing_a_five : concerns
	{
		private string _output;

		protected override void context()
		{

			var fizzer = new FizzBuzz();
			_output = fizzer.For(5);
		}

		[Specification]
		public void it_outputs_buzz()
		{
			_output.should_equal("Buzz");
		}
	}

	public class when_fizzing_a_nine : concerns
	{
		private string _output;

		protected override void context()
		{

			var fizzer = new FizzBuzz();
			_output = fizzer.For(9);
		}

		[Specification]
		public void it_outputs_buzz()
		{
			_output.should_equal("Fizz");
		}
	}

	public class when_fizzing_a_fifteen : concerns
	{
		private string _output;

		protected override void context()
		{

			var fizzer = new FizzBuzz();
			_output = fizzer.For(15);
		}

		[Specification]
		public void it_outputs_fizzbuzz()
		{
			_output.should_equal("FizzBuzz");
		}
	}
}

namespace specs_for_fizz_buzz_list_of_numbers
{
	public class when_calling_UpTo_with_zero : concerns
	{
		private IEnumerable<string> _output;

		protected override void context()
		{

			var fizzer = new FizzBuzz();
			_output = fizzer.UpTo(0);
		}

		[Specification]
		public void it_produces_one_item()
		{
			_output.Count().should_equal(1);
		}
	}

	public class when_calling_UpTo_20: concerns
	{
		private IEnumerable<string> _output;

		protected override void context()
		{
			var fizzer = new FizzBuzz();
			_output = fizzer.UpTo(20);
		}

		[Specification]
		public void it_fizzes_3s()
		{
			_output.ElementAt(3).should_equal("Fizz");
		}

		[Specification]
		public void it_buzzes_5s()
		{
			_output.ElementAt(5).should_equal("Buzz");

		}

		[Specification]
		public void it_fizz_buzzes_15()
		{
			_output.ElementAt(15).should_equal("FizzBuzz");
		}

		[Specification]
		public void it_echos_17()
		{
			_output.ElementAt(17).should_equal("17");

		}
	}
}