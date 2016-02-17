namespace FizzBuzz
{
    internal class BuzzRule : IRule
    {
        public string Process(int number)
        {
            if (number % 5 == 0)
            {
                return "Buzz";
            }
            return string.Empty;
        }
    }
}