using System;

namespace InterviewPreparations.LeetCode
{
    class ArithmaticOperationsUsingAddSign
    {
        // We need to do a - b = a + (-1)*b.
        public static int Subtract(int a, int b)
        {
            // Negating b 
            return a + flipSign(b);
        }

        // we have to this as we cannot use -sign
        public static int flipSign(int a)
        {
            int neg = 0;

            // If sign is + ve turn it -ve 
            // and vice-versa 
            int tmp = a < 0 ? 1 : -1;
            while (a != 0)
            {
                neg += tmp;
                a += tmp;
            }
            return neg;
        }

        // a * b = a + a + a...b times.
        public static int Multiply(int a, int b)
        {
            // because algo is faster if b<a like 2 * 4 to make it faster do 4 * 2
            if (a < b)
                return Multiply(b, a);

            // Adding a to itself b times 
            int sum = 0;
            //for (int i = Math.Abs(b); i > 0; i--)
            //    sum += a;

            for (int i = 1; i <= Math.Abs(b); i++)
                sum += a;

            // Check if final sign must be -ve or + ve 
            if (b < 0)
                sum = flipSign(sum);

            return sum;
        }

        // Function to divide a by b by counting how many 
        // times 'b' can be subtracted from 'a' before 
        // getting 0 
        public static int Division(int a, int b)
        {
            // Raise exception if b is 0 
            if (b == 0)
                return b;

            int quotient = 0, i;

            // Negating b to subtract from a 
            int divisor = flipSign(Math.Abs(b));

            // Subtracting divisor from dividend 
            for (i = Math.Abs(a); i >= Math.Abs(divisor);
                                        i += divisor)
                quotient++;

            // Check if a and b are of similar symbols or not 
            if (areDifferentSign(a, b))
                quotient = flipSign(quotient);
            return quotient;
        }

        // Check if a and b are of different signs 
        public static bool areDifferentSign(int a, int b)
        {
            return ((a < 0 && b > 0) || (a > 0 && b < 0));
        }
    }
}
