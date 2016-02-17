using System.Collections.Generic;

namespace FizzBuzz
{
    internal class RulesProvider
    {
        public static List<IRule> GetRules()
        {
            var rules = new List<IRule>();
            rules.Add(new FizzRule());
            rules.Add(new BuzzRule());
            return rules;
        }
    }
}