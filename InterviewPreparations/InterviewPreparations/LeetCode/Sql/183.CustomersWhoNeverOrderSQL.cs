using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class CustomersWhoNeverOrderSQL
    {

        /*select Customers.Name as Customers from Customers left join Orders On Customers.Id = Orders.CustomerId where Orders.CustomerId is null 
        
           select Name as Customers from Customers where Id Not In (select CustomerId from Orders)*/
    }
}
