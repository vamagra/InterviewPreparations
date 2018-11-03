using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class ValidateIPAddress
    {
        /// <summary>
        /// Write a function to check whether an input string is a valid IPv4 address or IPv6 address or neither.
        //  IPv4 addresses are canonically represented in dot-decimal notation, which consists of four decimal numbers, each ranging from 0 to 255, separated by dots("."), e.g.,172.16.254.1;
        //  Besides, leading zeros in the IPv4 is invalid.For example, the address 172.16.254.01 is invalid.
        //  IPv6 addresses are represented as eight groups of four hexadecimal digits, each group representing 16 bits.The groups are separated by colons(":"). For example, the address 2001:0db8:85a3:0000:0000:8a2e:0370:7334 is a valid one.Also, we could omit some leading zeros among four hexadecimal digits and some low-case characters in the address to upper-case ones, so 2001:db8:85a3:0:0:8A2E:0370:7334 is also a valid IPv6 address(Omit leading zeros and using upper cases).
        //  However, we don't replace a consecutive group of zero value with a single empty group using two consecutive colons (::) to pursue simplicity. For example, 2001:0db8:85a3::8A2E:0370:7334 is an invalid IPv6 address.
        //  Besides, extra leading zeros in the IPv6 is also invalid.For example, the address 02001:0db8:85a3:0000:0000:8a2e:0370:7334 is invalid.
        //  Note: You may assume there is no extra space or special characters in the input string.
        //  Example 1:
        //  Input: "172.16.254.1"
        //  Output: "IPv4"
        //  Explanation: This is a valid IPv4 address, return "IPv4".
        //  Example 2:
        //  Input: "2001:0db8:85a3:0:0:8A2E:0370:7334"
        //  Output: "IPv6"
        //  Explanation: This is a valid IPv6 address, return "IPv6".
        //  Example 3:
        //  Input: "256.256.256.256"
        //  Output: "Neither"
        //  Explanation: This is neither a IPv4 address nor a IPv6 address.
        //  </summary>
        //  <param name="s"></param>
        //  <returns></returns>
        public static string ValidIPAddress(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return "Neighter";
            }

            #region Explnation
            //IPV4 should follow below rules

            //1. it cannt be less than 7 length
            //2. it cannot start with . period
            //3. last char of the ip address cannot be 0 period
            //4. Split the IP Address with . periods
            //5. tokens array length is not equal to 4 then return false
            //=> Token should follow below rules - 
            // 1. if token starts with 0 zero and has length > 1 its not valid token
            // 2. if the token number don't lies with 0 to 255
            // 3. If parseInt is 0 and token first char is not equal to 0 then return false
            // 4. It should be handle in try catch block and return false for any error

            //IPV6 should follow below rules

            //1. it cannt be less than 15 length
            //2. it cannot be start with : colon
            //3. last char of the ip address cannot be : colon
            //4. split the token with : colon
            //5. token array length is not equal to 8 then return false
            //=> Token should follow below rules -
            //1. token length should be between 0 to 4
            //2. loop through the char of then token 
            //=> 1. check if char is digit
            //2. check if char is Upper letter from A:F
            //3. check if char is lower letter from a:f    
            //4. check if char is not digit or UpperAF or loweraf then return false
            #endregion

            if (IsValidIPv4(s))
            {
                return "IPv4";
            }
            else if (IsValidIPv6(s))
            {
                return "IPv6";
            }
            else
            {
                return "Neighter";
            }
        }

        public static bool IsValidIPv4(string s)
        {
            if (s[0] == '.')
            {
                return false;
            }

            if (s[s.Length - 1] == '0')
            {
                return false;
            }

            if (s.Length < 7)
            {
                return false;
            }

            string[] splitIPAdress = s.Split('.');

            if (splitIPAdress.Length != 4)
            {
                return false;
            }

            foreach (string splitStr in splitIPAdress)
            {
                if (!string.IsNullOrEmpty(splitStr))
                {
                    if (!IsValidIPv4Token(splitStr))
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsValidIPv4Token(string token)
        {
            if (token[0] == '0' && token.Length > 1)
            {
                return false;
            }

            try
            {
                int parseInt = int.Parse(token);

                if (parseInt < 0 || parseInt > 255)
                {
                    return false;
                }

                if (parseInt == 0 && token[0] != '0')
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }

            return true;
        }

        public static bool IsValidIPv6(string s)
        {
            if (s.Length < 15)
            {
                return false;
            }

            if (s[0] == ':')
            {
                return false;
            }

            if (s[s.Length - 1] == ':')
            {
                return false;
            }

            string[] splitToken = s.Split(':');

            if (splitToken.Length != 8)
            {
                return false;
            }

            foreach (string token in splitToken)
            {
                if (!IsValidIPv6Token(token) || string.IsNullOrEmpty(token))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsValidIPv6Token(string token)
        {
            if (token.Length > 4 || token.Length == 0)
            {
                return false;
            }

            foreach (char ch in token)
            {
                bool IsDigit = (ch >= 48 && ch <= 57);
                bool IsUpperAF = (ch >= 65 && ch <= 70);
                bool IsLoweraf = (ch >= 97 && ch <= 102);

                if (!(IsDigit || IsUpperAF || IsLoweraf))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
