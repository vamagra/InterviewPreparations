using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class CountColumnValuesInTable
    {
        // Question 
        // You have one table with a single column having three values a, b and c.
        // Current snapshot of the table is 
        // Table :- tblTest
        // Values :- 
        // tblColumn
        // a
        // a
        // a
        // b
        // b
        // b
        // b
        // c
        // c
        // We need and output in SQL Server in the format:- 
        // Acount BCount CCount
        // 3      4      2 
        // Do not use temporarytable/variables/multiple queries in a single query.
        // Values are restricted to be a, b and c only but the count may vary and output will change accordingly.

        //#Answer -   Select 
                   //  SUM (Case When type='a' THEN 1 ELSE 0 END) AS Acount,
                   //  SUM (Case When type='b' THEN 1 ELSE 0 END) As Bcount,
                   //  SUM (Case When type='c' THEN 1 ELSE 0 END) AS Ccount
                   // From tblTest;
    }
}
