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
}