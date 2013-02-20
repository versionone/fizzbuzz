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

            if (number == 0)
            {
                return "";
            }
            else if ((number % 3) == 0)
            {
                return "Fizz";
            }
            else if ((number % 5) == 0)
            {
                return "Buzz";
            }
            else
            {
                return number.ToString();
            }
            

            //_fbValue = number == 0 ? "" : number.ToString();

            //_fbValue = (number % 3) == 0 && _fbValue == number.ToString() ? "Fizz" : number.ToString() ;

            //_fbValue = (number % 5) == 0 && _fbValue == number.ToString() ? "Buzz" : number.ToString() ;
            
            //if ((number/3) == 1) return "Fizz";

            //switch (number)
            //{
            //    case (3):
            //        return "Fizz";
            //        break;
            //    case (5):
            //        return "Buzz";
            //        break;
            //}

        }

        public IEnumerable<string> UpTo(int number)
        {
            throw new System.NotImplementedException();
        }
    }
}