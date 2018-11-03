using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class StudentAttendanceRecordClassI
    {
        /// <summary>
        //  You are given a string representing an attendance record for a student. 
        //  The record only contains the following three characters:
        //  'A' : Absent.
        //  'L' : Late.
        //  'P' : Present.
        //  A student could be rewarded if his attendance record doesn't contain more than one 'A' (absent) or 
        //  more than two continuous 'L' (late).
        //  You need to return whether the student could be rewarded according to his attendance record.
        //  Example 1:
        //  Input: "PPALLP"
        //  Output: True
        //  Example 2:
        //  Input: "PPALLL"
        //  Output: False
        //  </summary>
        //  <param name="s"></param>
        //  <returns></returns>
        public static bool CheckRecord(string s)
        {
            if(string.IsNullOrEmpty(s))
            {
                return false;
            }

            int countA = 0;
            int continuosL = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'A')
                {
                    countA++;
                    continuosL = 0;
                }
                else if (s[i] == 'L')
                {
                    continuosL++;
                }
                else
                {
                    continuosL = 0;
                }

                if (countA > 1 || continuosL > 2)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
