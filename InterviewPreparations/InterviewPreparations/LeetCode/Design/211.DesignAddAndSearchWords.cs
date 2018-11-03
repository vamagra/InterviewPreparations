using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    //  <summary>
    //  Design a data structure that supports the following two operations:
    //  void addWord(word)
    //  bool search(word)
    //  search(word) can search a literal word or a regular expression string containing only letters a-z or..A.means it can represent any one letter.
    //  Example:
    //  addWord("bad")
    //  addWord("dad")
    //  addWord("mad")
    //  search("pad") -> false
    //  search("bad") -> true
    //  search(".ad") -> true
    //  search("b..") -> true
    //  </summary>
    class DesignAddAndSearchWords
    {
        IDictionary<string,string> dict;

        public DesignAddAndSearchWords()
        {
            dict = new Dictionary<string, string>();
        }

        public void AddWord(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return;
            }

            if (!dict.ContainsKey(word))
            {
                dict.Add(word, word);
            }
        }

        public bool Search(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return false;
            }

            int counter = 0;
            foreach (string s in dict.Keys)
            {
                if (s.Length != word.Length)
                {
                    continue;
                }

                if (dict.ContainsKey(word))
                {
                    for (int i = 0; i < s.Length; i++)
                    {
                        if (word[i] == '.' || word[i] == s[i])
                        {
                            counter++;
                        }
                    }

                    if (counter == word.Length)
                    {
                        return true;
                    }
                    else
                    {
                        counter = 0;
                    }
                }
            }

            return false;
        }
    }
}
