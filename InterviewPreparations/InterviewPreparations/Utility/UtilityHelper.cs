using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.Utility
{
    public class UtilityHelper
    {
        public static void PrintArray(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + "  ");
            }
            Console.ReadKey();
        }

        public static int max(int a, int b)
        {
            return a > b ? a : b;
        }

        public static int min(int a, int b)
        {
            return a > b ? b : a;
        }

        public static void PrintMatrix(int[,] matrix, int rowLength, int colLength)
        {
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", matrix[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }

            Console.ReadLine();
        }
    }
}
