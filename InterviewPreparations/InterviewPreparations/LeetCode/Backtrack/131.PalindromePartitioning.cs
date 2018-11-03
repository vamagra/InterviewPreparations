using System.Collections.Generic;

namespace InterviewQuestions.LeetCode
{
    /// <summary>
    //  Given a string s, partition s such that every substring of the partition is a palindrome.
    //  Return all possible palindrome partitioning of s.
    //  For example, given s = "aab",
    //  Return
    //  [
    //      ["aa", "b"],
    //      ["a","a","b"]
    //  ]
    //  </summary>
    class PalindromePartitioning
    {
        public static IList<IList<string>> GetListPalindromePartitioning(string s)
        {
            IList<IList<string>> resultedList = new List<IList<string>>();

            if (string.IsNullOrEmpty(s))
            {
                return resultedList;
            }

            Backtrack(resultedList, new List<string>(), s, 0);

            return resultedList;
        }

        private static void Backtrack(IList<IList<string>> list, List<string> tempList, string s, int start)
        {
            if (s.Length == start)
            {
                list.Add(new List<string>(tempList));
            }
            else
            {
                for (int end = start; end < s.Length; end++)
                {
                    if (isPalindrome(s, start, end))
                    {
                        tempList.Add(s.Substring(start, (end - start) + 1));
                        Backtrack(list, tempList, s, end + 1);
                        tempList.RemoveAt(tempList.Count - 1);
                    }
                }
            }
        }

        private static bool isPalindrome(string s, int low, int high)
        {
            while (low <= high)
                if (s[low++] != s[high--])
                    return false;
            return true;
        }
    }
}
