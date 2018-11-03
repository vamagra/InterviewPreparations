using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class ReadNCharsGivenRead4
    {
        /// <summary>
        /// The API: int read4(char *buf) reads 4 characters at a time from a file.
        //  The return value is the actual number of characters read.For example, it returns 3 if there is only 3 characters left in the file.
        //  By using the read4 API, implement the function int read(char* buf, int n) that reads n characters from the file.
        //  Note: The read function will only be called once for each test case.
        /// </summary>
        /// <param name="buff"></param>
        /// <param name="n"></param>
        /// <returns></returns>

        public int read(char[] buf, int n)
        {
            // This is an easy question but we need to get the meaning of requirements correct.
            // At the beginning, I thought read4 function is reading characters from buf.So does the function read.But that’s not correct.
            // The meaning here is that read4() function will read 4 characters at a time from a file and then put the characters that has been read into this buf variable.
            // So read() function is reading at most n characters from a file (we don’t know what file and how it’s reading from the file), and put x characters into char[] buf.
            int offset = 0;
            char[] buf4 = new char[4];

            while (true)
            {
                int count = ReadApi(buf4);
                if (count == 0)
                {
                    break;
                }

                for (int i = 0; i < count && offset < n; i++)
                {
                    buf[offset] = buf4[i];
                    offset++;
                }
            }
            return offset;
        }

        public static int ReadNCharsGivenRead4Api(char[] buff, int n)
        {
            bool eof = false;
            char[] tempBuff = new char[4];

            int counter = 0;

            while (!eof && counter < n)
            {
                // read char from Api
                int readCharCount = ReadApi(buff);

                // check if read chars are less than 4, it will determine if this is end of file or not
                eof = readCharCount < 4;

                // get the min of read count chars and (n-total), just to make sure that you buff 
                // min chars if that is the end of file e.g. file has total 7 char, and you need to read 5 char then take math.min (4, 5-4) => read 1 char 
                readCharCount = Math.Min(readCharCount, n - counter);

                for (int i = 0; i < readCharCount; i++)
                {
                    tempBuff[counter++] = buff[i];
                }
            }

            return counter;
        }

        private static int ReadApi(char[] buff)
        {
            return 4;
        }
    }
}
