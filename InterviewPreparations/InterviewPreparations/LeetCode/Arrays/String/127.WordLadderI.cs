using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class WordLadderI
    {
        /// <summary>
        //  Given two words (beginWord and endWord), and a dictionary's word list, find the length of 
        //  shortest transformation sequence from beginWord to endWord, such that:
        //  Only one letter can be changed at a time.
        //  Each transformed word must exist in the word list. Note that beginWord is not a transformed word.
        //  For example,
        //  Given:
        //  beginWord = "hit"
        //  endWord = "cog"
        //  wordList = ["hot", "dot", "dog", "lot", "log", "cog"]
        //  As one shortest transformation is "hit" -> "hot" -> "dot" -> "dog" -> "cog",
        //  return its length 5.
        //  Note:
        //  Return 0 if there is no such transformation sequence.
        //  All words have the same length.
        //  All words contain only lowercase alphabetic characters.
        //  You may assume no duplicates in the word list.
        //  You may assume beginWord and endWord are non-empty and are not the same.
        //  UPDATE (2017/1/20):
        //  The wordList parameter had been changed to a list of strings(instead of a set of strings). Please reload the code definition to get the latest changes.
        //  </summary>
        //  <param name="begin"></param>
        //  <param name="end"></param>
        //  <param name="wordDict"></param>
        //  <returns></returns>
        public static int GetMinDistWordLadder(string begin, string end, List<string> wordDict)
        {
            //base case if begin and end words are same
            if (string.Equals(begin, end))
            {
                return 1;
            }

            Queue<string> queueStr = new Queue<string>();
            queueStr.Enqueue(begin);

            int level = 1;

            while (queueStr.Count != 0)
            {
                int size = queueStr.Count;

                for (int j = 0; j < size; j++)
                {
                    char[] currWord = queueStr.Dequeue().ToCharArray();

                    for (int i = 0; i < currWord.Length; i++)
                    {
                        char temp = currWord[i];

                        //run the loop from a to z and change the one character and look for that word in dictionary
                        for (char ch = 'a'; ch <= 'z'; ch++)
                        {
                            //update the first char
                            currWord[i] = ch;

                            string newWord = new string(currWord);

                            //if that word is exists in dict add new word in the queue and remove from dict as well
                            if (wordDict.Contains(newWord))
                            {
                                //check the base case if new word is equal to end word then
                                //we are done with the search in the dict
                                if (string.Equals(end, newWord))
                                {
                                    return level + 1;
                                }

                                queueStr.Enqueue(newWord);
                                wordDict.Remove(newWord);
                            }
                        }

                        currWord[i] = temp;
                    }
                }

                level++;
            }

            return 0;
        }
    }
}
