using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    /// <summary>
    /// Given a list of strings words representing an English Dictionary, find the longest word in words that can be built one character at a time by other words in words. If there is more than one possible answer, return the longest word with the smallest lexicographical order.
    //  If there is no answer, return the empty string.
    //  Example 1:
    //  Input: 
    //  words = ["w","wo","wor","worl", "world"]
    //    Output: "world"
    //  Explanation: 
    //  The word "world" can be built one character at a time by "w", "wo", "wor", and "worl".
    //  Example 2:
    //  Input: 
    //  words = ["a", "banana", "app", "appl", "ap", "apply", "apple"]
    //  Output: "apple"
    //  Explanation: 
    //  Both "apply" and "apple" can be built from other words in the dictionary.However, "apple" is lexicographically smaller than "apply".
    //  Note:
    //  All the strings in the input will only contain lowercase letters.
    //  The length of words will be in the range [1, 1000].
    //  The length of words[i] will be in the range [1, 30].
    /// </summary>
    class LongestWordInDictionary
    {
        public static string LongestWord(string[] words)
        {
            // Sort the words
            // Start adding the words in List and check if curr word is present in list, if yes update the result word based on length

            List<string> list = new List<string>();
            Array.Sort(words);

            string resultWord = string.Empty;

            foreach(string word in words)
            {
                // word.Length == 1 - check for 1 length word, if there then add in list 
                // word.Substring(0, word.Length - 1) - check for length - 1 word in list like if word is Apple then check if Appl is in the list
                if (list.Contains(word.Substring(0, word.Length - 1)) || word.Length == 1)
                {
                    resultWord = word.Length > resultWord.Length ? word : resultWord;
                    list.Add(word);
                }
            }

            return resultWord;
        }

        //public static string LongestWord(string[] words)
        //{

        //}
    }
}
