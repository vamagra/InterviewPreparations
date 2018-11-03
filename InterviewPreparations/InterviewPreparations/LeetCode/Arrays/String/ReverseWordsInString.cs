using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class ReverseWordsInString
    {
        public static string ReverseWords(string s)
        {
            if (string.IsNullOrEmpty(s.Trim()))
            {
                return "";
            }

            char[] chArray = s.Trim().ToCharArray();
            int counter = 0;
            int begin = 0;
            int end = 0;
            int len = s.Length;

            //clean up space from begining of the string
            //skip the space at the front
            while (counter < len && s[counter] == ' ')
            {
                counter++;
            }

            //clean up the space from the end of the string
            //skip the spaces from end
            while (len > counter && s[len - 1] == ' ')
            {
                len--;
            }


            while (counter < len)
            {
                if (s[counter] == ' ')
                {
                    end = counter - 1;

                    Reverse(chArray, begin, end);
                    begin = counter + 1;
                }

                if (counter != len)
                {
                    counter++;
                }
            }

            if (counter != len)
            {
                Reverse(chArray, begin, counter - 1);

                Reverse(chArray, 0, len - 1);
            }

            return new string(chArray);
        }

        public static string ReverseWordsII(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return "";
            }

            //s = s.Trim();

            char[] chArray = s.ToCharArray();
            int counter = 0;
            int begin = 0;
            int end = 0;
            int len = s.Length;
            int wordCount = 0;

            while (true)
            {
                //skip the space at the front
                while (counter < len && chArray[counter] == ' ')
                {
                    counter++;
                }

                //break the loop if counter reached to length of the string
                if (counter == len)
                {
                    break;
                }

                if (wordCount > 0)
                {
                    chArray[end++] = ' ';
                }

                //update the begin for next word
                begin = end;

                while (len > counter && chArray[counter] != ' ')
                {
                    chArray[end] = chArray[counter];
                    end++;
                    counter++;
                }


                Reverse(chArray, begin, end - 1);

                wordCount++;
            }

            //Array.Resize(ref chArray, counter - 1);

            Reverse(chArray, 0, end - 1);
           
            return end == 0 ? "" : new string(chArray);
        }

        private static void Reverse(char[] chArray, int start, int end)
        {
            while (start < end)
            {
                char temp = chArray[start];
                chArray[start] = chArray[end];
                chArray[end] = temp;
                start++;
                end--;
            }
        }

        public static  List<string> subStringsLessKDist(string inputString, int num)
        {
            // WRITE YOUR CODE HERE

            List<string> resultedString = new List<string>();

            if (inputString.Length < 1 || num > inputString.Length)
            {
                return resultedString;
            }

            IDictionary<char, int> dict = new Dictionary<char, int>();

            for (int i = 0; i <= inputString.Length - num; i++)
            {
                int slidingWindowCounterBegin = i;
                int slidingWindowCounterend = i + num - 1;

                char[] subString = new char[num];
                int j = 0;
                int count = 0;
                dict.Clear();

                while (slidingWindowCounterBegin <= slidingWindowCounterend)
                {
                    //this will store the substring in char Array
                    subString[j++] = inputString[slidingWindowCounterBegin];
                    if (dict.ContainsKey(inputString[slidingWindowCounterBegin]))
                    {
                        count++;
                    }
                    else
                    {
                        if (!dict.ContainsKey(inputString[slidingWindowCounterBegin]))
                        {
                            dict.Add(inputString[slidingWindowCounterBegin], 1);
                        }
                    }
                    slidingWindowCounterBegin++;
                }

                if (count == 1)
                {
                    resultedString.Add(new string(subString));
                }
            }


            return resultedString;

        }

        //public static List<int> subSequenceTags(List<string> targetList,
        //                             List<string> availableTagList)
        //{
        //    //// WRITE YOUR CODE HERE
        //    //List<int> list = new List<int>();

        //    //if (targetList == null || availableTagList == null)
        //    //{
        //    //    return list;
        //    //}

        //    //int counter = 0;
        //    //int targetListCount = 0;

        //    //int i = 0;

        //    //IDictionary<string, int> 
        //    //foreach(string s in targetList)
        //    //{

        //    //}


        //    //foreach (string s in availableTagList)
        //    //{
        //    //    i++;
        //    //    if (string.Equals(s, targetList[counter]))
        //    //    {
        //    //        targetListCount++;
        //    //        list.Add(i);
        //    //    }
        //    //}

        //    //return list;
        //}
    }
}
