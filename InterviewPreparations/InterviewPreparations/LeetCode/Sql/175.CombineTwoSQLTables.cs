﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class CombineTwoSQLTables
    {
        //        Table: Person

        //+-------------+---------+
        //| Column Name | Type    |
        //+-------------+---------+
        //| PersonId    | int     |
        //| FirstName   | varchar |
        //| LastName    | varchar |
        //+-------------+---------+
        //PersonId is the primary key column for this table.
        //Table: Address

        //+-------------+---------+
        //| Column Name | Type    |
        //+-------------+---------+
        //| AddressId   | int     |
        //| PersonId    | int     |
        //| City        | varchar |
        //| State       | varchar |
        //+-------------+---------+
        //AddressId is the primary key column for this table.

        //Write a SQL query for a report that provides the following information for each person in the Person table, regardless if there is an address for each of those people:

        //FirstName, LastName, City, State


        //# Write your MySQL query statement below
        //SELECT Person.FirstName, Person.LastName, Address.City, Address.State from Person LEFT JOIN Address on Person.PersonId = Address.PersonId
    }
}
