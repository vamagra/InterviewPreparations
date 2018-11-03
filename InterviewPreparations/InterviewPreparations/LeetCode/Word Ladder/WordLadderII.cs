using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode.Word_Ladder
{
    class WordLadderII
    {
        public static IList<IList<string>> GetMinDistanceWordLadder(string begin, string end, List<string> wordDict)
        {
            IList<IList<string>> resultedList = new List<IList<string>>();
            List<string> list = new List<string>();

            Queue<string> queueStr = new Queue<string>();
            queueStr.Enqueue(begin);
            list.Add(begin);

            while (queueStr.Count != 0)
            {
                int size = queueStr.Count;

                for (int i = 0; i < size; i++)
                {
                    char[] charArray = queueStr.Dequeue().ToCharArray();

                    for (int j = 0; j < charArray.Length; j++)
                    {
                        char temp = charArray[j];

                        for (char ch = 'a'; ch <= 'z'; ch++)
                        {
                            charArray[i] = ch;

                            string newWord = new string(charArray);

                            if (wordDict.Contains(newWord))
                            {
                                list.Add(newWord);

                                if (string.Equals(end, newWord))
                                {
                                    resultedList.Add(list);
                                    list = new List<string>();
                                }

                                queueStr.Enqueue(newWord);
                                wordDict.Remove(newWord);
                            }
                        }

                        charArray[j] = temp;
                    }
                }
            }

            return resultedList;
        }
    }
}
