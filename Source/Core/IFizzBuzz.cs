using System.Collections.Generic;

namespace Main
{
	public interface IFizzBuzz
	{
		string For(int number);
		IEnumerable<string> UpTo(int number);
	}

    /// <summary>
    /// Could this be a static class?
    /// </summary>
    public class FizzBuzz : IFizzBuzz
    {
        public FizzBuzz()
        {
            
        }

        private string _fbValue;
        
        public string For(int number)
        {
            _fbValue = number != 0 ? number.ToString() : "";
            
            if ((number/3) == 1) return "Fizz";

            return _fbValue;
        }

        public IEnumerable<string> UpTo(int number)
        {
            throw new System.NotImplementedException();
        }
    }
}