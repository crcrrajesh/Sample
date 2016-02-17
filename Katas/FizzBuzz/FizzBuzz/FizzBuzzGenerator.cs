using System.Collections.Generic;

namespace FizzBuzz
{
    internal class FizzBuzzGenerator
    {
        private readonly List<IRule> _rules;

        public FizzBuzzGenerator(List<IRule> rules)
        {
            _rules = rules;
        }

        public string[] Generate(int minIndex, int maxIndex)
        {
            var result = new List<string>();
            for (var index = minIndex; index <= maxIndex; index++)
            {
                result.Add(GetNumberType(index));
            }
            return result.ToArray();
        }

        public string GetNumberType(int number)
        {
            var result = string.Empty;
            foreach (var rule in _rules)
            {
                result += rule.Process(number);
            }
            if (string.IsNullOrEmpty(result))
            {
                return number.ToString();
            }
            return result;
        }
    }
}