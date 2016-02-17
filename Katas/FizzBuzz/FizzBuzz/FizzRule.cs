namespace FizzBuzz
{
    internal class FizzRule:IRule
    {
        public string Process(int number)
        {
            if (number % 3 == 0)
            {
                return "Fizz";
            }
            return string.Empty;
        }
    }
}