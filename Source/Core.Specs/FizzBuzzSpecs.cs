using System;
using System.Collections.Generic;
using Bowling.Specs.Infrastructure;
using Main;

namespace specs_for_fizz_buzz
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
			var count = 0;
			foreach (var item in _output)
			{
				count += 1;
			}
			count.should_be_greater_than(0);
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