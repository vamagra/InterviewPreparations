using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode._CrakingTheCodeInterview
{
    class StringRotation
    {
        /// <summary>
        /// If we imagine that s2 is a rotation of si, then we can ask what the rotation point is. For
        //  example, if you rotate waterbottle after wat, you get erbottlewat.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static bool IsRotationTwoStrings(string s1, string s2)
        {
            if (s1 == null || s1.Length < 1 || s2 == null || s2.Length < 1)
            {
                return false;
            }

            if (s1.Length != s2.Length)
            {
                return false;
            }

            string s1s1 = s1 + s1;

            return isSubstring(s1s1,s2);
        }

        private static bool isSubstring(string s1s1, string s2)
        {
            return true;
        }
    }
}
