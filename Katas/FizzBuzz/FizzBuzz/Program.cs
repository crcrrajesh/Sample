using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzGenerator fizzBuzzGenerator = new FizzBuzzGenerator(RulesProvider.GetRules());
            Console.WriteLine(string.Join(Environment.NewLine, fizzBuzzGenerator.Generate(12, 125)));
            Console.Read();
        }
    }
}
