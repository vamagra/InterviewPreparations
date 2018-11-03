using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class SimplifyPath
    {
        /// <summary>
        /// Given an absolute path for a file (Unix-style), simplify it.
        //  For example,
        //  path = "/home/", => "/home"
        //  path = "/a/./b/../../c/", => "/c"
        //  click to show corner cases.
        //  Corner Cases:
        //  Did you consider the case where path = "/../" ?
        //  In this case, you should return "/".
        //  Another corner case is the path might contain multiple slashes '/' together, such as "/home//foo/".
        //  In this case, you should ignore redundant slashes and return "/home/foo".
        //  </summary>
        //  <param name="path"></param>
        // <returns></returns>

        #region Explanation
        //Assume root looks like:
        ///a/b
        ///c
        //Let's break it down to componenets:
        /// -> root
        ///a -> in (a)
        //. -> THIS dir path
        ///a/./ -> still in /a
        ///a/./b -> in /a/b
        //.. -> go "up" one level
        ///a/./b/.. -> /a/b/.. -> /a
        ///a/./b/../.. -> /a/.. -> /
        ///a/./b/../../c -> /c
        #endregion
        public static string SimplyfyPath(string path)
        {
            string resultedString = string.Empty;
            Stack<string> stack= new Stack<string>();

            string[] paths = path.Split('/');

            foreach(string s in paths)
            {
                if (stack.Count != 0 && string.Equals(s, ".."))
                {
                    stack.Pop();
                }
                else if (!string.Equals(s, ".") && !string.Equals(s, "") && !string.Equals(s, ".."))
                {
                    stack.Push(s); // push all the directory name in stack
                }
            }

            List<string> listResult = new List<string>(stack.Reverse());
            resultedString = "/" + string.Join("/", listResult);

            return resultedString;
        }

        public static string SimplyfyPathII(string path)
        {
            StringBuilder resultedString = new StringBuilder();
            LinkedList<string> stack = new LinkedList<string>();

            string[] paths = path.Split('/');

            foreach (string s in paths)
            {
                if (stack.Count != 0 && string.Equals(s, ".."))
                {
                    stack.RemoveLast();
                }
                else if (!string.Equals(s, ".") && !string.Equals(s, "") && !string.Equals(s, ".."))
                {
                    stack.AddLast(s);
                }
            }

            foreach (string s in stack)
            {
                resultedString.Append(s + "/");
            }

            //if (stack.Count != 0)
            //{
            //    resultedString.Capacity = resultedString.Length - 1;
            //}

            return resultedString.ToString();
        }
    }
}
