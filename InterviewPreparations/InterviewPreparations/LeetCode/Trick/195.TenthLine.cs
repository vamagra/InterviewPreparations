using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class TenthLine
    {

        public static List<string> TenthLineFromFile(string fileName)
        {
            return File.ReadLines(fileName).Take(10).ToList();
        }
    }
}
