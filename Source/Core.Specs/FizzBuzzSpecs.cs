using System;
using Bowling.Specs.Infrastructure;
using Main;

namespace specs_for_fizz_buzz
{
    internal class when_fizzing_a_zero : concerns
    {
        private string _result;

        protected override void context()
        {
            IFizzBuzz fizzer =new FizzBuzz();
            _result = fizzer.For(0);
        }

        [Specification]
        private void it_should_return_empty()
        {
            _result.should_equal("");
        }
    }

    internal class when_fizzing_a_three : concerns
    {
        private string _result;

        protected override void context()
        {
            IFizzBuzz fizzer = new FizzBuzz();
            _result = fizzer.For(3);
        }

        [Specification]
        private void it_should_return_Fizz()
        {
            _result.should_equal("Fizz");
        }
    }

    internal class when_fizzing_a_5: concerns
    {
        private string _result;

        protected override void context()
        {
            IFizzBuzz fizzer = new FizzBuzz();
            _result = fizzer.For(5);
        }

        [Specification]
        private void it_should_return_Buzz()
        {
            _result.should_equal("Buzz");
        }
    }
}