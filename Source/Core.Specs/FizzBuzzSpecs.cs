using System;
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
	
}