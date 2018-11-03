using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class FizzBuzz 
    {
        private static IDictionary<Rule, string> ruleContainers = new Dictionary<Rule, string>();
        private static List<Rule> rules = new List<Rule>();

        public static void addRule(Rule rule, string res)
        {
            rules.Add(rule);
            ruleContainers.Add(rule, res);
        }

        public static string getValue(int i)
        {
            foreach (Rule rule in rules)
            {
                if (rule.apply(i))
                {
                    return ruleContainers[rule];
                }
            }

            return Convert.ToString(i);
        }

        /// <summary>
        // Write a program that outputs the string representation of numbers from 1 to n.
        //  But for multiples of three it should output “Fizz” instead of the number and for the multiples of five output “Buzz”. For numbers which are multiples of both three and five output “FizzBuzz”.
        //  Example:
        //  n = 15,
        //  Return:
        //  [
        //    "1",
        //    "2",
        //    "Fizz",
        //    "4",
        //    "Buzz",
        //    "Fizz",
        //    "7",
        //    "8",
        //    "Fizz",
        //    "Buzz",
        //    "11",
        //    "Fizz",
        //    "13",
        //    "14",
        //    "FizzBuzz"
        //]
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static IList<string> ReturnFizzBuzzStrings(int n)
        {
            IList<string> result = new List<string>();

            //for (int i = 1; i <= n; i++)
            //{
            //    result.Add(getValue(i));
            //}

            //return null;

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    result.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    result.Add("Buzz");
                }
                else
                {
                    result.Add(Convert.ToString(i));
                }
            }
            return result;
        }
    }

    interface Rule
    {
        bool apply(int i);
    }
}
