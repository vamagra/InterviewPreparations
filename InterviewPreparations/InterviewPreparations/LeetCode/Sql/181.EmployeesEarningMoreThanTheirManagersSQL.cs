using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class EmployeesEarningMoreThanTheirManagers
    {
        // The Employee table holds all employees including their managers.Every employee has an Id, and there is also a column for the manager Id.

        //+----+-------+--------+-----------+
        //| Id | Name  | Salary | ManagerId |
        //+----+-------+--------+-----------+
        //| 1  | Joe   | 70000  | 3         |
        //| 2  | Henry | 80000  | 4         |
        //| 3  | Sam   | 60000  | NULL      |
        //| 4  | Max   | 90000  | NULL      |
        //+----+-------+--------+-----------+
        //Given the Employee table, write a SQL query that finds out employees who earn more than their managers.For the above table, Joe is the only employee who earns more than his manager.

        //+----------+
        //| Employee |
        //+----------+
        //| Joe      |
        //+----------+

        /*
          I. Select Name from employee e1 where salary > (select salary from employee m1 where e1.managerId= m1.Id)

          II. Select E1.Name from Employee E1, Employee E2 where E1.ManagerId = E2.Id and E1.Salary > E2.Salary     
         */
    }
}
