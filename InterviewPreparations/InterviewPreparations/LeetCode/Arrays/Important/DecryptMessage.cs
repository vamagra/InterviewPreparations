using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode.Arrays.Important
{
    class DecryptMessage
    {
        /// <summary>
        /// An infamous gang of cyber criminals named “The Gray Cyber Mob”, which is behind many hacking attacks and drug trafficking, has recently become a target for the FBI. After intercepting some of their messages, which looked like complete nonsense, the agency learned that they indeed encrypt their messages, and studied their method of encryption.
        //  Their messages consist of lowercase latin letters only, and every word is encrypted separately as follows:

        // Convert every letter to its ASCII value.Add 1 to the first letter, and then for every letter from the second one to the last one, add the value of the previous letter.Subtract 26 from every letter until it is in the range of lowercase letters a-z in ASCII.Convert the values back to letters.
        // For instance, to encrypt the word “crime”
        // Decrypted message:	c r   i m   e
        // Step 1:	99	114	105	109	101
        // Step 2:	100	214	319	428	529
        // Step 3:	100	110	111	116	113
        // Encrypted message:	d n   o t   q
        // The FBI needs an efficient method to decrypt messages. Write a function named decrypt(word) that receives a string that consists of small latin letters only, and returns the decrypted word.

        // Explain your solution and analyze its time and space complexities.
        // Examples:
        // Input:  word = "dnotq"
        // Output: "crime"


        //input:  word = "flgxswdliefy"
        //output: "encyclopedia"
        //Since the function should be used on messages with many words, make sure the function is as efficient as possible in both time and space. Explain the correctness of your function, and analyze its asymptotic runtime and space complexity.


        //Note: Most programing languages have built-in methods of converting letters to ASCII values and vica versa. You may search the internet for the appropriate method.

        //Constraints:


        //[time limit] 5000ms

        //[input] string word


        //The ASCII value of every char is in the range of lowercase letters a-z.
        //[output] string
        // </summary>
        // <param name="s"></param>
        /// <returns></returns>
        private static string DecryptText(string word)
        {
            // 100	110	111	116	113
            // 99  110 = 114?       
            // 99 + 1 + 114 = 214
            // 100 + XX = 110 => 110 - 100 = xxx = 10 + (26 * y)
            // 100 - 214 = 114

            if (string.IsNullOrEmpty(word))
            {
                return string.Empty;
            }

            char[] result = new char[word.Length];

            for (int i = 0; i < word.Length; i++)
            {
                // 100	110	111	116	113
                if (i == 0)
                {
                    int ascValue = ((int)word[i]) - 1; //99

                    while (ascValue < 97)
                    {
                        ascValue += 26;
                    }

                    result[i] = (char)ascValue; //result = [c, r, i, ]             
                }
                else
                {
                    int prevAscValue = (int)word[i - 1];   // 110     
                    int newAscValue = (int)word[i] - prevAscValue; // 1       

                    while (newAscValue < 97)
                    {
                        newAscValue += 26;
                    }

                    result[i] = (char)newAscValue;
                }
            }

            return new string(result);
        }
    }
}
