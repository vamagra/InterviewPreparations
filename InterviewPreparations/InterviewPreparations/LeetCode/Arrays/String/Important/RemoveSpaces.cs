using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class RemoveSpaces
    {
        public static string RemoveSpace(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return s;
            }

            char[] chArray = s.ToCharArray();

            int j = -1;

            for (int i = 0; i < s.Length; i++)
            {
                if (chArray[i] != ' ')
                {
                    chArray[++j] = chArray[i];
                }
            }

            return new string(chArray, 0, j);
        }
    }
}
