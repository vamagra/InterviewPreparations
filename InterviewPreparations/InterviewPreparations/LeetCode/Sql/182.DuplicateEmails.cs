using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class DuplicateEmails
    {
        // Write a SQL query to find all duplicate emails in a table named Person.

        //+----+---------+
        //| Id | Email   |
        //+----+---------+
        //| 1  | a @b.com |
        //| 2  | c @d.com |
        //| 3  | a @b.com |
        //+----+---------+
        //For example, your query should return the following for the above table:

        //+---------+
        //| Email   |
        //+---------+
        //| a @b.com |
        //+---------+

        /*
             I.   Select Email from Person group by Email having Count(*) > 1  

             II.   SELECT distinct p1.Email from Person p1
                INNER JOIN Person p2
                ON p1.Email = p2.Email
                WHERE p1.Id <> p2.Id;
        */
    }
}
