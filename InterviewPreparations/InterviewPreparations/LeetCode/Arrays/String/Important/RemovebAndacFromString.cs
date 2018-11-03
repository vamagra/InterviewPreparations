using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode.String.Important
{
    class RemovebAndacFromString
    {
        /// <summary>
        /// Given a string, eliminate all “b” and “ac” in the string, you have to replace them in-place, and you are only allowed to iterate over the string once.
        //  Examples:
        //  acbac   ==>  ""
        //  aaac    ==>  aa
        //  ababac  ==>   aa
        //  bbbbd   ==>   d
        //  </summary>
        //  <param name="s"></param>
        //  <returns></returns>
        public static string RemoveChars(string s)
        {
            if(string.IsNullOrEmpty(s))
            {
                return s;
            }

            char[] chArray = s.ToCharArray();
            int counter = 0;

            bool isIncludeChar = false;

            for (int i = 0; i < chArray.Length; i++)
            {
                isIncludeChar = true;

                if (chArray[i] == 'b')
                {
                    isIncludeChar = false;
                }
                else if (chArray[i] == 'c')
                {
                    if (i > 0 && chArray[i - 1] == 'a')
                    {
                        isIncludeChar = false;
                        counter--;
                    }
                }

                if (isIncludeChar)
                {
                    chArray[counter] = chArray[i];
                    counter++;
                }
            }

            return new string(chArray, 0, counter);
        }
    }
}
